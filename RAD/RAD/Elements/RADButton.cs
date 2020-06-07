using System.Windows.Forms;

namespace RAD.Elements
{
    public partial class RADButton : UserControl, IRADElement
    {
        public RADButton()
        {
            InitializeComponent();
        }

        public Control GetControl { get { return this; } }
    }
}
