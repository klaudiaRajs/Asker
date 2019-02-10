namespace Asker
{
    partial class Asker
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
            this.nextQuestionButton = new System.Windows.Forms.Button();
            this.closeButton = new System.Windows.Forms.Button();
            this.loadFileButton = new System.Windows.Forms.Button();
            this.QuestionsAnswers = new System.Windows.Forms.OpenFileDialog();
            this.helpButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // nextQuestionButton
            // 
            this.nextQuestionButton.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.nextQuestionButton.FlatAppearance.BorderColor = System.Drawing.Color.WhiteSmoke;
            this.nextQuestionButton.FlatAppearance.BorderSize = 0;
            this.nextQuestionButton.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.nextQuestionButton.Location = new System.Drawing.Point(12, 12);
            this.nextQuestionButton.Name = "nextQuestionButton";
            this.nextQuestionButton.Size = new System.Drawing.Size(75, 23);
            this.nextQuestionButton.TabIndex = 0;
            this.nextQuestionButton.Text = "Next";
            this.nextQuestionButton.UseVisualStyleBackColor = false;
            this.nextQuestionButton.Click += new System.EventHandler(this.nextQuestionButton_Click);
            // 
            // closeButton
            // 
            this.closeButton.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.closeButton.FlatAppearance.BorderColor = System.Drawing.Color.WhiteSmoke;
            this.closeButton.FlatAppearance.BorderSize = 0;
            this.closeButton.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.closeButton.Location = new System.Drawing.Point(293, 12);
            this.closeButton.Name = "closeButton";
            this.closeButton.Size = new System.Drawing.Size(75, 23);
            this.closeButton.TabIndex = 2;
            this.closeButton.Text = "Close";
            this.closeButton.UseVisualStyleBackColor = false;
            this.closeButton.Click += new System.EventHandler(this.closeButton_Click);
            // 
            // loadFileButton
            // 
            this.loadFileButton.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.loadFileButton.FlatAppearance.BorderColor = System.Drawing.Color.WhiteSmoke;
            this.loadFileButton.FlatAppearance.BorderSize = 0;
            this.loadFileButton.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.loadFileButton.Location = new System.Drawing.Point(93, 12);
            this.loadFileButton.Name = "loadFileButton";
            this.loadFileButton.Size = new System.Drawing.Size(113, 23);
            this.loadFileButton.TabIndex = 3;
            this.loadFileButton.Text = "Load flashcards";
            this.loadFileButton.UseVisualStyleBackColor = false;
            this.loadFileButton.Click += new System.EventHandler(this.loadFileButton_Click);
            // 
            // QuestionsAnswers
            // 
            this.QuestionsAnswers.FileName = "QuestionsAnswers";
            // 
            // helpButton
            // 
            this.helpButton.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.helpButton.FlatAppearance.BorderColor = System.Drawing.Color.WhiteSmoke;
            this.helpButton.FlatAppearance.BorderSize = 0;
            this.helpButton.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.helpButton.Location = new System.Drawing.Point(212, 12);
            this.helpButton.Name = "helpButton";
            this.helpButton.Size = new System.Drawing.Size(75, 23);
            this.helpButton.TabIndex = 4;
            this.helpButton.Text = "Help";
            this.helpButton.UseVisualStyleBackColor = false;
            this.helpButton.Click += new System.EventHandler(this.helpButton_Click);
            // 
            // Asker
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(380, 48);
            this.Controls.Add(this.helpButton);
            this.Controls.Add(this.loadFileButton);
            this.Controls.Add(this.closeButton);
            this.Controls.Add(this.nextQuestionButton);
            this.Name = "Asker";
            this.Text = "Asker";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button nextQuestionButton;
        private System.Windows.Forms.Button closeButton;
        private System.Windows.Forms.Button loadFileButton;
        private System.Windows.Forms.OpenFileDialog QuestionsAnswers;
        private System.Windows.Forms.Button helpButton;
    }
}

