namespace CycleTracker
{
    partial class MainForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.ridesGroupBox = new System.Windows.Forms.GroupBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.ridesGrid = new System.Windows.Forms.DataGridView();
            this.RideDateGridColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.RideDistanceGridColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.RideTimeGridColum = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.AverageSpeedGridColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.AscentGridColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.BikeGridColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CommentsGridColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.monthToDateSummaryControl = new CycleTracker.Controls.StatisticsControl();
            this.montlySummaryControl = new CycleTracker.Controls.StatisticsControl();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label11 = new System.Windows.Forms.Label();
            this.monthComboBox = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.yearToDateSummaryControl = new CycleTracker.Controls.StatisticsControl();
            this.yearlySummaryControl = new CycleTracker.Controls.StatisticsControl();
            this.panel3 = new System.Windows.Forms.Panel();
            this.bikeComboBox = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.previousYearComboBox = new System.Windows.Forms.ComboBox();
            this.yearComboBox = new System.Windows.Forms.ComboBox();
            this.label15 = new System.Windows.Forms.Label();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.addRideButton = new System.Windows.Forms.ToolStripButton();
            this.editItemButton = new System.Windows.Forms.ToolStripButton();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.ridesGroupBox.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ridesGrid)).BeginInit();
            this.panel1.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.panel3.SuspendLayout();
            this.toolStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControl1.Location = new System.Drawing.Point(0, 24);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(1345, 946);
            this.tabControl1.TabIndex = 0;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.ridesGroupBox);
            this.tabPage1.Controls.Add(this.groupBox1);
            this.tabPage1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tabPage1.Location = new System.Drawing.Point(4, 25);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(1337, 917);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Summary";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // ridesGroupBox
            // 
            this.ridesGroupBox.Controls.Add(this.panel2);
            this.ridesGroupBox.Controls.Add(this.panel1);
            this.ridesGroupBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ridesGroupBox.Location = new System.Drawing.Point(3, 454);
            this.ridesGroupBox.Name = "ridesGroupBox";
            this.ridesGroupBox.Padding = new System.Windows.Forms.Padding(10);
            this.ridesGroupBox.Size = new System.Drawing.Size(1331, 460);
            this.ridesGroupBox.TabIndex = 1;
            this.ridesGroupBox.TabStop = false;
            this.ridesGroupBox.Text = "Rides";
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.ridesGrid);
            this.panel2.Controls.Add(this.monthToDateSummaryControl);
            this.panel2.Controls.Add(this.montlySummaryControl);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.Location = new System.Drawing.Point(10, 72);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1311, 378);
            this.panel2.TabIndex = 1;
            // 
            // ridesGrid
            // 
            this.ridesGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.ridesGrid.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.RideDateGridColumn,
            this.RideDistanceGridColumn,
            this.RideTimeGridColum,
            this.AverageSpeedGridColumn,
            this.AscentGridColumn,
            this.BikeGridColumn,
            this.CommentsGridColumn});
            this.ridesGrid.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ridesGrid.Location = new System.Drawing.Point(1225, 0);
            this.ridesGrid.Name = "ridesGrid";
            this.ridesGrid.RowHeadersVisible = false;
            this.ridesGrid.RowTemplate.Height = 24;
            this.ridesGrid.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.ridesGrid.Size = new System.Drawing.Size(86, 378);
            this.ridesGrid.TabIndex = 2;
            // 
            // RideDateGridColumn
            // 
            this.RideDateGridColumn.DataPropertyName = "RideDate";
            this.RideDateGridColumn.HeaderText = "Date";
            this.RideDateGridColumn.Name = "RideDateGridColumn";
            // 
            // RideDistanceGridColumn
            // 
            this.RideDistanceGridColumn.DataPropertyName = "DistanceInMiles";
            this.RideDistanceGridColumn.HeaderText = "Distance in Miles";
            this.RideDistanceGridColumn.Name = "RideDistanceGridColumn";
            this.RideDistanceGridColumn.Width = 150;
            // 
            // RideTimeGridColum
            // 
            this.RideTimeGridColum.DataPropertyName = "RideTime";
            this.RideTimeGridColum.HeaderText = "Time";
            this.RideTimeGridColum.Name = "RideTimeGridColum";
            // 
            // AverageSpeedGridColumn
            // 
            this.AverageSpeedGridColumn.DataPropertyName = "AverageSpeed";
            this.AverageSpeedGridColumn.HeaderText = "Average Speed";
            this.AverageSpeedGridColumn.Name = "AverageSpeedGridColumn";
            this.AverageSpeedGridColumn.Width = 150;
            // 
            // AscentGridColumn
            // 
            this.AscentGridColumn.DataPropertyName = "Ascent";
            this.AscentGridColumn.HeaderText = "Ascent";
            this.AscentGridColumn.Name = "AscentGridColumn";
            // 
            // BikeGridColumn
            // 
            this.BikeGridColumn.DataPropertyName = "Bike";
            this.BikeGridColumn.HeaderText = "Bike";
            this.BikeGridColumn.Name = "BikeGridColumn";
            // 
            // CommentsGridColumn
            // 
            this.CommentsGridColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.CommentsGridColumn.DataPropertyName = "Comments";
            this.CommentsGridColumn.HeaderText = "Comments";
            this.CommentsGridColumn.Name = "CommentsGridColumn";
            // 
            // monthToDateSummaryControl
            // 
            this.monthToDateSummaryControl.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.monthToDateSummaryControl.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.monthToDateSummaryControl.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.monthToDateSummaryControl.Dock = System.Windows.Forms.DockStyle.Left;
            this.monthToDateSummaryControl.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.monthToDateSummaryControl.Location = new System.Drawing.Point(609, 0);
            this.monthToDateSummaryControl.Margin = new System.Windows.Forms.Padding(4);
            this.monthToDateSummaryControl.Name = "monthToDateSummaryControl";
            this.monthToDateSummaryControl.Padding = new System.Windows.Forms.Padding(0, 0, 3, 0);
            this.monthToDateSummaryControl.Size = new System.Drawing.Size(616, 378);
            this.monthToDateSummaryControl.TabIndex = 10;
            // 
            // montlySummaryControl
            // 
            this.montlySummaryControl.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.montlySummaryControl.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.montlySummaryControl.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.montlySummaryControl.Dock = System.Windows.Forms.DockStyle.Left;
            this.montlySummaryControl.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.montlySummaryControl.Location = new System.Drawing.Point(0, 0);
            this.montlySummaryControl.Margin = new System.Windows.Forms.Padding(4);
            this.montlySummaryControl.Name = "montlySummaryControl";
            this.montlySummaryControl.Padding = new System.Windows.Forms.Padding(0, 0, 3, 0);
            this.montlySummaryControl.Size = new System.Drawing.Size(609, 378);
            this.montlySummaryControl.TabIndex = 9;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.LightGray;
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.label11);
            this.panel1.Controls.Add(this.monthComboBox);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(10, 30);
            this.panel1.Margin = new System.Windows.Forms.Padding(10);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1311, 42);
            this.panel1.TabIndex = 0;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.ForeColor = System.Drawing.Color.Red;
            this.label11.Location = new System.Drawing.Point(544, 7);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(127, 25);
            this.label11.TabIndex = 4;
            this.label11.Text = "Ride Details";
            this.label11.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // monthComboBox
            // 
            this.monthComboBox.DisplayMember = "MonthName";
            this.monthComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.monthComboBox.FormattingEnabled = true;
            this.monthComboBox.Location = new System.Drawing.Point(85, 3);
            this.monthComboBox.Name = "monthComboBox";
            this.monthComboBox.Size = new System.Drawing.Size(121, 28);
            this.monthComboBox.TabIndex = 1;
            this.monthComboBox.ValueMember = "monthId";
            this.monthComboBox.SelectedIndexChanged += new System.EventHandler(this.monthComboBox_SelectedValueChanged);
            this.monthComboBox.SelectedValueChanged += new System.EventHandler(this.monthComboBox_SelectedValueChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(10, 7);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(55, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Month";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.yearToDateSummaryControl);
            this.groupBox1.Controls.Add(this.yearlySummaryControl);
            this.groupBox1.Controls.Add(this.panel3);
            this.groupBox1.Dock = System.Windows.Forms.DockStyle.Top;
            this.groupBox1.Location = new System.Drawing.Point(3, 3);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(10);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(10);
            this.groupBox1.Size = new System.Drawing.Size(1331, 451);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Year to Date";
            // 
            // yearToDateSummaryControl
            // 
            this.yearToDateSummaryControl.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.yearToDateSummaryControl.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.yearToDateSummaryControl.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.yearToDateSummaryControl.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.yearToDateSummaryControl.Location = new System.Drawing.Point(614, 72);
            this.yearToDateSummaryControl.Margin = new System.Windows.Forms.Padding(4);
            this.yearToDateSummaryControl.Name = "yearToDateSummaryControl";
            this.yearToDateSummaryControl.Padding = new System.Windows.Forms.Padding(0, 0, 3, 0);
            this.yearToDateSummaryControl.Size = new System.Drawing.Size(609, 389);
            this.yearToDateSummaryControl.TabIndex = 5;
            // 
            // yearlySummaryControl
            // 
            this.yearlySummaryControl.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.yearlySummaryControl.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.yearlySummaryControl.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.yearlySummaryControl.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.yearlySummaryControl.Location = new System.Drawing.Point(6, 72);
            this.yearlySummaryControl.Margin = new System.Windows.Forms.Padding(4);
            this.yearlySummaryControl.Name = "yearlySummaryControl";
            this.yearlySummaryControl.Padding = new System.Windows.Forms.Padding(0, 0, 3, 0);
            this.yearlySummaryControl.Size = new System.Drawing.Size(609, 389);
            this.yearlySummaryControl.TabIndex = 4;
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.LightGray;
            this.panel3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel3.Controls.Add(this.bikeComboBox);
            this.panel3.Controls.Add(this.label2);
            this.panel3.Controls.Add(this.previousYearComboBox);
            this.panel3.Controls.Add(this.yearComboBox);
            this.panel3.Controls.Add(this.label15);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel3.Location = new System.Drawing.Point(10, 30);
            this.panel3.Margin = new System.Windows.Forms.Padding(10);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(1311, 42);
            this.panel3.TabIndex = 1;
            // 
            // bikeComboBox
            // 
            this.bikeComboBox.DisplayMember = "BikeName";
            this.bikeComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.bikeComboBox.FormattingEnabled = true;
            this.bikeComboBox.Location = new System.Drawing.Point(346, 6);
            this.bikeComboBox.Name = "bikeComboBox";
            this.bikeComboBox.Size = new System.Drawing.Size(258, 28);
            this.bikeComboBox.TabIndex = 8;
            this.bikeComboBox.ValueMember = "BikeId";
            this.bikeComboBox.SelectedValueChanged += new System.EventHandler(this.bikeComboBox_SelectedValueChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(298, 11);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(42, 20);
            this.label2.TabIndex = 7;
            this.label2.Text = "Bike";
            // 
            // previousYearComboBox
            // 
            this.previousYearComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.previousYearComboBox.FormattingEnabled = true;
            this.previousYearComboBox.Location = new System.Drawing.Point(159, 6);
            this.previousYearComboBox.Name = "previousYearComboBox";
            this.previousYearComboBox.Size = new System.Drawing.Size(121, 28);
            this.previousYearComboBox.TabIndex = 6;
            this.previousYearComboBox.SelectedValueChanged += new System.EventHandler(this.previousYearComboBox_SelectedValueChanged);
            // 
            // yearComboBox
            // 
            this.yearComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.yearComboBox.FormattingEnabled = true;
            this.yearComboBox.Location = new System.Drawing.Point(54, 6);
            this.yearComboBox.Name = "yearComboBox";
            this.yearComboBox.Size = new System.Drawing.Size(99, 28);
            this.yearComboBox.TabIndex = 4;
            this.yearComboBox.SelectedValueChanged += new System.EventHandler(this.yearComboBox_SelectedValueChanged);
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(5, 11);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(43, 20);
            this.label15.TabIndex = 2;
            this.label15.Text = "Year";
            // 
            // tabPage2
            // 
            this.tabPage2.Location = new System.Drawing.Point(4, 25);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(1337, 917);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "tabPage2";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1345, 24);
            this.menuStrip1.TabIndex = 1;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.exitToolStripMenuItem});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(44, 24);
            this.fileToolStripMenuItem.Text = "&File";
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(108, 26);
            this.exitToolStripMenuItem.Text = "E&xit";
            // 
            // toolStrip1
            // 
            this.toolStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.addRideButton,
            this.editItemButton});
            this.toolStrip1.Location = new System.Drawing.Point(0, 24);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(1345, 27);
            this.toolStrip1.TabIndex = 2;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // addRideButton
            // 
            this.addRideButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.addRideButton.Image = ((System.Drawing.Image)(resources.GetObject("addRideButton.Image")));
            this.addRideButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.addRideButton.Name = "addRideButton";
            this.addRideButton.Size = new System.Drawing.Size(24, 24);
            this.addRideButton.Text = "toolStripButton1";
            this.addRideButton.Click += new System.EventHandler(this.addRideButton_Click);
            // 
            // editItemButton
            // 
            this.editItemButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.editItemButton.Image = ((System.Drawing.Image)(resources.GetObject("editItemButton.Image")));
            this.editItemButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.editItemButton.Name = "editItemButton";
            this.editItemButton.Size = new System.Drawing.Size(24, 24);
            this.editItemButton.Text = "toolStripButton1";
            this.editItemButton.Click += new System.EventHandler(this.editItemButton_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1345, 970);
            this.Controls.Add(this.toolStrip1);
            this.Controls.Add(this.tabControl1);
            this.Controls.Add(this.menuStrip1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "MainForm";
            this.Text = "Cycle Tracker";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Shown += new System.EventHandler(this.MainForm_Shown);
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.ridesGroupBox.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.ridesGrid)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.GroupBox ridesGroupBox;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.ComboBox monthComboBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ComboBox yearComboBox;
        private System.Windows.Forms.ComboBox previousYearComboBox;
        private Controls.StatisticsControl yearlySummaryControl;
        private Controls.StatisticsControl yearToDateSummaryControl;
        private System.Windows.Forms.Panel panel2;
        private Controls.StatisticsControl monthToDateSummaryControl;
        private Controls.StatisticsControl montlySummaryControl;
        private System.Windows.Forms.DataGridView ridesGrid;
        private System.Windows.Forms.DataGridViewTextBoxColumn RideDateGridColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn RideDistanceGridColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn RideTimeGridColum;
        private System.Windows.Forms.DataGridViewTextBoxColumn AverageSpeedGridColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn AscentGridColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn BikeGridColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn CommentsGridColumn;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox bikeComboBox;
        private System.Windows.Forms.ToolStripButton addRideButton;
        private System.Windows.Forms.ToolStripButton editItemButton;
    }
}

