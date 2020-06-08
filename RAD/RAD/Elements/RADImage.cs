using Newtonsoft.Json;
using RAD.Elements.Serializer;
using RAD.PropertiesForms;
using System.Collections.Generic;
using System.Drawing;

namespace RAD.Elements
{
    public partial class RADImage : BaseRADControl
    {
        public override RADElementType RADType { get { return RADElementType.Image; } }

        protected string Path { get; private set; }

        public override List<IProperty> Properties
        {
            get
            {
                List<IProperty> properties = base.Properties;
                properties.Add(GetPathProperty());

                return properties;
            }
        }

        public RADImage()
        {
            InitializeComponent();

            image.Click += new System.EventHandler(Control_Click);
        }

        private IProperty GetPathProperty()
        {
            return new PathProperty("Image", Path ,(path) =>
            {
                Path = path;
                image.Image = Image.FromFile(path);
            }, "Image Files(*.BMP;*.JPG;*.GIF)|*.BMP;*.JPG;*.GIF|All files (*.*)|*.*");
        }


        public override string Serialize()
        {
            return JsonConvert.SerializeObject(new LabelSerializer(Path, Location.X, Location.Y, Width, Height));
        }

        public override void Deserialize(string value)
        {
            Deserialize(JsonConvert.DeserializeObject<LabelSerializer>(value));
        }

        protected void Deserialize(LabelSerializer serializer)
        {
            Path = serializer.label;
            if(!string.IsNullOrEmpty(Path))
                image.Image = Image.FromFile(Path);

            base.Deserialize(serializer);
        }
    }
}
