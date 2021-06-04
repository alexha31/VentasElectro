
namespace BaseDeDatos
{
    partial class CambioDeConstrasenia
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
            this.button1 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.TxtNowPass = new System.Windows.Forms.TextBox();
            this.TxtNewPass = new System.Windows.Forms.TextBox();
            this.TxtNewPassConfirm = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Microsoft YaHei UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(150, 127);
            this.button1.MaximumSize = new System.Drawing.Size(123, 37);
            this.button1.MinimumSize = new System.Drawing.Size(123, 37);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(123, 37);
            this.button1.TabIndex = 6;
            this.button1.Text = "CAMBIAR";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft YaHei UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(13, 18);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(240, 23);
            this.label1.TabIndex = 0;
            this.label1.Text = "Escriba su contraseña actual:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft YaHei UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(13, 53);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(244, 23);
            this.label2.TabIndex = 1;
            this.label2.Text = "Escriba la nueva constraseña:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft YaHei UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(13, 87);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(205, 23);
            this.label3.TabIndex = 2;
            this.label3.Text = "Confirme su contraseña:";
            // 
            // TxtNowPass
            // 
            this.TxtNowPass.Location = new System.Drawing.Point(264, 12);
            this.TxtNowPass.Name = "TxtNowPass";
            this.TxtNowPass.Size = new System.Drawing.Size(182, 28);
            this.TxtNowPass.TabIndex = 3;
            this.TxtNowPass.Validated += new System.EventHandler(this.TxtNowPass_Validated);
            // 
            // TxtNewPass
            // 
            this.TxtNewPass.Location = new System.Drawing.Point(264, 47);
            this.TxtNewPass.Name = "TxtNewPass";
            this.TxtNewPass.PasswordChar = '*';
            this.TxtNewPass.Size = new System.Drawing.Size(182, 28);
            this.TxtNewPass.TabIndex = 4;
            this.TxtNewPass.Validated += new System.EventHandler(this.TxtNewPass_Validated);
            // 
            // TxtNewPassConfirm
            // 
            this.TxtNewPassConfirm.Location = new System.Drawing.Point(264, 82);
            this.TxtNewPassConfirm.Name = "TxtNewPassConfirm";
            this.TxtNewPassConfirm.PasswordChar = '*';
            this.TxtNewPassConfirm.Size = new System.Drawing.Size(182, 28);
            this.TxtNewPassConfirm.TabIndex = 5;
            this.TxtNewPassConfirm.Validated += new System.EventHandler(this.TxtNewPassConfirm_Validated);
            // 
            // CambioDeConstrasenia
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(120F, 120F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.ClientSize = new System.Drawing.Size(462, 174);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.TxtNewPassConfirm);
            this.Controls.Add(this.TxtNewPass);
            this.Controls.Add(this.TxtNowPass);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Microsoft YaHei UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(470, 211);
            this.MinimizeBox = false;
            this.MinimumSize = new System.Drawing.Size(470, 211);
            this.Name = "CambioDeConstrasenia";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Cambiar contraseña";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.CambioDeConstrasenia_FormClosing);
            this.Load += new System.EventHandler(this.CambioDeConstrasenia_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox TxtNowPass;
        private System.Windows.Forms.TextBox TxtNewPass;
        private System.Windows.Forms.TextBox TxtNewPassConfirm;
    }
}