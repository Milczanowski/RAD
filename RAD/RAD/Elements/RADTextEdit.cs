using Newtonsoft.Json;
using RAD.Elements.Serializer;
using RAD.PropertiesForms;
using System.Collections.Generic;

namespace RAD.Elements
{
    public partial class RADTextEdit : BaseRADControl
    {
        public override RADElementType RADType
        {
            get
            {
                return RADElementType.TextEdit;
            }
        }

        public override List<IProperty> Properties
        {
            get
            {
                List<IProperty> properties = base.Properties;
                properties.Add(GetTextProperty());

                return properties;
            }
        }

        public RADTextEdit()
        {
            InitializeComponent();
            textBox.Click += new System.EventHandler(Control_Click);
        }

        private IProperty GetTextProperty()
        {
            return new TextProperty("Text", textBox.Text, (text) =>
            {
                textBox.Text = text;
            });
        }

        public override string Serialize()
        {
            return JsonConvert.SerializeObject(new LabelSerializer(textBox.Text, Location.X, Location.Y, Width, Height));
        }

        public override void Deserialize(string value)
        {
            Deserialize(JsonConvert.DeserializeObject<LabelSerializer>(value));
        }

        protected void Deserialize(LabelSerializer serializer)
        {
            textBox.Text = serializer.label;
            base.Deserialize(serializer);
        }
    }
}
