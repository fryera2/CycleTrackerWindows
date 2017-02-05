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
    public partial class MainForm : RideBaseForm
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
            InitializeComponent();
        }

        protected override void ClearDataBindings()
        {
            this.monthComboBox.DataBindings.Clear();
            this.yearComboBox.DataBindings.Clear();
            this.previousYearComboBox.DataBindings.Clear();
        }

        protected override void ApplyDataBindings()
        {
            this.monthComboBox.DataBindings.Add(new Binding("Text", AppCoordinator, "SelectedMonth"));
            this.yearComboBox.DataBindings.Add(new Binding("Text", AppCoordinator, "SelectedCurrentYear"));
            this.previousYearComboBox.DataBindings.Add(new Binding("Text", AppCoordinator, "SelectedPreviousYear"));
        }

        protected override void Initialise()
        {
            _initialising = true;
            this.monthComboBox.DataSource = AppCoordinator.RideMonths;
            List<int> years = AppCoordinator.RideYears;
            List<int> previousYears = AppCoordinator.RidePreviousYears;
            this.yearComboBox.DataSource = years;
            this.previousYearComboBox.DataSource = previousYears;
            int currentYear = DateTime.Now.Year;
            int previousYear = currentYear - 1;
            this.AppCoordinator.SelectedMonth = DateTime.Now.Month;
            this.monthComboBox.SelectedIndex = (this.AppCoordinator.SelectedMonth - 1);
           
            this.AppCoordinator.SelectedCurrentYear = currentYear;
            this.yearComboBox.SelectedItem = this.AppCoordinator.SelectedCurrentYear;

            if (years.Contains (previousYear))
            {
                this.AppCoordinator.SelectedPreviousYear = previousYear;
                this.previousYearComboBox.SelectedItem = previousYear;
            } 
            else
            {
                this.AppCoordinator.SelectedPreviousYear = currentYear;
                this.previousYearComboBox.SelectedItem = currentYear;
            }
            _initialising = false;

            SetAllDataSources();
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
            if (_initialising) { return; }

            this.AppCoordinator.SelectedCurrentYear = (int)yearComboBox.SelectedValue;

            SetAllDataSources();
        }

        private void monthComboBox_SelectedValueChanged(object sender, EventArgs e)
        {
            if (_initialising) { return; }

            this.AppCoordinator.SelectedMonth = (int)monthComboBox.SelectedIndex + 1;

            SetMonthDataSource();
        }

        private void SetMonthDataSource()
        {
            CombinedStatsObject current = new CombinedStatsObject(AppCoordinator.GetFilteredRides(), AppCoordinator.GetPreviousFilteredRides());

            this.ridesGrid.DataSource = AppCoordinator.GetFilteredRides();
            this.totalRidesLabel.Text = current.TotalRides.ToString();
            this.totalTimeLabel.Text = current.TotalTime.ToString();
            this.averageSpeedLabel.Text = current.AverageSpeed.ToString();
            this.totalDistanceLabel.Text = current.TotalDistance.ToString();
            this.totalAscentFtLabel.Text = current.TotalAscentFt.ToString();
            this.totalAscentMLabel.Text = current.TotalAscentMetres.ToString();
            this.longestRideMilesLabel.Text = current.LongestRideMiles.ToString();
            this.longestRideTimeLabel.Text = current.LongestRideTime.ToString();

            this.totalRidesPreviousLabel.Text = current.TotalPreviousRides.ToString();
            this.totalTimePreviousLabel.Text = current.TotalPreviousTime.ToString();
            this.averageSpeedPreviousLabel.Text = current.AveragePreviousSpeed.ToString();
            this.totalDistancePreviousLabel.Text = current.TotalPreviousDistance.ToString();
            this.totalAscentFtPreviousLabel.Text = current.TotalPreviousAscentFt.ToString();
            this.totalAscentMPreviousLabel.Text = current.TotalPreviousAscentMetres.ToString();
            this.longestRidePreviousMilesLabel.Text = current.LongestPreviousRideInMiles.ToString();
            this.longestRideTimePreviousLabel.Text = current.LongestPreviousRideTime.ToString();

            SetDifferenceControl(totalRidesDifferenceLabel, current.TotalRideDifference);
            SetDifferenceControl(totalTimeDifferenceLabel, current.TotalTimeDifference);
            SetDifferenceControl(totalSpeedDifferenceLabel, current.TotalSpeedDifference);
            SetDifferenceControl(totalDistanceDifferenceLabel, current.TotalDistanceDifference);
            SetDifferenceControl(totalAscentFtDifferenceLabel, current.TotalAscentDifferenceFt);
            SetDifferenceControl(totalAscentMDifferenceLabel, current.TotalAscentDifferenceMetres);
            SetDifferenceControl(longestRideMilesDifferenceLabel, current.LongestRideDifference);
            SetDifferenceControl(longestRideTimeDifferenceLabel, current.LongestTimeDifference);
        }

        private void SetYearDataSource ()
        {
            CombinedStatsObject current = new CombinedStatsObject(AppCoordinator.GetFilteredRidesForYear(), AppCoordinator.GetPreviousFilteredRidesForYear());

            this.totalRidesYearLabel.Text = current.TotalRides.ToString();
            this.totalTimeYearLabel.Text = current.TotalTime.ToString();
            this.averageSpeedYearLabel.Text = current.AverageSpeed.ToString();
            this.totalDistanceYearLabel.Text = current.TotalDistance.ToString();
            this.totalAscentFtYearLabel.Text = current.TotalAscentFt.ToString();
            this.totalAscentMYearLabel.Text = current.TotalAscentMetres.ToString();
            this.longestRideMilesYearLabel.Text = current.LongestRideMiles.ToString();
            this.longestRideTimeYearLabel.Text = current.LongestRideTime.ToString();

            this.totalRidesPreviousYearLabel.Text = current.TotalPreviousRides.ToString();
            this.totalTimePreviousYearLabel.Text = current.TotalPreviousTime.ToString();
            this.averageSpeedPreviousYearLabel.Text = current.AveragePreviousSpeed.ToString();
            this.totalDistancePreviousYearLabel.Text = current.TotalPreviousDistance.ToString();
            this.totalAscentFtPreviousYearLabel.Text = current.TotalPreviousAscentFt.ToString();
            this.totalAscentMPreviousYearLabel.Text = current.TotalPreviousAscentMetres.ToString();
            this.longestRideMilesPreviousYearLabel.Text = current.LongestPreviousRideInMiles.ToString();
            this.longestRideTimePreviousYearLabel.Text = current.LongestPreviousRideTime.ToString();

            SetDifferenceControl(totalRidesYearDifferenceLabel, current.TotalRideDifference);
            SetDifferenceControl(totalTimeYearDifferenceLabel, current.TotalTimeDifference);
            SetDifferenceControl(averageSpeedYearDifferenceLabel, current.TotalSpeedDifference);
            SetDifferenceControl(totalDistanceYearDifferenceLabel, current.TotalDistanceDifference);
            SetDifferenceControl(totalAscentFtYearDifferenceLabel, current.TotalAscentDifferenceFt);
            SetDifferenceControl(totalAscentMYearDifferenceLabel, current.TotalAscentDifferenceMetres);
            SetDifferenceControl(longestRideMilesYearDifferenceLabel, current.LongestRideDifference);
            SetDifferenceControl(longestRideTimeYearDifferenceLabel, current.LongestTimeDifference);
        }

        private void SetYearToDateDataSource()
        {
            CombinedStatsObject current = new CombinedStatsObject(AppCoordinator.GetFilteredRidesToDate(), AppCoordinator.GetPreviousRidesToDate());

            this.totalRidesToDate.Text = current.TotalRides.ToString();
            this.totalTimeToDate.Text = current.TotalTime.ToString();
            this.averageSpeedToDate.Text = current.AverageSpeed.ToString();
            this.totalDistanceToDate.Text = current.TotalDistance.ToString();
            this.totalAscentFtToDate.Text = current.TotalAscentFt.ToString();
            this.totalAscentMToDate.Text = current.TotalAscentMetres.ToString();
            this.YearToDatePanel.Text = current.TotalAscentMetres.ToString();
            this.longestRideMilesToDate.Text = current.LongestRideMiles.ToString();
            this.longestRideTimeToDate.Text = current.LongestRideTime.ToString();

            this.totalRidesToPreviousDate.Text = current.TotalPreviousRides.ToString();
            this.totalTimeToPreviousDate.Text = current.TotalPreviousTime.ToString();
            this.averageSpeedToPreviousDate.Text = current.AveragePreviousSpeed.ToString();
            this.totalDistanceToPreviousDate.Text = current.TotalPreviousDistance.ToString();
            this.totalAscentFtToPreviousDate.Text = current.TotalPreviousAscentFt.ToString();
            this.totalAscentMToPreviousDate.Text = current.TotalPreviousAscentMetres.ToString();
            this.longestRideMilesToPreviousDate.Text = current.LongestPreviousRideInMiles.ToString();
            this.longestRideTimeToPreviousDate.Text = current.LongestPreviousRideTime.ToString();

            SetDifferenceControl(totalRidesToDateDifference, current.TotalRideDifference);
            SetDifferenceControl(totalTimeToDateDifference, current.TotalTimeDifference);
            SetDifferenceControl(averageSpeedToDateDifference, current.TotalSpeedDifference);
            SetDifferenceControl(totalDistanceToDateDifference, current.TotalDistanceDifference);
            SetDifferenceControl(totalAscentFtToDateDifference, current.TotalAscentDifferenceFt);
            SetDifferenceControl(totalAscentMtToDateDiffernce, current.TotalAscentDifferenceMetres);
            SetDifferenceControl(longestRideMilesToDateDifferenceLabel, current.LongestRideDifference);
            SetDifferenceControl(longestRideTimeToDateDifference, current.LongestTimeDifference);
        }

        private void addRideButton_Click(object sender, EventArgs e)
        {
            AddRideForm addForm = new AddRideForm();
            addForm.ShowDialog();
            AppCoordinator.ResetRideData();
            SetAllDataSources();
        }

        private void previousYearComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (_initialising) { return; }

            this.AppCoordinator.SelectedPreviousYear = (int)previousYearComboBox.SelectedValue;

            SetYearDataSource();
            SetYearToDateDataSource();
            SetMonthDataSource();
        }

        private void panel3_Paint(object sender, PaintEventArgs e)
        {

        }
    
        private void SetAllDataSources ()
        {
            SetMonthDataSource();
            SetYearDataSource();
            SetYearToDateDataSource();
        }

        private void SetDifferenceControl (Control control, int value)
        {
            SetDifferenceControl(control, value.ToString(), value < 0);
        }

        private void SetDifferenceControl(Control control, decimal value)
        {
            SetDifferenceControl(control, value.ToString(), value < 0);
        }

        private void SetDifferenceControl (Control control, string value, bool negative)
        {
            control.Text = value;
            control.ForeColor = (negative) ? Color.Red : Color.Green;
        }
    }
}
