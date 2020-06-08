using Newtonsoft.Json;
using RAD.Elements.Serializer;
using System.Collections.Generic;

namespace RAD.Elements
{
    public partial class RADButton : BaseRADControl
    {
        public override RADElementType RADType { get { return RADElementType.Button; } }

        public override List<IProperty> Properties
        {
            get
            {
                List<IProperty> properties = base.Properties;
                properties.Add(GetLabelProperty(label, "Label"));

                return properties;
            }
        }

        public RADButton()
        {
            InitializeComponent();

            label.Click += new System.EventHandler(Control_Click);
        }

        public override string Serialize()
        {
            return JsonConvert.SerializeObject(new LabelSerializer(label.Text, Location.X, Location.Y, Width, Height));
        }

        public override void Deserialize(string value)
        {
            Deserialize(JsonConvert.DeserializeObject<LabelSerializer>(value));
        }

        protected void Deserialize(LabelSerializer serializer)
        {
            label.Text = serializer.label;
            base.Deserialize(serializer);
        }
    }
}
