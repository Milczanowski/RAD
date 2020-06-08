using System;

namespace RAD.PropertiesForms
{
    public partial class TextProperty : BaseProperty<String>
    { 
        public TextProperty()
        {
            InitializeComponent();
        }

        public TextProperty(string name, string value, Action<string> onValueChanged) : base(name, value, onValueChanged)
        {
            InitializeComponent();
            textBox.Text = value;
            textBox.TextChanged += new EventHandler(textBox_TextChanged);
        }

        private void textBox_TextChanged(object sender, EventArgs e)
        {
            OnValueChanged(textBox.Text);
        }
    }
}
