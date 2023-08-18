using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;

namespace AppCloud_TSMIT.Controller
{
    public class ApplicationController
    {
        private readonly ConfigController configController;

        private readonly Dictionary<Image, string> imagens = new Dictionary<Image, string>();
        public ApplicationController(ConfigController config)
        {
            configController = config;
        }

        public void VerificaAplicacoes(Form_MenuPrincipal form)
        {
            bool agro = configController.ExistAgro();
            bool neo = configController.ExistNeo();
            bool touchComp = configController.ExistTouchComp();

            if ((agro == true && neo == true && touchComp == false))
            {
                //IMPLEMANTA AGRO E NEO ITEM
                imagens.Add(Image.FromFile(@"C:\Users\João Victor\Documents\GitHub\AppCloud-TSMIT\Assets\neo.png"), "neo");
                imagens.Add(Image.FromFile(@"C:\Users\João Victor\Documents\GitHub\AppCloud-TSMIT\Assets\agro.png"), "agro");
                Console.WriteLine("Agro e Neo visivel");
                VerificaPasta(form);
                AlinhaImagens(form);
                form.Show();
            }
            else if (touchComp == true && neo == false && agro == false)
            {
                //IMPLEMENTA O TOUCHCOMP ITEM
                imagens.Add(Image.FromFile(@"C:\Users\João Victor\Documents\GitHub\AppCloud-TSMIT\Assets\touchComp.png"), "touchComp");
                Console.WriteLine("Touch Comp visivel");
                VerificaPasta(form);
                AlinhaImagens(form);
                form.Show();
            }
            else if (touchComp == true && neo == true && agro == true)
            {
                form.Visible = false;
                MessageBox.Show("Arquivo de configuração incorreto, revise-o", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
            else if (agro == true && neo == false && touchComp == false)
            {
                //IMPLEMENTA O AGRO ITEM
                imagens.Add(Image.FromFile(@"C:\Users\João Victor\Documents\GitHub\AppCloud-TSMIT\Assets\agro.png"), "agro");
                Console.WriteLine("Agro visivel");
                VerificaPasta(form);
                AlinhaImagens(form);
                form.Show();
            }
            else if (neo == true && agro == false && touchComp == false)
            {
                //IMPLEMENTA O NEO ITEM
                imagens.Add(Image.FromFile(@"C:\Users\João Victor\Documents\GitHub\AppCloud-TSMIT\Assets\neo.png"), "neo");
                Console.WriteLine("Neo visivel");
                VerificaPasta(form);
                AlinhaImagens(form);
                form.Show();
            }
            else
            {
                form.Visible = false;
                MessageBox.Show("Arquivo de configuração incorreto, revise-o", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        public void VerificaPasta(Form_MenuPrincipal form)
        {
            bool pastaDesktop = configController.ExistPastaDesktop();
            if (pastaDesktop == true)
            {
                imagens.Add(Image.FromFile(@"C:\Users\João Victor\Documents\GitHub\AppCloud-TSMIT\Assets\pasta.png"), "pasta");
            }
        }

        public void AlinhaImagens(Form_MenuPrincipal form)
        {
            form.painel.Controls.Clear();

            int totalImagens = imagens.Count;
            int painelWidth = form.painel.Width;
            int painelHeight = form.painel.Height;

            int imageWidth = painelWidth / totalImagens;
            int imageHeight = painelHeight;

            int xOffset = 0;

            foreach (var imagemItem in imagens)
            {
                Image imagem = imagemItem.Key;

                PictureBox pictureBox = new PictureBox();
                pictureBox.Image = imagem;
                pictureBox.SizeMode = PictureBoxSizeMode.Zoom;

                pictureBox.Location = new Point(xOffset, 0);
                pictureBox.Size = new Size(imageWidth, imageHeight);

                form.painel.Controls.Add(pictureBox);

                xOffset += imageWidth;
            }
        }
    }
}
