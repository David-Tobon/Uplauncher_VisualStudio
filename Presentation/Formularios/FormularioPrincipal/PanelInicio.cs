using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Runtime.InteropServices;
using FontAwesome.Sharp;
using Common.Cache;
using Presentation.Formularios.FormulariosRecursos.Editar_Perfil;
using System.Diagnostics;
using System.IO;
using System.IO.Compression;
using System.Threading;
using System.Xml;
using Microsoft.VisualBasic.Devices;
using Presentation.Formularios.FormulariosRecursos.Contacto;
using Presentation.Formularios.FormulariosRecursos.Guia;
using Presentation.Formularios.FormulariosRecursos;
using System.Globalization;
using Presentation.Formularios.FormulariosSecundarios.Actualizaciones;
using Presentation.Formularios.FormularioLogin;

namespace Presentation
{

    public partial class PanelInicio : Form
    {

        Computer mycomputer = new Computer();


        private IconButton currentBtn;
        private Panel leftBorderBtn;
        private Form currentChildForm;






        public PanelInicio()
        {
            InitializeComponent();
            ActualizarArchivoVersion();

            LoadUserData();
            //ActualizarJuego();
            


            leftBorderBtn = new Panel();
            leftBorderBtn.Size = new Size(7, 40);
            MenuVertical.Controls.Add(leftBorderBtn);




            //Formulario

            this.MaximizedBounds = Screen.FromHandle(this.Handle).WorkingArea;

        }

        #region Variables de Texto para Descargas
        private WebClient cliente;
        


        private string Host,
            Voltion,
            direccionDescarga, 
            WinrarDescargado, 
            CarpetaDescomprimidaTemporal,
            CarpetaDescomprimidaFinal,
            DireccionArchivoVersion,
            WinrarVersionDescargado,
            CarpetaArchivoVersionTemporal,
            CarpetaArchivoVersionFinal
            
            ;
        #endregion
       

        #region Actualizar Archivo Version
        private void ActualizarArchivoVersion()
        {
            cliente = new WebClient();
            cliente.DownloadFileCompleted += new AsyncCompletedEventHandler(VersionDescargada);
            cliente.DownloadProgressChanged += new DownloadProgressChangedEventHandler(VersionCargando);

            /*| Leer Link del Host |*/

            TextReader LinkHost = new StreamReader("LinkHost");
            Host = LinkHost.ReadLine();



            /*| ------------------ |*/


            DireccionArchivoVersion = Host+"Version.zip";
            WinrarVersionDescargado = (Application.StartupPath + "/cache/Version.zip");
            CarpetaArchivoVersionTemporal = (Application.StartupPath + "/cache");
            CarpetaArchivoVersionFinal = (Application.StartupPath);

            cliente.DownloadFileAsync(new Uri(DireccionArchivoVersion), WinrarVersionDescargado);



        }
        private void VersionCargando(object sender, DownloadProgressChangedEventArgs e)
        {
            lblDescargando.Text = "Descargando Archivo de Version";
            BarraProgresoColor.Value = e.ProgressPercentage;
        }

        private void VersionDescargada(object sender, AsyncCompletedEventArgs e)
        {
            BarraProgresoColor.Value = 100;
            ZipFile.ExtractToDirectory(WinrarVersionDescargado, CarpetaArchivoVersionTemporal);

            mycomputer.FileSystem.MoveDirectory(CarpetaArchivoVersionTemporal, CarpetaArchivoVersionFinal, true);
            mycomputer.FileSystem.CreateDirectory("cache");
            
            
            ActualizarJuego();

        }




        #endregion

        
        #region Actualizar El Juego
        private void ActualizarJuego()
        {
            cliente = new WebClient();
            cliente.DownloadFileCompleted += new AsyncCompletedEventHandler(cargado);
            cliente.DownloadProgressChanged += new DownloadProgressChangedEventHandler(cargando);


            #region  | Leer archivos de links | 

            /*| Leer Link del Host |*/

            TextReader LinkHost = new StreamReader("LinkHost");
            Host = LinkHost.ReadLine();
            


            /*| ------------------ |*/

            /*| Leer Version Voltion |*/

            TextReader VersionVoltion = new StreamReader("Version");
            Voltion = VersionVoltion.ReadLine();

            /*| ------------------ |*/
            #endregion

            #region |Descargar actualizaciones del Juego |

            /*| Descargar el Juego |*/
            direccionDescarga = Host +"Voltion_" + Voltion + ".zip";
            WinrarDescargado = (Application.StartupPath + "/app/Versiones/Voltion_" + Voltion + ".zip");
            CarpetaDescomprimidaTemporal = (Application.StartupPath + "/app/Versiones/temp/");
            CarpetaDescomprimidaFinal = (Application.StartupPath);

            if (!File.Exists(WinrarDescargado))
            {

                cliente.DownloadFileAsync(new Uri(direccionDescarga), WinrarDescargado);
                lblVersionVoltion.Text = "Voltion Versión:  " + Voltion + ".";

                BarraProgresoColor.Value = 0;
            }
            else
            {
                btnJugar.Enabled = true;
                BarraProgresoColor.Enabled = false;
                BarraProgresoColor.Value = 100;


                lblDescargando.Text = "Voltion actualizado a la Ultima Version: " + Voltion;
                lblVersionVoltion.Text = "Voltion Versión:  " + Voltion + ".";
            }

            /*| ------------------ |*/
            #endregion



        }



        private void cargando(object sender, DownloadProgressChangedEventArgs e)
        {
            BarraProgresoColor.Value = e.ProgressPercentage;
            lblDescargando.Text = "Descargando la Version de Dofus Voltion: " + Voltion;


        }

        private void cargado(object sender, AsyncCompletedEventArgs e)
        {



            BarraProgresoColor.Value = 100;
            lblDescargando.Text = "Descarga de la Ultima Version Dofus Voltion Completa: " + Voltion;
                btnJugar.Enabled = true;


                   ZipFile.ExtractToDirectory(WinrarDescargado, CarpetaDescomprimidaTemporal);
           
            //mycomputer.FileSystem.MoveDirectory(CarpetaDescomprimidaTemporal, CarpetaDescomprimidaFinal);
            mycomputer.FileSystem.MoveDirectory(CarpetaDescomprimidaTemporal, CarpetaDescomprimidaFinal, true);
            lblVersionVoltion.Text = "Voltion Versión:  " + Voltion + ".";






        }


        #endregion


        #region Cargar Datos de Usuario
        private void LoadUserData()
        {

            
            if (UserLoginCache.Login != null) 
            {
                btnIngreso.Visible = false;
                btnAccount.Visible = true;
                //icnLogout.Visible = true;
                lblUsuario.Visible = true;
                lblUserGroup.Visible = true;
                icnUsuario.Visible = true;
                lblFecha.Visible = true;
                lblFecha1.Visible = true;
                lblUltConexion.Visible = true;
                lblUltConexion1.Visible = true;
                lblUltimaIP.Visible = true;
                lblUltimaIP1.Visible = true;



                lblUltimaIP1.Text = UserLoginCache.LastConnectedIp;
                lblUsuario.Text = UserLoginCache.NickName;

                lblUltConexion1.Text = UserLoginCache.LastConnection.ToString();  
                lblFecha1.Text = UserLoginCache.CreationDate.ToString();

                
                MemoryStream ms = new MemoryStream(UserLoginCache.Imagen);
                Bitmap bm = new Bitmap(ms);
                imagenInicio.Image = bm;

                if (UserLoginCache.UserGroupId == 1)
                {
                    lblUserGroup.Text = "Usuario";
                    lblUserGroup.ForeColor = Color.GreenYellow;
                    imagenInicio.BorderColor = Color.GreenYellow;
                    imagenInicio.BorderColor2 = Color.Green;
                }
                if (UserLoginCache.UserGroupId == 2)
                {
                    lblUserGroup.Text = "[VIP]";
                    lblUserGroup.ForeColor = Color.Gold;

                    imagenInicio.BorderColor = Color.Gold;
                    imagenInicio.BorderColor2 = Color.GreenYellow;

                }
                if (UserLoginCache.UserGroupId >= 3)
                {
                    lblUserGroup.Text = "[Administrador]";
                    lblUserGroup.ForeColor = Color.Red;

                    imagenInicio.BorderColor = Color.Red;
                    imagenInicio.BorderColor2 = Color.IndianRed;


                }


            }
        }
        #endregion


        #region Botones de Colores

        private void ActivateButton(object senderBtn, Color color)
        {
            if (senderBtn != null)
            {
                DisableButton();

                //Boton
                currentBtn = (IconButton)senderBtn;
                currentBtn.BackColor = Color.FromArgb(52, 55, 60);
                currentBtn.ForeColor = color;
                currentBtn.TextAlign = ContentAlignment.MiddleCenter;
                currentBtn.IconColor = color;
                currentBtn.TextImageRelation = TextImageRelation.TextBeforeImage;
                currentBtn.ImageAlign = ContentAlignment.MiddleRight;

                // Borde Izquierdo Boton
                leftBorderBtn.BackColor = color;
                leftBorderBtn.Location = new Point(0, currentBtn.Location.Y);
                leftBorderBtn.Visible = true;
                leftBorderBtn.BringToFront();

                // Icono Titulo Principal
                iconCurrentChildForm.IconChar = currentBtn.IconChar;
                iconCurrentChildForm.IconColor = color;





            }
        }

        private void DisableButton()
        {
            if (currentBtn != null)
            {
                currentBtn.BackColor = Color.FromArgb(47, 49, 54);
                currentBtn.ForeColor = Color.Silver;
                currentBtn.TextAlign = ContentAlignment.MiddleLeft;
                currentBtn.IconColor = Color.Silver;
                currentBtn.TextImageRelation = TextImageRelation.ImageBeforeText;
                currentBtn.ImageAlign = ContentAlignment.MiddleLeft;
            }
        }
        #endregion


        #region Arrastre del Panel

        //Importar Librerias de Arrastre del Panel
        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();
        [DllImport("user32.DLL", EntryPoint = "SendMessage")]
        private extern static void SendMessage(System.IntPtr hwnd, int wmsg, int wparam, int lparam);

        private void BarraTitulo_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }

        #endregion


        #region Abrir Formulario Hijo
        private void AbrirFormularioEnPanel(Object FormHijo)
        {
            if (this.PanelDeskop.Controls.Count > 0)

                this.PanelDeskop.Controls.RemoveAt(0);
            Form fh = FormHijo as Form;
            fh.TopLevel = false;
            fh.Dock = DockStyle.Fill;

            this.PanelDeskop.Controls.Add(fh);
            this.PanelDeskop.Tag = fh;
            fh.Show();
        }

       private void OpenChildForm(Form childForm)
        {
            if (currentChildForm != null)
            {
                currentChildForm.Close();
            }
            currentChildForm = childForm;
            childForm.TopLevel = false;
            childForm.FormBorderStyle = FormBorderStyle.None;
            childForm.Dock = DockStyle.Fill;
            PanelDeskop.Controls.Add(childForm);
            PanelDeskop.Tag = childForm;
            childForm.BringToFront();
            childForm.Show();
            //lblTitleChildForm.Text = currentBtn.Text;

        }
        #endregion


        #region Clic en Botones 

        private void Reset()
        {
            DisableButton();
            leftBorderBtn.Visible = false;

            iconCurrentChildForm.IconChar = IconChar.Home;
            iconCurrentChildForm.IconColor = Color.Silver;
            lblTitleChildForm.Text = "Inicio";
        }


        private void btnPlay_Click(object sender, EventArgs e)
        {
            

            
        }
        private void btnIngreso_Click(object sender, EventArgs e)
        {
            ActivateButton(sender, Color.GreenYellow);



            //Form FormBG = new Form();
            //using (PanelLogin panelLogin = new PanelLogin())
            {
                lblTitleChildForm.Text = currentBtn.Text;
                PanelLogin panelLogin = new PanelLogin();
                panelLogin.ShowDialog();

                this.Hide();
                /* FormBG.StartPosition = FormStartPosition.Manual;
                FormBG.FormBorderStyle = FormBorderStyle.None;
                FormBG.Opacity = .70d;
                FormBG.BackColor = Color.Black;
                FormBG.WindowState = FormWindowState.Maximized;
                FormBG.TopMost = true;
                FormBG.Location = this.Location;
                FormBG.ShowInTaskbar = false;
                FormBG.Show();
                 //panelLogin.Owner = FormBG;
                 //FormBG.Dispose();
                */



            }
            
        }
        private void btnHome_Click(object sender, EventArgs e)
        {
            ActivateButton(sender, Color.Silver);
            lblTitleChildForm.Text = currentBtn.Text;

            if (currentChildForm != null)
            {
                currentChildForm.Close();
            }
        }

        private void btnActualizaciones_Click(object sender, EventArgs e)
        {
            ActivateButton(sender, Color.Silver);
            lblTitleChildForm.Text = currentBtn.Text;
            OpenChildForm(new FormActualizaciones());
 
        }

        private void btnshop_Click(object sender, EventArgs e)
        {
            ActivateButton(sender, Color.Silver);
            lblTitleChildForm.Text = currentBtn.Text;
            OpenChildForm(new FormTienda());
        }

        private void btnguia_Click(object sender, EventArgs e)
        {
            ActivateButton(sender, Color.Silver);
            lblTitleChildForm.Text = currentBtn.Text;
            OpenChildForm(new FormGuia());
        }

        private void btnAccount_Click(object sender, EventArgs e)
        {
            ActivateButton(sender, Color.Silver);
            lblTitleChildForm.Text = currentBtn.Text;
            
        }

        private void btnContacto_Click(object sender, EventArgs e)
        {
            ActivateButton(sender, Color.Silver);
            lblTitleChildForm.Text = currentBtn.Text;
            OpenChildForm(new FormContacto());
        }

       

        private void btnguia_Click_1(object sender, EventArgs e)
        {
            ActivateButton(sender, Color.Silver);
            lblTitleChildForm.Text = currentBtn.Text;
            OpenChildForm(new FormGuia());

        }

        private void btnAccount_Click_1(object sender, EventArgs e)
        {
            ActivateButton(sender, Color.Silver);
            OpenChildForm(new FormEditProfile());
            lblTitleChildForm.Text = currentBtn.Text;
        }
        private void icnUsuario_Click(object sender, EventArgs e)
        {
            OpenChildForm(new FormEditProfile());
        }
        private int angulo = 1;
       
        
        private void timerHoraFecha_Tick(object sender, EventArgs e)
        {
            hora.Text = DateTime.Now.ToString("HH:mm:ss");
            fecha.Text = DateTime.Now.ToLongDateString();
             
            
        }

        private void btnJugar_Click(object sender, EventArgs e)
        {
            Process.Start(Application.StartupPath + "/app/Dofus.exe");
           // Process.Start(Application.StartupPath + "/app/reg/Reg.exe");
        }

        private void iconButton1_Click(object sender, EventArgs e)
        {
            ActivateButton(sender, Color.Silver);

            lblTitleChildForm.Text = currentBtn.Text;
            PanelRegistro  panelRegistro = new PanelRegistro();
            panelRegistro.ShowDialog();

            this.Hide();
        }

        private void ColorCirculo_Tick(object sender, EventArgs e)
        {
            imagenInicio.GradientAngle = angulo + DateTime.Now.Millisecond; 

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            if (currentChildForm != null)
            {
                currentChildForm.Close();
            }
            
            Reset();
        }
        private void NombrePlantala_Click(object sender, EventArgs e)
        {
            if (currentChildForm != null)
            {
                currentChildForm.Close();
            }


            Reset();
        }

        public int NodesCount
        {
            get;
            set;
        }
        private void CopiarCarpeta_DoWork(object sender, DoWorkEventArgs e)
        {
            
        
        
           }
        #endregion


        #region Botones Cerrar 
        private void btnClose_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void iconPictureBox2_Click(object sender, EventArgs e)
        {
            if (this.WindowState == FormWindowState.Maximized)
            {
                this.WindowState = FormWindowState.Normal;
            }
            else
            {
                this.WindowState = FormWindowState.Maximized;
            }
        }

        private void iconPictureBox3_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        

        private void icnLogout_Click(object sender, EventArgs e)
        {
            if(MessageBox.Show("Para Evitar intermitencias en la Conexión de datos, es recomendable iniciar la aplicacion nuevamente para volver a iniciar sesión, cualquier descarga en curso se cancelará. ¿Quiere Cerrar la Aplicación?","Atención",MessageBoxButtons.YesNo, MessageBoxIcon.Question)== DialogResult.Yes)
                Application.Exit();
        }


        #endregion

        
    }
}

