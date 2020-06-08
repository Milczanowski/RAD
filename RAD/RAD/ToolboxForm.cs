using RAD.Elements;
using System;
using System.Windows.Forms;

namespace RAD
{
    public partial class ToolboxForm : Form
    {
        protected IRADElementSelectable ElementSelectable { get; private set; }

        public ToolboxForm(IRADElementSelectable elementSelectable)
        {
            InitializeComponent();
            ElementSelectable = elementSelectable;

            ElementSelectable.SelectRADElement(new RADButton());
        }

        private void buttonButton_Click(object sender, EventArgs e)
        {
            ElementSelectable.SelectRADElement(new RADButton());
        }

        private void imageButton_Click(object sender, EventArgs e)
        {
            ElementSelectable.SelectRADElement(new RADImage());
        }

        private void labelButton_MouseClick(object sender, MouseEventArgs e)
        {
            ElementSelectable.SelectRADElement(new RADLabel());
        }

        private void textEditbutton_Click(object sender, EventArgs e)
        {
            ElementSelectable.SelectRADElement(new RADTextEdit());
        }

        private void checkBoxButton_Click(object sender, EventArgs e)
        {
            ElementSelectable.SelectRADElement(new RADCheckBox());
        }
    }
}
