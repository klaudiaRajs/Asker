namespace Asker
{
    partial class LackOfAnswer
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
            this.confirmationText = new System.Windows.Forms.TextBox();
            this.correctAnswer = new System.Windows.Forms.TextBox();
            this.closeButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // confirmationText
            // 
            this.confirmationText.BackColor = System.Drawing.SystemColors.Control;
            this.confirmationText.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.confirmationText.Location = new System.Drawing.Point(27, 23);
            this.confirmationText.Name = "confirmationText";
            this.confirmationText.Size = new System.Drawing.Size(227, 20);
            this.confirmationText.TabIndex = 1;
            this.confirmationText.TabStop = false;
            this.confirmationText.Text = "The correct answer is:";
            this.confirmationText.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // correctAnswer
            // 
            this.correctAnswer.BackColor = System.Drawing.SystemColors.Control;
            this.correctAnswer.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.correctAnswer.Location = new System.Drawing.Point(60, 70);
            this.correctAnswer.Name = "correctAnswer";
            this.correctAnswer.Size = new System.Drawing.Size(143, 20);
            this.correctAnswer.TabIndex = 2;
            this.correctAnswer.TabStop = false;
            this.correctAnswer.Text = "Sample answer";
            this.correctAnswer.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // closeButton
            // 
            this.closeButton.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.closeButton.FlatAppearance.BorderColor = System.Drawing.Color.WhiteSmoke;
            this.closeButton.FlatAppearance.BorderSize = 0;
            this.closeButton.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.closeButton.Location = new System.Drawing.Point(128, 122);
            this.closeButton.Name = "closeButton";
            this.closeButton.Size = new System.Drawing.Size(75, 23);
            this.closeButton.TabIndex = 3;
            this.closeButton.Text = "Close";
            this.closeButton.UseVisualStyleBackColor = false;
            this.closeButton.Click += new System.EventHandler(this.closeButton_Click);
            // 
            // lackOfAnswer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(276, 157);
            this.Controls.Add(this.closeButton);
            this.Controls.Add(this.correctAnswer);
            this.Controls.Add(this.confirmationText);
            this.Name = "lackOfAnswer";
            this.Text = "lackOfAnswer";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox confirmationText;
        private System.Windows.Forms.TextBox correctAnswer;
        private System.Windows.Forms.Button closeButton;
    }
}