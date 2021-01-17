using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SpaceShooter
{
    public partial class GameOver : Form
    {
        int finalScore;
        public GameOver(int score)
        {
            
            InitializeComponent();
            finalScore = score;
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void GameOver_Load(object sender, EventArgs e)
        {
            labelScore.Text = "Final Score : " + finalScore;
        }

        private void Main_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnQuit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
