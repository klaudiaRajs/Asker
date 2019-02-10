using System;
using System.Windows.Forms;

namespace Asker {
    public partial class ExitConfirmation : Form {

        Form mainWindow; 

        /** constructor takes the param of parent Form as it is closed from this level */ 
        public ExitConfirmation(  Form parentForm ) {
            InitializeComponent();
            mainWindow = parentForm; 
        }

        /** Closes the whole program */ 
        private void closeWholePrgoram_Click(object sender, EventArgs e) {
            this.Close();
            mainWindow.Close();
            Application.Exit(); 
        }

        /** Closes confirmation window */ 
        private void button1_Click(object sender, EventArgs e) {
            this.Close();
        }
    }
}
