namespace DoctorAdmin
{
    partial class Form1
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
            this.btnvolver = new System.Windows.Forms.Button();
            this.btnenviar = new System.Windows.Forms.Button();
            this.CMBESPECIALIDAD = new System.Windows.Forms.ComboBox();
            this.txtDpi = new System.Windows.Forms.TextBox();
            this.txtTelefono = new System.Windows.Forms.TextBox();
            this.txtCorreo = new System.Windows.Forms.TextBox();
            this.txtApellido = new System.Windows.Forms.TextBox();
            this.txtNombre = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnvolver
            // 
            this.btnvolver.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(148)))), ((int)(((byte)(184)))));
            this.btnvolver.FlatAppearance.BorderSize = 0;
            this.btnvolver.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnvolver.Font = new System.Drawing.Font("Candara", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnvolver.Location = new System.Drawing.Point(183, 288);
            this.btnvolver.Name = "btnvolver";
            this.btnvolver.Size = new System.Drawing.Size(115, 28);
            this.btnvolver.TabIndex = 28;
            this.btnvolver.Text = "Volver";
            this.btnvolver.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnvolver.UseVisualStyleBackColor = false;
            // 
            // btnenviar
            // 
            this.btnenviar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(148)))), ((int)(((byte)(184)))));
            this.btnenviar.FlatAppearance.BorderSize = 0;
            this.btnenviar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnenviar.Font = new System.Drawing.Font("Candara", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnenviar.Location = new System.Drawing.Point(461, 286);
            this.btnenviar.Name = "btnenviar";
            this.btnenviar.Size = new System.Drawing.Size(110, 30);
            this.btnenviar.TabIndex = 27;
            this.btnenviar.Text = "Registrar";
            this.btnenviar.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnenviar.UseVisualStyleBackColor = false;
            this.btnenviar.Click += new System.EventHandler(this.btnenviar_Click_1);
            // 
            // CMBESPECIALIDAD
            // 
            this.CMBESPECIALIDAD.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.CMBESPECIALIDAD.FormattingEnabled = true;
            this.CMBESPECIALIDAD.Items.AddRange(new object[] {
            ""});
            this.CMBESPECIALIDAD.Location = new System.Drawing.Point(171, 234);
            this.CMBESPECIALIDAD.Name = "CMBESPECIALIDAD";
            this.CMBESPECIALIDAD.Size = new System.Drawing.Size(215, 21);
            this.CMBESPECIALIDAD.TabIndex = 34;
            // 
            // txtDpi
            // 
            this.txtDpi.BackColor = System.Drawing.Color.White;
            this.txtDpi.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtDpi.Cursor = System.Windows.Forms.Cursors.Default;
            this.txtDpi.Location = new System.Drawing.Point(392, 242);
            this.txtDpi.Name = "txtDpi";
            this.txtDpi.Size = new System.Drawing.Size(215, 13);
            this.txtDpi.TabIndex = 33;
            // 
            // txtTelefono
            // 
            this.txtTelefono.BackColor = System.Drawing.Color.White;
            this.txtTelefono.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtTelefono.Cursor = System.Windows.Forms.Cursors.Default;
            this.txtTelefono.Location = new System.Drawing.Point(392, 196);
            this.txtTelefono.Name = "txtTelefono";
            this.txtTelefono.Size = new System.Drawing.Size(215, 13);
            this.txtTelefono.TabIndex = 32;
            // 
            // txtCorreo
            // 
            this.txtCorreo.BackColor = System.Drawing.Color.White;
            this.txtCorreo.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtCorreo.Cursor = System.Windows.Forms.Cursors.Default;
            this.txtCorreo.Location = new System.Drawing.Point(171, 196);
            this.txtCorreo.Name = "txtCorreo";
            this.txtCorreo.Size = new System.Drawing.Size(215, 13);
            this.txtCorreo.TabIndex = 31;
            // 
            // txtApellido
            // 
            this.txtApellido.BackColor = System.Drawing.Color.White;
            this.txtApellido.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtApellido.Cursor = System.Windows.Forms.Cursors.Default;
            this.txtApellido.Location = new System.Drawing.Point(379, 153);
            this.txtApellido.Name = "txtApellido";
            this.txtApellido.Size = new System.Drawing.Size(215, 13);
            this.txtApellido.TabIndex = 30;
            // 
            // txtNombre
            // 
            this.txtNombre.BackColor = System.Drawing.Color.White;
            this.txtNombre.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtNombre.Cursor = System.Windows.Forms.Cursors.Default;
            this.txtNombre.Location = new System.Drawing.Point(171, 153);
            this.txtNombre.Name = "txtNombre";
            this.txtNombre.Size = new System.Drawing.Size(215, 13);
            this.txtNombre.TabIndex = 29;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(148)))), ((int)(((byte)(184)))));
            this.button1.FlatAppearance.BorderSize = 0;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Candara", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(329, 286);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(110, 30);
            this.button1.TabIndex = 35;
            this.button1.Text = "Agregar";
            this.button1.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::DoctorAdmin.Properties.Resources.Captura_de_pantalla_2024_07_06_202311;
            this.ClientSize = new System.Drawing.Size(621, 346);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.CMBESPECIALIDAD);
            this.Controls.Add(this.txtDpi);
            this.Controls.Add(this.txtTelefono);
            this.Controls.Add(this.txtCorreo);
            this.Controls.Add(this.txtApellido);
            this.Controls.Add(this.txtNombre);
            this.Controls.Add(this.btnvolver);
            this.Controls.Add(this.btnenviar);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnvolver;
        private System.Windows.Forms.Button btnenviar;
        private System.Windows.Forms.ComboBox CMBESPECIALIDAD;
        private System.Windows.Forms.TextBox txtDpi;
        private System.Windows.Forms.TextBox txtTelefono;
        private System.Windows.Forms.TextBox txtCorreo;
        private System.Windows.Forms.TextBox txtApellido;
        private System.Windows.Forms.TextBox txtNombre;
        private System.Windows.Forms.Button button1;
    }
}

