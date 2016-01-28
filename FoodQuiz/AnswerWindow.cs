using System;
using System.Windows.Forms;

namespace FoodQuiz
{
    public partial class AnswerWindow : Form
    {
        public AnswerWindow(string ans)
        {
            InitializeComponent();
            label1.Text = ans;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Dispose();
        }
    }
}