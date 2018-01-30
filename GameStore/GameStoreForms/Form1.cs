using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using GameStoreForms.ServiceReference1;
using GameStoreForms;

namespace GameStoreForms
{
    public partial class GameForm : Form
    {
        public GameForm()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox12_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Game G = new Game();
            G.GameId = Convert.ToInt32(textId.Text);
            G.GameName = textName.Text;
            G.GameDescription = textDescription.Text;
            G.GamePremiere = Convert.ToDateTime(textPremiere.Text);
            G.GameRating = Convert.ToInt32(textRating.Text); ;
            G.OrToBuy = Convert.ToBoolean(textOrToBuy.Text);
            //G.GameType = textType.Text;
            G.GameTypeId = Convert.ToInt32(textTypeId.Text); ;

            Service1Client service = new Service1Client();

            if (service.InsertGame(G) == 1)
            {
                MessageBox.Show("Gra dodana");
            }
        }
    }
}
