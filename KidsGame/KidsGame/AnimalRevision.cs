using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace KidsGame
{
    public partial class AnimalRevision : Form
    {
        public AnimalRevision()
        {
            InitializeComponent();
        }

        private void Back_Click(object sender, EventArgs e)
        {
            
                this.Close();
                AnimalLearn animalLearn = new AnimalLearn();
                animalLearn.Show();
            
            
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
            AnimalQuiz quiz = new AnimalQuiz();
            quiz.Show();
        }
    }
}
