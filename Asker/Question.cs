using System;
using System.Windows.Forms;

namespace Asker {
    partial class Question : Form
    {
        /** Initializes a question used in the form */ 
        String question;
        /** Initializes an answer used in the form */ 
        String answer;
    
        public Question( QuestionAnswer questionAnswer )
        {
            InitializeComponent();
            this.question = questionAnswer.question;
            this.answer = questionAnswer.answer;
            questionBox.Text = this.question; 
        }

        /** Loads form used when user don't know the answer to question */ 
        private void lackOfAnswerButton_Click(object sender, EventArgs e)
        {
            LackOfAnswer lackOfAnswerForm = new LackOfAnswer( answer );
            lackOfAnswerForm.ShowDialog();
            this.Close(); 
        }

        /** When user clicks the check answer button, the answer is checked */ 
        private void checkAnswerButton_Click(object sender, EventArgs e) {
            checkAnswer(); 
        }

        /** Allow user to check the answer by pressing enter */ 
        private void userAnswer_KeyUp(object sender, KeyEventArgs e) {
            if (e.KeyCode == Keys.Enter) {
                checkAnswer();
            }
        }

        /** check if user's answer is correct */
        private void checkAnswer() {
            if (userAnswer.Text == answer) {
                CorrectAnswer correctMessage = new CorrectAnswer();
                correctMessage.ShowDialog();
                this.Close();
            } else {
                WrongAnswerWarning wrongAnswer = new WrongAnswerWarning(answer, this);
                wrongAnswer.ShowDialog();
            }
        }
    }
}
