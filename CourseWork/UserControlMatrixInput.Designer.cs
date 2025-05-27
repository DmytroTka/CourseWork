namespace CourseWork
{
    partial class UserControlMatrixInput
    {
        /// <summary> 
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором компонентов

        /// <summary> 
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            MatrixInputGroupBox = new GroupBox();
            inputRulesLabel = new Label();
            errorLabel = new Label();
            CalculateButton = new Button();
            SLAEInputTitleLabel = new Label();
            SLAEpanel = new Panel();
            MethodsGroupBox = new GroupBox();
            SquareRootMethodRadioButton = new RadioButton();
            GaussianMethodRadioButton = new RadioButton();
            SLAESizeLabel = new Label();
            ReturnToPrevPageButton = new Button();
            MatrixInputGroupBox.SuspendLayout();
            MethodsGroupBox.SuspendLayout();
            SuspendLayout();
            // 
            // MatrixInputGroupBox
            // 
            MatrixInputGroupBox.Controls.Add(inputRulesLabel);
            MatrixInputGroupBox.Controls.Add(errorLabel);
            MatrixInputGroupBox.Controls.Add(CalculateButton);
            MatrixInputGroupBox.Controls.Add(SLAEInputTitleLabel);
            MatrixInputGroupBox.Controls.Add(SLAEpanel);
            MatrixInputGroupBox.Controls.Add(MethodsGroupBox);
            MatrixInputGroupBox.Controls.Add(SLAESizeLabel);
            MatrixInputGroupBox.Controls.Add(ReturnToPrevPageButton);
            MatrixInputGroupBox.Font = new Font("Segoe UI", 12F);
            MatrixInputGroupBox.Location = new Point(3, 8);
            MatrixInputGroupBox.Name = "MatrixInputGroupBox";
            MatrixInputGroupBox.Size = new Size(972, 598);
            MatrixInputGroupBox.TabIndex = 0;
            MatrixInputGroupBox.TabStop = false;
            MatrixInputGroupBox.Text = "Задання системи рівнянь та обрання методу розв'зку";
            // 
            // inputRulesLabel
            // 
            inputRulesLabel.AutoSize = true;
            inputRulesLabel.Font = new Font("Segoe UI", 12F);
            inputRulesLabel.Location = new Point(571, 79);
            inputRulesLabel.MaximumSize = new Size(300, 0);
            inputRulesLabel.Name = "inputRulesLabel";
            inputRulesLabel.Size = new Size(189, 56);
            inputRulesLabel.TabIndex = 7;
            inputRulesLabel.Text = "Правила введення коефіцієнтів:";
            // 
            // errorLabel
            // 
            errorLabel.AutoSize = true;
            errorLabel.ForeColor = Color.Tomato;
            errorLabel.Location = new Point(161, 525);
            errorLabel.MaximumSize = new Size(790, 0);
            errorLabel.Name = "errorLabel";
            errorLabel.Size = new Size(0, 28);
            errorLabel.TabIndex = 6;
            // 
            // CalculateButton
            // 
            CalculateButton.Location = new Point(6, 525);
            CalculateButton.Name = "CalculateButton";
            CalculateButton.Size = new Size(135, 45);
            CalculateButton.TabIndex = 5;
            CalculateButton.Text = "Обрахувати";
            CalculateButton.UseVisualStyleBackColor = true;
            CalculateButton.Click += CalculateButton_Click;
            // 
            // SLAEInputTitleLabel
            // 
            SLAEInputTitleLabel.AutoSize = true;
            SLAEInputTitleLabel.Location = new Point(19, 299);
            SLAEInputTitleLabel.Name = "SLAEInputTitleLabel";
            SLAEInputTitleLabel.Size = new Size(491, 28);
            SLAEInputTitleLabel.TabIndex = 4;
            SLAEInputTitleLabel.Text = "Введіть коефіцієнти та вільні члени системи рівнянь";
            // 
            // SLAEpanel
            // 
            SLAEpanel.AutoScroll = true;
            SLAEpanel.Location = new Point(6, 330);
            SLAEpanel.Name = "SLAEpanel";
            SLAEpanel.Size = new Size(960, 177);
            SLAEpanel.TabIndex = 3;
            // 
            // MethodsGroupBox
            // 
            MethodsGroupBox.Controls.Add(SquareRootMethodRadioButton);
            MethodsGroupBox.Controls.Add(GaussianMethodRadioButton);
            MethodsGroupBox.Location = new Point(6, 148);
            MethodsGroupBox.Name = "MethodsGroupBox";
            MethodsGroupBox.Size = new Size(480, 129);
            MethodsGroupBox.TabIndex = 2;
            MethodsGroupBox.TabStop = false;
            MethodsGroupBox.Text = "Оберіть метод розв'язку СЛАР";
            // 
            // SquareRootMethodRadioButton
            // 
            SquareRootMethodRadioButton.AutoSize = true;
            SquareRootMethodRadioButton.Location = new Point(13, 80);
            SquareRootMethodRadioButton.Name = "SquareRootMethodRadioButton";
            SquareRootMethodRadioButton.Size = new Size(466, 32);
            SquareRootMethodRadioButton.TabIndex = 3;
            SquareRootMethodRadioButton.TabStop = true;
            SquareRootMethodRadioButton.Text = "Метод Гауса-Холецького (квадратного кореня)";
            SquareRootMethodRadioButton.UseVisualStyleBackColor = true;
            // 
            // GaussianMethodRadioButton
            // 
            GaussianMethodRadioButton.AutoSize = true;
            GaussianMethodRadioButton.Location = new Point(13, 42);
            GaussianMethodRadioButton.Name = "GaussianMethodRadioButton";
            GaussianMethodRadioButton.Size = new Size(145, 32);
            GaussianMethodRadioButton.TabIndex = 3;
            GaussianMethodRadioButton.TabStop = true;
            GaussianMethodRadioButton.Text = "Метод Гауса";
            GaussianMethodRadioButton.UseVisualStyleBackColor = true;
            // 
            // SLAESizeLabel
            // 
            SLAESizeLabel.AutoSize = true;
            SLAESizeLabel.Location = new Point(6, 101);
            SLAESizeLabel.Name = "SLAESizeLabel";
            SLAESizeLabel.Size = new Size(162, 28);
            SLAESizeLabel.TabIndex = 1;
            SLAESizeLabel.Text = "Розмір СЛАР: ___";
            // 
            // ReturnToPrevPageButton
            // 
            ReturnToPrevPageButton.Location = new Point(6, 47);
            ReturnToPrevPageButton.Name = "ReturnToPrevPageButton";
            ReturnToPrevPageButton.Size = new Size(385, 37);
            ReturnToPrevPageButton.TabIndex = 0;
            ReturnToPrevPageButton.Text = "Повернутись до задання розміру СЛАР";
            ReturnToPrevPageButton.UseVisualStyleBackColor = true;
            ReturnToPrevPageButton.Click += ReturnToPrevPageButton_Click;
            // 
            // UserControlMatrixInput
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(MatrixInputGroupBox);
            Name = "UserControlMatrixInput";
            Size = new Size(978, 609);
            MatrixInputGroupBox.ResumeLayout(false);
            MatrixInputGroupBox.PerformLayout();
            MethodsGroupBox.ResumeLayout(false);
            MethodsGroupBox.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private GroupBox MatrixInputGroupBox;
        private Button ReturnToPrevPageButton;
        private Label SLAESizeLabel;
        private GroupBox MethodsGroupBox;
        private RadioButton SquareRootMethodRadioButton;
        private RadioButton GaussianMethodRadioButton;
        private Label SLAEInputTitleLabel;
        private Panel SLAEpanel;
        private Button CalculateButton;
        private Label errorLabel;
        private Label inputRulesLabel;
    }
}
