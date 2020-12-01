using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Runtime.CompilerServices;
using System.Windows.Forms;
using System.Data;

namespace DSNServer
{
    partial class DSNServerForm
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
            this.sendCMDBtn = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.spacecraftsDataGridView = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.spacecraftsDataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // sendCMDBtn
            // 
            this.sendCMDBtn.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.sendCMDBtn.Location = new System.Drawing.Point(0, 940);
            this.sendCMDBtn.Name = "sendCMDBtn";
            this.sendCMDBtn.Size = new System.Drawing.Size(1924, 50);
            this.sendCMDBtn.TabIndex = 0;
            this.sendCMDBtn.Text = "send command";
            this.sendCMDBtn.Click += new System.EventHandler(this.sendCMDBtn_Click);
            // 
            // textBox1
            // 
            this.textBox1.AcceptsReturn = true;
            this.textBox1.AcceptsTab = true;
            this.textBox1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.textBox1.Location = new System.Drawing.Point(0, 914);
            this.textBox1.Name = "textBox1";
            this.textBox1.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.textBox1.Size = new System.Drawing.Size(1924, 26);
            this.textBox1.TabIndex = 2;
            // 
            // spacecraftsDataGridView
            // 
            this.spacecraftsDataGridView.ColumnHeadersHeight = 34;
            this.spacecraftsDataGridView.Dock = System.Windows.Forms.DockStyle.Top;
            this.spacecraftsDataGridView.Location = new System.Drawing.Point(0, 0);
            this.spacecraftsDataGridView.Name = "spacecraftsDataGridView";
            this.spacecraftsDataGridView.RowHeadersWidth = 10;
            this.spacecraftsDataGridView.Size = new System.Drawing.Size(1924, 908);
            this.spacecraftsDataGridView.TabIndex = 1;
            this.spacecraftsDataGridView.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.spacecraftsDataGridView_CellContentClick);
            // 
            // DSNServerForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1924, 990);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.sendCMDBtn);
            this.Controls.Add(this.spacecraftsDataGridView);
            this.Name = "DSNServerForm";
            this.Text = "DSNServerForm";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.DSNServerForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.spacecraftsDataGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private Button sendCMDBtn;
        //private Button startSyncBtn;
        private DataGridView spacecraftsDataGridView;
        private TextBox textBox1;
    }
}

