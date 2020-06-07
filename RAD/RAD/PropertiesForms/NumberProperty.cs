using RAD.Elements;
using System;
using System.Windows.Forms;

namespace RAD.PropertiesForms
{
    public partial class NumberProperty : UserControl, IProperty
    {
        protected Action<int> OnValueChanged { get; private set; } = delegate { };

        public Control GetControl { get { return this; } }

        public NumberProperty()
        {
            InitializeComponent();
        }

        public NumberProperty(string name, int value, Action<int> onValueChanged)
        {
            InitializeComponent();
            label.Text = name;
            numericUpDown.Value = value;
            OnValueChanged = onValueChanged;
        }

        private void numericUpDown_ValueChanged(object sender, EventArgs e)
        {
            OnValueChanged.Invoke((int)numericUpDown.Value);
        }
    }
}
