using System.Collections.Generic;
using System.Windows.Forms;

namespace RAD
{
    public partial class PropertiesForm : Form
    {
        private IRADElementDeleteable ElementDeleteable { get; set; } = null;

        public PropertiesForm()
        {
            InitializeComponent();
        }

        public PropertiesForm(IRADElementDeleteable elementDeleteable)
        {
            ElementDeleteable = elementDeleteable;
            InitializeComponent();
        }

        public void SetProperties(List<IProperty> properties)
        {
            Controls.Clear();

            if (properties == null)
                return;

            Controls.Add(deleteButton);

            int position = 50;

            foreach(IProperty property in properties)
            {
                Control control = property.GetControl;
                Controls.Add(control);
                control.Location = new System.Drawing.Point(0, position);
                position += control.Height;
            }
        }

        private void deleteButton_Click(object sender, System.EventArgs e)
        {
            if(ElementDeleteable != null)
                ElementDeleteable.DeleteRADElement();
        }
    }
}
