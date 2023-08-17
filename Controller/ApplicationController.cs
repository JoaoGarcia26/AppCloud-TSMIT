using System;
using System.Windows.Forms;

namespace AppCloud_TSMIT.Controller
{
    public class ApplicationController
    {
        private readonly ConfigController configController;
        private Form_MenuPrincipal form;
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
                form.appNeoLado.Visible = true;
                form.appAgroLado.Visible = true;
                Console.WriteLine("Agro e Neo visivel");
                VerificaPasta(form);
                form.Show();
            }
            else if (touchComp == true && neo == false && agro == false)
            {
                //IMPLEMENTA O TOUCHCOMP ITEM
                form.appTouchComp.Visible = true;
                Console.WriteLine("Touch Comp visivel");
                VerificaPasta(form);
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
                form.appAgro.Visible = true;
                Console.WriteLine("Agro visivel");
                VerificaPasta(form);
                form.Show();
            }
            else if (neo == true && agro == false && touchComp == false)
            {
                //IMPLEMENTA O NEO ITEM
                form.appNeo.Visible = true;
                Console.WriteLine("Neo visivel");
                VerificaPasta(form);
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
                form.appPastaDesktop.Visible = true;
            }
            else
            {
                form.appPastaDesktop.Visible = false;
            }
        }
    }
}
