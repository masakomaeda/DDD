
namespace DDD.WinForm.Views
{
    partial class MeasureLisstView
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
            this.MeasureDataGrid = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.MeasureDataGrid)).BeginInit();
            this.SuspendLayout();
            // 
            // MeasureDataGrid
            // 
            this.MeasureDataGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.MeasureDataGrid.Dock = System.Windows.Forms.DockStyle.Fill;
            this.MeasureDataGrid.Location = new System.Drawing.Point(0, 0);
            this.MeasureDataGrid.Name = "MeasureDataGrid";
            this.MeasureDataGrid.RowTemplate.Height = 25;
            this.MeasureDataGrid.Size = new System.Drawing.Size(824, 468);
            this.MeasureDataGrid.TabIndex = 0;
            // 
            // MeasureLisstView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(824, 468);
            this.Controls.Add(this.MeasureDataGrid);
            this.Name = "MeasureLisstView";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.MeasureDataGrid)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView MeasureDataGrid;
    }
}