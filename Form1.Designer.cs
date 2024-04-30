namespace IMLab8
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            QuestionTextBox = new TextBox();
            SimpleAnswerButton = new Button();
            BallAnswerButton = new Button();
            SimpleAnswerLabel = new Label();
            BallAnswerLabel = new Label();
            SuspendLayout();
            // 
            // QuestionTextBox
            // 
            QuestionTextBox.Location = new Point(175, 52);
            QuestionTextBox.Name = "QuestionTextBox";
            QuestionTextBox.PlaceholderText = "Введите ваш вопрос";
            QuestionTextBox.Size = new Size(173, 23);
            QuestionTextBox.TabIndex = 0;
            // 
            // SimpleAnswerButton
            // 
            SimpleAnswerButton.Location = new Point(37, 122);
            SimpleAnswerButton.Name = "SimpleAnswerButton";
            SimpleAnswerButton.Size = new Size(170, 25);
            SimpleAnswerButton.TabIndex = 1;
            SimpleAnswerButton.Text = "Простой ответ";
            SimpleAnswerButton.UseVisualStyleBackColor = true;
            SimpleAnswerButton.Click += SimpleAnswerButton_Click;
            // 
            // BallAnswerButton
            // 
            BallAnswerButton.Location = new Point(307, 122);
            BallAnswerButton.Name = "BallAnswerButton";
            BallAnswerButton.Size = new Size(170, 25);
            BallAnswerButton.TabIndex = 2;
            BallAnswerButton.Text = "Ответ шара предсказаний";
            BallAnswerButton.UseVisualStyleBackColor = true;
            BallAnswerButton.Click += BallAnswerButton_Click;
            // 
            // SimpleAnswerLabel
            // 
            SimpleAnswerLabel.AutoSize = true;
            SimpleAnswerLabel.Location = new Point(109, 182);
            SimpleAnswerLabel.Name = "SimpleAnswerLabel";
            SimpleAnswerLabel.Size = new Size(0, 15);
            SimpleAnswerLabel.TabIndex = 3;
            SimpleAnswerLabel.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // BallAnswerLabel
            // 
            BallAnswerLabel.AutoSize = true;
            BallAnswerLabel.Location = new Point(307, 182);
            BallAnswerLabel.Name = "BallAnswerLabel";
            BallAnswerLabel.Size = new Size(0, 15);
            BallAnswerLabel.TabIndex = 4;
            BallAnswerLabel.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(527, 267);
            Controls.Add(BallAnswerLabel);
            Controls.Add(SimpleAnswerLabel);
            Controls.Add(BallAnswerButton);
            Controls.Add(SimpleAnswerButton);
            Controls.Add(QuestionTextBox);
            Name = "Form1";
            Text = "Lab8";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox QuestionTextBox;
        private Button SimpleAnswerButton;
        private Button BallAnswerButton;
        private Label SimpleAnswerLabel;
        private Label BallAnswerLabel;
    }
}
