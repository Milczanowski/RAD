using RAD.PropertiesForms;
using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace RAD.Elements
{
    public class BaseRADControl : UserControl, IRADElement
    {
        private Action<IRADElement> OnClickEventRADElement { get; set; } = delegate { };

        public virtual Control GetControl { get { return this; } }

        public List<IProperty> GetProperties
        {
            get
            {
                List<IProperty> properties = new List<IProperty>();
                properties.Add(GetPositionXProperty());
                properties.Add(GetPositionYProperty());

                return properties;
            }
        }

        public BaseRADControl()
        {
            this.Click += new System.EventHandler(Control_Click);
        }

        public void SetOnClickEvent(Action<IRADElement> onClickEventRADElement)
        {
            OnClickEventRADElement = onClickEventRADElement;
        }

        protected void Control_Click(object sender, EventArgs e)
        {
            OnClickEventRADElement.Invoke(this);
        }

        protected IProperty GetPositionXProperty()
        {
            return new NumberProperty("Position X", Location.X, (x) =>
            {
                Location = new System.Drawing.Point(x, Location.Y);
            });
        }

        protected IProperty GetPositionYProperty()
        {
            return new NumberProperty("Position Y", Location.Y, (y) =>
            {
                Location = new System.Drawing.Point(Location.X, y);
            });
        }
    }
}
