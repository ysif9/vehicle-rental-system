using System.ComponentModel;
using System.Drawing;
using System.Windows.Forms;

namespace VehicleRentalSystem.Forms
{
    partial class VehicleMaintenanceControl
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private IContainer components = null;

        private System.Windows.Forms.TextBox vehicleSearchTextBox;
        private System.Windows.Forms.Button vehicleSearchButton;
        private System.Windows.Forms.Button vehicleInsertButton;
        private System.Windows.Forms.Button vehicleUpdateButton;
        private System.Windows.Forms.Button vehicleDeleteButton;

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
            this.vehicleSearchTextBox = new System.Windows.Forms.TextBox();
            this.vehicleSearchButton = new System.Windows.Forms.Button();
            this.vehicleInsertButton = new System.Windows.Forms.Button();
            this.vehicleUpdateButton = new System.Windows.Forms.Button();
            this.vehicleDeleteButton = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.maintenanceTextBox = new System.Windows.Forms.TextBox();
            this.carTextBox = new System.Windows.Forms.TextBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // vehicleSearchTextBox
            // 
            this.vehicleSearchTextBox.Location = new System.Drawing.Point(33, 175);
            this.vehicleSearchTextBox.Name = "vehicleSearchTextBox";
            this.vehicleSearchTextBox.Size = new System.Drawing.Size(200, 20);
            this.vehicleSearchTextBox.TabIndex = 1;
            // 
            // vehicleSearchButton
            // 
            this.vehicleSearchButton.Location = new System.Drawing.Point(263, 173);
            this.vehicleSearchButton.Name = "vehicleSearchButton";
            this.vehicleSearchButton.Size = new System.Drawing.Size(75, 23);
            this.vehicleSearchButton.TabIndex = 2;
            this.vehicleSearchButton.Text = "Search";
            this.vehicleSearchButton.UseVisualStyleBackColor = true;
            // 
            // vehicleInsertButton
            // 
            this.vehicleInsertButton.Location = new System.Drawing.Point(359, 173);
            this.vehicleInsertButton.Name = "vehicleInsertButton";
            this.vehicleInsertButton.Size = new System.Drawing.Size(75, 23);
            this.vehicleInsertButton.TabIndex = 3;
            this.vehicleInsertButton.Text = "Insert";
            this.vehicleInsertButton.UseVisualStyleBackColor = true;
            this.vehicleInsertButton.Click += new System.EventHandler(this.vehicleInsertButton_Click);
            // 
            // vehicleUpdateButton
            // 
            this.vehicleUpdateButton.Location = new System.Drawing.Point(462, 173);
            this.vehicleUpdateButton.Name = "vehicleUpdateButton";
            this.vehicleUpdateButton.Size = new System.Drawing.Size(75, 23);
            this.vehicleUpdateButton.TabIndex = 4;
            this.vehicleUpdateButton.Text = "Update";
            this.vehicleUpdateButton.UseVisualStyleBackColor = true;
            this.vehicleUpdateButton.Click += new System.EventHandler(this.vehicleUpdateButton_Click);
            // 
            // vehicleDeleteButton
            // 
            this.vehicleDeleteButton.Location = new System.Drawing.Point(560, 173);
            this.vehicleDeleteButton.Name = "vehicleDeleteButton";
            this.vehicleDeleteButton.Size = new System.Drawing.Size(75, 23);
            this.vehicleDeleteButton.TabIndex = 5;
            this.vehicleDeleteButton.Text = "Delete";
            this.vehicleDeleteButton.UseVisualStyleBackColor = true;
            this.vehicleDeleteButton.Click += new System.EventHandler(this.vehicleDeleteButton_Click);
            // 
            // label1
            // 
            this.label1.Location = new System.Drawing.Point(45, 59);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(118, 22);
            this.label1.TabIndex = 6;
            this.label1.Text = "Maintenance Number";
            // 
            // label2
            // 
            this.label2.Location = new System.Drawing.Point(45, 110);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(118, 22);
            this.label2.TabIndex = 7;
            this.label2.Text = "Car ID";
            // 
            // maintenanceTextBox
            // 
            this.maintenanceTextBox.Location = new System.Drawing.Point(204, 56);
            this.maintenanceTextBox.Name = "maintenanceTextBox";
            this.maintenanceTextBox.Size = new System.Drawing.Size(108, 20);
            this.maintenanceTextBox.TabIndex = 8;
            // 
            // carTextBox
            // 
            this.carTextBox.Location = new System.Drawing.Point(204, 107);
            this.carTextBox.Name = "carTextBox";
            this.carTextBox.Size = new System.Drawing.Size(108, 20);
            this.carTextBox.TabIndex = 9;
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(12, 218);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(776, 220);
            this.dataGridView1.TabIndex = 10;
            // 
            // VehicleMaintenanceControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.carTextBox);
            this.Controls.Add(this.maintenanceTextBox);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.vehicleSearchTextBox);
            this.Controls.Add(this.vehicleSearchButton);
            this.Controls.Add(this.vehicleInsertButton);
            this.Controls.Add(this.vehicleUpdateButton);
            this.Controls.Add(this.vehicleDeleteButton);
            this.Name = "VehicleMaintenanceControl";
            this.Text = "Vehicle Maintenance";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();
        }

        private System.Windows.Forms.TextBox maintenanceTextBox;
        private System.Windows.Forms.TextBox carTextBox;
        private System.Windows.Forms.DataGridView dataGridView1;

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;

        #endregion
    }
}