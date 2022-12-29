using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Imaging;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Common.Cache;
using Domain;

namespace Presentation.Formularios.FormulariosRecursos.Editar_Perfil
{
    public partial class FormEditProfile : Form
    {
        public FormEditProfile()
        {
            InitializeComponent();
            LoadUserData();

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }





        #region Boton Abrir panel Edicion

        private void btnEdit_Click(object sender, EventArgs e)
        {
            btnEdit.Visible = false;
            btnEditClose.Visible = true;
            panelEditar.Visible = true;
        }

        private void btnEditClose_Click(object sender, EventArgs e)
        {
            btnEdit.Visible = true;
            btnEditClose.Visible = false;
            panelEditar.Visible = false;
        }

        #endregion



        #region Link Label Cambiar Contraseña
        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            if (linklabelEditarClave.Text == "[Cambiar Contraseña]")

            {
                linklabelEditarClave.Text = "[Cancelar]";
                CargarLabelNuevaContraseña();

            }

            else if (linklabelEditarClave.Text == "[Cancelar]")
            {

                CancelarLabelNuevaContraseña();
            }






        }


        #endregion

        #region Cargar Datos de Usuario en Caché
        private void LoadUserData()
        {

            if (UserLoginCache.Login != null)
            {

                //Labels Panel Vista 
                lblApodo.Text = UserLoginCache.NickName;
                lblLogin.Text = UserLoginCache.Login;
                lblEmail.Text = UserLoginCache.Email;
                lblPregunta.Text = UserLoginCache.SecretQuestion;
                lblUltimaIP.Text = UserLoginCache.LastConnectedIp;
                lblFechaCreacion.Text = UserLoginCache.CreationDate.ToString();
                lblUltimaConexion.Text = UserLoginCache.LastConnection.ToString();

                //TextBox Panel Edicion
                txtUser.Text = UserLoginCache.Login;
                txtApodo.Text = UserLoginCache.NickName;
                txtEmail.Text = UserLoginCache.Email;
                txtPregunta.Text = UserLoginCache.SecretQuestion;
                txtRespuesta.Text = UserLoginCache.SecretAnswer;
                txtNuevaContraseña.Text = UserLoginCache.PasswordHash;
                txtConfirmarNuevaContraseña.Text = UserLoginCache.PasswordHash;

                txtContraseña.UseSystemPasswordChar = true;
                txtNuevaContraseña.UseSystemPasswordChar = true;
                txtConfirmarNuevaContraseña.UseSystemPasswordChar = true;
                MemoryStream ms = new MemoryStream(UserLoginCache.Imagen);
                Bitmap bm = new Bitmap(ms);
                imagenCuenta.Image = bm;

                if (UserLoginCache.UserGroupId == 1)
                {
                    lblLogin.Text = "Usuario";
                    lblLogin.ForeColor = Color.GreenYellow;
                }
                if (UserLoginCache.UserGroupId == 2)
                {
                    lblLogin.Text = "[VIP]";
                    lblLogin.ForeColor = Color.Gold;
                }
                if (UserLoginCache.UserGroupId >= 3)
                {
                    lblLogin.Text = "[Administrador]";
                    lblLogin.ForeColor = Color.Red;
                }

            }








        }

        #endregion

        #region Label Nueva Contraseña
        private void CargarLabelNuevaContraseña()
        {


            txtNuevaContraseña.Enabled = true;
            txtConfirmarNuevaContraseña.Enabled = true;

            txtNuevaContraseña.Visible = true;
            txtConfirmarNuevaContraseña.Visible = true;
            linea1.Visible = true;
            linea2.Visible = true;
            lblConfirmarContraseña.Visible = true;
            lblContraseñaAnterior.Visible = true;
            
        }


        private void CancelarLabelNuevaContraseña()
        {

            linklabelEditarClave.Text = "[Cambiar Contraseña]";
            txtNuevaContraseña.Enabled = false;
            txtConfirmarNuevaContraseña.Enabled = false;

            txtNuevaContraseña.Visible = false;
            txtConfirmarNuevaContraseña.Visible = false;
            linea1.Visible = false;
            linea2.Visible = false;
            lblConfirmarContraseña.Visible = false;
            lblContraseñaAnterior.Visible = false;
            txtContraseña.Text = "";

        }
        #endregion
        #region Reset 
        private void reset()
        {
            LoadUserData();
            CancelarLabelNuevaContraseña();

        }

        #endregion

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            MemoryStream ms = new MemoryStream();
            imagenCuenta.Image.Save(ms, ImageFormat.Png);

            byte[] aByte = ms.ToArray();

            if (txtContraseña.Text == "")
            {
                MessageBox.Show("Por Favor ingresa tu contraseña para actualizar el perfil");


            }

            if (txtNuevaContraseña.Text.Length >= 4)
            {
                if (txtNuevaContraseña.Text == txtConfirmarNuevaContraseña.Text)
                {
                    if (txtContraseña.Text == UserLoginCache.PasswordHash)
                    {
                        var UserModel = new UserModel(
                                  id: UserLoginCache.Id,
                                  login: txtUser.Text,
                                  passwordHash: txtNuevaContraseña.Text,
                                  nickname: txtApodo.Text,
                                  secretQuestion: txtPregunta.Text,
                                  secretAnswer: txtRespuesta.Text,
                                  email: txtEmail.Text,
                                  imagen: aByte
                                  );
                        var result = UserModel.editUserProfile();
                        MessageBox.Show(result);
                        MessageBox.Show("Sí cambiaste la imagen de perfil, los cambios serán aplicados una vez vuelva a iniciar sesión, disculpa las molestias ocasionadas... <3");
                        reset();
                    }
                    else MessageBox.Show("Contraseña Incorrecta");
                }
                else MessageBox.Show("Las contraseñas no Coinciden, intentalo de nuevo");

            }
            else MessageBox.Show("La Nueva Contraseña debe tener almenos 4 caracteres.");

          
        }

        private void btnViewPass_Click(object sender, EventArgs e)
        {

            btnOcultarPass.Visible = true;
            btnViewPass.Visible = false;
                txtContraseña.UseSystemPasswordChar = false;
               // txtNuevaContraseña.UseSystemPasswordChar = false;
               // txtConfirmarNuevaContraseña.UseSystemPasswordChar = false;
            
           
               
                
            
            
        }

        private void btnOcultarPass_Click(object sender, EventArgs e)
        {
            btnViewPass.Visible = true;
            btnOcultarPass.Visible = false;
            txtContraseña.UseSystemPasswordChar = true;
           // txtNuevaContraseña.UseSystemPasswordChar = true;
           // txtConfirmarNuevaContraseña.UseSystemPasswordChar = true;
        }

        private void lblApodo_Click(object sender, EventArgs e)
        {

        }

        private void imagenCuenta_Click(object sender, EventArgs e)
        {
            openFileDialog1.Filter = "Archivos de Imagen .PNG |*.png| Archivos de Imagen .jpg |*.jpg| Archivos de Imagen .jpeg|*.jpeg| Todos los Archivos |*.*";
            openFileDialog1.Title = " Seleccionar Imagenes";
            DialogResult resultado = openFileDialog1.ShowDialog();


            if (resultado == DialogResult.OK)
            {
                imagenCuenta.Image = Image.FromFile(openFileDialog1.FileName);
            }

        }

        private void btnGuardarImagen_Click(object sender, EventArgs e)
        {
            btnEdit.Visible = false;
            btnEditClose.Visible = true;
            panelEditar.Visible = true;
            txtContraseña.Focus();
        }
    }
}











