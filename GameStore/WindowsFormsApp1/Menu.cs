using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class Menu : Form
    {
        public Menu()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
            Addresses addresses = new Addresses();
            addresses.Show();
        }

        private void buttonExit_Click(object sender, EventArgs e)
        {
            this.Close();
            FormLogin formLogin = new FormLogin();
            formLogin.Show();
            
            
        }

        private void buttonGame_Click(object sender, EventArgs e)
        {
            this.Close();
            Gry gry = new Gry();
            gry.Show();
        }

        private void buttonBasket_Click(object sender, EventArgs e)
        {
            this.Hide();
            Baskets baskets = new Baskets();
            baskets.Show();
        }

        private void buttonClient_Click(object sender, EventArgs e)
        {
            this.Hide();
            Clients clients = new Clients();
            clients.Show();
        }

        private void buttonContact_Click(object sender, EventArgs e)
        {
            this.Hide();
            Contacts contacts = new Contacts();
            contacts.Show();
        }

        private void buttonCopie_Click(object sender, EventArgs e)
        {
            this.Hide();
            Copies copies = new Copies();
            copies.Show();
        }

        private void buttonEmployer_Click(object sender, EventArgs e)
        {
            this.Hide();
            Employers employers = new Employers();
            employers.Show();
        }

        private void buttonGallery_Click(object sender, EventArgs e)
        {
            this.Hide();
            Gallery gallery = new Gallery();
            gallery.Show();
        }

        private void buttonGameLanguage_Click(object sender, EventArgs e)
        {
            this.Hide();
            GameLanguage gameLanguage = new GameLanguage();
            gameLanguage.Show();
        }

        private void buttonGamePublisher_Click(object sender, EventArgs e)
        {
            this.Hide();
            GamePublisher gamePublisher = new GamePublisher();
            gamePublisher.Show();
        }

        private void buttonGameType_Click(object sender, EventArgs e)
        {
            this.Hide();
            GameType gameType = new GameType();
            gameType.Show();
        }

        private void buttonImage_Click(object sender, EventArgs e)
        {
            this.Hide();
            Image image = new Image();
            image.Show();
        }

        private void buttonPlatform_Click(object sender, EventArgs e)
        {
            this.Hide();
            Platform platform = new Platform();
            platform.Show();
        }

        private void buttonPlatformType_Click(object sender, EventArgs e)
        {
            this.Hide();
            PlatformType platformType = new PlatformType();
            platformType.Show();
        }

        private void buttonSalesInvoice_Click(object sender, EventArgs e)
        {
            this.Hide();
            SalesInvoice salesInvoice = new SalesInvoice();
            salesInvoice.Show();
        }

        private void buttonState_Click(object sender, EventArgs e)
        {
            this.Hide();
            State state = new State();
            state.Show();
        }

        private void buttonSystemRequir_Click(object sender, EventArgs e)
        {
            this.Hide();
            SystemRequir systemRequir = new SystemRequir();
            systemRequir.Show();
        }

        private void buttonVideo_Click(object sender, EventArgs e)
        {
            this.Hide();
            Video video = new Video();
            video.Show();
        }

        private void buttonWishList_Click(object sender, EventArgs e)
        {
            this.Hide();
            WishList wishList = new WishList();
            wishList.Show();
        }
    }
}
