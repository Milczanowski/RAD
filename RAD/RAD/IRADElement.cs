using System.Windows.Forms;

namespace RAD
{
    public interface IRADElement
    {
        Control GetControl { get; }
    }
}
