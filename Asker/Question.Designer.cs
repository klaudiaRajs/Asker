namespace Asker
{
    partial class Question
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.questionBox = new System.Windows.Forms.TextBox();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.checkAnswerButton = new System.Windows.Forms.Button();
            this.lackOfAnswerButton = new System.Windows.Forms.Button();
            this.userAnswer = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // questionBox
            // 
            this.questionBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.questionBox.Location = new System.Drawing.Point(44, 12);
            this.questionBox.Name = "questionBox";
            this.questionBox.Size = new System.Drawing.Size(308, 20);
            this.questionBox.TabIndex = 9;
            this.questionBox.TabStop = false;
            this.questionBox.Text = "Sample question";
            this.questionBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(61, 4);
            // 
            // checkAnswerButton
            // 
            this.checkAnswerButton.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.checkAnswerButton.FlatAppearance.BorderColor = System.Drawing.Color.WhiteSmoke;
            this.checkAnswerButton.FlatAppearance.BorderSize = 0;
            this.checkAnswerButton.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.checkAnswerButton.Location = new System.Drawing.Point(84, 137);
            this.checkAnswerButton.Name = "checkAnswerButton";
            this.checkAnswerButton.Size = new System.Drawing.Size(90, 25);
            this.checkAnswerButton.TabIndex = 7;
            this.checkAnswerButton.Text = "Check answer";
            this.checkAnswerButton.UseVisualStyleBackColor = false;
            this.checkAnswerButton.Click += new System.EventHandler(this.checkAnswerButton_Click);
            // 
            // lackOfAnswerButton
            // 
            this.lackOfAnswerButton.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.lackOfAnswerButton.FlatAppearance.BorderColor = System.Drawing.Color.WhiteSmoke;
            this.lackOfAnswerButton.FlatAppearance.BorderSize = 0;
            this.lackOfAnswerButton.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.lackOfAnswerButton.Location = new System.Drawing.Point(216, 137);
            this.lackOfAnswerButton.Name = "lackOfAnswerButton";
            this.lackOfAnswerButton.Size = new System.Drawing.Size(90, 25);
            this.lackOfAnswerButton.TabIndex = 10;
            this.lackOfAnswerButton.Text = "I don\'t know";
            this.lackOfAnswerButton.UseVisualStyleBackColor = false;
            this.lackOfAnswerButton.Click += new System.EventHandler(this.lackOfAnswerButton_Click);
            // 
            // userAnswer
            // 
            this.userAnswer.AcceptsReturn = true;
            this.userAnswer.Location = new System.Drawing.Point(142, 83);
            this.userAnswer.Name = "userAnswer";
            this.userAnswer.Size = new System.Drawing.Size(100, 20);
            this.userAnswer.TabIndex = 1;
            this.userAnswer.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.userAnswer.KeyDown += new System.Windows.Forms.KeyEventHandler(this.userAnswer_KeyUp);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Enabled = false;
            this.label1.Location = new System.Drawing.Point(133, 55);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(121, 13);
            this.label1.TabIndex = 8;
            this.label1.Text = "Please enter the answer";
            // 
            // Question
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(414, 172);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.userAnswer);
            this.Controls.Add(this.lackOfAnswerButton);
            this.Controls.Add(this.checkAnswerButton);
            this.Controls.Add(this.questionBox);
            this.Name = "Question";
            this.Text = "Question";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox questionBox;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.Button checkAnswerButton;
        private System.Windows.Forms.Button lackOfAnswerButton;
        private System.Windows.Forms.TextBox userAnswer;
        private System.Windows.Forms.Label label1;
    }
}