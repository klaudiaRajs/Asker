using System;

namespace Asker {
    class QuestionAnswer {
        /** Initializes a question and it's getter */ 
        public String question { get; }
        /** Initializes an answer and it's getter */ 
        public String answer { get; } 

        public QuestionAnswer( String question, String answer ) {
            this.question = question;
            this.answer = answer; 
        }
    }
}
