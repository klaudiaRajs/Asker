namespace Asker {
    partial class CorrectAnswer {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing) {
            if (disposing && (components != null)) {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent() {
            this.answerResponseMessage = new System.Windows.Forms.Label();
            this.closeAnswerMessage = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // answerResponseMessage
            // 
            this.answerResponseMessage.AutoSize = true;
            this.answerResponseMessage.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.answerResponseMessage.Location = new System.Drawing.Point(12, 18);
            this.answerResponseMessage.Name = "answerResponseMessage";
            this.answerResponseMessage.Size = new System.Drawing.Size(307, 24);
            this.answerResponseMessage.TabIndex = 0;
            this.answerResponseMessage.Text = "Congrats! Your answer was correct!";
            // 
            // closeAnswerMessage
            // 
            this.closeAnswerMessage.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.closeAnswerMessage.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.closeAnswerMessage.FlatAppearance.BorderColor = System.Drawing.Color.WhiteSmoke;
            this.closeAnswerMessage.FlatAppearance.BorderSize = 0;
            this.closeAnswerMessage.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.closeAnswerMessage.Location = new System.Drawing.Point(0, 55);
            this.closeAnswerMessage.Name = "closeAnswerMessage";
            this.closeAnswerMessage.Size = new System.Drawing.Size(325, 25);
            this.closeAnswerMessage.TabIndex = 6;
            this.closeAnswerMessage.Text = "Close";
            this.closeAnswerMessage.UseVisualStyleBackColor = false;
            this.closeAnswerMessage.Click += new System.EventHandler(this.closeAnswerMessage_Click);
            // 
            // CorrectAnswer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.ClientSize = new System.Drawing.Size(325, 80);
            this.Controls.Add(this.closeAnswerMessage);
            this.Controls.Add(this.answerResponseMessage);
            this.Name = "CorrectAnswer";
            this.Text = "You did well!";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label answerResponseMessage;
        private System.Windows.Forms.Button closeAnswerMessage;
    }
}