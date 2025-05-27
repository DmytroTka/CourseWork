using System.Windows.Forms;

namespace CourseWork
{
    public partial class FormSolvingSLAE : Form
    {
        public FormSolvingSLAE()
        {
            InitializeComponent();
        }

        public UserControlSizeInput UserControlSizeInputInstance => userControlSizeInput1;
        public UserControlMatrixInput UserControlMatrixInputInstance => userControlMatrixInput1;

        public UserControlResultsOutput UserControlResultsOutputInstance => userControlResultsOutput1;

    }
}
