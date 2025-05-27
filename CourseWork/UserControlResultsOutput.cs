using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net.Http.Headers;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CourseWork
{
    public partial class UserControlResultsOutput : UserControl
    {
        private SLAE slae;
        private bool isFileForm = false;
        public UserControlResultsOutput()
        {
            InitializeComponent();
        }

        internal void SetResultsOutputUserControl(SLAE slae, SolvingMethod.SolvingMethods? method, int practicalDIfficulty)
        {
            this.slae = slae;
            RootsOutput();
            SLAEOutput();
            SolvingMethodOutput(method);
            PracticalDIfficultyOutput(practicalDIfficulty);
        }

        private void RootsOutput()
        {
            ResultsLabel.Text = "";
            for (int i = 0; i < slae.roots.Length; i++)
            {
                ResultsLabel.Text += $"x{i + 1} = " + slae.roots[i].Real.ToString("F6") + " + i " + slae.roots[i].Imaginary.ToString("F6") + "\n";
            }
        }

        private void ReturnToPrevPageButton_Click(object sender, EventArgs e)
        {
            var form = this.FindForm() as FormSolvingSLAE;
            if (form != null)
            {
                UserControlMatrixInput MatrixInputUserControl = form.UserControlMatrixInputInstance;

                this.Visible = false;
                MatrixInputUserControl.Visible = true;
            }
        }

        private void SLAEOutput()
        {
            InSLAELabel.Text = "";
            for (int i = 0; i < slae.Size; i++)
            {
                for (int j = 0; j < slae.Size; j++)
                {
                    InSLAELabel.Text += $"({slae.CoefficientMatrix[i, j].Real} + i * {slae.CoefficientMatrix[i, j].Imaginary}) * x{j + 1}";
                    if (j + 1 != slae.Size)
                    {
                        InSLAELabel.Text += " + ";
                    }
                    else
                    {
                        InSLAELabel.Text += " = ";
                    }
                }
                InSLAELabel.Text += $"{slae.FreeMembers[i].Real} + i * {slae.FreeMembers[i].Imaginary}\n";
            }
        }

        private void SolvingMethodOutput(SolvingMethod.SolvingMethods? method)
        {
            SollutionMethodLabel.Text = "Метод розв'язку: ";
            switch (method)
            {
                case SolvingMethod.SolvingMethods.GaussianMethod:
                    SollutionMethodLabel.Text += "Метод Гауса";
                    break;
                case SolvingMethod.SolvingMethods.SquareRootMethod:
                    SollutionMethodLabel.Text += "Метод Гауса-Холецького";
                    break;
            }
        }

        private void PracticalDIfficultyOutput(int practicalDifficulty)
        {
            PracticalDifficultyLabel.Text = $"Практична складність: {practicalDifficulty}";
        }

        private void InputToFileButton_Click(object sender, EventArgs e)
        {
            if (isFileForm == false)
            {
                isFileForm = true;
                FormFileSaving fileForm = new FormFileSaving(slae);
                fileForm.FormClosed += (s, args) => { isFileForm = false; };
                fileForm.Show();
            }
        }
    }
}
