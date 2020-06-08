using RAD.PropertiesForms;
using System.Collections.Generic;

namespace RAD.Elements
{
    public partial class RADTextEdit : BaseRADControl
    {
        public override List<IProperty> GetProperties
        {
            get
            {
                List<IProperty> properties = base.GetProperties;
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
    }
}
