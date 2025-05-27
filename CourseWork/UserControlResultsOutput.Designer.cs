namespace CourseWork
{
    partial class UserControlResultsOutput
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
            ResultsOutputGroupBox = new GroupBox();
            PracticalDifficultyLabel = new Label();
            SLAETitleLabel = new Label();
            InSLAEPanel = new Panel();
            InSLAELabel = new Label();
            InputToFileButton = new Button();
            SollutionMethodLabel = new Label();
            rootsPanel = new Panel();
            ResultsLabel = new Label();
            RootsLabel = new Label();
            RootResultsTitleLabel = new Label();
            ReturnToPrevPageButton = new Button();
            ResultsOutputGroupBox.SuspendLayout();
            InSLAEPanel.SuspendLayout();
            rootsPanel.SuspendLayout();
            SuspendLayout();
            // 
            // ResultsOutputGroupBox
            // 
            ResultsOutputGroupBox.Controls.Add(PracticalDifficultyLabel);
            ResultsOutputGroupBox.Controls.Add(SLAETitleLabel);
            ResultsOutputGroupBox.Controls.Add(InSLAEPanel);
            ResultsOutputGroupBox.Controls.Add(InputToFileButton);
            ResultsOutputGroupBox.Controls.Add(SollutionMethodLabel);
            ResultsOutputGroupBox.Controls.Add(rootsPanel);
            ResultsOutputGroupBox.Controls.Add(RootsLabel);
            ResultsOutputGroupBox.Controls.Add(RootResultsTitleLabel);
            ResultsOutputGroupBox.Controls.Add(ReturnToPrevPageButton);
            ResultsOutputGroupBox.Font = new Font("Segoe UI", 12F);
            ResultsOutputGroupBox.Location = new Point(3, 5);
            ResultsOutputGroupBox.Name = "ResultsOutputGroupBox";
            ResultsOutputGroupBox.Size = new Size(972, 598);
            ResultsOutputGroupBox.TabIndex = 1;
            ResultsOutputGroupBox.TabStop = false;
            ResultsOutputGroupBox.Text = "Результати Розв'язку";
            // 
            // PracticalDifficultyLabel
            // 
            PracticalDifficultyLabel.AutoSize = true;
            PracticalDifficultyLabel.Location = new Point(432, 212);
            PracticalDifficultyLabel.Name = "PracticalDifficultyLabel";
            PracticalDifficultyLabel.Size = new Size(220, 28);
            PracticalDifficultyLabel.TabIndex = 9;
            PracticalDifficultyLabel.Text = "Практична складність: ";
            // 
            // SLAETitleLabel
            // 
            SLAETitleLabel.AutoSize = true;
            SLAETitleLabel.Location = new Point(6, 427);
            SLAETitleLabel.Name = "SLAETitleLabel";
            SLAETitleLabel.Size = new Size(159, 28);
            SLAETitleLabel.TabIndex = 8;
            SLAETitleLabel.Text = "Вхідне рівняння";
            // 
            // InSLAEPanel
            // 
            InSLAEPanel.AutoScroll = true;
            InSLAEPanel.Controls.Add(InSLAELabel);
            InSLAEPanel.Location = new Point(6, 467);
            InSLAEPanel.Name = "InSLAEPanel";
            InSLAEPanel.Size = new Size(960, 125);
            InSLAEPanel.TabIndex = 7;
            // 
            // InSLAELabel
            // 
            InSLAELabel.AutoSize = true;
            InSLAELabel.Location = new Point(12, 18);
            InSLAELabel.Name = "InSLAELabel";
            InSLAELabel.Size = new Size(159, 28);
            InSLAELabel.TabIndex = 0;
            InSLAELabel.Text = "Вхідне рівняння";
            // 
            // InputToFileButton
            // 
            InputToFileButton.Location = new Point(432, 33);
            InputToFileButton.Name = "InputToFileButton";
            InputToFileButton.Size = new Size(250, 37);
            InputToFileButton.TabIndex = 6;
            InputToFileButton.Text = "Записати СЛАР у файл";
            InputToFileButton.UseVisualStyleBackColor = true;
            InputToFileButton.Click += InputToFileButton_Click;
            // 
            // SollutionMethodLabel
            // 
            SollutionMethodLabel.AutoSize = true;
            SollutionMethodLabel.Location = new Point(432, 165);
            SollutionMethodLabel.Name = "SollutionMethodLabel";
            SollutionMethodLabel.Size = new Size(168, 28);
            SollutionMethodLabel.TabIndex = 5;
            SollutionMethodLabel.Text = "Метод розв'язку:";
            // 
            // rootsPanel
            // 
            rootsPanel.AutoScroll = true;
            rootsPanel.BorderStyle = BorderStyle.FixedSingle;
            rootsPanel.Controls.Add(ResultsLabel);
            rootsPanel.Location = new Point(6, 165);
            rootsPanel.Name = "rootsPanel";
            rootsPanel.Size = new Size(385, 249);
            rootsPanel.TabIndex = 4;
            // 
            // ResultsLabel
            // 
            ResultsLabel.AutoSize = true;
            ResultsLabel.Location = new Point(12, 11);
            ResultsLabel.Name = "ResultsLabel";
            ResultsLabel.Size = new Size(112, 28);
            ResultsLabel.TabIndex = 5;
            ResultsLabel.Text = "результати";
            // 
            // RootsLabel
            // 
            RootsLabel.AutoSize = true;
            RootsLabel.Location = new Point(6, 134);
            RootsLabel.Name = "RootsLabel";
            RootsLabel.Size = new Size(158, 28);
            RootsLabel.TabIndex = 3;
            RootsLabel.Text = "Корені системи:";
            // 
            // RootResultsTitleLabel
            // 
            RootResultsTitleLabel.AutoSize = true;
            RootResultsTitleLabel.Location = new Point(6, 85);
            RootResultsTitleLabel.Name = "RootResultsTitleLabel";
            RootResultsTitleLabel.Size = new Size(283, 28);
            RootResultsTitleLabel.TabIndex = 2;
            RootResultsTitleLabel.Text = "Результати розв'язку системи";
            // 
            // ReturnToPrevPageButton
            // 
            ReturnToPrevPageButton.Location = new Point(6, 33);
            ReturnToPrevPageButton.Name = "ReturnToPrevPageButton";
            ReturnToPrevPageButton.Size = new Size(385, 37);
            ReturnToPrevPageButton.TabIndex = 1;
            ReturnToPrevPageButton.Text = "Повернутись до задання СЛАР";
            ReturnToPrevPageButton.UseVisualStyleBackColor = true;
            ReturnToPrevPageButton.Click += ReturnToPrevPageButton_Click;
            // 
            // UserControlResultsOutput
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(ResultsOutputGroupBox);
            Name = "UserControlResultsOutput";
            Size = new Size(978, 609);
            ResultsOutputGroupBox.ResumeLayout(false);
            ResultsOutputGroupBox.PerformLayout();
            InSLAEPanel.ResumeLayout(false);
            InSLAEPanel.PerformLayout();
            rootsPanel.ResumeLayout(false);
            rootsPanel.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private GroupBox ResultsOutputGroupBox;
        private Button ReturnToPrevPageButton;
        private Label SollutionMethodLabel;
        private Panel rootsPanel;
        private Label ResultsLabel;
        private Label RootsLabel;
        private Label RootResultsTitleLabel;
        private Label SLAETitleLabel;
        private Panel InSLAEPanel;
        private Button InputToFileButton;
        private Label InSLAELabel;
        private Label PracticalDifficultyLabel;
    }
}
