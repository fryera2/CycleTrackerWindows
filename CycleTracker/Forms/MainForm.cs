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
            ClearDataBindings();
            ApplyDataBindings();
            Initialise();

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
            this.ridesGrid.DataSource = AppCoordinator.GetFilteredRides();
        }

        private void monthComboBox_SelectedValueChanged(object sender, EventArgs e)
        {
            this.AppCoordinator.SelectedMonth = ((int)monthComboBox.SelectedIndex) + 1;
            this.ridesGrid.DataSource = AppCoordinator.GetFilteredRides();
        }
    }
}
