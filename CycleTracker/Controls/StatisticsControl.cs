using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CycleTracker.BusinessObjects;

namespace CycleTracker.Controls
{
    public partial class StatisticsControl : UserControl
    {

        public StatisticsControl()
        {
            InitializeComponent();
        }

        public void SetTitle (string title)
        {
            this.titleLabel.Text = title;
        }

        public void SetDataSource (CombinedStatsObject current)
        {
            this.totalRidesYearLabel.Text = current.TotalRides.ToString();
            this.totalTimeYearLabel.Text = current.TotalTime.ToString();
            this.averageSpeedYearLabel.Text = current.AverageSpeed.ToString();
            this.totalDistanceYearLabel.Text = current.TotalDistance.ToString();
            this.totalAscentFtYearLabel.Text = current.TotalAscentFt.ToString();
            this.totalAscentMYearLabel.Text = current.TotalAscentMetres.ToString();
            this.totalAscentMilesCurrent.Text = current.TotalAscentMiles.ToString();
            this.longestRideMilesYearLabel.Text = current.LongestRideMiles.ToString();
            this.longestRideTimeYearLabel.Text = current.LongestRideTime.ToString();
            this.speedOver15Current.Text = current.PlusMinusFifteen.ToString();
            this.speedOver155Current.Text = current.PlusMinusFifteenFive.ToString();

            this.totalRidesPreviousYearLabel.Text = current.TotalPreviousRides.ToString();
            this.totalTimePreviousYearLabel.Text = current.TotalPreviousTime.ToString();
            this.averageSpeedPreviousYearLabel.Text = current.AveragePreviousSpeed.ToString();
            this.totalDistancePreviousYearLabel.Text = current.TotalPreviousDistance.ToString();
            this.totalAscentFtPreviousYearLabel.Text = current.TotalPreviousAscentFt.ToString();
            this.totalAscentMPreviousYearLabel.Text = current.TotalPreviousAscentMetres.ToString();
            this.totalAscentMilesPrevious.Text = current.TotalPreviousAscentMiles.ToString();
            this.longestRideMilesPreviousYearLabel.Text = current.LongestPreviousRideInMiles.ToString();
            this.longestRideTimePreviousYearLabel.Text = current.LongestPreviousRideTime.ToString();
            this.speedOver15Previous.Text = current.PlusMinusFifteenPrevious.ToString();
            this.speedOver155Previous.Text = current.PlusMinusFifteenFivePrevious.ToString();

            SetDifferenceControl(totalRidesYearDifferenceLabel, current.TotalRideDifference);
            SetDifferenceControl(totalTimeYearDifferenceLabel, current.TotalTimeDifference);
            SetDifferenceControl(averageSpeedYearDifferenceLabel, current.TotalSpeedDifference);
            SetDifferenceControl(totalDistanceYearDifferenceLabel, current.TotalDistanceDifference);
            SetDifferenceControl(totalAscentFtYearDifferenceLabel, current.TotalAscentDifferenceFt);
            SetDifferenceControl(totalAscentMYearDifferenceLabel, current.TotalAscentDifferenceMetres);
            SetDifferenceControl(totalAscentMilesDifference, current.TotalAscentDifferenceMiles);
            SetDifferenceControl(longestRideMilesYearDifferenceLabel, current.LongestRideDifference);
            SetDifferenceControl(longestRideTimeYearDifferenceLabel, current.LongestTimeDifference);
            SetDifferenceControl(speedOver15Difference, current.PlusMinusFifteenDifference);
            SetDifferenceControl(speedOver155Difference, current.PlusMinusFifteenFiveDifference);
        }

        private void SetDifferenceControl(Control control, decimal value)
        {
            SetDifferenceControl(control, value.ToString(), value < 0);
        }

        private void SetDifferenceControl(Control control, string value, bool negative)
        {
            control.Text = value;
            control.ForeColor = (negative) ? Color.Red : Color.Green;
        }
    }
}
