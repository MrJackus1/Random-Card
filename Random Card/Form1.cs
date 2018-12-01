using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Random_Card
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void btnGetCard_Click(object sender, EventArgs e)
        {
            Random card = new Random();
            Random suit = new Random();
            CardClass Card = new CardClass();

            int rCard = card.Next(1, 13);
            int rSuit = suit.Next(1, 4);

            label1.Text = Card.Carding(rCard, rSuit);
        }
    }
}
