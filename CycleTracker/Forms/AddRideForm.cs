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
        }

        protected override void Initialise()
        {
            this.bikeListComboBox.DataSource = Coordinator.BikeList;
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
            this.rideDatePicker.DataBindings.Add(new Binding("Text", Coordinator, "RideDate"));
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
            Coordinator.AddRideToDatabase();
            ClearDataBindings();
            ApplyDataBindings();
        }

        private void addButton_Click(object sender, EventArgs e)
        {
            Coordinator.AddRideToDatabase();
            this.Close();
        }
    }
}
