﻿namespace DrawingShapes
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
            this.DrawingPannel = new System.Windows.Forms.Panel();
            this.SuspendLayout();
            // 
            // DrawingPannel
            // 
            this.DrawingPannel.Location = new System.Drawing.Point(13, 13);
            this.DrawingPannel.Name = "DrawingPannel";
            this.DrawingPannel.Size = new System.Drawing.Size(526, 425);
            this.DrawingPannel.TabIndex = 0;
            this.DrawingPannel.Click += new System.EventHandler(this.DrawingPannel_Click);
            this.DrawingPannel.Paint += new System.Windows.Forms.PaintEventHandler(this.DrawingPannel_Paint);
            this.DrawingPannel.MouseClick += new System.Windows.Forms.MouseEventHandler(this.DrawingPannel_MouseClick);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.DrawingPannel);
            this.Name = "MainForm";
            this.Text = "Form1";
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.MainForm_KeyDown);
            this.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.MainForm_KeyPress);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel DrawingPannel;
    }
}

