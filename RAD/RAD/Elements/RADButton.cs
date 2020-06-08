using System.Collections.Generic;
using RAD.PropertiesForms;

namespace RAD.Elements
{
    public partial class RADButton : BaseRADControl
    {
        public override List<IProperty> GetProperties
        {
            get
            {
                List<IProperty> properties = base.GetProperties;
                properties.Add(GetLabelProperty());

                return properties;
            }
        }

        public RADButton()
        {
            InitializeComponent();

            label.Click += new System.EventHandler(Control_Click);
        }

        private IProperty GetLabelProperty()
        {
            return new TextProperty("Label", label.Text, (text) =>
            {
                label.Text = text;
            });
        }
    }
}
