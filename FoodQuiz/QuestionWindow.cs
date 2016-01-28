using System;
using System.Drawing;
using System.Windows.Forms;

namespace FoodQuiz
{
    public partial class QuestionWindow : Form
    {
        private readonly AnswerWindow _answerWindow;
        private int _time = 30;

        public QuestionWindow(string q, string a)
        {
            InitializeComponent();
            label1.Text = q;
            _answerWindow = new AnswerWindow(a);
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            _time--;
            label2.Text = _time.ToString();
            if (_time == 0)
            {
                timer1.Stop();
                BackColor = Color.Red;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            timer1.Start();
            button2.Focus();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            timer1.Stop();
            _answerWindow.ShowDialog();
            Dispose();
        }
    }
}