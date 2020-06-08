using System;

namespace RAD.PropertiesForms
{
    public partial class NumberProperty : BaseProperty<int>
    {
        public NumberProperty()
        {
            InitializeComponent();
        }

        public NumberProperty(string name, int value, Action<int> onValueChanged):base(name, value, onValueChanged)
        {
            InitializeComponent();
            numericUpDown.Value = value;
            numericUpDown.ValueChanged += new System.EventHandler(this.numericUpDown_ValueChanged);
        }

        private void numericUpDown_ValueChanged(object sender, EventArgs e)
        {
            OnValueChanged.Invoke((int)numericUpDown.Value);
        }
    }
}
