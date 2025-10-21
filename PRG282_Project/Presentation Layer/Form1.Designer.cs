using System;

namespace PRG282_Project
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
            this.txtHeroID = new System.Windows.Forms.TextBox();
            this.txtHeroName = new System.Windows.Forms.TextBox();
            this.txtHeroAge = new System.Windows.Forms.TextBox();
            this.txtHeroSuperPower = new System.Windows.Forms.TextBox();
            this.numHeroExamScore = new System.Windows.Forms.NumericUpDown();
            this.lblHeroID = new System.Windows.Forms.Label();
            this.lblHeroName = new System.Windows.Forms.Label();
            this.lblHeroAge = new System.Windows.Forms.Label();
            this.lblHeroSuperpower = new System.Windows.Forms.Label();
            this.lblExamScore = new System.Windows.Forms.Label();
            this.btnAddHero = new System.Windows.Forms.Button();
            this.btnDeleteHero = new System.Windows.Forms.Button();
            this.dgvHeroes = new System.Windows.Forms.DataGridView();
            this.gbSummary = new System.Windows.Forms.GroupBox();
            this.btnEditHero = new System.Windows.Forms.Button();
            this.lblAvgAge = new System.Windows.Forms.Label();
            this.lblAvgScore = new System.Windows.Forms.Label();
            this.lblTotalHeroes = new System.Windows.Forms.Label();
            this.lblSRank = new System.Windows.Forms.Label();
            this.lblARank = new System.Windows.Forms.Label();
            this.lblBRank = new System.Windows.Forms.Label();
            this.lblCRank = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.numHeroExamScore)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvHeroes)).BeginInit();
            this.gbSummary.SuspendLayout();
            this.SuspendLayout();
            // 
            // txtHeroID
            // 
            this.txtHeroID.Location = new System.Drawing.Point(155, 137);
            this.txtHeroID.Name = "txtHeroID";
            this.txtHeroID.Size = new System.Drawing.Size(167, 20);
            this.txtHeroID.TabIndex = 0;
            // 
            // txtHeroName
            // 
            this.txtHeroName.Location = new System.Drawing.Point(155, 187);
            this.txtHeroName.Name = "txtHeroName";
            this.txtHeroName.Size = new System.Drawing.Size(167, 20);
            this.txtHeroName.TabIndex = 1;
            // 
            // txtHeroAge
            // 
            this.txtHeroAge.Location = new System.Drawing.Point(155, 236);
            this.txtHeroAge.Name = "txtHeroAge";
            this.txtHeroAge.Size = new System.Drawing.Size(167, 20);
            this.txtHeroAge.TabIndex = 2;
            // 
            // txtHeroSuperPower
            // 
            this.txtHeroSuperPower.Location = new System.Drawing.Point(155, 287);
            this.txtHeroSuperPower.Name = "txtHeroSuperPower";
            this.txtHeroSuperPower.Size = new System.Drawing.Size(167, 20);
            this.txtHeroSuperPower.TabIndex = 3;
            // 
            // numHeroExamScore
            // 
            this.numHeroExamScore.Location = new System.Drawing.Point(155, 343);
            this.numHeroExamScore.Name = "numHeroExamScore";
            this.numHeroExamScore.Size = new System.Drawing.Size(167, 20);
            this.numHeroExamScore.TabIndex = 5;
            // 
            // lblHeroID
            // 
            this.lblHeroID.AutoSize = true;
            this.lblHeroID.Location = new System.Drawing.Point(54, 143);
            this.lblHeroID.Name = "lblHeroID";
            this.lblHeroID.Size = new System.Drawing.Size(44, 13);
            this.lblHeroID.TabIndex = 6;
            this.lblHeroID.Text = "Hero ID";
            // 
            // lblHeroName
            // 
            this.lblHeroName.AutoSize = true;
            this.lblHeroName.Location = new System.Drawing.Point(54, 187);
            this.lblHeroName.Name = "lblHeroName";
            this.lblHeroName.Size = new System.Drawing.Size(35, 13);
            this.lblHeroName.TabIndex = 7;
            this.lblHeroName.Text = "Name";
            // 
            // lblHeroAge
            // 
            this.lblHeroAge.AutoSize = true;
            this.lblHeroAge.Location = new System.Drawing.Point(54, 239);
            this.lblHeroAge.Name = "lblHeroAge";
            this.lblHeroAge.Size = new System.Drawing.Size(26, 13);
            this.lblHeroAge.TabIndex = 8;
            this.lblHeroAge.Text = "Age";
            // 
            // lblHeroSuperpower
            // 
            this.lblHeroSuperpower.AutoSize = true;
            this.lblHeroSuperpower.Location = new System.Drawing.Point(54, 294);
            this.lblHeroSuperpower.Name = "lblHeroSuperpower";
            this.lblHeroSuperpower.Size = new System.Drawing.Size(64, 13);
            this.lblHeroSuperpower.TabIndex = 9;
            this.lblHeroSuperpower.Text = "Superpower";
            // 
            // lblExamScore
            // 
            this.lblExamScore.AutoSize = true;
            this.lblExamScore.Location = new System.Drawing.Point(54, 350);
            this.lblExamScore.Name = "lblExamScore";
            this.lblExamScore.Size = new System.Drawing.Size(64, 13);
            this.lblExamScore.TabIndex = 10;
            this.lblExamScore.Text = "Exam Score";
            // 
            // btnAddHero
            // 
            this.btnAddHero.Location = new System.Drawing.Point(57, 399);
            this.btnAddHero.Name = "btnAddHero";
            this.btnAddHero.Size = new System.Drawing.Size(75, 23);
            this.btnAddHero.TabIndex = 11;
            this.btnAddHero.Text = "Add Hero";
            this.btnAddHero.UseVisualStyleBackColor = true;
            this.btnAddHero.Click += new System.EventHandler(this.btnAddHero_Click);
            // 
            // btnDeleteHero
            // 
            this.btnDeleteHero.Location = new System.Drawing.Point(626, 449);
            this.btnDeleteHero.Name = "btnDeleteHero";
            this.btnDeleteHero.Size = new System.Drawing.Size(115, 23);
            this.btnDeleteHero.TabIndex = 12;
            this.btnDeleteHero.Text = "Delete Hero";
            this.btnDeleteHero.UseVisualStyleBackColor = true;
            this.btnDeleteHero.Click += new System.EventHandler(this.btnDeleteHero_Click);
            // 
            // dgvHeroes
            // 
            this.dgvHeroes.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvHeroes.Location = new System.Drawing.Point(396, 143);
            this.dgvHeroes.Name = "dgvHeroes";
            this.dgvHeroes.Size = new System.Drawing.Size(536, 279);
            this.dgvHeroes.TabIndex = 13;
            this.dgvHeroes.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvHeroes_CellClick);
            // 
            // gbSummary
            // 
            this.gbSummary.Controls.Add(this.lblCRank);
            this.gbSummary.Controls.Add(this.lblBRank);
            this.gbSummary.Controls.Add(this.lblARank);
            this.gbSummary.Controls.Add(this.lblSRank);
            this.gbSummary.Controls.Add(this.lblTotalHeroes);
            this.gbSummary.Controls.Add(this.lblAvgScore);
            this.gbSummary.Controls.Add(this.lblAvgAge);
            this.gbSummary.Location = new System.Drawing.Point(396, 449);
            this.gbSummary.Name = "gbSummary";
            this.gbSummary.Size = new System.Drawing.Size(200, 217);
            this.gbSummary.TabIndex = 14;
            this.gbSummary.TabStop = false;
            this.gbSummary.Text = "Summary:";
            // 
            // btnEditHero
            // 
            this.btnEditHero.Location = new System.Drawing.Point(789, 449);
            this.btnEditHero.Name = "btnEditHero";
            this.btnEditHero.Size = new System.Drawing.Size(115, 23);
            this.btnEditHero.TabIndex = 15;
            this.btnEditHero.Text = "Edit Hero";
            this.btnEditHero.UseVisualStyleBackColor = true;
            this.btnEditHero.Click += new System.EventHandler(this.btnEditHero_Click);
            // 
            // lblAvgAge
            // 
            this.lblAvgAge.AutoSize = true;
            this.lblAvgAge.Location = new System.Drawing.Point(6, 45);
            this.lblAvgAge.Name = "lblAvgAge";
            this.lblAvgAge.Size = new System.Drawing.Size(69, 13);
            this.lblAvgAge.TabIndex = 0;
            this.lblAvgAge.Text = "Average Age";
            // 
            // lblAvgScore
            // 
            this.lblAvgScore.AutoSize = true;
            this.lblAvgScore.Location = new System.Drawing.Point(6, 72);
            this.lblAvgScore.Name = "lblAvgScore";
            this.lblAvgScore.Size = new System.Drawing.Size(78, 13);
            this.lblAvgScore.TabIndex = 1;
            this.lblAvgScore.Text = "Average Score";
            // 
            // lblTotalHeroes
            // 
            this.lblTotalHeroes.AutoSize = true;
            this.lblTotalHeroes.Location = new System.Drawing.Point(7, 20);
            this.lblTotalHeroes.Name = "lblTotalHeroes";
            this.lblTotalHeroes.Size = new System.Drawing.Size(68, 13);
            this.lblTotalHeroes.TabIndex = 2;
            this.lblTotalHeroes.Text = "Total Heroes";
            // 
            // lblSRank
            // 
            this.lblSRank.AutoSize = true;
            this.lblSRank.Location = new System.Drawing.Point(7, 100);
            this.lblSRank.Name = "lblSRank";
            this.lblSRank.Size = new System.Drawing.Size(80, 13);
            this.lblSRank.TabIndex = 3;
            this.lblSRank.Text = "S-Rank Heroes";
            // 
            // lblARank
            // 
            this.lblARank.AutoSize = true;
            this.lblARank.Location = new System.Drawing.Point(7, 127);
            this.lblARank.Name = "lblARank";
            this.lblARank.Size = new System.Drawing.Size(80, 13);
            this.lblARank.TabIndex = 4;
            this.lblARank.Text = "A-Rank Heroes";
            // 
            // lblBRank
            // 
            this.lblBRank.AutoSize = true;
            this.lblBRank.Location = new System.Drawing.Point(7, 155);
            this.lblBRank.Name = "lblBRank";
            this.lblBRank.Size = new System.Drawing.Size(80, 13);
            this.lblBRank.TabIndex = 5;
            this.lblBRank.Text = "B-Rank Heroes";
            // 
            // lblCRank
            // 
            this.lblCRank.AutoSize = true;
            this.lblCRank.Location = new System.Drawing.Point(7, 184);
            this.lblCRank.Name = "lblCRank";
            this.lblCRank.Size = new System.Drawing.Size(80, 13);
            this.lblCRank.TabIndex = 6;
            this.lblCRank.Text = "C-Rank Heroes";
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1006, 678);
            this.Controls.Add(this.btnEditHero);
            this.Controls.Add(this.gbSummary);
            this.Controls.Add(this.dgvHeroes);
            this.Controls.Add(this.btnDeleteHero);
            this.Controls.Add(this.btnAddHero);
            this.Controls.Add(this.lblExamScore);
            this.Controls.Add(this.lblHeroSuperpower);
            this.Controls.Add(this.lblHeroAge);
            this.Controls.Add(this.lblHeroName);
            this.Controls.Add(this.lblHeroID);
            this.Controls.Add(this.numHeroExamScore);
            this.Controls.Add(this.txtHeroSuperPower);
            this.Controls.Add(this.txtHeroAge);
            this.Controls.Add(this.txtHeroName);
            this.Controls.Add(this.txtHeroID);
            this.Name = "MainForm";
            this.Text = "One Kick Heroes";
            this.Load += new System.EventHandler(this.MainForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.numHeroExamScore)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvHeroes)).EndInit();
            this.gbSummary.ResumeLayout(false);
            this.gbSummary.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        private void btnViewAll_Click(object sender, EventArgs e)
        {
            throw new NotImplementedException();
        }

        #endregion

        private System.Windows.Forms.TextBox txtHeroID;
        private System.Windows.Forms.TextBox txtHeroName;
        private System.Windows.Forms.TextBox txtHeroAge;
        private System.Windows.Forms.TextBox txtHeroSuperPower;
        private System.Windows.Forms.NumericUpDown numHeroExamScore;
        private System.Windows.Forms.Label lblHeroID;
        private System.Windows.Forms.Label lblHeroName;
        private System.Windows.Forms.Label lblHeroAge;
        private System.Windows.Forms.Label lblHeroSuperpower;
        private System.Windows.Forms.Label lblExamScore;
        private System.Windows.Forms.Button btnAddHero;
        private System.Windows.Forms.Button btnDeleteHero;
        private System.Windows.Forms.DataGridView dgvHeroes;
        private System.Windows.Forms.GroupBox gbSummary;
        private System.Windows.Forms.Button btnEditHero;
        private System.Windows.Forms.Label lblCRank;
        private System.Windows.Forms.Label lblBRank;
        private System.Windows.Forms.Label lblARank;
        private System.Windows.Forms.Label lblSRank;
        private System.Windows.Forms.Label lblTotalHeroes;
        private System.Windows.Forms.Label lblAvgScore;
        private System.Windows.Forms.Label lblAvgAge;
    }
}

