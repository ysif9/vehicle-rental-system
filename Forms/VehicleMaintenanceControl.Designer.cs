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
            this.vehicleInsertButton = new System.Windows.Forms.Button();
            this.vehicleUpdateButton = new System.Windows.Forms.Button();
            this.vehicleDeleteButton = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.maintenanceTextBox = new System.Windows.Forms.TextBox();
            this.carTextBox = new System.Windows.Forms.TextBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // vehicleInsertButton
            // 
            this.vehicleInsertButton.Location = new System.Drawing.Point(12, 173);
            this.vehicleInsertButton.Name = "vehicleInsertButton";
            this.vehicleInsertButton.Size = new System.Drawing.Size(75, 23);
            this.vehicleInsertButton.TabIndex = 3;
            this.vehicleInsertButton.Text = "Insert";
            this.vehicleInsertButton.UseVisualStyleBackColor = true;
            this.vehicleInsertButton.Click += new System.EventHandler(this.vehicleInsertButton_Click);
            // 
            // vehicleUpdateButton
            // 
            this.vehicleUpdateButton.Location = new System.Drawing.Point(110, 173);
            this.vehicleUpdateButton.Name = "vehicleUpdateButton";
            this.vehicleUpdateButton.Size = new System.Drawing.Size(75, 23);
            this.vehicleUpdateButton.TabIndex = 4;
            this.vehicleUpdateButton.Text = "Update";
            this.vehicleUpdateButton.UseVisualStyleBackColor = true;
            this.vehicleUpdateButton.Click += new System.EventHandler(this.vehicleUpdateButton_Click);
            // 
            // vehicleDeleteButton
            // 
            this.vehicleDeleteButton.Location = new System.Drawing.Point(204, 173);
            this.vehicleDeleteButton.Name = "vehicleDeleteButton";
            this.vehicleDeleteButton.Size = new System.Drawing.Size(75, 23);
            this.vehicleDeleteButton.TabIndex = 5;
            this.vehicleDeleteButton.Text = "Delete";
            this.vehicleDeleteButton.UseVisualStyleBackColor = true;
            this.vehicleDeleteButton.Click += new System.EventHandler(this.vehicleDeleteButton_Click);
            // 
            // label1
            // 
            this.label1.Location = new System.Drawing.Point(33, 33);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(118, 22);
            this.label1.TabIndex = 6;
            this.label1.Text = "Maintenance Number";
            // 
            // label2
            // 
            this.label2.Location = new System.Drawing.Point(33, 84);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(118, 22);
            this.label2.TabIndex = 7;
            this.label2.Text = "Car ID";
            // 
            // maintenanceTextBox
            // 
            this.maintenanceTextBox.Location = new System.Drawing.Point(192, 30);
            this.maintenanceTextBox.Name = "maintenanceTextBox";
            this.maintenanceTextBox.Size = new System.Drawing.Size(108, 20);
            this.maintenanceTextBox.TabIndex = 8;
            // 
            // carTextBox
            // 
            this.carTextBox.Location = new System.Drawing.Point(192, 81);
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
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.carTextBox);
            this.groupBox1.Controls.Add(this.maintenanceTextBox);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(12, 26);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(776, 141);
            this.groupBox1.TabIndex = 11;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Vehicle Needs Maintenance";
            // 
            // VehicleMaintenanceControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.vehicleInsertButton);
            this.Controls.Add(this.vehicleUpdateButton);
            this.Controls.Add(this.vehicleDeleteButton);
            this.Name = "VehicleMaintenanceControl";
            this.Size = new System.Drawing.Size(800, 450);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
        }

        private System.Windows.Forms.GroupBox groupBox1;

        private System.Windows.Forms.TextBox maintenanceTextBox;
        private System.Windows.Forms.TextBox carTextBox;
        private System.Windows.Forms.DataGridView dataGridView1;

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;

        #endregion
    }
}