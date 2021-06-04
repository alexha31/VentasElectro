
namespace BaseDeDatos
{
    partial class FormularioRegistro
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.Pic_usuario = new System.Windows.Forms.PictureBox();
            this.Textbox_user = new System.Windows.Forms.TextBox();
            this.Textbox_password = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.Label_mensaje = new System.Windows.Forms.Label();
            this.Label_error = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.Pic_usuario)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft YaHei UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(10, 216);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(63, 20);
            this.label1.TabIndex = 1;
            this.label1.Text = "Usuario:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft YaHei UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(10, 246);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(94, 20);
            this.label2.TabIndex = 2;
            this.label2.Text = "Constraseña:";
            // 
            // Pic_usuario
            // 
            this.Pic_usuario.BackColor = System.Drawing.Color.Transparent;
            this.Pic_usuario.Image = global::BaseDeDatos.Properties.Resources._4092564_about_mobile_ui_profile_ui_user_website_114033;
            this.Pic_usuario.Location = new System.Drawing.Point(36, 10);
            this.Pic_usuario.Name = "Pic_usuario";
            this.Pic_usuario.Size = new System.Drawing.Size(185, 190);
            this.Pic_usuario.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.Pic_usuario.TabIndex = 0;
            this.Pic_usuario.TabStop = false;
            // 
            // Textbox_user
            // 
            this.Textbox_user.Font = new System.Drawing.Font("Microsoft YaHei UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Textbox_user.Location = new System.Drawing.Point(106, 211);
            this.Textbox_user.Name = "Textbox_user";
            this.Textbox_user.Size = new System.Drawing.Size(133, 25);
            this.Textbox_user.TabIndex = 3;
            this.Textbox_user.Validated += new System.EventHandler(this.Textbox_user_Validated);
            // 
            // Textbox_password
            // 
            this.Textbox_password.Font = new System.Drawing.Font("Microsoft YaHei UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Textbox_password.Location = new System.Drawing.Point(106, 241);
            this.Textbox_password.Name = "Textbox_password";
            this.Textbox_password.PasswordChar = '*';
            this.Textbox_password.Size = new System.Drawing.Size(133, 25);
            this.Textbox_password.TabIndex = 4;
            this.Textbox_password.Validated += new System.EventHandler(this.Textbox_password_Validated);
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Microsoft YaHei UI Light", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(67, 275);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(108, 29);
            this.button1.TabIndex = 5;
            this.button1.Text = "Ingresar";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Label_mensaje
            // 
            this.Label_mensaje.AutoSize = true;
            this.Label_mensaje.Font = new System.Drawing.Font("Microsoft YaHei UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label_mensaje.ForeColor = System.Drawing.Color.Black;
            this.Label_mensaje.Location = new System.Drawing.Point(0, 390);
            this.Label_mensaje.Name = "Label_mensaje";
            this.Label_mensaje.Size = new System.Drawing.Size(0, 19);
            this.Label_mensaje.TabIndex = 6;
            // 
            // Label_error
            // 
            this.Label_error.AutoSize = true;
            this.Label_error.Location = new System.Drawing.Point(6, 306);
            this.Label_error.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.Label_error.Name = "Label_error";
            this.Label_error.Size = new System.Drawing.Size(0, 13);
            this.Label_error.TabIndex = 8;
            // 
            // FormularioRegistro
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(96F, 96F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.ClientSize = new System.Drawing.Size(250, 322);
            this.Controls.Add(this.Label_error);
            this.Controls.Add(this.Label_mensaje);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.Textbox_password);
            this.Controls.Add(this.Textbox_user);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Pic_usuario);
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(266, 361);
            this.MinimizeBox = false;
            this.MinimumSize = new System.Drawing.Size(266, 361);
            this.Name = "FormularioRegistro";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Inicio de sesión";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.FormularioRegistro_FormClosing);
            this.Load += new System.EventHandler(this.FormularioRegistro_Load);
            ((System.ComponentModel.ISupportInitialize)(this.Pic_usuario)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox Pic_usuario;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox Textbox_user;
        private System.Windows.Forms.TextBox Textbox_password;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label Label_mensaje;
        private System.Windows.Forms.Label Label_error;
    }
}