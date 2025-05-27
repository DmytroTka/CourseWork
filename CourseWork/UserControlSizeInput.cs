using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CourseWork
{
    public partial class UserControlSizeInput : UserControl
    {
        public UserControlSizeInput()
        {
            InitializeComponent();
        }

        private void sizeInputGroupBox_Enter(object sender, EventArgs e)
        {
            labelSizeMatrixInfo.Text = $"При заданні роміру використовуйте цілі числа в діапазоні від {SLAE.MIN_SLAE_SIZE} до {SLAE.MAX_SLAE_SIZE}.";
        }

        private void buttonSizeMatrix_Click(object sender, EventArgs e)
        {
            int size = 0;
            bool res = int.TryParse(SizeTextBox.Text, out size);

            if (!res)
            {
                errorLabel.Text = "Помилкове значення розміру, очікувалось ціле число.";
            }
            else if (!sizeValidation(size))
            {
                errorLabel.Text = $"Розмір СЛАР повинен бути в діапазоні від {SLAE.MIN_SLAE_SIZE} до {SLAE.MAX_SLAE_SIZE}.";
            }
            else
            {
                errorLabel.Text = "";
                moveToMatrixInputUC(size);
            }
        }

        private bool sizeValidation(int size)
        {
            if (size < SLAE.MIN_SLAE_SIZE || size > SLAE.MAX_SLAE_SIZE)
            {
                return false;
            }
            else
            {
                return true;
            }
        }

        private void moveToMatrixInputUC(int size)
        {
            var form = this.FindForm() as FormSolvingSLAE;
            if (form != null)
            {
                UserControlMatrixInput MatrixInputUserControl = form.UserControlMatrixInputInstance;

                MatrixInputUserControl.MatrixSize = size;
                MatrixInputUserControl.SetMatrixInputForm();
                this.Visible = false;
                MatrixInputUserControl.Visible = true;
                
            }
        }
    }
}
