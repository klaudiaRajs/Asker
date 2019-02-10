namespace Asker {
    partial class ExitConfirmation {
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
            this.confirmationText = new System.Windows.Forms.TextBox();
            this.closeWholeProgram = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // confirmationText
            // 
            this.confirmationText.BackColor = System.Drawing.SystemColors.Control;
            this.confirmationText.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.confirmationText.Location = new System.Drawing.Point(13, 12);
            this.confirmationText.Name = "confirmationText";
            this.confirmationText.Size = new System.Drawing.Size(227, 20);
            this.confirmationText.TabIndex = 0;
            this.confirmationText.TabStop = false;
            this.confirmationText.Text = "Are you sure you want to close Asker?";
            this.confirmationText.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // closeWholeProgram
            // 
            this.closeWholeProgram.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.closeWholeProgram.FlatAppearance.BorderColor = System.Drawing.Color.WhiteSmoke;
            this.closeWholeProgram.FlatAppearance.BorderSize = 0;
            this.closeWholeProgram.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.closeWholeProgram.Location = new System.Drawing.Point(34, 38);
            this.closeWholeProgram.Name = "closeWholeProgram";
            this.closeWholeProgram.Size = new System.Drawing.Size(75, 23);
            this.closeWholeProgram.TabIndex = 2;
            this.closeWholeProgram.Text = "Yes";
            this.closeWholeProgram.UseVisualStyleBackColor = false;
            this.closeWholeProgram.Click += new System.EventHandler(this.closeWholePrgoram_Click);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.button1.FlatAppearance.BorderColor = System.Drawing.Color.WhiteSmoke;
            this.button1.FlatAppearance.BorderSize = 0;
            this.button1.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.button1.Location = new System.Drawing.Point(145, 38);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 3;
            this.button1.Text = "No";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Confirmation
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(252, 73);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.closeWholeProgram);
            this.Controls.Add(this.confirmationText);
            this.Name = "Confirmation";
            this.Text = "Confirmation";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox confirmationText;
        private System.Windows.Forms.Button closeWholeProgram;
        private System.Windows.Forms.Button button1;
    }
}