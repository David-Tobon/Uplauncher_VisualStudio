
namespace Presentation
{
    partial class PanelInicio
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(PanelInicio));
            this.MenuVertical = new System.Windows.Forms.Panel();
            this.btnAccount = new FontAwesome.Sharp.IconButton();
            this.btnContacto = new FontAwesome.Sharp.IconButton();
            this.btnguia = new FontAwesome.Sharp.IconButton();
            this.btnshop = new FontAwesome.Sharp.IconButton();
            this.btnActualizaciones = new FontAwesome.Sharp.IconButton();
            this.btnHome = new FontAwesome.Sharp.IconButton();
            this.panelNombrePlantala = new System.Windows.Forms.Panel();
            this.NombrePlantala = new System.Windows.Forms.Label();
            this.separadorLogo = new System.Windows.Forms.Panel();
            this.PanelUsuario = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.lblUltConexion1 = new System.Windows.Forms.Label();
            this.lblUltConexion = new System.Windows.Forms.Label();
            this.lblUltimaIP1 = new System.Windows.Forms.Label();
            this.lblUltimaIP = new System.Windows.Forms.Label();
            this.lblFecha1 = new System.Windows.Forms.Label();
            this.lblFecha = new System.Windows.Forms.Label();
            this.lblUserGroup = new System.Windows.Forms.Label();
            this.lblUsuario = new System.Windows.Forms.Label();
            this.icnUsuario = new FontAwesome.Sharp.IconPictureBox();
            this.separadorPictureUsuario = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.BarraTitulo = new System.Windows.Forms.Panel();
            this.btnIngreso = new FontAwesome.Sharp.IconButton();
            this.iconPictureBox3 = new FontAwesome.Sharp.IconPictureBox();
            this.iconPictureBox2 = new FontAwesome.Sharp.IconPictureBox();
            this.btnClose = new FontAwesome.Sharp.IconPictureBox();
            this.lblTitleChildForm = new System.Windows.Forms.Label();
            this.iconCurrentChildForm = new FontAwesome.Sharp.IconPictureBox();
            this.PanelJugar = new System.Windows.Forms.Panel();
            this.BarraProgresoColor = new Presentation.Extra.BarraProgreso_Color();
            this.btnJugar = new FontAwesome.Sharp.IconButton();
            this.lblDescargando = new System.Windows.Forms.Label();
            this.PanelDeskop = new System.Windows.Forms.Panel();
            this.imagenInicio = new Presentation.Extra.PictureBox_Circular();
            this.lblVersionVoltion = new System.Windows.Forms.Label();
            this.fecha = new System.Windows.Forms.Label();
            this.hora = new System.Windows.Forms.Label();
            this.timerHoraFecha = new System.Windows.Forms.Timer(this.components);
            this.ColorCirculo = new System.Windows.Forms.Timer(this.components);
            this.iconButton1 = new FontAwesome.Sharp.IconButton();
            this.MenuVertical.SuspendLayout();
            this.panelNombrePlantala.SuspendLayout();
            this.PanelUsuario.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.icnUsuario)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.separadorPictureUsuario)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.BarraTitulo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.iconPictureBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.iconPictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnClose)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.iconCurrentChildForm)).BeginInit();
            this.PanelJugar.SuspendLayout();
            this.PanelDeskop.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.imagenInicio)).BeginInit();
            this.SuspendLayout();
            // 
            // MenuVertical
            // 
            this.MenuVertical.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(47)))), ((int)(((byte)(49)))), ((int)(((byte)(54)))));
            this.MenuVertical.Controls.Add(this.btnAccount);
            this.MenuVertical.Controls.Add(this.btnContacto);
            this.MenuVertical.Controls.Add(this.btnguia);
            this.MenuVertical.Controls.Add(this.btnshop);
            this.MenuVertical.Controls.Add(this.btnActualizaciones);
            this.MenuVertical.Controls.Add(this.btnHome);
            this.MenuVertical.Controls.Add(this.panelNombrePlantala);
            this.MenuVertical.Controls.Add(this.separadorLogo);
            this.MenuVertical.Controls.Add(this.PanelUsuario);
            this.MenuVertical.Controls.Add(this.pictureBox1);
            this.MenuVertical.Dock = System.Windows.Forms.DockStyle.Left;
            this.MenuVertical.Location = new System.Drawing.Point(0, 0);
            this.MenuVertical.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.MenuVertical.Name = "MenuVertical";
            this.MenuVertical.Size = new System.Drawing.Size(280, 700);
            this.MenuVertical.TabIndex = 0;
            // 
            // btnAccount
            // 
            this.btnAccount.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnAccount.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnAccount.FlatAppearance.BorderSize = 0;
            this.btnAccount.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAccount.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnAccount.ForeColor = System.Drawing.Color.Silver;
            this.btnAccount.IconChar = FontAwesome.Sharp.IconChar.UserEdit;
            this.btnAccount.IconColor = System.Drawing.Color.DarkGray;
            this.btnAccount.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnAccount.IconSize = 40;
            this.btnAccount.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnAccount.Location = new System.Drawing.Point(0, 404);
            this.btnAccount.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.btnAccount.Name = "btnAccount";
            this.btnAccount.Padding = new System.Windows.Forms.Padding(12, 0, 23, 0);
            this.btnAccount.Size = new System.Drawing.Size(280, 46);
            this.btnAccount.TabIndex = 10;
            this.btnAccount.Text = "Cuenta";
            this.btnAccount.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnAccount.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnAccount.UseVisualStyleBackColor = true;
            this.btnAccount.Visible = false;
            this.btnAccount.Click += new System.EventHandler(this.btnAccount_Click_1);
            // 
            // btnContacto
            // 
            this.btnContacto.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnContacto.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnContacto.FlatAppearance.BorderSize = 0;
            this.btnContacto.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnContacto.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnContacto.ForeColor = System.Drawing.Color.Silver;
            this.btnContacto.IconChar = FontAwesome.Sharp.IconChar.Headset;
            this.btnContacto.IconColor = System.Drawing.Color.DarkGray;
            this.btnContacto.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnContacto.IconSize = 40;
            this.btnContacto.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnContacto.Location = new System.Drawing.Point(0, 358);
            this.btnContacto.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.btnContacto.Name = "btnContacto";
            this.btnContacto.Padding = new System.Windows.Forms.Padding(12, 0, 23, 0);
            this.btnContacto.Size = new System.Drawing.Size(280, 46);
            this.btnContacto.TabIndex = 9;
            this.btnContacto.Text = "Contacto";
            this.btnContacto.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnContacto.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnContacto.UseVisualStyleBackColor = true;
            this.btnContacto.Click += new System.EventHandler(this.btnContacto_Click);
            // 
            // btnguia
            // 
            this.btnguia.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnguia.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnguia.FlatAppearance.BorderSize = 0;
            this.btnguia.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnguia.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnguia.ForeColor = System.Drawing.Color.Silver;
            this.btnguia.IconChar = FontAwesome.Sharp.IconChar.QuestionCircle;
            this.btnguia.IconColor = System.Drawing.Color.DarkGray;
            this.btnguia.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnguia.IconSize = 40;
            this.btnguia.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnguia.Location = new System.Drawing.Point(0, 312);
            this.btnguia.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.btnguia.Name = "btnguia";
            this.btnguia.Padding = new System.Windows.Forms.Padding(12, 0, 23, 0);
            this.btnguia.Size = new System.Drawing.Size(280, 46);
            this.btnguia.TabIndex = 8;
            this.btnguia.Text = "Guia";
            this.btnguia.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnguia.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnguia.UseVisualStyleBackColor = true;
            this.btnguia.Click += new System.EventHandler(this.btnguia_Click_1);
            // 
            // btnshop
            // 
            this.btnshop.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnshop.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnshop.FlatAppearance.BorderSize = 0;
            this.btnshop.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnshop.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnshop.ForeColor = System.Drawing.Color.Silver;
            this.btnshop.IconChar = FontAwesome.Sharp.IconChar.ShoppingCart;
            this.btnshop.IconColor = System.Drawing.Color.DarkGray;
            this.btnshop.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnshop.IconSize = 40;
            this.btnshop.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnshop.Location = new System.Drawing.Point(0, 266);
            this.btnshop.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.btnshop.Name = "btnshop";
            this.btnshop.Padding = new System.Windows.Forms.Padding(12, 0, 23, 0);
            this.btnshop.Size = new System.Drawing.Size(280, 46);
            this.btnshop.TabIndex = 7;
            this.btnshop.Text = "Tienda";
            this.btnshop.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnshop.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnshop.UseVisualStyleBackColor = true;
            this.btnshop.Click += new System.EventHandler(this.btnshop_Click);
            // 
            // btnActualizaciones
            // 
            this.btnActualizaciones.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnActualizaciones.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnActualizaciones.FlatAppearance.BorderSize = 0;
            this.btnActualizaciones.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnActualizaciones.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnActualizaciones.ForeColor = System.Drawing.Color.Silver;
            this.btnActualizaciones.IconChar = FontAwesome.Sharp.IconChar.Upload;
            this.btnActualizaciones.IconColor = System.Drawing.Color.DarkGray;
            this.btnActualizaciones.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnActualizaciones.IconSize = 40;
            this.btnActualizaciones.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnActualizaciones.Location = new System.Drawing.Point(0, 220);
            this.btnActualizaciones.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.btnActualizaciones.Name = "btnActualizaciones";
            this.btnActualizaciones.Padding = new System.Windows.Forms.Padding(12, 0, 23, 0);
            this.btnActualizaciones.Size = new System.Drawing.Size(280, 46);
            this.btnActualizaciones.TabIndex = 6;
            this.btnActualizaciones.Text = "Actualizaciones";
            this.btnActualizaciones.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnActualizaciones.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnActualizaciones.UseVisualStyleBackColor = true;
            this.btnActualizaciones.Click += new System.EventHandler(this.btnActualizaciones_Click);
            // 
            // btnHome
            // 
            this.btnHome.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnHome.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnHome.FlatAppearance.BorderSize = 0;
            this.btnHome.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnHome.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnHome.ForeColor = System.Drawing.Color.Silver;
            this.btnHome.IconChar = FontAwesome.Sharp.IconChar.Home;
            this.btnHome.IconColor = System.Drawing.Color.DarkGray;
            this.btnHome.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnHome.IconSize = 40;
            this.btnHome.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnHome.Location = new System.Drawing.Point(0, 174);
            this.btnHome.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.btnHome.Name = "btnHome";
            this.btnHome.Padding = new System.Windows.Forms.Padding(12, 0, 23, 0);
            this.btnHome.Size = new System.Drawing.Size(280, 46);
            this.btnHome.TabIndex = 5;
            this.btnHome.Text = "Inicio";
            this.btnHome.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnHome.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnHome.UseVisualStyleBackColor = true;
            this.btnHome.Click += new System.EventHandler(this.btnHome_Click);
            // 
            // panelNombrePlantala
            // 
            this.panelNombrePlantala.Controls.Add(this.NombrePlantala);
            this.panelNombrePlantala.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelNombrePlantala.Location = new System.Drawing.Point(0, 116);
            this.panelNombrePlantala.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.panelNombrePlantala.Name = "panelNombrePlantala";
            this.panelNombrePlantala.Size = new System.Drawing.Size(280, 58);
            this.panelNombrePlantala.TabIndex = 4;
            // 
            // NombrePlantala
            // 
            this.NombrePlantala.AutoSize = true;
            this.NombrePlantala.Font = new System.Drawing.Font("Century Gothic", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.NombrePlantala.ForeColor = System.Drawing.Color.GreenYellow;
            this.NombrePlantala.Location = new System.Drawing.Point(95, 0);
            this.NombrePlantala.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.NombrePlantala.Name = "NombrePlantala";
            this.NombrePlantala.Size = new System.Drawing.Size(92, 28);
            this.NombrePlantala.TabIndex = 0;
            this.NombrePlantala.Text = "Voltion";
            this.NombrePlantala.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.NombrePlantala.Click += new System.EventHandler(this.NombrePlantala_Click);
            // 
            // separadorLogo
            // 
            this.separadorLogo.Dock = System.Windows.Forms.DockStyle.Top;
            this.separadorLogo.Location = new System.Drawing.Point(0, 99);
            this.separadorLogo.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.separadorLogo.Name = "separadorLogo";
            this.separadorLogo.Size = new System.Drawing.Size(280, 17);
            this.separadorLogo.TabIndex = 3;
            // 
            // PanelUsuario
            // 
            this.PanelUsuario.Controls.Add(this.label1);
            this.PanelUsuario.Controls.Add(this.lblUltConexion1);
            this.PanelUsuario.Controls.Add(this.lblUltConexion);
            this.PanelUsuario.Controls.Add(this.lblUltimaIP1);
            this.PanelUsuario.Controls.Add(this.lblUltimaIP);
            this.PanelUsuario.Controls.Add(this.lblFecha1);
            this.PanelUsuario.Controls.Add(this.lblFecha);
            this.PanelUsuario.Controls.Add(this.lblUserGroup);
            this.PanelUsuario.Controls.Add(this.lblUsuario);
            this.PanelUsuario.Controls.Add(this.icnUsuario);
            this.PanelUsuario.Controls.Add(this.separadorPictureUsuario);
            this.PanelUsuario.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.PanelUsuario.Location = new System.Drawing.Point(0, 568);
            this.PanelUsuario.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.PanelUsuario.Name = "PanelUsuario";
            this.PanelUsuario.Size = new System.Drawing.Size(280, 132);
            this.PanelUsuario.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 6.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.ForeColor = System.Drawing.Color.Gray;
            this.label1.Location = new System.Drawing.Point(202, 117);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(78, 13);
            this.label1.TabIndex = 5;
            this.label1.Text = "By: David Tobon";
            // 
            // lblUltConexion1
            // 
            this.lblUltConexion1.AutoSize = true;
            this.lblUltConexion1.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblUltConexion1.ForeColor = System.Drawing.Color.GreenYellow;
            this.lblUltConexion1.Location = new System.Drawing.Point(75, 102);
            this.lblUltConexion1.Name = "lblUltConexion1";
            this.lblUltConexion1.Size = new System.Drawing.Size(63, 13);
            this.lblUltConexion1.TabIndex = 9;
            this.lblUltConexion1.Text = "01-12-2021";
            this.lblUltConexion1.Visible = false;
            // 
            // lblUltConexion
            // 
            this.lblUltConexion.AutoSize = true;
            this.lblUltConexion.ForeColor = System.Drawing.Color.Silver;
            this.lblUltConexion.Location = new System.Drawing.Point(75, 88);
            this.lblUltConexion.Name = "lblUltConexion";
            this.lblUltConexion.Size = new System.Drawing.Size(99, 15);
            this.lblUltConexion.TabIndex = 8;
            this.lblUltConexion.Text = "Ultima Conexión:";
            this.lblUltConexion.Visible = false;
            // 
            // lblUltimaIP1
            // 
            this.lblUltimaIP1.AutoSize = true;
            this.lblUltimaIP1.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblUltimaIP1.ForeColor = System.Drawing.Color.GreenYellow;
            this.lblUltimaIP1.Location = new System.Drawing.Point(75, 74);
            this.lblUltimaIP1.Name = "lblUltimaIP1";
            this.lblUltimaIP1.Size = new System.Drawing.Size(52, 13);
            this.lblUltimaIP1.TabIndex = 7;
            this.lblUltimaIP1.Text = "127.0.0.1";
            this.lblUltimaIP1.Visible = false;
            // 
            // lblUltimaIP
            // 
            this.lblUltimaIP.AutoSize = true;
            this.lblUltimaIP.ForeColor = System.Drawing.Color.Silver;
            this.lblUltimaIP.Location = new System.Drawing.Point(75, 60);
            this.lblUltimaIP.Name = "lblUltimaIP";
            this.lblUltimaIP.Size = new System.Drawing.Size(58, 15);
            this.lblUltimaIP.TabIndex = 6;
            this.lblUltimaIP.Text = "Ultima IP:";
            this.lblUltimaIP.Visible = false;
            // 
            // lblFecha1
            // 
            this.lblFecha1.AutoSize = true;
            this.lblFecha1.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblFecha1.ForeColor = System.Drawing.Color.GreenYellow;
            this.lblFecha1.Location = new System.Drawing.Point(75, 46);
            this.lblFecha1.Name = "lblFecha1";
            this.lblFecha1.Size = new System.Drawing.Size(63, 13);
            this.lblFecha1.TabIndex = 5;
            this.lblFecha1.Text = "01-12-2021";
            this.lblFecha1.Visible = false;
            // 
            // lblFecha
            // 
            this.lblFecha.AutoSize = true;
            this.lblFecha.ForeColor = System.Drawing.Color.Silver;
            this.lblFecha.Location = new System.Drawing.Point(75, 33);
            this.lblFecha.Name = "lblFecha";
            this.lblFecha.Size = new System.Drawing.Size(91, 15);
            this.lblFecha.TabIndex = 4;
            this.lblFecha.Text = "Fecha Creacion:";
            this.lblFecha.Visible = false;
            // 
            // lblUserGroup
            // 
            this.lblUserGroup.AutoSize = true;
            this.lblUserGroup.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblUserGroup.ForeColor = System.Drawing.Color.GreenYellow;
            this.lblUserGroup.Location = new System.Drawing.Point(75, 17);
            this.lblUserGroup.Name = "lblUserGroup";
            this.lblUserGroup.Size = new System.Drawing.Size(76, 15);
            this.lblUserGroup.TabIndex = 3;
            this.lblUserGroup.Text = "Tipo Usuario";
            this.lblUserGroup.Visible = false;
            // 
            // lblUsuario
            // 
            this.lblUsuario.AutoSize = true;
            this.lblUsuario.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblUsuario.ForeColor = System.Drawing.Color.Silver;
            this.lblUsuario.Location = new System.Drawing.Point(75, 0);
            this.lblUsuario.Name = "lblUsuario";
            this.lblUsuario.Size = new System.Drawing.Size(128, 17);
            this.lblUsuario.TabIndex = 2;
            this.lblUsuario.Text = "Nombre de Usuario";
            this.lblUsuario.Visible = false;
            // 
            // icnUsuario
            // 
            this.icnUsuario.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(47)))), ((int)(((byte)(49)))), ((int)(((byte)(54)))));
            this.icnUsuario.Cursor = System.Windows.Forms.Cursors.Hand;
            this.icnUsuario.Dock = System.Windows.Forms.DockStyle.Left;
            this.icnUsuario.ForeColor = System.Drawing.Color.DarkGray;
            this.icnUsuario.IconChar = FontAwesome.Sharp.IconChar.UserAlt;
            this.icnUsuario.IconColor = System.Drawing.Color.DarkGray;
            this.icnUsuario.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.icnUsuario.IconSize = 58;
            this.icnUsuario.Location = new System.Drawing.Point(10, 0);
            this.icnUsuario.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.icnUsuario.Name = "icnUsuario";
            this.icnUsuario.Size = new System.Drawing.Size(58, 132);
            this.icnUsuario.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.icnUsuario.TabIndex = 1;
            this.icnUsuario.TabStop = false;
            this.icnUsuario.Visible = false;
            this.icnUsuario.Click += new System.EventHandler(this.icnUsuario_Click);
            // 
            // separadorPictureUsuario
            // 
            this.separadorPictureUsuario.Dock = System.Windows.Forms.DockStyle.Left;
            this.separadorPictureUsuario.Location = new System.Drawing.Point(0, 0);
            this.separadorPictureUsuario.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.separadorPictureUsuario.Name = "separadorPictureUsuario";
            this.separadorPictureUsuario.Size = new System.Drawing.Size(10, 132);
            this.separadorPictureUsuario.TabIndex = 0;
            this.separadorPictureUsuario.TabStop = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Dock = System.Windows.Forms.DockStyle.Top;
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(0, 0);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(280, 99);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // BarraTitulo
            // 
            this.BarraTitulo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(47)))), ((int)(((byte)(49)))), ((int)(((byte)(54)))));
            this.BarraTitulo.Controls.Add(this.iconButton1);
            this.BarraTitulo.Controls.Add(this.btnIngreso);
            this.BarraTitulo.Controls.Add(this.iconPictureBox3);
            this.BarraTitulo.Controls.Add(this.iconPictureBox2);
            this.BarraTitulo.Controls.Add(this.btnClose);
            this.BarraTitulo.Controls.Add(this.lblTitleChildForm);
            this.BarraTitulo.Controls.Add(this.iconCurrentChildForm);
            this.BarraTitulo.Dock = System.Windows.Forms.DockStyle.Top;
            this.BarraTitulo.Location = new System.Drawing.Point(280, 0);
            this.BarraTitulo.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.BarraTitulo.Name = "BarraTitulo";
            this.BarraTitulo.Size = new System.Drawing.Size(1070, 60);
            this.BarraTitulo.TabIndex = 1;
            this.BarraTitulo.MouseDown += new System.Windows.Forms.MouseEventHandler(this.BarraTitulo_MouseDown);
            // 
            // btnIngreso
            // 
            this.btnIngreso.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnIngreso.FlatAppearance.BorderSize = 0;
            this.btnIngreso.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnIngreso.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnIngreso.ForeColor = System.Drawing.Color.Silver;
            this.btnIngreso.IconChar = FontAwesome.Sharp.IconChar.JediOrder;
            this.btnIngreso.IconColor = System.Drawing.Color.Silver;
            this.btnIngreso.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnIngreso.Location = new System.Drawing.Point(598, -7);
            this.btnIngreso.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.btnIngreso.Name = "btnIngreso";
            this.btnIngreso.Size = new System.Drawing.Size(152, 69);
            this.btnIngreso.TabIndex = 8;
            this.btnIngreso.Text = "Login";
            this.btnIngreso.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnIngreso.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.btnIngreso.UseVisualStyleBackColor = true;
            this.btnIngreso.Click += new System.EventHandler(this.btnIngreso_Click);
            // 
            // iconPictureBox3
            // 
            this.iconPictureBox3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(47)))), ((int)(((byte)(49)))), ((int)(((byte)(54)))));
            this.iconPictureBox3.Cursor = System.Windows.Forms.Cursors.Hand;
            this.iconPictureBox3.Dock = System.Windows.Forms.DockStyle.Right;
            this.iconPictureBox3.ForeColor = System.Drawing.Color.Silver;
            this.iconPictureBox3.IconChar = FontAwesome.Sharp.IconChar.WindowMinimize;
            this.iconPictureBox3.IconColor = System.Drawing.Color.Silver;
            this.iconPictureBox3.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.iconPictureBox3.IconSize = 23;
            this.iconPictureBox3.Location = new System.Drawing.Point(1001, 0);
            this.iconPictureBox3.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.iconPictureBox3.Name = "iconPictureBox3";
            this.iconPictureBox3.Padding = new System.Windows.Forms.Padding(0, 6, 0, 0);
            this.iconPictureBox3.Size = new System.Drawing.Size(23, 60);
            this.iconPictureBox3.TabIndex = 7;
            this.iconPictureBox3.TabStop = false;
            this.iconPictureBox3.Click += new System.EventHandler(this.iconPictureBox3_Click);
            // 
            // iconPictureBox2
            // 
            this.iconPictureBox2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(47)))), ((int)(((byte)(49)))), ((int)(((byte)(54)))));
            this.iconPictureBox2.Cursor = System.Windows.Forms.Cursors.Hand;
            this.iconPictureBox2.Dock = System.Windows.Forms.DockStyle.Right;
            this.iconPictureBox2.ForeColor = System.Drawing.Color.Silver;
            this.iconPictureBox2.IconChar = FontAwesome.Sharp.IconChar.WindowMaximize;
            this.iconPictureBox2.IconColor = System.Drawing.Color.Silver;
            this.iconPictureBox2.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.iconPictureBox2.IconSize = 23;
            this.iconPictureBox2.Location = new System.Drawing.Point(1024, 0);
            this.iconPictureBox2.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.iconPictureBox2.Name = "iconPictureBox2";
            this.iconPictureBox2.Padding = new System.Windows.Forms.Padding(0, 6, 0, 0);
            this.iconPictureBox2.Size = new System.Drawing.Size(23, 60);
            this.iconPictureBox2.TabIndex = 6;
            this.iconPictureBox2.TabStop = false;
            this.iconPictureBox2.Click += new System.EventHandler(this.iconPictureBox2_Click);
            // 
            // btnClose
            // 
            this.btnClose.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(47)))), ((int)(((byte)(49)))), ((int)(((byte)(54)))));
            this.btnClose.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnClose.Dock = System.Windows.Forms.DockStyle.Right;
            this.btnClose.ForeColor = System.Drawing.Color.Silver;
            this.btnClose.IconChar = FontAwesome.Sharp.IconChar.Times;
            this.btnClose.IconColor = System.Drawing.Color.Silver;
            this.btnClose.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnClose.IconSize = 23;
            this.btnClose.Location = new System.Drawing.Point(1047, 0);
            this.btnClose.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.btnClose.Name = "btnClose";
            this.btnClose.Padding = new System.Windows.Forms.Padding(0, 6, 0, 0);
            this.btnClose.Size = new System.Drawing.Size(23, 60);
            this.btnClose.TabIndex = 5;
            this.btnClose.TabStop = false;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // lblTitleChildForm
            // 
            this.lblTitleChildForm.AutoSize = true;
            this.lblTitleChildForm.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblTitleChildForm.ForeColor = System.Drawing.Color.Silver;
            this.lblTitleChildForm.Location = new System.Drawing.Point(65, 27);
            this.lblTitleChildForm.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblTitleChildForm.Name = "lblTitleChildForm";
            this.lblTitleChildForm.Size = new System.Drawing.Size(49, 20);
            this.lblTitleChildForm.TabIndex = 4;
            this.lblTitleChildForm.Text = "Inicio";
            // 
            // iconCurrentChildForm
            // 
            this.iconCurrentChildForm.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(54)))), ((int)(((byte)(57)))), ((int)(((byte)(63)))));
            this.iconCurrentChildForm.Dock = System.Windows.Forms.DockStyle.Left;
            this.iconCurrentChildForm.ForeColor = System.Drawing.Color.Silver;
            this.iconCurrentChildForm.IconChar = FontAwesome.Sharp.IconChar.Home;
            this.iconCurrentChildForm.IconColor = System.Drawing.Color.Silver;
            this.iconCurrentChildForm.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.iconCurrentChildForm.IconSize = 58;
            this.iconCurrentChildForm.Location = new System.Drawing.Point(0, 0);
            this.iconCurrentChildForm.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.iconCurrentChildForm.Name = "iconCurrentChildForm";
            this.iconCurrentChildForm.Padding = new System.Windows.Forms.Padding(0, 12, 0, 0);
            this.iconCurrentChildForm.Size = new System.Drawing.Size(58, 60);
            this.iconCurrentChildForm.TabIndex = 3;
            this.iconCurrentChildForm.TabStop = false;
            // 
            // PanelJugar
            // 
            this.PanelJugar.Controls.Add(this.BarraProgresoColor);
            this.PanelJugar.Controls.Add(this.btnJugar);
            this.PanelJugar.Controls.Add(this.lblDescargando);
            this.PanelJugar.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.PanelJugar.Location = new System.Drawing.Point(280, 627);
            this.PanelJugar.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.PanelJugar.Name = "PanelJugar";
            this.PanelJugar.Size = new System.Drawing.Size(1070, 73);
            this.PanelJugar.TabIndex = 2;
            // 
            // BarraProgresoColor
            // 
            this.BarraProgresoColor.ChannelColor = System.Drawing.Color.WhiteSmoke;
            this.BarraProgresoColor.ChannelHeight = 6;
            this.BarraProgresoColor.ForeBackColor = System.Drawing.Color.Transparent;
            this.BarraProgresoColor.ForeColor = System.Drawing.Color.Gold;
            this.BarraProgresoColor.Location = new System.Drawing.Point(65, 3);
            this.BarraProgresoColor.Name = "BarraProgresoColor";
            this.BarraProgresoColor.ShowMaximun = false;
            this.BarraProgresoColor.ShowValue = Presentation.Extra.TextPosition.Sliding;
            this.BarraProgresoColor.Size = new System.Drawing.Size(831, 40);
            this.BarraProgresoColor.SliderColor = System.Drawing.Color.Gold;
            this.BarraProgresoColor.SliderHeight = 35;
            this.BarraProgresoColor.Style = System.Windows.Forms.ProgressBarStyle.Continuous;
            this.BarraProgresoColor.SymbolAfter = "%";
            this.BarraProgresoColor.SymbolBefore = "";
            this.BarraProgresoColor.TabIndex = 5;
            // 
            // btnJugar
            // 
            this.btnJugar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnJugar.Enabled = false;
            this.btnJugar.FlatAppearance.BorderSize = 0;
            this.btnJugar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnJugar.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnJugar.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.btnJugar.IconChar = FontAwesome.Sharp.IconChar.Earlybirds;
            this.btnJugar.IconColor = System.Drawing.Color.WhiteSmoke;
            this.btnJugar.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnJugar.IconSize = 49;
            this.btnJugar.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnJugar.Location = new System.Drawing.Point(914, 1);
            this.btnJugar.Name = "btnJugar";
            this.btnJugar.Size = new System.Drawing.Size(143, 65);
            this.btnJugar.TabIndex = 1;
            this.btnJugar.Text = "JUGAR";
            this.btnJugar.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnJugar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btnJugar.UseVisualStyleBackColor = true;
            this.btnJugar.Click += new System.EventHandler(this.btnJugar_Click);
            // 
            // lblDescargando
            // 
            this.lblDescargando.AutoSize = true;
            this.lblDescargando.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblDescargando.ForeColor = System.Drawing.Color.Gray;
            this.lblDescargando.Location = new System.Drawing.Point(65, 45);
            this.lblDescargando.Name = "lblDescargando";
            this.lblDescargando.Size = new System.Drawing.Size(266, 17);
            this.lblDescargando.TabIndex = 3;
            this.lblDescargando.Text = "Descargando la Versión de Dofus Voltion:";
            // 
            // PanelDeskop
            // 
            this.PanelDeskop.Controls.Add(this.imagenInicio);
            this.PanelDeskop.Controls.Add(this.lblVersionVoltion);
            this.PanelDeskop.Controls.Add(this.fecha);
            this.PanelDeskop.Controls.Add(this.hora);
            this.PanelDeskop.Dock = System.Windows.Forms.DockStyle.Fill;
            this.PanelDeskop.Location = new System.Drawing.Point(280, 60);
            this.PanelDeskop.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.PanelDeskop.Name = "PanelDeskop";
            this.PanelDeskop.Size = new System.Drawing.Size(1070, 567);
            this.PanelDeskop.TabIndex = 3;
            this.PanelDeskop.TabStop = true;
            // 
            // imagenInicio
            // 
            this.imagenInicio.BorderCapStyle = System.Drawing.Drawing2D.DashCap.Round;
            this.imagenInicio.BorderColor = System.Drawing.Color.GreenYellow;
            this.imagenInicio.BorderColor2 = System.Drawing.Color.Gold;
            this.imagenInicio.BorderLineStyle = System.Drawing.Drawing2D.DashStyle.DashDotDot;
            this.imagenInicio.BorderSize = 5;
            this.imagenInicio.GradientAngle = 50F;
            this.imagenInicio.Image = ((System.Drawing.Image)(resources.GetObject("imagenInicio.Image")));
            this.imagenInicio.Location = new System.Drawing.Point(410, 31);
            this.imagenInicio.Name = "imagenInicio";
            this.imagenInicio.Size = new System.Drawing.Size(230, 230);
            this.imagenInicio.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.imagenInicio.TabIndex = 31;
            this.imagenInicio.TabStop = false;
            // 
            // lblVersionVoltion
            // 
            this.lblVersionVoltion.AutoSize = true;
            this.lblVersionVoltion.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblVersionVoltion.ForeColor = System.Drawing.Color.DarkGray;
            this.lblVersionVoltion.Location = new System.Drawing.Point(430, 413);
            this.lblVersionVoltion.Name = "lblVersionVoltion";
            this.lblVersionVoltion.Size = new System.Drawing.Size(210, 23);
            this.lblVersionVoltion.TabIndex = 8;
            this.lblVersionVoltion.Text = "Voltion Versión: X.X.X.";
            // 
            // fecha
            // 
            this.fecha.AutoSize = true;
            this.fecha.Font = new System.Drawing.Font("Century Gothic", 30F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.fecha.ForeColor = System.Drawing.Color.Gold;
            this.fecha.Location = new System.Drawing.Point(243, 349);
            this.fecha.Name = "fecha";
            this.fecha.Size = new System.Drawing.Size(148, 47);
            this.fecha.TabIndex = 6;
            this.fecha.Text = "FECHA";
            // 
            // hora
            // 
            this.hora.AutoSize = true;
            this.hora.Font = new System.Drawing.Font("Century Gothic", 60F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.hora.ForeColor = System.Drawing.Color.Silver;
            this.hora.Location = new System.Drawing.Point(374, 264);
            this.hora.Name = "hora";
            this.hora.Size = new System.Drawing.Size(266, 93);
            this.hora.TabIndex = 5;
            this.hora.Text = "HORA";
            // 
            // timerHoraFecha
            // 
            this.timerHoraFecha.Enabled = true;
            this.timerHoraFecha.Tick += new System.EventHandler(this.timerHoraFecha_Tick);
            // 
            // ColorCirculo
            // 
            this.ColorCirculo.Enabled = true;
            this.ColorCirculo.Interval = 300;
            this.ColorCirculo.Tick += new System.EventHandler(this.ColorCirculo_Tick);
            // 
            // iconButton1
            // 
            this.iconButton1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.iconButton1.FlatAppearance.BorderSize = 0;
            this.iconButton1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.iconButton1.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.iconButton1.ForeColor = System.Drawing.Color.Silver;
            this.iconButton1.IconChar = FontAwesome.Sharp.IconChar.Hippo;
            this.iconButton1.IconColor = System.Drawing.Color.Silver;
            this.iconButton1.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.iconButton1.Location = new System.Drawing.Point(789, -6);
            this.iconButton1.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.iconButton1.Name = "iconButton1";
            this.iconButton1.Size = new System.Drawing.Size(152, 69);
            this.iconButton1.TabIndex = 9;
            this.iconButton1.Text = "Crear Cuenta";
            this.iconButton1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.iconButton1.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.iconButton1.UseVisualStyleBackColor = true;
            this.iconButton1.Click += new System.EventHandler(this.iconButton1_Click);
            // 
            // PanelInicio
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(54)))), ((int)(((byte)(57)))), ((int)(((byte)(63)))));
            this.ClientSize = new System.Drawing.Size(1350, 700);
            this.Controls.Add(this.PanelDeskop);
            this.Controls.Add(this.PanelJugar);
            this.Controls.Add(this.BarraTitulo);
            this.Controls.Add(this.MenuVertical);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.Name = "PanelInicio";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "UpLauncher Voltion";
            this.MenuVertical.ResumeLayout(false);
            this.panelNombrePlantala.ResumeLayout(false);
            this.panelNombrePlantala.PerformLayout();
            this.PanelUsuario.ResumeLayout(false);
            this.PanelUsuario.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.icnUsuario)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.separadorPictureUsuario)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.BarraTitulo.ResumeLayout(false);
            this.BarraTitulo.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.iconPictureBox3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.iconPictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnClose)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.iconCurrentChildForm)).EndInit();
            this.PanelJugar.ResumeLayout(false);
            this.PanelJugar.PerformLayout();
            this.PanelDeskop.ResumeLayout(false);
            this.PanelDeskop.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.imagenInicio)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel MenuVertical;
        private System.Windows.Forms.Panel PanelUsuario;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Panel BarraTitulo;
        private System.Windows.Forms.Panel PanelJugar;
        private System.Windows.Forms.Panel PanelDeskop;
        private System.Windows.Forms.PictureBox separadorPictureUsuario;
        private System.Windows.Forms.Panel panelNombrePlantala;
        private System.Windows.Forms.Label NombrePlantala;
        private System.Windows.Forms.Panel separadorLogo;
        private FontAwesome.Sharp.IconButton btnContacto;
        private FontAwesome.Sharp.IconButton btnguia;
        private FontAwesome.Sharp.IconButton btnshop;
        private FontAwesome.Sharp.IconButton btnActualizaciones;
        private FontAwesome.Sharp.IconButton btnHome;
        private FontAwesome.Sharp.IconPictureBox icnUsuario;
        private FontAwesome.Sharp.IconButton btnAccount;
        private System.Windows.Forms.Label lblTitleChildForm;
        private FontAwesome.Sharp.IconPictureBox iconCurrentChildForm;
        private FontAwesome.Sharp.IconPictureBox btnClose;
        private FontAwesome.Sharp.IconPictureBox iconPictureBox3;
        private FontAwesome.Sharp.IconPictureBox iconPictureBox2;
        private FontAwesome.Sharp.IconButton btnIngreso;
        private System.Windows.Forms.Label lblUsuario;
        private System.Windows.Forms.Label lblUserGroup;
        private System.Windows.Forms.Label lblUltConexion1;
        private System.Windows.Forms.Label lblUltConexion;
        private System.Windows.Forms.Label lblUltimaIP1;
        private System.Windows.Forms.Label lblUltimaIP;
        private System.Windows.Forms.Label lblFecha1;
        private System.Windows.Forms.Label lblFecha;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblDescargando;
        private System.Windows.Forms.Label fecha;
        private System.Windows.Forms.Label hora;
        private System.Windows.Forms.Timer timerHoraFecha;
        private System.Windows.Forms.Label lblVersionVoltion;
        private FontAwesome.Sharp.IconButton btnJugar;
        private Extra.PictureBox_Circular imagenInicio;
        private Extra.BarraProgreso_Color BarraProgresoColor;
        private System.Windows.Forms.Timer ColorCirculo;
        private FontAwesome.Sharp.IconButton iconButton1;
    }
}

