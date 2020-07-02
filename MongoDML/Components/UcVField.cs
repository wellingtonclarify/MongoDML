using System.Windows.Forms;

namespace MongoDML.Components
{
    public partial class UcVField : UserControl
    {
        public string LabelText
        {
            get { return xLabel1.Text; }
            set { xLabel1.Text = value; }
        }
        public string FieldContent
        {
            get { return xTextBox1.Text; }
            set { xTextBox1.Text = value; }
        }

        public UcVField()
        {
            InitializeComponent();
        }
    }
}
