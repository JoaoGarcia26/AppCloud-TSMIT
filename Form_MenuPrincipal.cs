using AppCloud_TSMIT.Dominio;
using System;
using System.Windows.Forms;
using AppCloud_TSMIT.Controller;

namespace AppCloud_TSMIT
{
    public partial class Form_MenuPrincipal : Form
    {

        private readonly Host host;
        private readonly Usuario usuario;
        private readonly Form_MenuLogin formLogin;
        private readonly ApplicationController appController;
        
        public Form_MenuPrincipal()
        {
            InitializeComponent();

        }
        public Form_MenuPrincipal(Host host, Usuario usuario, Form_MenuLogin formLogin, ApplicationController appController)
        {
            InitializeComponent();
            this.host = host;
            this.usuario = usuario;
            this.formLogin = formLogin;
            this.appController = appController;
        }
        private void Form_MenuPrincipal_Load(object sender, EventArgs e)
        {
            formLogin.Visible = false;
        }

        private void Form_MenuPrincipal_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }
        private void Image_DoubleClick(object sender, EventArgs e)
        {
            PictureBox clickedImage = sender as PictureBox;

            if (clickedImage != null)
            {
                string imageValue = clickedImage.Tag.ToString();

                switch (imageValue)
                {
                    case "agro":
                        ProcessController.ChamadaDoProcessoAppController(host, usuario, "Agro");
                        break;

                    case "neo":
                        ProcessController.ChamadaDoProcessoAppController(host, usuario, "Neo");
                        break;

                    case "touchcomp":
                        ProcessController.ChamadaDoProcessoAppController(host, usuario, "TouchComp");
                        break;

                    case "pastaDesktop":
                        ProcessController.ChamadaDoProcessoAppController(host, usuario, "Desktop");
                        break;

                    default:
                        break;
                }
            }
        }
    }
}
