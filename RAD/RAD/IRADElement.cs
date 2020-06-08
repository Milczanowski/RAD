using RAD.Elements;
using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace RAD
{
    public interface IRADElement
    {
        Control Control { get; }
        List<IProperty> Properties { get; }

        void SetOnClickEvent(Action<IRADElement> onClickEventRADElement);

        string Serialize();
        void Deserialize(string value);
        RADElementType RADType { get; }
    }
}
