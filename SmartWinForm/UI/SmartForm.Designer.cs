﻿namespace SmartWinForm.UI
{
    partial class SmartForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SmartForm));
            this.SuspendLayout();
            // 
            // SmartForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 262);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "SmartForm";
            this.Text = "SmartForm";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.SmartForm_FormClosing);
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.SmartForm_FormClosed);
            this.Load += new System.EventHandler(this.SmartForm_Load);
            this.ResumeLayout(false);

        }

        #endregion
    }
}