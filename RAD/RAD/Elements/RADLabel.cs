using RAD.PropertiesForms;
using System.Collections.Generic;

namespace RAD.Elements
{
    public partial class RADLabel : BaseRADControl
    {
        public override List<IProperty> GetProperties
        {
            get
            {
                List<IProperty> properties = base.GetProperties;
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
    }
}
