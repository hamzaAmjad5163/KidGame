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
    public partial class Animals : Form
    {
        public Animals()
        {
            InitializeComponent();
        }

        private void LearnAnimalToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AnimalLearn animals = new AnimalLearn();
            animals.Show(this);
            Hide();
        }

        private void revisionToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AnimalRevision animalRevision = new AnimalRevision();
            animalRevision.Show(this);
            Hide();
        }

        private void quizToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            AnimalQuiz animalQuiz = new AnimalQuiz();
            animalQuiz.Show(this);
            Hide();
        }
    }
}
