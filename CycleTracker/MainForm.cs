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

        private ImportCoordinator _coordinator = null;

        ImportCoordinator Coordinator
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
        
        public MainForm()
        {
            InitializeComponent();
            ImportData();


        }

        private void ImportData ()
        {
            foreach (string worksheet in Coordinator.GetWorkSheetList())
            {
                Coordinator.ImportRecords(worksheet);
            }
        }
    }
}
