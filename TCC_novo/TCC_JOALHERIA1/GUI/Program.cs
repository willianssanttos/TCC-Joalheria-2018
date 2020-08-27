using Ferramentas;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GUI
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new frmTelaSplash());
           /* try
            {
                //frmTelaSplash carrega = new frmTelaSplash();
                //Application.Run(carrega);
                //carrega.Dispose();

                //if (carrega.  )
                {

                    frmLogin frm = new frmLogin();
                    Application.Run(frm);
                    frm.Dispose();
                    //Verifica se o usuário foi autenticado
                    if (SessaoUsuario.Session.Instance.UsuID > 0)
                    {
                        Application.Run(new frmMenu());

                    }
                    else
                    {
                        Application.Exit();
                    }
                }
            }

            catch
            {

            }*/
        }
     }
}
