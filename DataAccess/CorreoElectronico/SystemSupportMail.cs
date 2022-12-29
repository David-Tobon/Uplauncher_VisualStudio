using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DiseñoIconos.CorreoElectronico
{
    class SystemSupportMail:MasterMailServer
    {
        public SystemSupportMail()
        {
            senderMail = "email";
            password = "contraseña";
            host = "smtp.gmail.com";
            port = 587;
            ssl = true;

            IniatilizeSmtpClient();


        }



    }
}
