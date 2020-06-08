using System;
using System.IO;
using System.Windows.Forms;

namespace RAD.PropertiesForms
{
    public partial class PathProperty : BaseProperty<string>
    {
        public PathProperty()
        {
            InitializeComponent();
        }

        public PathProperty(string name, string value, Action<string> onValueChanged, string filters) : base(name, value, onValueChanged)
        {
            InitializeComponent();
            path.Text = Path.GetFileNameWithoutExtension(value);
            openFileDialog.Filter = filters;

        }

        private void button_Click(object sender, EventArgs e)
        {
            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                path.Text = Path.GetFileNameWithoutExtension(openFileDialog.FileName);
                OnValueChanged(openFileDialog.FileName);
            }
        }
    }
}
