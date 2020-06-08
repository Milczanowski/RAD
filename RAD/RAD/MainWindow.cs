using System;
using System.Windows.Forms;

namespace RAD
{
    public partial class MainWindow : Form, IRADElementSelectable
    {
        protected PropertiesForm PropertiesForm { get; private set; } = null;
        protected ToolboxForm ToolboxForm { get; private set; } = null;
        protected IRADElement currentSelectedElement { get; private set; } = null;


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


            ToolboxForm = new ToolboxForm(this);
            ToolboxForm.Show();
            ToolboxForm.SetDesktopLocation(Location.X - ToolboxForm.Width, Location.Y);

        }

        public void SelectRADElement(IRADElement radElement)
        {
            currentSelectedElement = radElement;
        }

        private void MainWindow_Click(object sender, EventArgs e)
        {
            if(currentSelectedElement!=null)
            {
                Control control = currentSelectedElement.GetControl;
                Controls.Add(control);
                control.Location = PointToClient(Cursor.Position);
                currentSelectedElement.SetOnClickEvent(OnClickRADElement);
                OnClickRADElement(currentSelectedElement);
                currentSelectedElement = null;
            }
        }

        private void OnClickRADElement(IRADElement radElement)
        {
            PropertiesForm.SetProperties(radElement.GetProperties);
        }
    }
}
