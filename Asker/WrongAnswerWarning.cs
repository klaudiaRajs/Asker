using System;
using System.Windows.Forms;

namespace Asker {
    public partial class WrongAnswerWarning : Form {

        /** Keeps the content of currently processed answer */ 
        String currentAnswer;
        /** Initialize access to parent form */ 
        Form parentForm; 

        /** Constructor takes a current answer as a parameter as it need to be passed to further forms 
         and takes parentForm as well as it is closed from this level */ 
        public WrongAnswerWarning( String currentAnswer, Form parentForm ) {
            this.currentAnswer = currentAnswer;
            this.parentForm = parentForm;
            InitializeComponent();
        }

        /** Loads form showing answers and closes current form opened */ 
        private void viewAnswer_Click(object sender, EventArgs e) {
            LackOfAnswer Answer = new LackOfAnswer( currentAnswer );
            Answer.ShowDialog();
            this.Close();
            this.parentForm.Close();
        }

        /** Closes current window and allow user to correct his answer */ 
        private void allowToCorrectTheAnswerButton_Click(object sender, EventArgs e) {
            this.Close();
        }

        /** Handles keyboard events in the form */ 
        private void WrongAnswerWarning_KeyDown(object sender, KeyEventArgs e) {
            if( e.KeyCode == Keys.Escape) { 
                this.Close();
            }
            else if ( e.KeyCode == Keys.Enter) {
                viewAnswer_Click( sender, e );
            }
        }
    }
}
