using RAD.PropertiesForms;
using System.Collections.Generic;
using System.Drawing;

namespace RAD.Elements
{
    public partial class RADImage : BaseRADControl
    {
        protected string Path { get; private set; }

        public override List<IProperty> GetProperties
        {
            get
            {
                List<IProperty> properties = base.GetProperties;
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


    }
}
