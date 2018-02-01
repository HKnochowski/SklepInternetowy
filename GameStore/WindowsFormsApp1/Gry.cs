using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WindowsFormsApp1.ServiceReference1;

namespace WindowsFormsApp1
{
    public partial class Gry : Form
    {
        public Gry()
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
            //G.GameId = Convert.ToInt32(textGameID.Text);
            G.GameName = textName.Text;
            G.GameDescription = textDescription.Text;
            G.GamePremiere = Convert.ToDateTime(textPremiere.Text);
            G.GameRating = Convert.ToInt32(textRating.Text);
            G.OrToBuy = Convert.ToBoolean(textOrToBuy.Text);
            //G.GameType = textType.Text;
            G.GameTypeId = Convert.ToInt32(textTypeId.Text);
            G.OrRecommended = Convert.ToBoolean(textBox1.Text);
            G.NameFileBestseller = textBox2.Text;
            G.NameFileNews = textBox3.Text;
            G.NameFileRecomended = textBox4.Text;

            Service1Client service = new Service1Client();

            if (service.InsertGame(G) == 1)
            {
                MessageBox.Show("Gra została dodana");
            }
        }

        private void Aktualizuj_Click(object sender, EventArgs e)
        {
            Game G = new Game()
            {

                //GameId = Convert.ToInt32(textGameID.Text),
                GameName = textName.Text,
                GameDescription = textDescription.Text,
                GamePremiere = Convert.ToDateTime(textPremiere.Text),
                GameRating = Convert.ToInt32(textRating.Text),
                OrToBuy = Convert.ToBoolean(textOrToBuy.Text),
                //GameType = textType.Text,
                GameTypeId = Convert.ToInt32(textTypeId.Text),
                OrRecommended = Convert.ToBoolean(textBox1.Text),
                NameFileBestseller = textBox2.Text,
                NameFileNews = textBox3.Text,
                NameFileRecomended = textBox4.Text,
            };
            //Game G = new Game();
            ////G.GameId = Convert.ToInt32(textGameID.Text);
            //G.GameName = textName.Text;
            //G.GameDescription = textDescription.Text;
            //G.GamePremiere = Convert.ToDateTime(textPremiere.Text);
            //G.GameRating = Convert.ToInt32(textRating.Text);
            //G.OrToBuy = Convert.ToBoolean(textOrToBuy.Text);
            ////G.GameType = textType.Text;
            //G.GameTypeId = Convert.ToInt32(textTypeId.Text);
            //G.OrRecommended = Convert.ToBoolean(textBox1.Text);
            //G.NameFileBestseller = textBox2.Text;
            //G.NameFileNews = textBox3.Text;
            //G.NameFileRecomended = textBox4.Text;




            Service1Client service = new Service1Client();
            if (service.UpdateGame(G) == 1)
            {
                MessageBox.Show("Gra została zaktualizowana");
            }

        }

        private void Delete_Click(object sender, EventArgs e)
        {
            Game G = new Game()
            {
                GameId = Convert.ToInt32(textGameID.Text),
                //GameName = textName.Text,
            };



            Service1Client service = new Service1Client();
            if (service.DeleteGame(G) == 1)
            {
                MessageBox.Show("Gra została usunięta");
            }

        }

        private void Select_Click(object sender, EventArgs e)
        {
            List<Game> GameL = new List<Game>();
            Game G = new Game()
            {
                GameId = Convert.ToInt32(textGameID.Text),
                //GameName = textName.Text,
            };



            Service1Client service = new Service1Client();
            GameL.Add(service.GetGame(G));
            dataGridView1.DataSource = GameL;

        }

        private void SelectAll_Click(object sender, EventArgs e)
        {
            List<Game> gameL = new List<Game>();
            Service1Client service = new Service1Client();


            dataGridView1.DataSource = service.GetAllGame();
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            //this.Hide();
            //Form2 f2 = new Form2();
            //f2.Show();
        }

        private void button1_Click_2(object sender, EventArgs e)
        {
            this.Hide();
            Menu menu = new Menu();
            menu.Show();

        }
    }
}
