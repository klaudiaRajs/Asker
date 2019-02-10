namespace Asker {
    partial class WrongAnswerWarning {
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.viewAnswer = new System.Windows.Forms.Button();
            this.allowToCorrectAnswerButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(50, 19);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(212, 16);
            this.label1.TabIndex = 0;
            this.label1.Text = "It seems that you made a mistake! ";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(50, 35);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(204, 16);
            this.label2.TabIndex = 1;
            this.label2.Text = "Do yo want to see correct answer";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(75, 51);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(146, 16);
            this.label3.TabIndex = 2;
            this.label3.Text = "or correct your answer?";
            // 
            // viewAnswer
            // 
            this.viewAnswer.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.viewAnswer.FlatAppearance.BorderColor = System.Drawing.Color.WhiteSmoke;
            this.viewAnswer.FlatAppearance.BorderSize = 0;
            this.viewAnswer.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.viewAnswer.Location = new System.Drawing.Point(12, 98);
            this.viewAnswer.Name = "viewAnswer";
            this.viewAnswer.Size = new System.Drawing.Size(120, 25);
            this.viewAnswer.TabIndex = 7;
            this.viewAnswer.Text = "View answer [Enter]";
            this.viewAnswer.UseVisualStyleBackColor = false;
            this.viewAnswer.Click += new System.EventHandler(this.viewAnswer_Click);
            this.viewAnswer.KeyDown += new System.Windows.Forms.KeyEventHandler(this.WrongAnswerWarning_KeyDown);
            // 
            // allowToCorrectAnswerButton
            // 
            this.allowToCorrectAnswerButton.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.allowToCorrectAnswerButton.FlatAppearance.BorderColor = System.Drawing.Color.WhiteSmoke;
            this.allowToCorrectAnswerButton.FlatAppearance.BorderSize = 0;
            this.allowToCorrectAnswerButton.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.allowToCorrectAnswerButton.Location = new System.Drawing.Point(150, 98);
            this.allowToCorrectAnswerButton.Name = "allowToCorrectAnswerButton";
            this.allowToCorrectAnswerButton.Size = new System.Drawing.Size(141, 25);
            this.allowToCorrectAnswerButton.TabIndex = 8;
            this.allowToCorrectAnswerButton.Text = "Correct your answer [Esc]";
            this.allowToCorrectAnswerButton.UseVisualStyleBackColor = false;
            this.allowToCorrectAnswerButton.Click += new System.EventHandler(this.allowToCorrectTheAnswerButton_Click);
            this.allowToCorrectAnswerButton.KeyDown += new System.Windows.Forms.KeyEventHandler(this.WrongAnswerWarning_KeyDown);
            // 
            // WrongAnswerWarning
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(303, 135);
            this.Controls.Add(this.allowToCorrectAnswerButton);
            this.Controls.Add(this.viewAnswer);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "WrongAnswerWarning";
            this.Text = "Something seems to be wrong";
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.WrongAnswerWarning_KeyDown);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button viewAnswer;
        private System.Windows.Forms.Button allowToCorrectAnswerButton;
    }
}