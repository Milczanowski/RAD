﻿namespace RAD
{
    partial class ToolboxForm
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
            this.buttonButton = new System.Windows.Forms.Button();
            this.imageButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // buttonButton
            // 
            this.buttonButton.Location = new System.Drawing.Point(13, 13);
            this.buttonButton.Name = "buttonButton";
            this.buttonButton.Size = new System.Drawing.Size(160, 30);
            this.buttonButton.TabIndex = 0;
            this.buttonButton.Text = "BUTTON";
            this.buttonButton.UseVisualStyleBackColor = true;
            this.buttonButton.Click += new System.EventHandler(this.buttonButton_Click);
            // 
            // imageButton
            // 
            this.imageButton.Location = new System.Drawing.Point(13, 50);
            this.imageButton.Name = "imageButton";
            this.imageButton.Size = new System.Drawing.Size(160, 30);
            this.imageButton.TabIndex = 1;
            this.imageButton.Text = "IMAGE";
            this.imageButton.UseVisualStyleBackColor = true;
            this.imageButton.Click += new System.EventHandler(this.imageButton_Click);
            // 
            // ToolboxForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(184, 461);
            this.ControlBox = false;
            this.Controls.Add(this.imageButton);
            this.Controls.Add(this.buttonButton);
            this.MaximumSize = new System.Drawing.Size(200, 500);
            this.MinimumSize = new System.Drawing.Size(200, 500);
            this.Name = "ToolboxForm";
            this.Text = "Toolbox";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button buttonButton;
        private System.Windows.Forms.Button imageButton;
    }
}