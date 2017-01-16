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
            this.summaryPanel = new System.Windows.Forms.Panel();
            this.longestRideTimePreviousLabel = new System.Windows.Forms.Label();
            this.yearComboBox = new System.Windows.Forms.ComboBox();
            this.longestRideTimeLabel = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.longestRidePreviousMilesLabel = new System.Windows.Forms.Label();
            this.longestRideMilesLabel = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.averageSpeedPreviousLabel = new System.Windows.Forms.Label();
            this.averageSpeedLabel = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.totalAscentMPreviousLabel = new System.Windows.Forms.Label();
            this.totalAscentFtPreviousLabel = new System.Windows.Forms.Label();
            this.totalDistancePreviousLabel = new System.Windows.Forms.Label();
            this.totalTimePreviousLabel = new System.Windows.Forms.Label();
            this.totalRidesPreviousLabel = new System.Windows.Forms.Label();
            this.label16 = new System.Windows.Forms.Label();
            this.totalAscentMLabel = new System.Windows.Forms.Label();
            this.totalAscentFtLabel = new System.Windows.Forms.Label();
            this.totalDistanceLabel = new System.Windows.Forms.Label();
            this.totalTimeLabel = new System.Windows.Forms.Label();
            this.totalRidesLabel = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label11 = new System.Windows.Forms.Label();
            this.monthComboBox = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.panel4 = new System.Windows.Forms.Panel();
            this.label17 = new System.Windows.Forms.Label();
            this.label18 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.label15 = new System.Windows.Forms.Label();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.importToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.importRecordsMenu = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.addRideButton = new System.Windows.Forms.ToolStripButton();
            this.toolStripButton2 = new System.Windows.Forms.ToolStripButton();
            this.previousYearComboBox = new System.Windows.Forms.ComboBox();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.ridesGroupBox.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ridesGrid)).BeginInit();
            this.summaryPanel.SuspendLayout();
            this.panel1.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.panel4.SuspendLayout();
            this.panel3.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            this.toolStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControl1.Location = new System.Drawing.Point(0, 28);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(1007, 942);
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
            this.tabPage1.Size = new System.Drawing.Size(999, 913);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Summary";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // ridesGroupBox
            // 
            this.ridesGroupBox.Controls.Add(this.panel2);
            this.ridesGroupBox.Controls.Add(this.panel1);
            this.ridesGroupBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ridesGroupBox.Location = new System.Drawing.Point(3, 409);
            this.ridesGroupBox.Name = "ridesGroupBox";
            this.ridesGroupBox.Padding = new System.Windows.Forms.Padding(10);
            this.ridesGroupBox.Size = new System.Drawing.Size(993, 501);
            this.ridesGroupBox.TabIndex = 1;
            this.ridesGroupBox.TabStop = false;
            this.ridesGroupBox.Text = "Rides";
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.ridesGrid);
            this.panel2.Controls.Add(this.summaryPanel);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.Location = new System.Drawing.Point(10, 72);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(973, 419);
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
            this.ridesGrid.Location = new System.Drawing.Point(550, 0);
            this.ridesGrid.Name = "ridesGrid";
            this.ridesGrid.RowHeadersVisible = false;
            this.ridesGrid.RowTemplate.Height = 24;
            this.ridesGrid.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.ridesGrid.Size = new System.Drawing.Size(423, 419);
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
            // summaryPanel
            // 
            this.summaryPanel.BackColor = System.Drawing.SystemColors.ControlLight;
            this.summaryPanel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.summaryPanel.Controls.Add(this.longestRideTimePreviousLabel);
            this.summaryPanel.Controls.Add(this.longestRideTimeLabel);
            this.summaryPanel.Controls.Add(this.label14);
            this.summaryPanel.Controls.Add(this.longestRidePreviousMilesLabel);
            this.summaryPanel.Controls.Add(this.longestRideMilesLabel);
            this.summaryPanel.Controls.Add(this.label10);
            this.summaryPanel.Controls.Add(this.averageSpeedPreviousLabel);
            this.summaryPanel.Controls.Add(this.averageSpeedLabel);
            this.summaryPanel.Controls.Add(this.label12);
            this.summaryPanel.Controls.Add(this.totalAscentMPreviousLabel);
            this.summaryPanel.Controls.Add(this.totalAscentFtPreviousLabel);
            this.summaryPanel.Controls.Add(this.totalDistancePreviousLabel);
            this.summaryPanel.Controls.Add(this.totalTimePreviousLabel);
            this.summaryPanel.Controls.Add(this.totalRidesPreviousLabel);
            this.summaryPanel.Controls.Add(this.label16);
            this.summaryPanel.Controls.Add(this.totalAscentMLabel);
            this.summaryPanel.Controls.Add(this.totalAscentFtLabel);
            this.summaryPanel.Controls.Add(this.totalDistanceLabel);
            this.summaryPanel.Controls.Add(this.totalTimeLabel);
            this.summaryPanel.Controls.Add(this.totalRidesLabel);
            this.summaryPanel.Controls.Add(this.label9);
            this.summaryPanel.Controls.Add(this.label8);
            this.summaryPanel.Controls.Add(this.label7);
            this.summaryPanel.Controls.Add(this.label6);
            this.summaryPanel.Controls.Add(this.label5);
            this.summaryPanel.Controls.Add(this.label4);
            this.summaryPanel.Controls.Add(this.label3);
            this.summaryPanel.Dock = System.Windows.Forms.DockStyle.Left;
            this.summaryPanel.Location = new System.Drawing.Point(0, 0);
            this.summaryPanel.Name = "summaryPanel";
            this.summaryPanel.Size = new System.Drawing.Size(550, 419);
            this.summaryPanel.TabIndex = 0;
            // 
            // longestRideTimePreviousLabel
            // 
            this.longestRideTimePreviousLabel.AutoSize = true;
            this.longestRideTimePreviousLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.longestRideTimePreviousLabel.Location = new System.Drawing.Point(372, 334);
            this.longestRideTimePreviousLabel.Name = "longestRideTimePreviousLabel";
            this.longestRideTimePreviousLabel.Size = new System.Drawing.Size(69, 20);
            this.longestRideTimePreviousLabel.TabIndex = 27;
            this.longestRideTimePreviousLabel.Text = "label14";
            // 
            // yearComboBox
            // 
            this.yearComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.yearComboBox.FormattingEnabled = true;
            this.yearComboBox.Location = new System.Drawing.Point(231, 3);
            this.yearComboBox.Name = "yearComboBox";
            this.yearComboBox.Size = new System.Drawing.Size(99, 28);
            this.yearComboBox.TabIndex = 3;
            this.yearComboBox.SelectedIndexChanged += new System.EventHandler(this.yearComboBox_SelectedIndexChanged);
            // 
            // longestRideTimeLabel
            // 
            this.longestRideTimeLabel.AutoSize = true;
            this.longestRideTimeLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.longestRideTimeLabel.Location = new System.Drawing.Point(228, 334);
            this.longestRideTimeLabel.Name = "longestRideTimeLabel";
            this.longestRideTimeLabel.Size = new System.Drawing.Size(69, 20);
            this.longestRideTimeLabel.TabIndex = 26;
            this.longestRideTimeLabel.Text = "label14";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label14.Location = new System.Drawing.Point(11, 334);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(151, 20);
            this.label14.TabIndex = 25;
            this.label14.Text = "Longest ride (time)";
            // 
            // longestRidePreviousMilesLabel
            // 
            this.longestRidePreviousMilesLabel.AutoSize = true;
            this.longestRidePreviousMilesLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.longestRidePreviousMilesLabel.Location = new System.Drawing.Point(371, 294);
            this.longestRidePreviousMilesLabel.Name = "longestRidePreviousMilesLabel";
            this.longestRidePreviousMilesLabel.Size = new System.Drawing.Size(69, 20);
            this.longestRidePreviousMilesLabel.TabIndex = 24;
            this.longestRidePreviousMilesLabel.Text = "label14";
            // 
            // longestRideMilesLabel
            // 
            this.longestRideMilesLabel.AutoSize = true;
            this.longestRideMilesLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.longestRideMilesLabel.Location = new System.Drawing.Point(227, 294);
            this.longestRideMilesLabel.Name = "longestRideMilesLabel";
            this.longestRideMilesLabel.Size = new System.Drawing.Size(69, 20);
            this.longestRideMilesLabel.TabIndex = 23;
            this.longestRideMilesLabel.Text = "label14";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(11, 294);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(159, 20);
            this.label10.TabIndex = 6;
            this.label10.Text = "Longest ride (miles)";
            // 
            // averageSpeedPreviousLabel
            // 
            this.averageSpeedPreviousLabel.AutoSize = true;
            this.averageSpeedPreviousLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.averageSpeedPreviousLabel.Location = new System.Drawing.Point(371, 137);
            this.averageSpeedPreviousLabel.Name = "averageSpeedPreviousLabel";
            this.averageSpeedPreviousLabel.Size = new System.Drawing.Size(69, 20);
            this.averageSpeedPreviousLabel.TabIndex = 22;
            this.averageSpeedPreviousLabel.Text = "label10";
            // 
            // averageSpeedLabel
            // 
            this.averageSpeedLabel.AutoSize = true;
            this.averageSpeedLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.averageSpeedLabel.Location = new System.Drawing.Point(227, 137);
            this.averageSpeedLabel.Name = "averageSpeedLabel";
            this.averageSpeedLabel.Size = new System.Drawing.Size(69, 20);
            this.averageSpeedLabel.TabIndex = 21;
            this.averageSpeedLabel.Text = "label11";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.Location = new System.Drawing.Point(11, 137);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(120, 20);
            this.label12.TabIndex = 20;
            this.label12.Text = "Average speed";
            // 
            // totalAscentMPreviousLabel
            // 
            this.totalAscentMPreviousLabel.AutoSize = true;
            this.totalAscentMPreviousLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.totalAscentMPreviousLabel.Location = new System.Drawing.Point(371, 257);
            this.totalAscentMPreviousLabel.Name = "totalAscentMPreviousLabel";
            this.totalAscentMPreviousLabel.Size = new System.Drawing.Size(69, 20);
            this.totalAscentMPreviousLabel.TabIndex = 19;
            this.totalAscentMPreviousLabel.Text = "label14";
            // 
            // totalAscentFtPreviousLabel
            // 
            this.totalAscentFtPreviousLabel.AutoSize = true;
            this.totalAscentFtPreviousLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.totalAscentFtPreviousLabel.Location = new System.Drawing.Point(371, 217);
            this.totalAscentFtPreviousLabel.Name = "totalAscentFtPreviousLabel";
            this.totalAscentFtPreviousLabel.Size = new System.Drawing.Size(69, 20);
            this.totalAscentFtPreviousLabel.TabIndex = 18;
            this.totalAscentFtPreviousLabel.Text = "label13";
            // 
            // totalDistancePreviousLabel
            // 
            this.totalDistancePreviousLabel.AutoSize = true;
            this.totalDistancePreviousLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.totalDistancePreviousLabel.Location = new System.Drawing.Point(371, 177);
            this.totalDistancePreviousLabel.Name = "totalDistancePreviousLabel";
            this.totalDistancePreviousLabel.Size = new System.Drawing.Size(69, 20);
            this.totalDistancePreviousLabel.TabIndex = 17;
            this.totalDistancePreviousLabel.Text = "label12";
            // 
            // totalTimePreviousLabel
            // 
            this.totalTimePreviousLabel.AutoSize = true;
            this.totalTimePreviousLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.totalTimePreviousLabel.Location = new System.Drawing.Point(372, 97);
            this.totalTimePreviousLabel.Name = "totalTimePreviousLabel";
            this.totalTimePreviousLabel.Size = new System.Drawing.Size(69, 20);
            this.totalTimePreviousLabel.TabIndex = 16;
            this.totalTimePreviousLabel.Text = "label11";
            // 
            // totalRidesPreviousLabel
            // 
            this.totalRidesPreviousLabel.AutoSize = true;
            this.totalRidesPreviousLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.totalRidesPreviousLabel.Location = new System.Drawing.Point(372, 57);
            this.totalRidesPreviousLabel.Name = "totalRidesPreviousLabel";
            this.totalRidesPreviousLabel.Size = new System.Drawing.Size(69, 20);
            this.totalRidesPreviousLabel.TabIndex = 15;
            this.totalRidesPreviousLabel.Text = "label10";
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label16.Location = new System.Drawing.Point(384, 57);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(0, 20);
            this.label16.TabIndex = 14;
            // 
            // totalAscentMLabel
            // 
            this.totalAscentMLabel.AutoSize = true;
            this.totalAscentMLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.totalAscentMLabel.Location = new System.Drawing.Point(227, 257);
            this.totalAscentMLabel.Name = "totalAscentMLabel";
            this.totalAscentMLabel.Size = new System.Drawing.Size(69, 20);
            this.totalAscentMLabel.TabIndex = 11;
            this.totalAscentMLabel.Text = "label14";
            // 
            // totalAscentFtLabel
            // 
            this.totalAscentFtLabel.AutoSize = true;
            this.totalAscentFtLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.totalAscentFtLabel.Location = new System.Drawing.Point(227, 217);
            this.totalAscentFtLabel.Name = "totalAscentFtLabel";
            this.totalAscentFtLabel.Size = new System.Drawing.Size(69, 20);
            this.totalAscentFtLabel.TabIndex = 10;
            this.totalAscentFtLabel.Text = "label13";
            // 
            // totalDistanceLabel
            // 
            this.totalDistanceLabel.AutoSize = true;
            this.totalDistanceLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.totalDistanceLabel.Location = new System.Drawing.Point(227, 177);
            this.totalDistanceLabel.Name = "totalDistanceLabel";
            this.totalDistanceLabel.Size = new System.Drawing.Size(69, 20);
            this.totalDistanceLabel.TabIndex = 9;
            this.totalDistanceLabel.Text = "label12";
            // 
            // totalTimeLabel
            // 
            this.totalTimeLabel.AutoSize = true;
            this.totalTimeLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.totalTimeLabel.Location = new System.Drawing.Point(228, 97);
            this.totalTimeLabel.Name = "totalTimeLabel";
            this.totalTimeLabel.Size = new System.Drawing.Size(69, 20);
            this.totalTimeLabel.TabIndex = 8;
            this.totalTimeLabel.Text = "label11";
            // 
            // totalRidesLabel
            // 
            this.totalRidesLabel.AutoSize = true;
            this.totalRidesLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.totalRidesLabel.Location = new System.Drawing.Point(228, 57);
            this.totalRidesLabel.Name = "totalRidesLabel";
            this.totalRidesLabel.Size = new System.Drawing.Size(69, 20);
            this.totalRidesLabel.TabIndex = 7;
            this.totalRidesLabel.Text = "label10";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(240, 57);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(0, 20);
            this.label9.TabIndex = 6;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(11, 257);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(132, 20);
            this.label8.TabIndex = 5;
            this.label8.Text = "Total ascent (m)";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(11, 217);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(128, 20);
            this.label7.TabIndex = 4;
            this.label7.Text = "Total ascent (ft)";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(11, 177);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(165, 20);
            this.label6.TabIndex = 3;
            this.label6.Text = "Total distance ridden";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(11, 97);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(175, 20);
            this.label5.TabIndex = 2;
            this.label5.Text = "Total time spent riding";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(11, 57);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(173, 20);
            this.label4.TabIndex = 1;
            this.label4.Text = "Total number of rides:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.label3.Location = new System.Drawing.Point(9, 9);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(218, 29);
            this.label3.TabIndex = 0;
            this.label3.Text = "Monthly Summary";
            this.label3.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.LightGray;
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.previousYearComboBox);
            this.panel1.Controls.Add(this.label11);
            this.panel1.Controls.Add(this.monthComboBox);
            this.panel1.Controls.Add(this.yearComboBox);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(10, 30);
            this.panel1.Margin = new System.Windows.Forms.Padding(10);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(973, 42);
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
            this.monthComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.monthComboBox.FormattingEnabled = true;
            this.monthComboBox.Location = new System.Drawing.Point(85, 3);
            this.monthComboBox.Name = "monthComboBox";
            this.monthComboBox.Size = new System.Drawing.Size(121, 28);
            this.monthComboBox.TabIndex = 1;
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
            this.groupBox1.Controls.Add(this.panel4);
            this.groupBox1.Controls.Add(this.panel3);
            this.groupBox1.Dock = System.Windows.Forms.DockStyle.Top;
            this.groupBox1.Location = new System.Drawing.Point(3, 3);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(10);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(10);
            this.groupBox1.Size = new System.Drawing.Size(993, 406);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Year to Date";
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.SystemColors.ControlLight;
            this.panel4.Controls.Add(this.label17);
            this.panel4.Controls.Add(this.label18);
            this.panel4.Controls.Add(this.label13);
            this.panel4.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel4.Location = new System.Drawing.Point(10, 72);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(550, 324);
            this.panel4.TabIndex = 2;
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label17.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.label17.Location = new System.Drawing.Point(367, 58);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(73, 25);
            this.label17.TabIndex = 15;
            this.label17.Text = "{Year}";
            this.label17.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label18.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.label18.Location = new System.Drawing.Point(223, 58);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(73, 25);
            this.label18.TabIndex = 14;
            this.label18.Text = "{Year}";
            this.label18.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.label13.Location = new System.Drawing.Point(5, 10);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(202, 29);
            this.label13.TabIndex = 1;
            this.label13.Text = "Yearly Summary";
            this.label13.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.LightGray;
            this.panel3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel3.Controls.Add(this.comboBox1);
            this.panel3.Controls.Add(this.label15);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel3.Location = new System.Drawing.Point(10, 30);
            this.panel3.Margin = new System.Windows.Forms.Padding(10);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(973, 42);
            this.panel3.TabIndex = 1;
            // 
            // comboBox1
            // 
            this.comboBox1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(94, 3);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(121, 28);
            this.comboBox1.TabIndex = 3;
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
            this.tabPage2.Size = new System.Drawing.Size(955, 840);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "tabPage2";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem,
            this.importToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1007, 28);
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
            // importToolStripMenuItem
            // 
            this.importToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.importRecordsMenu});
            this.importToolStripMenuItem.Name = "importToolStripMenuItem";
            this.importToolStripMenuItem.Size = new System.Drawing.Size(66, 24);
            this.importToolStripMenuItem.Text = "&Import";
            // 
            // importRecordsMenu
            // 
            this.importRecordsMenu.Name = "importRecordsMenu";
            this.importRecordsMenu.Size = new System.Drawing.Size(186, 26);
            this.importRecordsMenu.Text = "Import &Records";
            this.importRecordsMenu.Click += new System.EventHandler(this.importRecordsMenu_Click);
            // 
            // toolStrip1
            // 
            this.toolStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.addRideButton,
            this.toolStripButton2});
            this.toolStrip1.Location = new System.Drawing.Point(0, 28);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(1007, 27);
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
            this.addRideButton.Text = "addRideButton";
            this.addRideButton.Click += new System.EventHandler(this.addRideButton_Click);
            // 
            // toolStripButton2
            // 
            this.toolStripButton2.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButton2.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButton2.Image")));
            this.toolStripButton2.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton2.Name = "toolStripButton2";
            this.toolStripButton2.Size = new System.Drawing.Size(24, 24);
            this.toolStripButton2.Text = "toolStripButton2";
            // 
            // previousYearComboBox
            // 
            this.previousYearComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.previousYearComboBox.FormattingEnabled = true;
            this.previousYearComboBox.Location = new System.Drawing.Point(376, 3);
            this.previousYearComboBox.Name = "previousYearComboBox";
            this.previousYearComboBox.Size = new System.Drawing.Size(121, 28);
            this.previousYearComboBox.TabIndex = 5;
            this.previousYearComboBox.SelectedIndexChanged += new System.EventHandler(this.previousYearComboBox_SelectedIndexChanged);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1007, 970);
            this.Controls.Add(this.toolStrip1);
            this.Controls.Add(this.tabControl1);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "MainForm";
            this.Text = "Cycle Tracker";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.ridesGroupBox.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.ridesGrid)).EndInit();
            this.summaryPanel.ResumeLayout(false);
            this.summaryPanel.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
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
        private System.Windows.Forms.ToolStripMenuItem importToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem importRecordsMenu;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.ComboBox yearComboBox;
        private System.Windows.Forms.ComboBox monthComboBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView ridesGrid;
        private System.Windows.Forms.Panel summaryPanel;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label totalAscentMLabel;
        private System.Windows.Forms.Label totalAscentFtLabel;
        private System.Windows.Forms.Label totalDistanceLabel;
        private System.Windows.Forms.Label totalTimeLabel;
        private System.Windows.Forms.Label totalRidesLabel;
        private System.Windows.Forms.Label totalAscentMPreviousLabel;
        private System.Windows.Forms.Label totalAscentFtPreviousLabel;
        private System.Windows.Forms.Label totalDistancePreviousLabel;
        private System.Windows.Forms.Label totalTimePreviousLabel;
        private System.Windows.Forms.Label totalRidesPreviousLabel;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.Label averageSpeedPreviousLabel;
        private System.Windows.Forms.Label averageSpeedLabel;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label longestRideTimeLabel;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label longestRidePreviousMilesLabel;
        private System.Windows.Forms.Label longestRideMilesLabel;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label longestRideTimePreviousLabel;
        private System.Windows.Forms.DataGridViewTextBoxColumn RideDateGridColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn RideDistanceGridColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn RideTimeGridColum;
        private System.Windows.Forms.DataGridViewTextBoxColumn AverageSpeedGridColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn AscentGridColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn BikeGridColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn CommentsGridColumn;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripButton addRideButton;
        private System.Windows.Forms.ToolStripButton toolStripButton2;
        private System.Windows.Forms.ComboBox previousYearComboBox;
    }
}

