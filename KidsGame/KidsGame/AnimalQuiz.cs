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
    public partial class AnimalQuiz : Form
    {
        public AnimalQuiz()
        {
            InitializeComponent();
        }

        private void Back_Click(object sender, EventArgs e)
        {   
            this.Close();
            AnimalRevision animalRevision = new AnimalRevision();
            animalRevision.Show();
        }
    }
}
