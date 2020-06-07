using RAD.Elements;
using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace RAD
{
    public interface IRADElement
    {
        Control GetControl { get; }

        List<IProperty> GetProperties { get; }

        void SetOnClickEvent(Action<IRADElement> onClickEventRADElement);
    }
}
