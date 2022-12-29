using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Runtime.InteropServices;
using Domain;

using System.Security.Cryptography;
using System.Globalization;
using Presentation.Formularios.FormularioLogin;

namespace Presentation
{
    public partial class PanelLogin : Form
    {
        public PanelLogin()
        {
            InitializeComponent();
        }


        #region Clic Botones
        private void NombrePlantala_Click(object sender, EventArgs e)
        {

        }
        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            PanelRecuperarClave panelRecuperarClave = new PanelRecuperarClave();
            panelRecuperarClave.Show();
            this.Hide();
        }

        private void lblCreateAccount_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            PanelRegistro panelRegistro = new PanelRegistro();
            panelRegistro.Show();
            this.Hide();
        }
        private void btnClose_Click(object sender, EventArgs e)
        {
            PanelInicio panelInicio = new PanelInicio();
            panelInicio.Show();
            this.Hide();

        }

        private void iconButton1_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void PanelLogin_Load(object sender, EventArgs e)
        {

        }



        private void txtUser_Enter(object sender, EventArgs e)
        {
            if (txtUser.Text == "USUARIO")
            {
                txtUser.Text = "";
                txtUser.ForeColor = Color.LightGray;
            }

        }

        private void txtUser_Leave(object sender, EventArgs e)
        {
            if (txtUser.Text == "")

            {
                txtUser.Text = "USUARIO";
                txtUser.ForeColor = Color.Gray;
            }
        }

        private void txtPass_Enter(object sender, EventArgs e)
        {
            if (txtPass.Text == "CONTRASEÑA")
            {
                txtPass.Text = "";
                txtPass.ForeColor = Color.LightGray;
                txtPass.UseSystemPasswordChar = true;
            }
        }

        private void txtPass_Leave(object sender, EventArgs e)
        {
            if (txtPass.Text == "")

            {
                txtPass.Text = "CONTRASEÑA";
                txtPass.ForeColor = Color.Gray;
                txtPass.UseSystemPasswordChar = false;
            }
        }




        #endregion

        #region Arrastre del Panel

        //Importar Librerias de Arrastre del Panel
        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();
        [DllImport("user32.DLL", EntryPoint = "SendMessage")]
        private extern static void SendMessage(System.IntPtr hwnd, int wmsg, int wparam, int lparam);
        private void pictureBox1_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }


        #endregion


        #region Acesso a MySql

        private void btnlogin_Click(object sender, EventArgs e)
        {
            LoadUserData();

        }
       


        private void Logout(object sender, FormClosedEventArgs e)
        {
            txtPass.Clear();
            txtUser.Clear();
            lblErrorMessage.Visible = false;
            txtUser.Focus();

            this.Show();


        }
        private void msgError(String msg)
        {
            lblErrorMessage.Text = msg;
            lblErrorMessage.Visible = true;
            icnErrorMessage.Visible = true;
        }




        #endregion

        #region Encriptar a Md5

        public static string GetMD5Hash(string input)
        {
            var md5Hasher = MD5.Create();
            byte[] data = md5Hasher.ComputeHash(Encoding.Default.GetBytes(input));

            var sBuilder = new StringBuilder();

            foreach (var t in data)
            {
                sBuilder.Append(t.ToString("x2", CultureInfo.CurrentCulture));
            }

            return sBuilder.ToString();
        }
        public static string Encriptar(string CadenaEncriptar)
        {
            byte[] byteAEncriptar;
            byte[] byteEncriptados;
            string sResultado;


            try
            {

                if (CadenaEncriptar.Trim() == "")
                {
                    sResultado = "";

                }
                else
                {
                    // Convertir a Bytes el Texto
                    byteAEncriptar = Encoding.Unicode.GetBytes(CadenaEncriptar);
                    // Encriptar con MD5 el texto
                    byteEncriptados = MD5.Create().ComputeHash(byteAEncriptar);
                    // Convertir a Bytes el texto base
                    sResultado = Convert.ToBase64String(byteEncriptados);

                }
                return sResultado;
            }
            catch (Exception)
            {
                throw;
            }


        }



        #endregion


        private void LoadUserData()
        {
            if (txtUser.Text != "USUARIO")
            {
                if (txtPass.Text != "CONTRASEÑA")
                {
                    UserModel user = new UserModel();
                    // EncriptarMD5 encriptarMD5 = new EncriptarMD5();

                    var validLogin = user.LoginUser(
                        txtUser.Text,
                      txtPass.Text);

                    if (validLogin == true)
                    {
                        PanelInicio panelInicio = new PanelInicio();



                        panelInicio.Show();
                        panelInicio.FormClosed += Logout;
                        this.Hide();


                    }
                    else
                    {
                        msgError("Nombre de Usuario o Contraseña Incorrectos.");
                        txtPass.Clear();
                        txtPass.Focus();

                    }
                }
                else
                {
                    msgError("Por favor ingresa una Contraseña");
                }
            }
            else
            {
                msgError("Por favor ingresa un Usuario");
            }
        }

        
    }
}

