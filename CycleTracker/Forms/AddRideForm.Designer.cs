namespace CycleTracker
{
    partial class AddRideForm
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
            this.rideDatePicker = new System.Windows.Forms.DateTimePicker();
            this.closeButton = new System.Windows.Forms.Button();
            this.addNewButton = new System.Windows.Forms.Button();
            this.bikeListComboBox = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.rideAscentTextBox = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.rideTimeTextBox = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.rideDistanceTextBox = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.addButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // rideDatePicker
            // 
            this.rideDatePicker.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.rideDatePicker.Location = new System.Drawing.Point(154, 30);
            this.rideDatePicker.Name = "rideDatePicker";
            this.rideDatePicker.Size = new System.Drawing.Size(160, 22);
            this.rideDatePicker.TabIndex = 0;
            // 
            // closeButton
            // 
            this.closeButton.Location = new System.Drawing.Point(226, 226);
            this.closeButton.Name = "closeButton";
            this.closeButton.Size = new System.Drawing.Size(75, 28);
            this.closeButton.TabIndex = 10;
            this.closeButton.Text = "&Close";
            this.closeButton.UseVisualStyleBackColor = true;
            this.closeButton.Click += new System.EventHandler(this.closeButton_Click);
            // 
            // addNewButton
            // 
            this.addNewButton.Location = new System.Drawing.Point(93, 226);
            this.addNewButton.Name = "addNewButton";
            this.addNewButton.Size = new System.Drawing.Size(75, 28);
            this.addNewButton.TabIndex = 9;
            this.addNewButton.Text = "&New";
            this.addNewButton.UseVisualStyleBackColor = true;
            this.addNewButton.Click += new System.EventHandler(this.addNewButton_Click);
            // 
            // bikeListComboBox
            // 
            this.bikeListComboBox.DisplayMember = "BikeName";
            this.bikeListComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.bikeListComboBox.FormattingEnabled = true;
            this.bikeListComboBox.Location = new System.Drawing.Point(154, 171);
            this.bikeListComboBox.Name = "bikeListComboBox";
            this.bikeListComboBox.Size = new System.Drawing.Size(160, 24);
            this.bikeListComboBox.TabIndex = 4;
            this.bikeListComboBox.ValueMember = "BikeId";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(16, 171);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(35, 17);
            this.label5.TabIndex = 8;
            this.label5.Text = "Bike";
            // 
            // rideAscentTextBox
            // 
            this.rideAscentTextBox.Location = new System.Drawing.Point(154, 133);
            this.rideAscentTextBox.Name = "rideAscentTextBox";
            this.rideAscentTextBox.Size = new System.Drawing.Size(160, 22);
            this.rideAscentTextBox.TabIndex = 3;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(16, 133);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(73, 17);
            this.label4.TabIndex = 6;
            this.label4.Text = "Ascent (ft)";
            // 
            // rideTimeTextBox
            // 
            this.rideTimeTextBox.Location = new System.Drawing.Point(154, 98);
            this.rideTimeTextBox.Name = "rideTimeTextBox";
            this.rideTimeTextBox.Size = new System.Drawing.Size(160, 22);
            this.rideTimeTextBox.TabIndex = 2;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(13, 98);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(97, 17);
            this.label3.TabIndex = 4;
            this.label3.Text = "Ride Time (m)";
            // 
            // rideDistanceTextBox
            // 
            this.rideDistanceTextBox.Location = new System.Drawing.Point(154, 62);
            this.rideDistanceTextBox.Name = "rideDistanceTextBox";
            this.rideDistanceTextBox.Size = new System.Drawing.Size(160, 22);
            this.rideDistanceTextBox.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(13, 65);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(100, 17);
            this.label2.TabIndex = 2;
            this.label2.Text = "Ride Distance:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 30);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(75, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "Ride Date:";
            // 
            // addButton
            // 
            this.addButton.Location = new System.Drawing.Point(12, 226);
            this.addButton.Name = "addButton";
            this.addButton.Size = new System.Drawing.Size(75, 28);
            this.addButton.TabIndex = 11;
            this.addButton.Text = "&Add";
            this.addButton.UseVisualStyleBackColor = true;
            this.addButton.Click += new System.EventHandler(this.addButton_Click);
            // 
            // AddRideForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(326, 272);
            this.Controls.Add(this.addButton);
            this.Controls.Add(this.rideDatePicker);
            this.Controls.Add(this.closeButton);
            this.Controls.Add(this.addNewButton);
            this.Controls.Add(this.bikeListComboBox);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.rideAscentTextBox);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.rideTimeTextBox);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.rideDistanceTextBox);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "AddRideForm";
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Add New Ride";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox rideDistanceTextBox;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox rideTimeTextBox;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox rideAscentTextBox;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox bikeListComboBox;
        private System.Windows.Forms.Button addNewButton;
        private System.Windows.Forms.Button closeButton;
        private System.Windows.Forms.DateTimePicker rideDatePicker;
        private System.Windows.Forms.Button addButton;
    }
}