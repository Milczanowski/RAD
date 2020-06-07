using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RAD
{
    public partial class MainWindow : Form
    {
        protected PropertiesForm PropertiesForm { get; private set; }
        protected ToolboxForm ToolboxForm { get; private set; }


        public MainWindow()
        {
            InitializeComponent();
        }

        private void MainWindow_Load(object sender, EventArgs e)
        {
            CenterToScreen();

            PropertiesForm = new PropertiesForm();
            PropertiesForm.Show();
            PropertiesForm.SetDesktopLocation(Location.X + Width, Location.Y);


            ToolboxForm = new ToolboxForm();
            ToolboxForm.Show();
            ToolboxForm.SetDesktopLocation(Location.X - ToolboxForm.Width, Location.Y);

        }
    }
}
