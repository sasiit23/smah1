﻿namespace SMAH1.Forms.Clock
{
    partial class HourSelector
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.SuspendLayout();
            // 
            // ClockSelector
            // 
            this.BackColor = System.Drawing.SystemColors.Control;
            this.MinimumSize = new System.Drawing.Size(148, 139);
            this.Name = "ClockSelector";
            this.Size = new System.Drawing.Size(148, 139);
            this.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.ClockSelector_MouseDoubleClick);
            this.MouseClick += new System.Windows.Forms.MouseEventHandler(this.ClockSelector_MouseClick);
            this.ResumeLayout(false);

        }

        #endregion

    }
}
