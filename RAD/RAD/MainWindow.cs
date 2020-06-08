using Newtonsoft.Json;
using RAD.Elements;
using RAD.Serializer;
using System;
using System.Collections.Generic;
using System.IO;
using System.Windows.Forms;

namespace RAD
{
    public partial class MainWindow : Form, IRADElementSelectable, IRADElementDeleteable
    {
        protected PropertiesForm PropertiesForm { get; private set; } = null;
        protected ToolboxForm ToolboxForm { get; private set; } = null;
        protected IRADElement currentSelectedElement { get; private set; } = null;
        protected IRADElement currentFocusedElement { get; private set; } = null;
        protected List<IRADElement> RADElements { get; set; } = new List<IRADElement>();


        public MainWindow()
        {
            InitializeComponent();
        }

        private void MainWindow_Load(object sender, EventArgs e)
        {
            CenterToScreen();

            PropertiesForm = new PropertiesForm(this);
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
                Control control = currentSelectedElement.Control;

                Controls.Add(control);
                RADElements.Add(currentSelectedElement);

                control.Location = PointToClient(Cursor.Position);
                currentSelectedElement.SetOnClickEvent(OnClickRADElement);

                OnClickRADElement(currentSelectedElement);

                currentSelectedElement = null;
            }
        }

        private void OnClickRADElement(IRADElement radElement)
        {
            currentFocusedElement = radElement;
            PropertiesForm.SetProperties(radElement.Properties);
        }

        private void saveToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if(saveFileDialog.ShowDialog() == DialogResult.OK)
            {
                if (File.Exists(saveFileDialog.FileName))
                    File.Delete(saveFileDialog.FileName);

                ProjectSerializer projectSerializer = new ProjectSerializer();

                foreach(IRADElement radElement in RADElements)                
                    projectSerializer.radElements.Add(new RADElementSerializer(radElement.RADType, radElement.Serialize()));

                File.WriteAllText(saveFileDialog.FileName, JsonConvert.SerializeObject(projectSerializer));
            }
        }

        private void loadToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if(openFileDialog.ShowDialog() == DialogResult.OK)
            {
                Controls.Clear();
                Controls.Add(menuStrip);
                RADElements.Clear();
                PropertiesForm.SetProperties(null);
                currentSelectedElement = null;

                ProjectSerializer projectSerializer = JsonConvert.DeserializeObject<ProjectSerializer>(File.ReadAllText(openFileDialog.FileName));

                foreach (RADElementSerializer serializer in projectSerializer.radElements)
                {
                    IRADElement element = GetElement(serializer.radType);
                    Controls.Add(element.Control);
                    RADElements.Add(element);
                    element.Deserialize(serializer.jsonValue);

                    element.SetOnClickEvent(OnClickRADElement);
                }
            }
        }

        private void aboutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Michał Milczanowski\nIlona Kusztykiewicz", "RAD Projekt", MessageBoxButtons.OK);
        }

        protected IRADElement GetElement(RADElementType type)
        {
            switch (type)
            {
                case RADElementType.Button: return new RADButton();
                case RADElementType.Checkbox: return new RADCheckBox();
                case RADElementType.Image: return new RADImage();
                case RADElementType.Label: return new RADLabel();
                case RADElementType.TextEdit: return new RADTextEdit();
            }
            return null;
        }

        public void DeleteRADElement()
        {
            if(currentFocusedElement != null)
            {
                Controls.Remove(currentFocusedElement.Control);
                RADElements.Remove(currentFocusedElement);
                currentFocusedElement = null;
                PropertiesForm.SetProperties(null);
            }
        }
    }
}
