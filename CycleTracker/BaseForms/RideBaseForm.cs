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
    public partial class RideBaseForm : Form
    {
        public RideBaseForm()
        {
            InitializeComponent();
        }

        protected virtual void Initialise()
        {

        }

        protected virtual void ClearDataBindings()
        {

        }

        protected virtual void ApplyDataBindings()
        {

        }

        private void RideBaseForm_Shown(object sender, EventArgs e)
        {
            Initialise();
            ClearDataBindings();
            ApplyDataBindings();
        }
    }
}
