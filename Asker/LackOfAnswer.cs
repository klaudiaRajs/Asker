using System;
using System.Windows.Forms;

namespace Asker {
    public partial class LackOfAnswer : Form
    {
        public LackOfAnswer( String answer )
        {
            InitializeComponent();
            correctAnswer.Text = answer; 
        }

        private void closeButton_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
