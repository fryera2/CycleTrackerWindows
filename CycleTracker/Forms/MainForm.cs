using CycleTracker.BusinessObjects;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CycleTracker
{
    public partial class MainForm : Form
    {

        private ImportCoordinator _coordinator = null;
        private ApplicationCoordinator _appCoordinator = null;
        private bool _initialising;

        private ImportCoordinator ImportCoordinator
        {
            get
            {
                if (_coordinator == null)
                {
                    _coordinator = new ImportCoordinator(@"C:\Users\Andrew\Documents\exercise.xlsx");
                }
                return _coordinator;
            }
        }
        
        private ApplicationCoordinator AppCoordinator
        {
            get
            {
                if (_appCoordinator == null)
                {
                    _appCoordinator = new ApplicationCoordinator();
                }
                return _appCoordinator;
            }
        }
        
        public MainForm()
        {
            _initialising = true;
            InitializeComponent();
            ClearDataBindings();
            ApplyDataBindings();
            Initialise();
            _initialising = false;
            SetDataSource();
        }

        private void ClearDataBindings()
        {
            this.monthComboBox.DataBindings.Clear();
            this.yearComboBox.DataBindings.Clear();
        }

        private void ApplyDataBindings()
        {
            this.monthComboBox.DataBindings.Add(new Binding("Text", AppCoordinator, "SelectedMonth"));
            this.yearComboBox.DataBindings.Add(new Binding("Text", AppCoordinator, "SelectedYear"));
        }

        private void Initialise()
        {
            this.monthComboBox.DataSource = AppCoordinator.RideMonths;
            this.monthComboBox.SelectedItem = DateTimeFormatInfo.CurrentInfo.GetMonthName(DateTime.Now.Month);
            this.yearComboBox.DataSource = AppCoordinator.RideYears;
            this.yearComboBox.SelectedItem = DateTime.Now.Year;
        }

        private void ImportData ()
        {
            ImportCoordinator.GetListOfBikes();
            ImportCoordinator.ImportRecords();
        }

        private void importRecordsMenu_Click(object sender, EventArgs e)
        {
            ImportData();
        }


        private void yearComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            this.AppCoordinator.SelectedYear = (int)yearComboBox.SelectedValue;
            SetDataSource();
        }

        private void monthComboBox_SelectedValueChanged(object sender, EventArgs e)
        {
            this.AppCoordinator.SelectedMonth = ((int)monthComboBox.SelectedIndex) + 1;
            SetDataSource();
        }

        private void SetDataSource()
        {
            if (_initialising) { return; }
            this.labelCurrentYear.Text = this.AppCoordinator.SelectedYear.ToString();
            this.labelPreviousYear.Text = (this.AppCoordinator.SelectedYear - 1).ToString();
            var currentDataSource = AppCoordinator.GetFilteredRides();
            var previousDataSource = AppCoordinator.GetPreviousFilteredRides();
            this.ridesGrid.DataSource = currentDataSource;
            this.totalRidesLabel.Text = currentDataSource.Count().ToString();
            decimal? rideTime = currentDataSource.Sum(d => d.RideTime);
            decimal? totalDistance = currentDataSource.Sum(d => d.DistanceInMiles).Value;
            this.totalTimeLabel.Text = rideTime.ToString();
            this.totalDistanceLabel.Text = totalDistance.ToString() ;
            this.averageSpeedLabel.Text = Math.Round((Convert.ToDouble (totalDistance / rideTime)), 2).ToString();
            int totalAscentFt = currentDataSource.Sum(d => d.Ascent).Value;
            this.totalAscentFtLabel.Text = totalAscentFt.ToString();
            this.totalAscentMLabel.Text = Math.Round((totalAscentFt / 3.2808), 2).ToString();
            this.longestRideMilesLabel.Text = currentDataSource.Max(c => c.DistanceInMiles).ToString();
            this.longestRideTimeLabel.Text = currentDataSource.Max(c => c.RideTime).ToString();

            this.totalRidesPreviousLabel.Text = previousDataSource.Count().ToString();
            decimal? rideTimePrevious = previousDataSource.Sum(d => d.RideTime);
            decimal? totalDistancePrevious = previousDataSource.Sum(d => d.DistanceInMiles).Value;
            this.totalTimePreviousLabel.Text = rideTimePrevious.ToString();
            this.totalDistancePreviousLabel.Text = totalDistancePrevious.ToString();
            this.averageSpeedPreviousLabel.Text = Math.Round((Convert.ToDouble(totalDistancePrevious / rideTimePrevious)), 2).ToString();
            int totalAscentPreviousFt = previousDataSource.Sum(d => d.Ascent).Value;
            this.totalAscentFtPreviousLabel.Text = totalAscentPreviousFt.ToString();
            this.totalAscentMPreviousLabel.Text = Math.Round ((totalAscentPreviousFt / 3.2808), 2).ToString();
            this.longestRidePreviousMilesLabel.Text = previousDataSource.Max(p => p.DistanceInMiles).ToString();
            this.longestRideTimePreviousLabel.Text = previousDataSource.Max(p => p.RideTime).ToString();
        }

    }
}
