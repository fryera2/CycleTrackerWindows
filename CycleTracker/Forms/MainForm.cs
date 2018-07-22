﻿using CycleTracker.BusinessObjects;
using CycleTracker.Database;
using CycleTracker.Database.Database;
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

        private ApplicationCoordinator _appCoordinator = null;
        private bool _initialising;
        
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
            this.bikeComboBox.DataBindings.Clear();
        }

        protected override void ApplyDataBindings()
        {
            this.monthComboBox.DataBindings.Add(new Binding("Text", AppCoordinator, "SelectedMonth"));
            this.yearComboBox.DataBindings.Add(new Binding("Text", AppCoordinator, "SelectedCurrentYear"));
            this.previousYearComboBox.DataBindings.Add(new Binding("Text", AppCoordinator, "SelectedPreviousYear"));
            this.bikeComboBox.DataBindings.Add(new Binding("Text", AppCoordinator, "SelectedBike"));
        }

        protected override void Initialise()
        {
            _initialising = true;
            int currentYear = DateTime.Now.Year;
            int previousYear = currentYear - 1;
            this.monthComboBox.DataSource = AppCoordinator.RideMonths;
            this.yearComboBox.DataSource = AppCoordinator.RideYears;
            this.previousYearComboBox.DataSource = AppCoordinator.RidePreviousYears;
            this.AppCoordinator.SelectedMonth = DateTime.Now.Month;           
            this.AppCoordinator.SelectedCurrentYear = currentYear;
            this.AppCoordinator.SelectedPreviousYear = (AppCoordinator.RideYears.Contains(previousYear)) ? previousYear : currentYear;
            this.bikeComboBox.DataSource = AppCoordinator.Bikes;
            this.AppCoordinator.SelectedBike = AppCoordinator.Bikes.Where(b => b.BikeName == "All").Select(b => b.BikeID).Single();
            _initialising = false;

            SetAllDataSources();
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
            SetMonthToDateDataSource();
        }

        private void SetMonthDataSource()
        {
            this.ridesGrid.DataSource = AppCoordinator.GetFilteredRides();

            CombinedStatsObject current = new CombinedStatsObject(AppCoordinator.GetFilteredRides(), AppCoordinator.GetPreviousFilteredRides(),
                                                                  AppCoordinator.SelectedCurrentYear, AppCoordinator.SelectedPreviousYear);
            montlySummaryControl.SetDataSource(current);
        }

        private void SetMonthToDateDataSource()
        {
            CombinedStatsObject current = new CombinedStatsObject(AppCoordinator.GetFilteredRidesMonthToDate(), AppCoordinator.GetPreviousFilteredRidesMonthToDate(),
                                                                  AppCoordinator.SelectedCurrentYear, AppCoordinator.SelectedPreviousYear);
            monthToDateSummaryControl.SetDataSource(current);
        }

        private void SetYearDataSource ()
        {
            CombinedStatsObject current = new CombinedStatsObject(AppCoordinator.GetFilteredRidesForYear(), AppCoordinator.GetPreviousFilteredRidesForYear(),
                                                                  AppCoordinator.SelectedCurrentYear, AppCoordinator.SelectedPreviousYear);
            yearlySummaryControl.SetDataSource(current);
            
        }

        private void SetYearToDateDataSource()
        {
            CombinedStatsObject current = new CombinedStatsObject(AppCoordinator.GetFilteredRidesToDate(), AppCoordinator.GetPreviousRidesToDate(),
                                                                  AppCoordinator.SelectedCurrentYear, AppCoordinator.SelectedPreviousYear);
            yearToDateSummaryControl.SetDataSource(current);
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

            SetAllDataSources();
        }

        private void panel3_Paint(object sender, PaintEventArgs e)
        {

        }
    
        private void SetAllDataSources ()
        {
            SetMonthDataSource();
            SetMonthToDateDataSource();
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

        private void MainForm_Shown(object sender, EventArgs e)
        { 
            this.yearlySummaryControl.SetTitle("Yearly Summary");
            this.yearToDateSummaryControl.SetTitle("Year to Date");
            this.montlySummaryControl.SetTitle("Monthly Summary");
            this.monthToDateSummaryControl.SetTitle("Month to Date");

        }

        private void bikeComboBox_SelectedValueChanged(object sender, EventArgs e)
        {
            if (_initialising) { return; }

            AppCoordinator.SelectedBike = Convert.ToInt32(bikeComboBox.SelectedValue);
            AppCoordinator.ResetRideData();
            SetAllDataSources();
        }

        private void editItemButton_Click(object sender, EventArgs e)
        {
            if (this.ridesGrid.SelectedRows.Count == 0)
            {
                return;
            }

            FilteredRide ride = this.ridesGrid.SelectedRows[0].DataBoundItem as FilteredRide;

            AddRideForm addForm = new AddRideForm(ride);
            addForm.ShowDialog();
            AppCoordinator.ResetRideData();
            SetAllDataSources();
        }
    }
}
