using CycleTracker.BusinessObjects;
using CycleTracker.Database;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CycleTracker
{
    public partial class AddRideForm : RideBaseForm
    {

        private Enumerations.ApplicationProcessEnum _appProcess;
        private FilteredRide _ride;
        private NewRideCoordinator _coordinator;
        private NewRideCoordinator Coordinator
        {
            get
            {
                if (_coordinator == null)
                {
                    _coordinator = new NewRideCoordinator();
                }
                return _coordinator;
            }
        }

        public AddRideForm()
        {
            InitializeComponent();
            _appProcess = Enumerations.ApplicationProcessEnum.Add;
        }

        public AddRideForm (FilteredRide ride)
        {
            InitializeComponent();
            _appProcess = Enumerations.ApplicationProcessEnum.Update;
            _ride = ride;
            this.Text = "Edit Existing ride";
            this.addButton.Text = "Edit";
        }

        protected override void Initialise()
        {
            this.bikeListComboBox.DataSource = Coordinator.BikeList;
            if (_appProcess == Enumerations.ApplicationProcessEnum.Update)
            {
                Coordinator.RideId = _ride.RideID;
                Coordinator.RideDate = (DateTime)_ride.RideDate;
                Coordinator.RideDistance = (decimal)_ride.DistanceInMiles;
                Coordinator.RideTime = (decimal)_ride.RideTimeInMinutes;
                Coordinator.RideAscent = (int)_ride.Ascent;
                Coordinator.BikeUsed = _ride.BikeId;
            }
        }

        protected override void ClearDataBindings()
        {
            this.rideDatePicker.DataBindings.Clear();
            this.rideDistanceTextBox.DataBindings.Clear();
            this.rideTimeTextBox.DataBindings.Clear();
            this.rideAscentTextBox.DataBindings.Clear();
            this.bikeListComboBox.DataBindings.Clear();

        }

        protected override void ApplyDataBindings()
        {

            this.rideDatePicker.DataBindings.Add(new Binding("Value", Coordinator, "RideDate"));
            this.rideDistanceTextBox.DataBindings.Add(new Binding("Text", Coordinator, "RideDistance"));
            this.rideTimeTextBox.DataBindings.Add(new Binding("Text", Coordinator, "RideTime"));
            this.rideAscentTextBox.DataBindings.Add(new Binding("Text", Coordinator, "RideAscent"));
            this.bikeListComboBox.DataBindings.Add(new Binding("SelectedValue", Coordinator, "BikeUsed"));
        }

        private void closeButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void addNewButton_Click(object sender, EventArgs e)
        {
            if (_appProcess == Enumerations.ApplicationProcessEnum.Add)
            {
                Coordinator.AddRideToDatabase();
            }
            else
            {
                Coordinator.EditRideInDatabase();
            }
            ClearDataBindings();
            ApplyDataBindings();
        }

        private void addButton_Click(object sender, EventArgs e)
        {
            if (_appProcess == Enumerations.ApplicationProcessEnum.Add)
            {
                Coordinator.AddRideToDatabase();
            }
            else
            {
                Coordinator.EditRideInDatabase();
            }
            this.Close();
        }
    }
}
