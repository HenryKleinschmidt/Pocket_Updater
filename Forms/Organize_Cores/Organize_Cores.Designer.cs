﻿namespace Pocket_Updater
{
    partial class Organize_Cores
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
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Organize_Cores));
            this.Save = new System.Windows.Forms.Button();
            this.Button_Refresh = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.Pocket_Drive = new System.Windows.Forms.ComboBox();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.CoreName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CoreCategory = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // Save
            // 
            this.Save.Enabled = false;
            this.Save.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.Save.Location = new System.Drawing.Point(465, 12);
            this.Save.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Save.Name = "Save";
            this.Save.Size = new System.Drawing.Size(100, 25);
            this.Save.TabIndex = 2;
            this.Save.Text = "Organize";
            this.Save.UseVisualStyleBackColor = true;
            this.Save.Click += new System.EventHandler(this.Save_Click);
            // 
            // Button_Refresh
            // 
            this.Button_Refresh.BackColor = System.Drawing.Color.Transparent;
            this.Button_Refresh.BackgroundImage = global::Pocket_Updater.Properties.Resources.refresh;
            this.Button_Refresh.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.Button_Refresh.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Button_Refresh.FlatAppearance.BorderSize = 0;
            this.Button_Refresh.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Button_Refresh.Location = new System.Drawing.Point(285, 15);
            this.Button_Refresh.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Button_Refresh.Name = "Button_Refresh";
            this.Button_Refresh.Size = new System.Drawing.Size(20, 20);
            this.Button_Refresh.TabIndex = 16;
            this.Button_Refresh.UseVisualStyleBackColor = true;
            this.Button_Refresh.Click += new System.EventHandler(this.Button_Refresh_Click_1);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label3.Location = new System.Drawing.Point(11, 18);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(121, 15);
            this.label3.TabIndex = 15;
            this.label3.Text = "Pocket Drive Letter:";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // Pocket_Drive
            // 
            this.Pocket_Drive.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.Pocket_Drive.FormattingEnabled = true;
            this.Pocket_Drive.Location = new System.Drawing.Point(133, 14);
            this.Pocket_Drive.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Pocket_Drive.Name = "Pocket_Drive";
            this.Pocket_Drive.Size = new System.Drawing.Size(148, 23);
            this.Pocket_Drive.TabIndex = 14;
            this.Pocket_Drive.SelectedIndexChanged += new System.EventHandler(this.Pocket_Drive_SelectedIndexChanged);
            // 
            // toolTip1
            // 
            this.toolTip1.AutoPopDelay = 50000;
            this.toolTip1.InitialDelay = 500;
            this.toolTip1.ReshowDelay = 100;
            this.toolTip1.ToolTipIcon = System.Windows.Forms.ToolTipIcon.Info;
            this.toolTip1.ToolTipTitle = "Refresh";
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.AllowUserToResizeRows = false;
            this.dataGridView1.BackgroundColor = System.Drawing.Color.MintCream;
            this.dataGridView1.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.Raised;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.CoreName,
            this.CoreCategory});
            this.dataGridView1.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.dataGridView1.Location = new System.Drawing.Point(8, 45);
            this.dataGridView1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.dataGridView1.MultiSelect = false;
            this.dataGridView1.Name = "dataGridView1";
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.PaleTurquoise;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridView1.RowHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dataGridView1.RowHeadersWidth = 62;
            this.dataGridView1.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.dataGridView1.RowTemplate.Height = 33;
            this.dataGridView1.Size = new System.Drawing.Size(562, 452);
            this.dataGridView1.TabIndex = 20;
            // 
            // CoreName
            // 
            this.CoreName.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.CoreName.HeaderText = "Core Name";
            this.CoreName.MinimumWidth = 8;
            this.CoreName.Name = "CoreName";
            // 
            // CoreCategory
            // 
            this.CoreCategory.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.CoreCategory.HeaderText = "Category";
            this.CoreCategory.MinimumWidth = 8;
            this.CoreCategory.Name = "CoreCategory";
            // 
            // Organize_Cores
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ClientSize = new System.Drawing.Size(579, 505);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.Button_Refresh);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.Pocket_Drive);
            this.Controls.Add(this.Save);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.MaximizeBox = false;
            this.Name = "Organize_Cores";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Organize Cores";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Button Save;
        private Button Button_Refresh;
        private Label label3;
        private ComboBox Pocket_Drive;
        private ToolTip toolTip1;
        private DataGridView dataGridView1;
        private DataGridViewTextBoxColumn CoreName;
        private DataGridViewTextBoxColumn CoreCategory;
    }
}