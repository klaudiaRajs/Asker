using System;
using System.IO;
using System.Collections.Generic;
using System.Windows.Forms;

namespace Asker {
    public partial class Asker : Form {
        /** list of questions and answers */ 
        List<QuestionAnswer> questionsAnswers = new List<QuestionAnswer>(); 

        public Asker() {
            InitializeComponent();
        }
        
        /** Fires form that prompts user to confirm will to exit the program */
        private void closeButton_Click(object sender, EventArgs e) {
            ExitConfirmation confirmation = new ExitConfirmation( this );
            confirmation.ShowDialog();
        }

        /** Checks if user provided questions, if yes loads the first question, otherwise prompts user to load questions */ 
        private void nextQuestionButton_Click(object sender, EventArgs e) {
            if (emptyQAlist()) {
                Help help = new Help();
                help.changeHelpMessage("You have not provided any questions, please upload your file first");
                help.ShowDialog();
            } else {
                QuestionAnswer randomQA = getRandomQuestionAnswer(); 
                Question question = new Question( randomQA ) ;
                question.ShowDialog();
            }
        }

        /** returns random number from 0 to maximum number given as parameter */
        private int randomNumberFromRange(int maxNumber) {
            Random random = new Random();
            return random.Next(0, maxNumber);
        }

        /** returns object containing random question/answer */ 
        private QuestionAnswer getRandomQuestionAnswer() {
            int randomIndex = randomNumberFromRange(questionsAnswers.Count);
            return questionsAnswers[randomIndex]; 
        }

        /** Checks if questions/answers provide content */
        private Boolean emptyQAlist() {
            return questionsAnswers.Count == 0;
        }
        
        /** Loads contents of the file provided by the user into questions/answers list */
        private void loadFileButton_Click(object sender, EventArgs e) { 
            QuestionsAnswers.ShowDialog();
            String QaFileContents = File.ReadAllText(QuestionsAnswers.FileName);
            if (QaFileContents.Length <= 0) {
                Help help = new Help();
                help.changeHelpMessage("Something went wrong with the file");
                help.ShowDialog();
            } else {
                String[] qa = prepareFileContent( QaFileContents );
                divideContentOfTheFileIntoQuestionsAndAnswers( qa );
            }   
        }

        /** Divides file content into QuestionAnswer objects and adds them to questionsAnswers list  */ 
        private void divideContentOfTheFileIntoQuestionsAndAnswers( String[] qa ) {
            for (var i = 0; i < qa.Length; i++) {
                String record   = qa[i];
                String[] fields = record.Split(new char[] { ',' });
                QuestionAnswer questionAnswer = new QuestionAnswer(fields[0], fields[1]);
                questionsAnswers.Add(questionAnswer);
            }
        }

        /** prepares content of the file to be handled by the program */ 
        private String[] prepareFileContent( String QaFileContents ) {
            return QaFileContents.Replace('\n', '\r').Split(new char[] { '\r' }, StringSplitOptions.RemoveEmptyEntries);
        }

        /** Loads help window  */ 
        private void helpButton_Click(object sender, EventArgs e) {
            Help helpWindow = new Help();
            helpWindow.ShowDialog();
        }
    }


}
