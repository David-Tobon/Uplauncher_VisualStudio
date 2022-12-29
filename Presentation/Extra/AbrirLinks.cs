using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Diagnostics;
using System.Windows.Forms;

namespace Presentation.Extra
{
    public class AbrirLinks
    {
        #region |Abrir Discord|

        public void AbrirDiscord()
        {
            var p = new Process();
            p.StartInfo = new ProcessStartInfo(Application.StartupPath + "/app/Recursos/Links/Discord.url")
            {
                UseShellExecute = true
            };
            p.Start();
        }



        #endregion

        #region |Abrir Whatsapp|

        public void AbrirGrupoWhatsapp()
        {
            var p = new Process();
            p.StartInfo = new ProcessStartInfo(Application.StartupPath + "/app/Recursos/Links/WhatsApp.url")
            {
                UseShellExecute = true
            };
            p.Start();
        }

        public void AbrirWhatsappDavid()
        {
            var p = new Process();
            p.StartInfo = new ProcessStartInfo(Application.StartupPath + "/app/Recursos/Links/Tienda.url")
            {
                UseShellExecute = true
            };
            p.Start();
        }

        public void AbrirWhatsappTrejos()
        {
            var p = new Process();
            p.StartInfo = new ProcessStartInfo(Application.StartupPath + "/app/Recursos/Links/Tienda1.url")
            {
                UseShellExecute = true
            };
            p.Start();
        }

        #endregion

        #region |Abrir Facebook|

        public void AbrirFacebook()
        {
            var p = new Process();
            p.StartInfo = new ProcessStartInfo(Application.StartupPath + "/app/Recursos/Links/Facebook.url")
            {
                UseShellExecute = true
            };
            p.Start();
        }


        #endregion




    }
}
