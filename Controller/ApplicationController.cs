using AppCloud_TSMIT.Dominio;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;

namespace AppCloud_TSMIT.Controller
{
    public class ApplicationController
    {
        private readonly ConfigController configController;
        public readonly Dictionary<Image, string> imagens = new Dictionary<Image, string>();
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
                imagens.Add(Image.FromFile(@"C:\Users\João Victor\Documents\GitHub\AppCloud-TSMIT\Assets\touchComp.png"), "touchcomp");
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
                imagens.Add(Image.FromFile(@"C:\Users\João Victor\Documents\GitHub\AppCloud-TSMIT\Assets\pasta.png"), "pastaDesktop");
                AlinhaImagens(form);
            }
        }
        public void AlinhaImagens(Form_MenuPrincipal form)
        {
            form.painel.Controls.Clear();

            int totalImagens = imagens.Count;
            int painelWidth = form.painel.Width;
            int painelHeight = form.painel.Height;
            int tamanhoColuna;
            int colunaPrincipal;
            int xOffset;

            if (totalImagens == 1)
            {
                //CASO 1 IMAGEM, IRÁ PARTIR O PAINEL EM 3 E SETAR A IMAGEM NA SEGUNDA COLUNA
                tamanhoColuna = painelWidth / 3;
                colunaPrincipal = tamanhoColuna;
                xOffset = tamanhoColuna;

            } else
            {
                colunaPrincipal = painelWidth / totalImagens;
                xOffset = 0;
            }
            
            int imageHeight = painelHeight;

            foreach (var imagemItem in imagens)
            {
                if (imagemItem.Value == "agro")
                {
                    form.agroImg.Image = imagemItem.Key;
                    form.agroImg.SizeMode = PictureBoxSizeMode.Zoom;

                    form.agroImg.Location = new Point(xOffset, 0);
                    form.agroImg.Size = new Size(colunaPrincipal, imageHeight);
                    form.agroImg.Tag = imagemItem.Value;

                    form.painel.Controls.Add(form.agroImg);
                } else if (imagemItem.Value == "neo")
                {
                    form.neoImg.Image = imagemItem.Key;
                    form.neoImg.SizeMode = PictureBoxSizeMode.Zoom;

                    form.neoImg.Location = new Point(xOffset, 0);
                    form.neoImg.Size = new Size(colunaPrincipal, imageHeight);
                    form.neoImg.Tag = imagemItem.Value;

                    form.painel.Controls.Add(form.neoImg);
                } else if (imagemItem.Value == "touchcomp")
                {
                    form.touchImg.Image = imagemItem.Key;
                    form.touchImg.SizeMode = PictureBoxSizeMode.Zoom;

                    form.touchImg.Location = new Point(xOffset, 0);
                    form.touchImg.Size = new Size(colunaPrincipal, imageHeight);
                    form.touchImg.Tag = imagemItem.Value;

                    form.painel.Controls.Add(form.touchImg);

                } else if (imagemItem.Value == "pastaDesktop")
                {
                    form.pastaDesktopImg.Image = imagemItem.Key;
                    form.pastaDesktopImg.SizeMode = PictureBoxSizeMode.Zoom;

                    form.pastaDesktopImg.Location = new Point(xOffset, 0);
                    form.pastaDesktopImg.Size = new Size(colunaPrincipal, imageHeight);
                    form.pastaDesktopImg.Tag = imagemItem.Value;

                    form.painel.Controls.Add(form.pastaDesktopImg);
                }
                xOffset += colunaPrincipal;
            }
        }
    }
}
