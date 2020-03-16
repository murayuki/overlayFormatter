﻿namespace overlayFormatter
{
    partial class Main
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
            this.selectFileBtn = new System.Windows.Forms.Button();
            this.selectedPathLbl = new System.Windows.Forms.Label();
            this.selectedPathTxt = new System.Windows.Forms.TextBox();
            this.formatBtn = new System.Windows.Forms.Button();
            this.actionsLog = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // selectFileBtn
            // 
            this.selectFileBtn.Location = new System.Drawing.Point(233, 23);
            this.selectFileBtn.Name = "selectFileBtn";
            this.selectFileBtn.Size = new System.Drawing.Size(75, 23);
            this.selectFileBtn.TabIndex = 0;
            this.selectFileBtn.Text = "Open Folder";
            this.selectFileBtn.UseVisualStyleBackColor = true;
            this.selectFileBtn.Click += new System.EventHandler(this.selectFileBtn_Click);
            // 
            // selectedPathLbl
            // 
            this.selectedPathLbl.AutoSize = true;
            this.selectedPathLbl.Location = new System.Drawing.Point(12, 9);
            this.selectedPathLbl.Name = "selectedPathLbl";
            this.selectedPathLbl.Size = new System.Drawing.Size(76, 13);
            this.selectedPathLbl.TabIndex = 1;
            this.selectedPathLbl.Text = "Selected path:";
            // 
            // selectedPathTxt
            // 
            this.selectedPathTxt.Location = new System.Drawing.Point(15, 25);
            this.selectedPathTxt.Name = "selectedPathTxt";
            this.selectedPathTxt.ReadOnly = true;
            this.selectedPathTxt.Size = new System.Drawing.Size(212, 20);
            this.selectedPathTxt.TabIndex = 2;
            // 
            // formatBtn
            // 
            this.formatBtn.Enabled = false;
            this.formatBtn.Location = new System.Drawing.Point(15, 203);
            this.formatBtn.Name = "formatBtn";
            this.formatBtn.Size = new System.Drawing.Size(75, 23);
            this.formatBtn.TabIndex = 3;
            this.formatBtn.Text = "Format";
            this.formatBtn.UseVisualStyleBackColor = true;
            // 
            // actionsLog
            // 
            this.actionsLog.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.4F);
            this.actionsLog.Location = new System.Drawing.Point(15, 52);
            this.actionsLog.Multiline = true;
            this.actionsLog.Name = "actionsLog";
            this.actionsLog.ReadOnly = true;
            this.actionsLog.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.actionsLog.Size = new System.Drawing.Size(298, 145);
            this.actionsLog.TabIndex = 4;
            // 
            // Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(322, 241);
            this.Controls.Add(this.actionsLog);
            this.Controls.Add(this.formatBtn);
            this.Controls.Add(this.selectedPathTxt);
            this.Controls.Add(this.selectedPathLbl);
            this.Controls.Add(this.selectFileBtn);
            this.Name = "Main";
            this.Text = "overlayFormatter";
            this.Load += new System.EventHandler(this.Main_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button selectFileBtn;
        private System.Windows.Forms.Label selectedPathLbl;
        private System.Windows.Forms.TextBox selectedPathTxt;
        private System.Windows.Forms.Button formatBtn;
        private System.Windows.Forms.TextBox actionsLog;
    }
}
