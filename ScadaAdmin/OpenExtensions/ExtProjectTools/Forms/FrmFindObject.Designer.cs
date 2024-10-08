﻿namespace Scada.Admin.Extensions.ExtProjectTools.Forms
{
    partial class FrmFindObject
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
            lblFind = new Label();
            txtFind = new TextBox();
            gbLookAt = new GroupBox();
            chkDescr = new CheckBox();
            chkCode = new CheckBox();
            chkName = new CheckBox();
            chkObjNum = new CheckBox();
            chkWholeStringOnly = new CheckBox();
            btnFindNext = new Button();
            btnClose = new Button();
            chkCaseSensitive = new CheckBox();
            gbLookAt.SuspendLayout();
            SuspendLayout();
            // 
            // lblFind
            // 
            lblFind.AutoSize = true;
            lblFind.Location = new Point(9, 9);
            lblFind.Name = "lblFind";
            lblFind.Size = new Size(59, 15);
            lblFind.TabIndex = 0;
            lblFind.Text = "Find what";
            // 
            // txtFind
            // 
            txtFind.Location = new Point(12, 27);
            txtFind.Name = "txtFind";
            txtFind.Size = new Size(360, 23);
            txtFind.TabIndex = 1;
            txtFind.TextChanged += txtFind_TextChanged;
            // 
            // gbLookAt
            // 
            gbLookAt.Controls.Add(chkDescr);
            gbLookAt.Controls.Add(chkCode);
            gbLookAt.Controls.Add(chkName);
            gbLookAt.Controls.Add(chkObjNum);
            gbLookAt.Location = new Point(12, 56);
            gbLookAt.Name = "gbLookAt";
            gbLookAt.Padding = new Padding(10, 3, 10, 10);
            gbLookAt.Size = new Size(360, 129);
            gbLookAt.TabIndex = 2;
            gbLookAt.TabStop = false;
            gbLookAt.Text = "Look at";
            // 
            // chkDescr
            // 
            chkDescr.AutoSize = true;
            chkDescr.Checked = true;
            chkDescr.CheckState = CheckState.Checked;
            chkDescr.Location = new Point(13, 97);
            chkDescr.Name = "chkDescr";
            chkDescr.Size = new Size(86, 19);
            chkDescr.TabIndex = 3;
            chkDescr.Text = "Description";
            chkDescr.UseVisualStyleBackColor = true;
            // 
            // chkCode
            // 
            chkCode.AutoSize = true;
            chkCode.Checked = true;
            chkCode.CheckState = CheckState.Checked;
            chkCode.Location = new Point(13, 72);
            chkCode.Name = "chkCode";
            chkCode.Size = new Size(54, 19);
            chkCode.TabIndex = 2;
            chkCode.Text = "Code";
            chkCode.UseVisualStyleBackColor = true;
            // 
            // chkName
            // 
            chkName.AutoSize = true;
            chkName.Checked = true;
            chkName.CheckState = CheckState.Checked;
            chkName.Location = new Point(13, 47);
            chkName.Name = "chkName";
            chkName.Size = new Size(58, 19);
            chkName.TabIndex = 1;
            chkName.Text = "Name";
            chkName.UseVisualStyleBackColor = true;
            // 
            // chkObjNum
            // 
            chkObjNum.AutoSize = true;
            chkObjNum.Checked = true;
            chkObjNum.CheckState = CheckState.Checked;
            chkObjNum.Location = new Point(13, 22);
            chkObjNum.Name = "chkObjNum";
            chkObjNum.Size = new Size(70, 19);
            chkObjNum.TabIndex = 0;
            chkObjNum.Text = "Number";
            chkObjNum.UseVisualStyleBackColor = true;
            // 
            // chkWholeStringOnly
            // 
            chkWholeStringOnly.AutoSize = true;
            chkWholeStringOnly.Location = new Point(12, 216);
            chkWholeStringOnly.Name = "chkWholeStringOnly";
            chkWholeStringOnly.Size = new Size(154, 19);
            chkWholeStringOnly.TabIndex = 4;
            chkWholeStringOnly.Text = "Match whole string only";
            chkWholeStringOnly.UseVisualStyleBackColor = true;
            // 
            // btnFindNext
            // 
            btnFindNext.Enabled = false;
            btnFindNext.Location = new Point(186, 241);
            btnFindNext.Name = "btnFindNext";
            btnFindNext.Size = new Size(90, 23);
            btnFindNext.TabIndex = 5;
            btnFindNext.Text = "Find Next";
            btnFindNext.UseVisualStyleBackColor = true;
            btnFindNext.Click += btnFindNext_Click;
            // 
            // btnClose
            // 
            btnClose.Location = new Point(282, 241);
            btnClose.Name = "btnClose";
            btnClose.Size = new Size(90, 23);
            btnClose.TabIndex = 6;
            btnClose.Text = "Close";
            btnClose.UseVisualStyleBackColor = true;
            btnClose.Click += btnClose_Click;
            // 
            // chkCaseSensitive
            // 
            chkCaseSensitive.AutoSize = true;
            chkCaseSensitive.Location = new Point(12, 191);
            chkCaseSensitive.Name = "chkCaseSensitive";
            chkCaseSensitive.Size = new Size(86, 19);
            chkCaseSensitive.TabIndex = 3;
            chkCaseSensitive.Text = "Match case";
            chkCaseSensitive.UseVisualStyleBackColor = true;
            // 
            // FrmFindObject
            // 
            AcceptButton = btnFindNext;
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            CancelButton = btnClose;
            ClientSize = new Size(384, 276);
            Controls.Add(btnClose);
            Controls.Add(btnFindNext);
            Controls.Add(chkWholeStringOnly);
            Controls.Add(chkCaseSensitive);
            Controls.Add(gbLookAt);
            Controls.Add(txtFind);
            Controls.Add(lblFind);
            FormBorderStyle = FormBorderStyle.FixedDialog;
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "FrmFindObject";
            StartPosition = FormStartPosition.Manual;
            Text = "Find Object";
            gbLookAt.ResumeLayout(false);
            gbLookAt.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblFind;
        private TextBox txtFind;
        private GroupBox gbLookAt;
        private CheckBox chkWholeStringOnly;
        private Button btnFindNext;
        private Button btnClose;
        private CheckBox chkCode;
        private CheckBox chkName;
        private CheckBox chkObjNum;
        private CheckBox chkDescr;
        private CheckBox chkCaseSensitive;
    }
}