using System.ComponentModel;
using System.Drawing;
using System.Windows.Forms;

namespace VehicleRentalSystem
{
    partial class CustomerForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private IContainer components = null;

        /// Controls for 'CustomerForm' 
        private DataGridView customerDataGridView;
        private TextBox customerSearchTextBox;
        private Button customerSearchButton;
        private Button customerInsertButton;
        private Button customerUpdateButton;
        private Button customerDeleteButton;

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
            this.customerDataGridView = new DataGridView();
            this.customerSearchTextBox = new TextBox();
            this.customerSearchButton = new Button();
            this.customerInsertButton = new Button();
            this.customerUpdateButton = new Button();
            this.customerDeleteButton = new Button();

            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Text = "Customer Management";

            // Customer DataGridView
            this.customerDataGridView.Dock = DockStyle.Top;
            this.customerDataGridView.Height = 250;
            this.customerDataGridView.Location = new Point(0, 0);

            // Search TextBox
            this.customerSearchTextBox.Location = new Point(20, 260);
            this.customerSearchTextBox.Size = new Size(200, 20);

            // Search Button
            this.customerSearchButton.Location = new Point(230, 260);
            this.customerSearchButton.Size = new Size(75, 23);
            this.customerSearchButton.Text = "Search";
            this.customerSearchButton.UseVisualStyleBackColor = true;

            // Insert Button
            this.customerInsertButton.Location = new Point(20, 300);
            this.customerInsertButton.Size = new Size(75, 23);
            this.customerInsertButton.Text = "Insert";
            this.customerInsertButton.UseVisualStyleBackColor = true;

            // Update Button
            this.customerUpdateButton.Location = new Point(110, 300);
            this.customerUpdateButton.Size = new Size(75, 23);
            this.customerUpdateButton.Text = "Update";
            this.customerUpdateButton.UseVisualStyleBackColor = true;

            // Delete Button
            this.customerDeleteButton.Location = new Point(200, 300);
            this.customerDeleteButton.Size = new Size(75, 23);
            this.customerDeleteButton.Text = "Delete";
            this.customerDeleteButton.UseVisualStyleBackColor = true;

            // Adding controls to the form
            this.Controls.Add(this.customerDataGridView);
            this.Controls.Add(this.customerSearchTextBox);
            this.Controls.Add(this.customerSearchButton);
            this.Controls.Add(this.customerInsertButton);
            this.Controls.Add(this.customerUpdateButton);
            this.Controls.Add(this.customerDeleteButton);
        }

        #endregion
    }
}