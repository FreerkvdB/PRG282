namespace PRG282_Project.PresentationLayer
{
    partial class ViewAll
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
            this.dgvViewAll = new System.Windows.Forms.DataGridView();
            this.btnViewAll = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvViewAll)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvViewAll
            // 
            this.dgvViewAll.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvViewAll.Location = new System.Drawing.Point(46, 36);
            this.dgvViewAll.Name = "dgvViewAll";
            this.dgvViewAll.RowHeadersWidth = 51;
            this.dgvViewAll.RowTemplate.Height = 24;
            this.dgvViewAll.Size = new System.Drawing.Size(696, 326);
            this.dgvViewAll.TabIndex = 0;
            // 
            // btnViewAll
            // 
            this.btnViewAll.Location = new System.Drawing.Point(328, 394);
            this.btnViewAll.Name = "btnViewAll";
            this.btnViewAll.Size = new System.Drawing.Size(106, 44);
            this.btnViewAll.TabIndex = 1;
            this.btnViewAll.Text = "View All";
            this.btnViewAll.UseVisualStyleBackColor = true;
            // 
            // ViewAll
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnViewAll);
            this.Controls.Add(this.dgvViewAll);
            this.Name = "ViewAll";
            this.Text = "ViewAll";
            ((System.ComponentModel.ISupportInitialize)(this.dgvViewAll)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvViewAll;
        private System.Windows.Forms.Button btnViewAll;
    }
}