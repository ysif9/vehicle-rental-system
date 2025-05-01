﻿using System.ComponentModel;
using System.Drawing;
using System.Windows.Forms;

namespace VehicleRentalSystem
{
    partial class VehicleMaintenance
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private IContainer components = null;

        /// Controls for 'VehicleMaintenance' Form
        private DataGridView vehicleDataGridView;
        private TextBox vehicleSearchTextBox;
        private Button vehicleSearchButton;
        private Button vehicleInsertButton;
        private Button vehicleUpdateButton;
        private Button vehicleDeleteButton;

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
            this.components = new System.ComponentModel.Container();
            this.vehicleDataGridView = new DataGridView();
            this.vehicleSearchTextBox = new TextBox();
            this.vehicleSearchButton = new Button();
            this.vehicleInsertButton = new Button();
            this.vehicleUpdateButton = new Button();
            this.vehicleDeleteButton = new Button();

            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Text = "Vehicle Maintenance";

            // Vehicle DataGridView
            this.vehicleDataGridView.Dock = DockStyle.Top;
            this.vehicleDataGridView.Height = 300;
            this.vehicleDataGridView.Location = new Point(0, 0);

            // Search TextBox
            this.vehicleSearchTextBox.Location = new Point(20, 320);
            this.vehicleSearchTextBox.Size = new Size(200, 20);

            // Search Button
            this.vehicleSearchButton.Location = new Point(240, 320);
            this.vehicleSearchButton.Size = new Size(75, 23);
            this.vehicleSearchButton.Text = "Search";
            this.vehicleSearchButton.UseVisualStyleBackColor = true;

            // Insert Button
            this.vehicleInsertButton.Location = new Point(20, 360);
            this.vehicleInsertButton.Size = new Size(75, 23);
            this.vehicleInsertButton.Text = "Insert";
            this.vehicleInsertButton.UseVisualStyleBackColor = true;

            // Update Button
            this.vehicleUpdateButton.Location = new Point(110, 360);
            this.vehicleUpdateButton.Size = new Size(75, 23);
            this.vehicleUpdateButton.Text = "Update";
            this.vehicleUpdateButton.UseVisualStyleBackColor = true;

            // Delete Button
            this.vehicleDeleteButton.Location = new Point(200, 360);
            this.vehicleDeleteButton.Size = new Size(75, 23);
            this.vehicleDeleteButton.Text = "Delete";
            this.vehicleDeleteButton.UseVisualStyleBackColor = true;

            // Adding controls to the form
            this.Controls.Add(this.vehicleDataGridView);
            this.Controls.Add(this.vehicleSearchTextBox);
            this.Controls.Add(this.vehicleSearchButton);
            this.Controls.Add(this.vehicleInsertButton);
            this.Controls.Add(this.vehicleUpdateButton);
            this.Controls.Add(this.vehicleDeleteButton);
        }

        #endregion
    }
}