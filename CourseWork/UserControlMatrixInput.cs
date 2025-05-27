using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Numerics;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CourseWork
{
    public partial class UserControlMatrixInput : UserControl
    {
        public UserControlMatrixInput()
        {
            InitializeComponent();
        }

        private int matrixSize = 0;

        public int MatrixSize
        {
            get { return matrixSize; }
            set { matrixSize = value; }
        }

        public void SetMatrixInputForm()
        {
            ShowInputRules();
            ChangeSizeLabel();
            RemoveOldElementsFromMatrixInputBlock();
            MakeMatrixInputBlock();
        }

        private void ShowInputRules()
        {
            inputRulesLabel.Text = $"Праила введення коефіцієнтів:\n" +
                $"1. Використовуйте дійсні числа при заданні дійсної та комплексної частин;\n" +
                $"2. Дозволяється вводити значення від {SLAE.MIN_VALUE} до {SLAE.MAX_VALUE}; \n" +
                $"3. Не вводьте занадто наближені до 0 значення.";
        }

        private void ChangeSizeLabel()
        {
            this.SLAESizeLabel.Text = $"Розмір СЛАР: {matrixSize}";
        }

        private void RemoveOldElementsFromMatrixInputBlock()
        {
            if (SLAEpanel.Controls.Count > 0)
            {
                SLAEpanel.Controls.Clear();
            }
        }

        public void MakeMatrixInputBlock()
        {
            int previous_position_y = 0;
            const int SLAEMarginLeft = 13;
            const int marginBetweenSLAEs = 12;
            const int SLAEBlockHeight = 60;

            const int SLAEelementWidth = 260;
            const int marginBetweenSLAEElements = 0;
            const int SLAEElementHeight = 50;

            const int TextBoxWidth = 63;

            for (int i = 0; i < matrixSize; i++) // Генерація рядків матриці 
            {
                Panel SLAEEquition = new Panel();
                SLAEEquition.Height = SLAEBlockHeight;
                SLAEEquition.Width = (SLAEelementWidth + marginBetweenSLAEElements) * (matrixSize + 1);
                SLAEEquition.Location = new Point(SLAEMarginLeft, previous_position_y);
                previous_position_y += SLAEBlockHeight + marginBetweenSLAEs;


                for (int j = 0; j < matrixSize + 1; j++) // Генерація коефіцієнту - textbox та невідомого 
                {
                    Panel SLAEElement = new Panel();
                    SLAEElement.Height = SLAEElementHeight;
                    SLAEElement.Width = SLAEelementWidth;
                    SLAEElement.Location = new Point(j * SLAEelementWidth, 5);

                    Label leftBracket = new Label();
                    leftBracket.Text = "(";
                    leftBracket.Font = new Font("Segoe UI", 12);
                    leftBracket.Width = 15;
                    leftBracket.Height = 28;
                    leftBracket.Location = new Point(5, 15);
                    SLAEElement.Controls.Add(leftBracket);

                    TextBox realPartTextBox = new TextBox();
                    realPartTextBox.Width = TextBoxWidth;
                    realPartTextBox.Location = new Point(23, 12);
                    SLAEElement.Controls.Add(realPartTextBox);

                    Label plusLabel = new Label();
                    plusLabel.Text = "+ i";
                    plusLabel.Font = new Font("Segoe UI", 12);
                    plusLabel.Width = 36;
                    plusLabel.Height = 28;
                    plusLabel.Location = new Point(91, 15);
                    SLAEElement.Controls.Add(plusLabel);

                    TextBox imaginaryPartTextBox = new TextBox();
                    imaginaryPartTextBox.Width = TextBoxWidth;
                    imaginaryPartTextBox.Location = new Point(126, 12);
                    SLAEElement.Controls.Add(imaginaryPartTextBox);

                    if (j != matrixSize)
                    {
                        Label unknownMemberLabel = new Label();
                        if (j + 1 != matrixSize)
                        {
                            unknownMemberLabel.Text = $") x{j + 1} + ";
                        }
                        else
                        {
                            unknownMemberLabel.Text = $") x{j + 1} = ";
                        }
                        unknownMemberLabel.Font = new Font("Segoe UI", 12);
                        unknownMemberLabel.Width = 98;
                        unknownMemberLabel.Height = 28;
                        unknownMemberLabel.Location = new Point(189, 15);
                        SLAEElement.Controls.Add(unknownMemberLabel);
                    }
                    else
                    {
                        Label rightBracket = new Label();
                        rightBracket.Width = 18;
                        rightBracket.Height = 28;
                        rightBracket.Text = ")";
                        rightBracket.Location = new Point(189, 15);
                        SLAEElement.Controls.Add(rightBracket);
                    }

                    SLAEEquition.Controls.Add(SLAEElement);
                }
                this.SLAEpanel.Controls.Add(SLAEEquition);

            }
        }

        private void ReturnToPrevPageButton_Click(object sender, EventArgs e)
        {
            var form = this.FindForm() as FormSolvingSLAE;
            if (form != null)
            {
                UserControlSizeInput SizeInputUserControl = form.UserControlSizeInputInstance;

                this.Visible = false;
                SizeInputUserControl.Visible = true;
            }
        }

        private void CalculateButton_Click(object sender, EventArgs e)
        {
            bool isError = false;
            SolvingMethod.SolvingMethods? solving_method = null;
            string errorMessage = "";
            if (!GetAndValidateSolvingMethods(ref solving_method, ref errorMessage))
            {
                isError = true;
            }
            else if (!ValidateCoefficients(ref errorMessage))
            {
                isError = true;
            }
            else if (!ValidateFreeMembers(ref errorMessage))
            {
                isError = true;
            }

            if (isError)
            {
                errorLabel.Text = errorMessage;
            }
            else
            {
                errorLabel.Text = "";
                Complex[,] coefficientMatrix = MakeCoefficientsMatrix();
                Complex[] freeMembersMatrix = MakeFreeMembersMatrix();

                SLAE slae = new SLAE(coefficientMatrix, freeMembersMatrix);
                Complex[] roots = null;

                if (!slae.IsSingular())
                {
                    errorLabel.Text = "Система не має єдиного розв'язку.";
                    isError = true;
                }
                else
                {
                    int practicalDifficulty = 0;
                    if (solving_method == SolvingMethod.SolvingMethods.GaussianMethod)
                    {
                        if (GaussianMethod.CheckMethodConditions(slae, ref errorMessage))
                        {
                            roots = GaussianMethod.CalculateSLAE(slae, ref practicalDifficulty);
                            slae.roots = roots;
                        }
                        else
                        {
                            errorLabel.Text = errorMessage;
                        }
                    }
                    else
                    {
                        if (SquareRootMethod.CheckMethodConditions(slae, ref errorMessage))
                        {
                            roots = SquareRootMethod.CalculateSLAE(slae, ref practicalDifficulty);
                            slae.roots = roots;
                        }
                        else
                        {
                            errorLabel.Text = errorMessage;
                        }

                    }
                    var form = this.FindForm() as FormSolvingSLAE;
                    if (form != null && roots != null)
                    {
                        UserControlResultsOutput ResultsOutputUserControl = form.UserControlResultsOutputInstance;

                        this.Visible = false;
                        ResultsOutputUserControl.Visible = true;


                        ResultsOutputUserControl.SetResultsOutputUserControl(slae, solving_method, practicalDifficulty);
                    }
                }

            }
        }

        private bool GetAndValidateSolvingMethods(ref SolvingMethod.SolvingMethods? method, ref string errorMessage)
        {

            if (!GaussianMethodRadioButton.Checked && !SquareRootMethodRadioButton.Checked)
            {
                errorMessage = "Не обрано метод розв'язку.";
                return false;
            }
            else
            {
                if (GaussianMethodRadioButton.Checked)
                {
                    method = SolvingMethod.SolvingMethods.GaussianMethod;
                }
                else
                {
                    method = SolvingMethod.SolvingMethods.SquareRootMethod;
                }
                return true;
            }
        }

        private bool ValidateCoefficients(ref string errorMessage)
        {
            for (int i = 0; i < this.SLAEpanel.Controls.Count; i++)
            {
                Panel equitionPanel = (Panel)this.SLAEpanel.Controls[i];
                for (int j = 0; j < equitionPanel.Controls.Count - 1; j++)
                {
                    Panel equitionElement = (Panel)equitionPanel.Controls[j];
                    TextBox realPartTextBox = (TextBox)equitionElement.Controls[1];
                    TextBox imaginPartTextBox = (TextBox)equitionElement.Controls[3];
                    try
                    {
                        double realPart = Convert.ToDouble(realPartTextBox.Text);
                        double imaginPart = Convert.ToDouble(imaginPartTextBox.Text);
                        string validationError = "";
                        if (!ValidateComplexNumber(new Complex(realPart, imaginPart), ref validationError))
                        {
                            errorMessage = $"Помилка у коефіцієнті ({i + 1}, {j + 1}). " + validationError;
                            return false;
                        }
                    }
                    catch (FormatException)
                    {
                        errorMessage = $"Помилка у коефіцієнті ({i + 1}, {j + 1}). Очікувався ввід чисельного значення.";
                        return false;
                    }
                }
            }
            return true;
        }

        private bool ValidateComplexNumber(Complex number, ref string validationError)
        {
            if (number.Real < SLAE.MIN_VALUE || number.Real > SLAE.MAX_VALUE)
            {
                validationError = $"Значення дійсної частини повинно бути в діапазоні від {SLAE.MIN_VALUE} до {SLAE.MAX_VALUE}";
                return false;
            }
            else if (number.Imaginary < SLAE.MIN_VALUE || number.Imaginary > SLAE.MAX_VALUE)
            {
                validationError = $"Значення уявної частини повинно бути в діапазоні від {SLAE.MIN_VALUE} до {SLAE.MAX_VALUE}";
                return false;
            }
            else if (Math.Abs(number.Real) > 0 && Math.Abs(number.Real) < 1e-6)
            {
                validationError = $"Дійсна частина має занадто наближене до нуля значення. Введіть таке значення, щоб його модуль був більше 1e-6, або введіть 0.";
                return false;
            }
            else if (Math.Abs(number.Imaginary) > 0 && Math.Abs(number.Imaginary) < 1e-6)
            {
                validationError = $"Дійсна частина має занадто наближене до нуля значення.";
                return false;
            }
            else
            {
                return true;
            }
        }

        private bool ValidateFreeMembers(ref string errorMessage)
        {
            for (int i = 0; i < this.SLAEpanel.Controls.Count; i++)
            {
                Panel equitionPanel = (Panel)this.SLAEpanel.Controls[i];
                Panel freeMemberPanel = (Panel)equitionPanel.Controls[matrixSize];

                TextBox realPartTextBox = (TextBox)freeMemberPanel.Controls[1];
                TextBox imaginPartTextBox = (TextBox)freeMemberPanel.Controls[3];

                try
                {
                    double realPart = Convert.ToDouble(realPartTextBox.Text);
                    double imaginPart = Convert.ToDouble(imaginPartTextBox.Text);
                    string validationError = "";
                    if (!ValidateComplexNumber(new Complex(realPart, imaginPart), ref validationError))
                    {
                        errorMessage = $"Помилка у вільному члені {i + 1}-го рівняння. " + validationError;
                        return false;
                    }
                }
                catch (FormatException)
                {
                    errorMessage = $"Помилка у вільному члені {i + 1}-го рівняння. Очікувався ввід чисельного значення.";
                    return false;
                }
            }
            return true;
        }

        private Complex[,] MakeCoefficientsMatrix()
        {
            Complex[,] cofficientsMatrix = new Complex[matrixSize, matrixSize];
            for (int i = 0; i < this.SLAEpanel.Controls.Count; i++)
            {
                Panel equitionPanel = (Panel)this.SLAEpanel.Controls[i];
                for (int j = 0; j < equitionPanel.Controls.Count - 1; j++)
                {
                    Panel equitionElement = (Panel)equitionPanel.Controls[j];
                    TextBox realPartTextBox = (TextBox)equitionElement.Controls[1];
                    TextBox imaginPartTextBox = (TextBox)equitionElement.Controls[3];

                    double realPart = Convert.ToDouble(realPartTextBox.Text);
                    double imaginPart = Convert.ToDouble(imaginPartTextBox.Text);
                    cofficientsMatrix[i, j] = new Complex(realPart, imaginPart);
                }
            }
            return cofficientsMatrix;
        }

        private Complex[] MakeFreeMembersMatrix()
        {
            Complex[] freeMembersMatrix = new Complex[matrixSize];
            for (int i = 0; i < this.SLAEpanel.Controls.Count; i++)
            {
                Panel equitionPanel = (Panel)this.SLAEpanel.Controls[i];
                Panel freeMemberPanel = (Panel)equitionPanel.Controls[matrixSize];

                TextBox realPartTextBox = (TextBox)freeMemberPanel.Controls[1];
                TextBox imaginPartTextBox = (TextBox)freeMemberPanel.Controls[3];

                double realPart = Convert.ToDouble(realPartTextBox.Text);
                double imaginPart = Convert.ToDouble(imaginPartTextBox.Text);

                freeMembersMatrix[i] = new Complex(realPart, imaginPart);
            }
            return freeMembersMatrix;
        }
    }
}
