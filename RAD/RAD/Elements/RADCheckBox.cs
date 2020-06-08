using Newtonsoft.Json;
using RAD.Elements.Serializer;
using RAD.PropertiesForms;
using System.Collections.Generic;

namespace RAD.Elements
{
    public partial class RADCheckBox : BaseRADControl
    {
        public override RADElementType RADType
        {
            get { return RADElementType.Checkbox; }
        }

        public override List<IProperty> Properties
        {
            get
            {
                List<IProperty> properties = base.Properties;
                properties.Add(GetLabelProperty());
                properties.Add(GetCheckboxProperty());

                return properties;
            }
        }

        public RADCheckBox()
        {
            InitializeComponent();
            checkBox.Click += new System.EventHandler(Control_Click);
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

        public override string Serialize()
        {
            return JsonConvert.SerializeObject(new CheckBoxSerializer(checkBox.Checked, checkBox.Text, Location.X, Location.Y, Width, Height));
        }

        public override void Deserialize(string value)
        {
            Deserialize(JsonConvert.DeserializeObject<CheckBoxSerializer>(value));
        }

        protected void Deserialize(CheckBoxSerializer serializer)
        {
            checkBox.Text = serializer.label;
            checkBox.Checked = serializer.isChecked;
            base.Deserialize(serializer);
        }
    }
}
