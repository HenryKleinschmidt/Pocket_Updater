﻿namespace Pocket_Updater
{
    partial class CoreSelector
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CoreSelector));
            this.Button_Save = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.Enabled = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.CoreName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CoreAuthor = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // Button_Save
            // 
            this.Button_Save.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.Button_Save.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.Button_Save.Location = new System.Drawing.Point(239, 526);
            this.Button_Save.Margin = new System.Windows.Forms.Padding(1, 1, 1, 1);
            this.Button_Save.Name = "Button_Save";
            this.Button_Save.Size = new System.Drawing.Size(80, 25);
            this.Button_Save.TabIndex = 1;
            this.Button_Save.Text = "Save";
            this.Button_Save.UseVisualStyleBackColor = true;
            this.Button_Save.Click += new System.EventHandler(this.button1_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.AllowUserToResizeColumns = false;
            this.dataGridView1.AllowUserToResizeRows = false;
            this.dataGridView1.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.Raised;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Enabled,
            this.CoreName,
            this.CoreAuthor});
            this.dataGridView1.Location = new System.Drawing.Point(8, 7);
            this.dataGridView1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.dataGridView1.MultiSelect = false;
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 62;
            this.dataGridView1.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.dataGridView1.RowTemplate.Height = 33;
            this.dataGridView1.Size = new System.Drawing.Size(545, 516);
            this.dataGridView1.TabIndex = 3;
            // 
            // Enabled
            // 
            this.Enabled.HeaderText = "";
            this.Enabled.MinimumWidth = 4;
            this.Enabled.Name = "Enabled";
            this.Enabled.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.Enabled.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.Enabled.Width = 50;
            // 
            // CoreName
            // 
            this.CoreName.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.CoreName.DefaultCellStyle = dataGridViewCellStyle1;
            this.CoreName.HeaderText = "Core Name";
            this.CoreName.MinimumWidth = 8;
            this.CoreName.Name = "CoreName";
            this.CoreName.ReadOnly = true;
            // 
            // CoreAuthor
            // 
            this.CoreAuthor.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.CoreAuthor.DefaultCellStyle = dataGridViewCellStyle2;
            this.CoreAuthor.HeaderText = "Core Developer";
            this.CoreAuthor.MinimumWidth = 8;
            this.CoreAuthor.Name = "CoreAuthor";
            this.CoreAuthor.ReadOnly = true;
            // 
            // CoreSelector
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(564, 561);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.Button_Save);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(1, 1, 1, 1);
            this.MaximizeBox = false;
            this.Name = "CoreSelector";
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Manage Cores";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private Button Button_Save;
        private CheckBox checkBox1;
        private DataGridView dataGridView1;
        private DataGridViewCheckBoxColumn Enabled;
        private DataGridViewTextBoxColumn CoreName;
        private DataGridViewTextBoxColumn CoreAuthor;
    }
}