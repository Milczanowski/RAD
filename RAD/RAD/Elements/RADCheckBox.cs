using RAD.PropertiesForms;
using System.Collections.Generic;

namespace RAD.Elements
{
    public partial class RADCheckBox : BaseRADControl
    {
        public override List<IProperty> GetProperties
        {
            get
            {
                List<IProperty> properties = base.GetProperties;
                properties.Add(GetLabelProperty());
                properties.Add(GetCheckboxProperty());

                return properties;
            }
        }

        public RADCheckBox()
        {
            InitializeComponent();
        }

        private IProperty GetLabelProperty()
        {
            return new TextProperty("Label", checkBox.Text, (text) =>
            {
                checkBox.Text = text;
            });
        }

        private IProperty GetCheckboxProperty()
        {
            return new CheckbocProperty("Is checked", checkBox.Checked, (isChecked) =>
            {
                checkBox.Checked = isChecked;
            });
        }
    }
}
