using System;
using System.Windows.Forms;

namespace Asker {
    public partial class CorrectAnswer : Form {
        public CorrectAnswer( ) {
            InitializeComponent();
        }

        /** Closes the congratulation message */ 
        private void closeAnswerMessage_Click(object sender, EventArgs e) {
            this.Close();
        }
    }
}
