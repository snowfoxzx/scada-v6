﻿namespace Scada.Admin.Extensions.ExtProjectTools.Forms
{
    partial class FrmTableExport
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
            this.lblTable = new System.Windows.Forms.Label();
            this.cbTable = new System.Windows.Forms.ComboBox();
            this.gbIDs = new System.Windows.Forms.GroupBox();
            this.numEndID = new System.Windows.Forms.NumericUpDown();
            this.chkEndID = new System.Windows.Forms.CheckBox();
            this.lblEndID = new System.Windows.Forms.Label();
            this.numStartID = new System.Windows.Forms.NumericUpDown();
            this.chkStartID = new System.Windows.Forms.CheckBox();
            this.lblStartID = new System.Windows.Forms.Label();
            this.cbFormat = new System.Windows.Forms.ComboBox();
            this.lblFormat = new System.Windows.Forms.Label();
            this.btnExport = new System.Windows.Forms.Button();
            this.btnClose = new System.Windows.Forms.Button();
            this.saveFileDialog = new System.Windows.Forms.SaveFileDialog();
            this.gbIDs.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numEndID)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numStartID)).BeginInit();
            this.SuspendLayout();
            // 
            // lblTable
            // 
            this.lblTable.AutoSize = true;
            this.lblTable.Location = new System.Drawing.Point(9, 9);
            this.lblTable.Name = "lblTable";
            this.lblTable.Size = new System.Drawing.Size(34, 15);
            this.lblTable.TabIndex = 0;
            this.lblTable.Text = "Table";
            // 
            // cbTable
            // 
            this.cbTable.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbTable.FormattingEnabled = true;
            this.cbTable.Location = new System.Drawing.Point(12, 27);
            this.cbTable.Name = "cbTable";
            this.cbTable.Size = new System.Drawing.Size(310, 23);
            this.cbTable.TabIndex = 1;
            // 
            // gbIDs
            // 
            this.gbIDs.Controls.Add(this.numEndID);
            this.gbIDs.Controls.Add(this.chkEndID);
            this.gbIDs.Controls.Add(this.lblEndID);
            this.gbIDs.Controls.Add(this.numStartID);
            this.gbIDs.Controls.Add(this.chkStartID);
            this.gbIDs.Controls.Add(this.lblStartID);
            this.gbIDs.Location = new System.Drawing.Point(12, 100);
            this.gbIDs.Name = "gbIDs";
            this.gbIDs.Padding = new System.Windows.Forms.Padding(10, 3, 10, 10);
            this.gbIDs.Size = new System.Drawing.Size(310, 73);
            this.gbIDs.TabIndex = 4;
            this.gbIDs.TabStop = false;
            this.gbIDs.Text = "IDs";
            // 
            // numEndID
            // 
            this.numEndID.Enabled = false;
            this.numEndID.Location = new System.Drawing.Point(176, 37);
            this.numEndID.Maximum = new decimal(new int[] {
            2147483647,
            0,
            0,
            0});
            this.numEndID.Name = "numEndID";
            this.numEndID.Size = new System.Drawing.Size(118, 23);
            this.numEndID.TabIndex = 5;
            // 
            // chkEndID
            // 
            this.chkEndID.AutoSize = true;
            this.chkEndID.Location = new System.Drawing.Point(158, 42);
            this.chkEndID.Name = "chkEndID";
            this.chkEndID.Size = new System.Drawing.Size(15, 14);
            this.chkEndID.TabIndex = 4;
            this.chkEndID.UseVisualStyleBackColor = true;
            this.chkEndID.CheckedChanged += new System.EventHandler(this.chkEndID_CheckedChanged);
            // 
            // lblEndID
            // 
            this.lblEndID.AutoSize = true;
            this.lblEndID.Location = new System.Drawing.Point(173, 19);
            this.lblEndID.Name = "lblEndID";
            this.lblEndID.Size = new System.Drawing.Size(27, 15);
            this.lblEndID.TabIndex = 3;
            this.lblEndID.Text = "End";
            // 
            // numStartID
            // 
            this.numStartID.Enabled = false;
            this.numStartID.Location = new System.Drawing.Point(34, 37);
            this.numStartID.Maximum = new decimal(new int[] {
            2147483647,
            0,
            0,
            0});
            this.numStartID.Name = "numStartID";
            this.numStartID.Size = new System.Drawing.Size(118, 23);
            this.numStartID.TabIndex = 2;
            // 
            // chkStartID
            // 
            this.chkStartID.AutoSize = true;
            this.chkStartID.Location = new System.Drawing.Point(13, 42);
            this.chkStartID.Name = "chkStartID";
            this.chkStartID.Size = new System.Drawing.Size(15, 14);
            this.chkStartID.TabIndex = 1;
            this.chkStartID.UseVisualStyleBackColor = true;
            this.chkStartID.CheckedChanged += new System.EventHandler(this.chkStartID_CheckedChanged);
            // 
            // lblStartID
            // 
            this.lblStartID.AutoSize = true;
            this.lblStartID.Location = new System.Drawing.Point(31, 19);
            this.lblStartID.Name = "lblStartID";
            this.lblStartID.Size = new System.Drawing.Size(31, 15);
            this.lblStartID.TabIndex = 0;
            this.lblStartID.Text = "Start";
            // 
            // cbFormat
            // 
            this.cbFormat.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbFormat.FormattingEnabled = true;
            this.cbFormat.Items.AddRange(new object[] {
            "Runtime tables (*.dat)",
            "Project tables (*.xml)",
            "Comma-separated values (*.csv)"});
            this.cbFormat.Location = new System.Drawing.Point(12, 71);
            this.cbFormat.Name = "cbFormat";
            this.cbFormat.Size = new System.Drawing.Size(310, 23);
            this.cbFormat.TabIndex = 3;
            // 
            // lblFormat
            // 
            this.lblFormat.AutoSize = true;
            this.lblFormat.Location = new System.Drawing.Point(9, 53);
            this.lblFormat.Name = "lblFormat";
            this.lblFormat.Size = new System.Drawing.Size(45, 15);
            this.lblFormat.TabIndex = 2;
            this.lblFormat.Text = "Format";
            // 
            // btnExport
            // 
            this.btnExport.Location = new System.Drawing.Point(166, 189);
            this.btnExport.Name = "btnExport";
            this.btnExport.Size = new System.Drawing.Size(75, 23);
            this.btnExport.TabIndex = 5;
            this.btnExport.Text = "Export";
            this.btnExport.UseVisualStyleBackColor = true;
            this.btnExport.Click += new System.EventHandler(this.btnExport_Click);
            // 
            // btnClose
            // 
            this.btnClose.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnClose.Location = new System.Drawing.Point(247, 189);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(75, 23);
            this.btnClose.TabIndex = 6;
            this.btnClose.Text = "Close";
            this.btnClose.UseVisualStyleBackColor = true;
            // 
            // saveFileDialog
            // 
            this.saveFileDialog.Filter = "Tables (*.dat;*.xml;*.csv)|*.dat;*.xml;*.csv|All Files (*.*)|*.*";
            // 
            // FrmTableExport
            // 
            this.AcceptButton = this.btnExport;
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.btnClose;
            this.ClientSize = new System.Drawing.Size(334, 224);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.btnExport);
            this.Controls.Add(this.gbIDs);
            this.Controls.Add(this.cbFormat);
            this.Controls.Add(this.lblFormat);
            this.Controls.Add(this.cbTable);
            this.Controls.Add(this.lblTable);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FrmTableExport";
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Export Table";
            this.Load += new System.EventHandler(this.FrmTableExport_Load);
            this.gbIDs.ResumeLayout(false);
            this.gbIDs.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numEndID)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numStartID)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblTable;
        private System.Windows.Forms.ComboBox cbTable;
        private System.Windows.Forms.GroupBox gbIDs;
        private System.Windows.Forms.ComboBox cbFormat;
        private System.Windows.Forms.Label lblFormat;
        private System.Windows.Forms.CheckBox chkEndID;
        private System.Windows.Forms.CheckBox chkStartID;
        private System.Windows.Forms.NumericUpDown numEndID;
        private System.Windows.Forms.Label lblEndID;
        private System.Windows.Forms.NumericUpDown numStartID;
        private System.Windows.Forms.Label lblStartID;
        private System.Windows.Forms.Button btnExport;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.SaveFileDialog saveFileDialog;
    }
}