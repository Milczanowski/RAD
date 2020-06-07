namespace RAD.Elements
{
    public partial class RADImage : BaseRADControl
    {
        public RADImage()
        {
            InitializeComponent();
            image.Click += new System.EventHandler(Control_Click);
        }
    }
}
