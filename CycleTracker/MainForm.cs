using CycleTracker.BusinessObjects;
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
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
            ImportCoordinator Coordinator = new ImportCoordinator(@"C:\Users\Andrew\Documents\exercise.xlsx");

            var results = Coordinator.GetWorkSheetList();
        }
    }
}
