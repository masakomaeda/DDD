
namespace DDD.WinForm.Views
{
    partial class MenuView
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
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.MeasureButton = new System.Windows.Forms.Button();
            this.LatestButton = new System.Windows.Forms.Button();
            this.tableLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 1;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Controls.Add(this.MeasureButton, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.LatestButton, 0, 1);
            this.tableLayoutPanel1.Location = new System.Drawing.Point(23, 9);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 2;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(402, 100);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // MeasureButton
            // 
            this.MeasureButton.Location = new System.Drawing.Point(3, 3);
            this.MeasureButton.Name = "MeasureButton";
            this.MeasureButton.Size = new System.Drawing.Size(396, 44);
            this.MeasureButton.TabIndex = 0;
            this.MeasureButton.Text = "Measure";
            this.MeasureButton.UseVisualStyleBackColor = true;
            this.MeasureButton.Click += new System.EventHandler(this.MeasureButton_Click);
            // 
            // LatestButton
            // 
            this.LatestButton.Location = new System.Drawing.Point(3, 53);
            this.LatestButton.Name = "LatestButton";
            this.LatestButton.Size = new System.Drawing.Size(396, 44);
            this.LatestButton.TabIndex = 1;
            this.LatestButton.Text = "Latest";
            this.LatestButton.UseVisualStyleBackColor = true;
            this.LatestButton.Click += new System.EventHandler(this.LatestButton_Click);
            // 
            // MenuView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(451, 214);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Name = "MenuView";
            this.Text = "MenuView";
            this.tableLayoutPanel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Button MeasureButton;
        private System.Windows.Forms.Button LatestButton;
    }
}