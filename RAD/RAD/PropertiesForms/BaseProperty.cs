using System;
using System.Windows.Forms;

namespace RAD.PropertiesForms
{
    public class BaseProperty<T> : UserControl, IProperty
    {
        protected Label label;

        protected Action<T> OnValueChanged { get; private set; } = delegate { };

        public Control GetControl { get { return this; } }

        public BaseProperty()
        {
            InitializeComponent();
        }

        public BaseProperty(string name, T value, Action<T> onValueChanged)
        {
            InitializeComponent();
            OnValueChanged = onValueChanged;
            label.Text = name;
        }

        private void InitializeComponent()
        {
            this.label = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label
            // 
            this.label.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
            | System.Windows.Forms.AnchorStyles.Left)));
            this.label.AutoSize = true;
            this.label.Location = new System.Drawing.Point(3, 7);
            this.label.Margin = new System.Windows.Forms.Padding(3);
            this.label.Name = "label";
            this.label.Size = new System.Drawing.Size(35, 13);
            this.label.TabIndex = 0;
            this.label.Text = "Name";
            // 
            // BaseProperty
            // 
            this.Controls.Add(this.label);
            this.Name = "BaseProperty";
            this.Size = new System.Drawing.Size(180, 30);
            this.ResumeLayout(false);
            this.PerformLayout();

        }
    }
}
