using System;
using System.Windows.Forms;

namespace Asker {
    public partial class Help : Form {
        public Help() {
            InitializeComponent();
        }

        private void closeHelpButton_Click(object sender, EventArgs e) {
            this.Close();
        }

        /** Method used for displaying different than regular help message to the user */ 
        public void changeHelpMessage( String helpText ) {
            richTextBox1.Text = helpText; 
        }
    }
}
