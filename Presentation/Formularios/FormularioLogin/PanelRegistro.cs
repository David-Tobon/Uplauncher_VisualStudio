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
using Domain;


namespace Presentation.Formularios.FormularioLogin
{
    public partial class PanelRegistro : Form
    {
        public PanelRegistro()
        {
            InitializeComponent();
            Reset();
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            PanelLogin panelLogin = new PanelLogin();
            panelLogin.Show();
            this.Hide();
        }

        private void btnMinimize_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void btnCreateAccount_Click(object sender, EventArgs e)
        {
            MemoryStream ms = new MemoryStream();
            ImagenRegistro.Image.Save(ms, ImageFormat.Png);

            byte[] aByte = ms.ToArray();

            if (VerificarDatos())
            {
                var UserModel = new UserModel(

                                              login: txtLogin.Text,
                                              passwordHash: txtPassword.Text,
                                              nickname: txtNickName.Text,
                                              secretQuestion: txtPregunta.Text,
                                              secretAnswer: txtRespuesta.Text,
                                              email: txtEmail.Text,
                                              fechacreacion: DateTime.Now,
                                              fechaUltinicio: DateTime.Now,
                                              lang: "es",
                                              lastconnectip: "0",
                                              imagen: aByte

                                              );
                var result = UserModel.CreateAccount();

                Reset();
                MessageBox.Show(result);
            }



        }

        
   

      




        private void Reset()
        {
            txtEmail.Text = "";
            txtLogin.Text = "";
            txtNickName.Text = "";
            txtPassword.Text = "";
            txtPassword.UseSystemPasswordChar = true;
            txtPasswordConfirm.Text = "";
            txtPasswordConfirm.UseSystemPasswordChar = true;
            txtPregunta.Text = "";
            txtRespuesta.Text = "";

    }

        private bool VerificarDatos()
        {
            if (txtLogin.Text != "")
            {
                if(txtPassword.Text != "")
                {
                    if (txtPasswordConfirm.Text != "")
                    {
                        if (txtPassword.Text == txtPasswordConfirm.Text)
                        {
                            if (txtPassword.Text.Length >= 4)
                            {
                         
                            if (txtPregunta.Text != "")
                            {
                                    if (txtRespuesta.Text != "")
                                    {
                                        if (txtEmail.Text != "")
                                        {
                                            if (txtNickName.Text != "")
                                            {
                                                return true;
                                            }
                                            else MessageBox.Show("Por Favor Ingresa un Apodo");
                                        }
                                        else MessageBox.Show("Por Favor Ingresa un Email.");
                                    }
                                    else MessageBox.Show("Por Favor Ingresa un Respuesta Secreta.");
                                }
                                else MessageBox.Show("Por Favor Ingresa una Pregunta Secreta.");
                            }
                            else MessageBox.Show("La contraseñe debe tener minimo 4 caracteres.");
                        }
                        else MessageBox.Show("Las contraseñas no coinciden, intentalo nuevamente.");
                    }
                    else MessageBox.Show("Por Favor Verifica tu contraseña.");
                }
                else MessageBox.Show("Por Favor Ingresa una Contraseña.");

            }
            else MessageBox.Show("Por Favor Ingresa un Usuario");
            return false;
            }

        private void PanelRegistro_Load(object sender, EventArgs e)
        {

        }



        #region Botones Contraseña
        private void btnViewPass_Click(object sender, EventArgs e)
        {
            btnOcultarPass.Visible = true;
            btnViewPass.Visible = false;

            txtPassword.UseSystemPasswordChar = false;
            txtPasswordConfirm.UseSystemPasswordChar = false;
        }

        private void btnOcultarPass_Click(object sender, EventArgs e)
        {
            btnOcultarPass.Visible = false;
            btnViewPass.Visible = true;

            txtPassword.UseSystemPasswordChar = true;
            txtPasswordConfirm.UseSystemPasswordChar = true;
        }

        private void btnAtras_Click(object sender, EventArgs e)
        {
            this.Close();
            PanelLogin panelLogin = new PanelLogin();
            panelLogin.Show();
        }

        private void ImagenRegistro_Click(object sender, EventArgs e)
        {
            openFileDialog1.Filter = "Archivos de Imagen .PNG |*.png| Archivos de Imagen .jpg |*.jpg| Archivos de Imagen .jpeg|*.jpeg| Todos los Archivos |*.*";
            openFileDialog1.Title = " Seleccionar Imagenes";
            DialogResult resultado = openFileDialog1.ShowDialog();


            if (resultado == DialogResult.OK)
            {
                ImagenRegistro.Image = Image.FromFile(openFileDialog1.FileName);
            }


        }

        private void iconButton1_Click(object sender, EventArgs e)
        {
            openFileDialog1.Filter = "Archivos de Imagen .PNG |*.png| Archivos de Imagen .jpg |*.jpg| Archivos de Imagen .jpeg|*.jpeg| Todos los Archivos |*.*";
            openFileDialog1.Title = " Seleccionar Imagenes";
            DialogResult resultado = openFileDialog1.ShowDialog();


            if (resultado == DialogResult.OK)
            {
                ImagenRegistro.Image = Image.FromFile(openFileDialog1.FileName);
            }
        }
    }
    #endregion
}




