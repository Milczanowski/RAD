namespace RAD.PropertiesForms
{
    partial class PathProperty
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
            this.openFileDialog = new System.Windows.Forms.OpenFileDialog();
            this.button = new System.Windows.Forms.Button();
            this.path = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // openFileDialog
            // 
            this.openFileDialog.DefaultExt = "png, jpg, jpeg";
            this.openFileDialog.FileName = "openFileDialog";
            // 
            // button
            // 
            this.button.Location = new System.Drawing.Point(148, 7);
            this.button.Name = "button";
            this.button.Size = new System.Drawing.Size(29, 20);
            this.button.TabIndex = 1;
            this.button.Text = "...";
            this.button.UseVisualStyleBackColor = true;
            this.button.Click += new System.EventHandler(this.button_Click);
            // 
            // path
            // 
            this.path.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.path.AutoSize = true;
            this.path.Location = new System.Drawing.Point(56, 7);
            this.path.Name = "path";
            this.path.Size = new System.Drawing.Size(28, 13);
            this.path.TabIndex = 2;
            this.path.Text = "path";
            // 
            // PathProperty
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.path);
            this.Controls.Add(this.button);
            this.Name = "PathProperty";
            this.Controls.SetChildIndex(this.label, 0);
            this.Controls.SetChildIndex(this.button, 0);
            this.Controls.SetChildIndex(this.path, 0);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.OpenFileDialog openFileDialog;
        private System.Windows.Forms.Button button;
        private System.Windows.Forms.Label path;
    }
}
