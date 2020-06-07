using System.Windows.Forms;

namespace RAD.Elements
{
    public partial class RADButton : BaseRADControl
    {
        public RADButton()
        {
            InitializeComponent();

            label.Click += new System.EventHandler(Control_Click);
        }
    }
}
