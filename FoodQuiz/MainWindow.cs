using System;
using System.Drawing;
using System.Windows.Forms;

namespace FoodQuiz
{
    public partial class MainWindow : Form
    {
        private string _question, _answer;
        private QuestionWindow _questionWindow;

        public MainWindow()
        {
            InitializeComponent();
        }

        private void button11_Click(object sender, EventArgs e)
        {
            button11.BackColor = Color.Red;
            _question = "1) What are the three main ways to cook an egg?";
            _answer = "Poaching, frying, boiling";
            _questionWindow = new QuestionWindow(_question, _answer);
            _questionWindow.ShowDialog();
        }

        private void button12_Click(object sender, EventArgs e)
        {
            button12.BackColor = Color.Red;
            _question =
                "2) What do you call the process of melting ingredients (e.g. sugar, onions)?\n\nA. Caramelization\nB. Crystallization\nC. Ionization\nD. Electrolysis";
            _answer = "A. Caramelization";
            _questionWindow = new QuestionWindow(_question, _answer);
            _questionWindow.ShowDialog();
        }

        private void button13_Click(object sender, EventArgs e)
        {
            button13.BackColor = Color.Red;
            _question = "3) Cutting something (e.g. meat) into long, thin strips is called?";
            _answer = "Julienne";
            _questionWindow = new QuestionWindow(_question, _answer);
            _questionWindow.ShowDialog();
        }

        private void button14_Click(object sender, EventArgs e)
        {
            button14.BackColor = Color.Red;
            _question =
                "4) What is the process of putting chicken/cheese/vegetables/fish in bread crumbs, eggs, and flour called?\n\nA. Panirising\nB. Baking\nC. Breading\nD. Steaming";
            _answer = "C. Breading";
            _questionWindow = new QuestionWindow(_question, _answer);
            _questionWindow.ShowDialog();
        }

        private void button15_Click(object sender, EventArgs e)
        {
            button15.BackColor = Color.Red;
            _question = "5) Filling a pan with alcohol and igniting it to prepare food is called?";
            _answer = "Flambe";
            _questionWindow = new QuestionWindow(_question, _answer);
            _questionWindow.ShowDialog();
        }

        private void button16_Click(object sender, EventArgs e)
        {
            button16.BackColor = Color.Red;
            _question =
                "6) How do you call the process of putting meat in a mixtures of herbs and sauces?\n\nA. Marinate\nB. Marinade\nC. Maranade\nD. Madanate";
            _answer = "A. Marinate";
            _questionWindow = new QuestionWindow(_question, _answer);
            _questionWindow.ShowDialog();
        }

        private void button17_Click(object sender, EventArgs e)
        {
            button17.BackColor = Color.Red;
            _question = "7) Which cooking method is the least healthy?";
            _answer = "(Deep) frying";
            _questionWindow = new QuestionWindow(_question, _answer);
            _questionWindow.ShowDialog();
        }

        private void button18_Click(object sender, EventArgs e)
        {
            button18.BackColor = Color.Red;
            _question =
                "8) When you bake a pie crust, why do you put raw rice or beans on top of it?\n\nA. To bake it faster\nB. To make it rise\nC. To make it taste it better\nD. To prevent it from rising";
            _answer = "D. To prevent it from rising";
            _questionWindow = new QuestionWindow(_question, _answer);
            _questionWindow.ShowDialog();
        }

        private void button21_Click(object sender, EventArgs e)
        {
            button21.BackColor = Color.Red;
            _question = "1) What is the main ingredient of paella?";
            _answer = "Rice";
            _questionWindow = new QuestionWindow(_question, _answer);
            _questionWindow.ShowDialog();
        }

        private void button22_Click(object sender, EventArgs e)
        {
            button22.BackColor = Color.Red;
            _question = "2) Where do French fries originally come from?";
            _answer = "Belgium";
            _questionWindow = new QuestionWindow(_question, _answer);
            _questionWindow.ShowDialog();
        }

        private void button23_Click(object sender, EventArgs e)
        {
            button23.BackColor = Color.Red;
            _question =
                "3) What is the name of the seaweed that you wrap sushi with?\n\nA. Wasabi\nB. Nori\nC. Uramaki\nD. Nigiri";
            _answer = "B. Nori";
            _questionWindow = new QuestionWindow(_question, _answer);
            _questionWindow.ShowDialog();
        }

        private void button24_Click(object sender, EventArgs e)
        {
            button24.BackColor = Color.Red;
            _question =
                "4) Which city does the deep-pan pizza come from?\n\nA. New York\nB. Milan\nC. Chicago\nD. San Francisco";
            _answer = "C. Chicago";
            _questionWindow = new QuestionWindow(_question, _answer);
            _questionWindow.ShowDialog();
        }

        private void button25_Click(object sender, EventArgs e)
        {
            button25.BackColor = Color.Red;
            _question = "5) Which region of France is the most famous for its wine fields?";
            _answer = "Bordeaux";
            _questionWindow = new QuestionWindow(_question, _answer);
            _questionWindow.ShowDialog();
        }

        private void button26_Click(object sender, EventArgs e)
        {
            button26.BackColor = Color.Red;
            _question = "6) What is the Italian dried ham called?";
            _answer = "Prosciutto";
            _questionWindow = new QuestionWindow(_question, _answer);
            _questionWindow.ShowDialog();
        }

        private void button27_Click(object sender, EventArgs e)
        {
            button27.BackColor = Color.Red;
            _question =
                "7) Which of these desserts does NOT come from Turkey?\n\nA. Baklava\nB. Halva\nC. Tulumba\nD. Lokum";
            _answer = "B. Halva";
            _questionWindow = new QuestionWindow(_question, _answer);
            _questionWindow.ShowDialog();
        }

        private void button28_Click(object sender, EventArgs e)
        {
            button28.BackColor = Color.Red;
            _question =
                "8) Which kind of meat is the main ingredient of Shepherd's pie?\n\nA. Turkey\nB. Beef\nC. Pork\nD. Lamb";
            _answer = "D. Lamb";
            _questionWindow = new QuestionWindow(_question, _answer);
            _questionWindow.ShowDialog();
        }

        private void button31_Click(object sender, EventArgs e)
        {
            button31.BackColor = Color.Red;
            _question =
                "1) What was the name of the restaurant in Paris where the story of 'Ratatouille' takes place?\n\nA. Pierre's\nB. Gusteau's\nC. François'\nD. Henry's";
            _answer = "B. Gusteau's";
            _questionWindow = new QuestionWindow(_question, _answer);
            _questionWindow.ShowDialog();
        }

        private void button32_Click(object sender, EventArgs e)
        {
            button32.BackColor = Color.Red;
            _question =
                "2) What animal was the imaginary friend of Anouk (the daughter of Vianne from 'Chocolat')?\n\nA. Cat\nB. Dog\nC. Fox\nD. Kangaroo";
            _answer = "D. Kangaroo";
            _questionWindow = new QuestionWindow(_question, _answer);
            _questionWindow.ShowDialog();
        }

        private void button33_Click(object sender, EventArgs e)
        {
            button33.BackColor = Color.Red;
            _question = "3) Who plays Julia Child in 'Julie and Julia' from 2009?";
            _answer = "Meryl Streep";
            _questionWindow = new QuestionWindow(_question, _answer);
            _questionWindow.ShowDialog();
        }

        private void button34_Click(object sender, EventArgs e)
        {
            button34.BackColor = Color.Red;
            _question =
                "4) What nationality are the main characters who open their own family restaurant in 'The Hundred-Foot Journey'?";
            _answer = "Indian";
            _questionWindow = new QuestionWindow(_question, _answer);
            _questionWindow.ShowDialog();
        }

        private void button35_Click(object sender, EventArgs e)
        {
            button35.BackColor = Color.Red;
            _question =
                "5) What is Julia's most famous dish that Julie tries to make at home and fails in 'Julie and Julia'?\n\nA. Onion soup\nB. Omelette \nC. Burgundy Beef\nD. Souflé";
            _answer = "C. Burgundy beef";
            _questionWindow = new QuestionWindow(_question, _answer);
            _questionWindow.ShowDialog();
        }

        private void button36_Click(object sender, EventArgs e)
        {
            button36.BackColor = Color.Red;
            _question =
                "6) How is the ranking system of restaurants called, mentioned in 'The Hundred-Foot Journey'?\n\nA. Citroen stars\nB. Michelin stars\nC. Renault stars\nD. Peugeot stars";
            _answer = "B. Michelin stars";
            _questionWindow = new QuestionWindow(_question, _answer);
            _questionWindow.ShowDialog();
        }

        private void button37_Click(object sender, EventArgs e)
        {
            button37.BackColor = Color.Red;
            _question = "7) What is the name of the little chef rat from Disney Pixar's 'Ratatouille'?";
            _answer = "Remy";
            _questionWindow = new QuestionWindow(_question, _answer);
            _questionWindow.ShowDialog();
        }

        private void button38_Click(object sender, EventArgs e)
        {
            button38.BackColor = Color.Red;
            _question = "8) Who starred as the leading male role in Lasse Hallström's 'Chocolat'?";
            _answer = "Johnny Depp";
            _questionWindow = new QuestionWindow(_question, _answer);
            _questionWindow.ShowDialog();
        }

        private void button41_Click(object sender, EventArgs e)
        {
            button41.BackColor = Color.Red;
            _question =
                "1) In the valley of which river was watermelon cultivated during prehistoric times?\n\nA. Danube\nB. Nile\nC. Tigris\nD. Euphrates";
            _answer = "B. Nile";
            _questionWindow = new QuestionWindow(_question, _answer);
            _questionWindow.ShowDialog();
        }

        private void button42_Click(object sender, EventArgs e)
        {
            button42.BackColor = Color.Red;
            _question = "2) What inspired the Austrians (yes, not the French!) to invent the croissant?";
            _answer = "The crescent on the Turkish flag";
            _questionWindow = new QuestionWindow(_question, _answer);
            _questionWindow.ShowDialog();
        }

        private void button43_Click(object sender, EventArgs e)
        {
            button43.BackColor = Color.Red;
            _question =
                "3) Which nationality introduced potatoes to Europe?\n\nA. Portuguese\nB. Spanish\nC. British\nD. Italian";
            _answer = "B. Spanish";
            _questionWindow = new QuestionWindow(_question, _answer);
            _questionWindow.ShowDialog();
        }

        private void button44_Click(object sender, EventArgs e)
        {
            button44.BackColor = Color.Red;
            _question = "4) Where were tomatoes used as food for the first time?";
            _answer = "Mexico";
            _questionWindow = new QuestionWindow(_question, _answer);
            _questionWindow.ShowDialog();
        }

        private void button45_Click(object sender, EventArgs e)
        {
            button45.BackColor = Color.Red;
            _question =
                "5) The Spice Route connected Europe and which region of the world?\n\nA. Japan\nB. India\nC. Egypt\nD. Mexico";
            _answer = "B. India";
            _questionWindow = new QuestionWindow(_question, _answer);
            _questionWindow.ShowDialog();
        }

        private void button46_Click(object sender, EventArgs e)
        {
            button46.BackColor = Color.Red;
            _question =
                "6) What did Europeans use to make sugar during the Middle Ages before sugar cane came from the Americas?";
            _answer = "Sugar beet";
            _questionWindow = new QuestionWindow(_question, _answer);
            _questionWindow.ShowDialog();
        }

        private void button47_Click(object sender, EventArgs e)
        {
            button47.BackColor = Color.Red;
            _question =
                "7) How is the pasta sauce invented by the miners in Italy called?\n\nA. Minara\nB. Bolognese\nC. Carbonara\nD. Puttanesca";
            _answer = "C. Carbonara";
            _questionWindow = new QuestionWindow(_question, _answer);
            _questionWindow.ShowDialog();
        }

        private void button48_Click(object sender, EventArgs e)
        {
            button48.BackColor = Color.Red;
            _question = "8) What is the name of the French king whose food dish was cauliflower?";
            _answer = "Louis XIV, the Sun King";
            _questionWindow = new QuestionWindow(_question, _answer);
            _questionWindow.ShowDialog();
        }

        private void button51_Click(object sender, EventArgs e)
        {
            button51.BackColor = Color.Red;
            _question = "1) What is made with mascarpone, biscotti, cocoa powder, coffee?";
            _answer = "Tiramisù";
            _questionWindow = new QuestionWindow(_question, _answer);
            _questionWindow.ShowDialog();
        }

        private void button52_Click(object sender, EventArgs e)
        {
            button52.BackColor = Color.Red;
            _question = "2) What is made with sour cream, bacon, basilico, eggs?";
            _answer = "Carbonara sauce";
            _questionWindow = new QuestionWindow(_question, _answer);
            _questionWindow.ShowDialog();
        }

        private void button53_Click(object sender, EventArgs e)
        {
            button53.BackColor = Color.Red;
            _question = "3) What is made with minced meat, potatoes, eggs, herbs?";
            _answer = "Moussaka";
            _questionWindow = new QuestionWindow(_question, _answer);
            _questionWindow.ShowDialog();
        }

        private void button54_Click(object sender, EventArgs e)
        {
            button54.BackColor = Color.Red;
            _question = "4) What is made with butter, cream cheese, cherries, biscuits?";
            _answer = "Cheesecake";
            _questionWindow = new QuestionWindow(_question, _answer);
            _questionWindow.ShowDialog();
        }

        private void button55_Click(object sender, EventArgs e)
        {
            button55.BackColor = Color.Red;
            _question = "5) What is made with avocado, tomato, lemon, garlic?";
            _answer = "Guacamole";
            _questionWindow = new QuestionWindow(_question, _answer);
            _questionWindow.ShowDialog();
        }

        private void button56_Click(object sender, EventArgs e)
        {
            button56.BackColor = Color.Red;
            _question = "6) What is made with iceberg salad, chicken, anchovies, croutons?";
            _answer = "Caesar salad";
            _questionWindow = new QuestionWindow(_question, _answer);
            _questionWindow.ShowDialog();
        }

        private void button57_Click(object sender, EventArgs e)
        {
            button57.BackColor = Color.Red;
            _question = "7) What is made with peppers, rice, minced meat?";
            _answer = "Stuffed peppers";
            _questionWindow = new QuestionWindow(_question, _answer);
            _questionWindow.ShowDialog();
        }

        private void button58_Click(object sender, EventArgs e)
        {
            button58.BackColor = Color.Red;
            _question = "8) What is made with vodka, triple sec, cranberry juice, lime juice?";
            _answer = "Cosmopolitan";
            _questionWindow = new QuestionWindow(_question, _answer);
            _questionWindow.ShowDialog();
        }
    }
}