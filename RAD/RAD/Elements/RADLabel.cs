using Newtonsoft.Json;
using RAD.Elements.Serializer;
using RAD.PropertiesForms;
using System.Collections.Generic;

namespace RAD.Elements
{
    public partial class RADLabel : BaseRADControl
    {
        public override RADElementType RADType
        {
            get
            {
                return RADElementType.Label;
            }
        }

        public override List<IProperty> Properties
        {
            get
            {
                List<IProperty> properties = base.Properties;
                properties.Add(GetLabelProperty(label,"Label"));
                properties.Add(GetFontSiezeProperty());

                return properties;
            }
        }

        public RADLabel()
        {
            InitializeComponent();
            label.Click += new System.EventHandler(Control_Click);
        }


        private IProperty GetFontSiezeProperty()
        {
            return new NumberProperty("Font size", (int)label.Font.Size, (size) =>
            {
                label.Font = new System.Drawing.Font(label.Font.Name, size, label.Font.Style);
            });
        }

        public override string Serialize()
        {
            return JsonConvert.SerializeObject(new LabelSerializer(label.Text, (int)label.Font.Size, Location.X, Location.Y, Width, Height));
        }

        public override void Deserialize(string value)
        {
            Deserialize(JsonConvert.DeserializeObject<LabelSerializer>(value));
        }

        protected void Deserialize(LabelSerializer serializer)
        {
            label.Text = serializer.label;
            label.Font = new System.Drawing.Font(label.Font.Name, serializer.fontSize, label.Font.Style);
            base.Deserialize(serializer);
        }
    }
}
