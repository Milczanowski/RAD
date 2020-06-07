using System.Collections.Generic;
using System.Windows.Forms;

namespace RAD
{
    public partial class PropertiesForm : Form
    {
        public PropertiesForm()
        {
            InitializeComponent();
        }

        public void SetProperties(List<IProperty> properties)
        {
            Controls.Clear();

            int position = 0;

            foreach(IProperty property in properties)
            {
                Control control = property.GetControl;
                Controls.Add(control);
                control.Location = new System.Drawing.Point(0, position);
                position += control.Height;
            }
        }
    }
}
