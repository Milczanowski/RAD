using System.Windows.Forms;

namespace RAD.Elements
{
    public partial class RADImage : UserControl, IRADElement
    {
        public RADImage()
        {
            InitializeComponent();
        }

        public Control GetControl { get { return this; } }
    }
}
