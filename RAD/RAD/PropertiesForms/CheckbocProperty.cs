using System;

namespace RAD.PropertiesForms
{
    public partial class CheckbocProperty : BaseProperty<bool>
    {

        public CheckbocProperty()
        {
            InitializeComponent();
        }

        public CheckbocProperty(string name, bool value, Action<bool> onValueChanged) : base(name, value, onValueChanged)
        {
            InitializeComponent();
            checkBox.Checked = value;
            checkBox.CheckedChanged += new EventHandler(checkBox_CheckedChanged);

        }

        private void checkBox_CheckedChanged(object sender, EventArgs e)
        {
            OnValueChanged(checkBox.Checked);
        }
    }
}
