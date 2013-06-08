namespace PVHLF0001
{
    partial class frm_EnvioMensaje
    {
        /// <summary>
        /// Variable del diseñador requerida.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén utilizando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben eliminar; false en caso contrario, false.</param>
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
        /// el contenido del método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frm_EnvioMensaje));
            this.label1 = new System.Windows.Forms.Label();
            this.rtbMensajeEnviado = new System.Windows.Forms.RichTextBox();
            this.btnMostrarMensaje = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.txtMensaje = new System.Windows.Forms.TextBox();
            this.tmrEscuchar = new System.Windows.Forms.Timer(this.components);
            this.tmrRecibir = new System.Windows.Forms.Timer(this.components);
            this.tmrIniciar = new System.Windows.Forms.Timer(this.components);
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 39);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(88, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Ingrese Mensaje:";
            // 
            // rtbMensajeEnviado
            // 
            this.rtbMensajeEnviado.Location = new System.Drawing.Point(111, 94);
            this.rtbMensajeEnviado.Name = "rtbMensajeEnviado";
            this.rtbMensajeEnviado.Size = new System.Drawing.Size(442, 226);
            this.rtbMensajeEnviado.TabIndex = 3;
            this.rtbMensajeEnviado.Text = "";
            // 
            // btnMostrarMensaje
            // 
            this.btnMostrarMensaje.Location = new System.Drawing.Point(442, 65);
            this.btnMostrarMensaje.Name = "btnMostrarMensaje";
            this.btnMostrarMensaje.Size = new System.Drawing.Size(111, 23);
            this.btnMostrarMensaje.TabIndex = 2;
            this.btnMostrarMensaje.Text = "Mostarar mensaje";
            this.btnMostrarMensaje.UseVisualStyleBackColor = true;
            this.btnMostrarMensaje.Click += new System.EventHandler(this.btnMostrarMensaje_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(111, 75);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(101, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Mensajes enviados:";
            // 
            // txtMensaje
            // 
            this.txtMensaje.Location = new System.Drawing.Point(111, 39);
            this.txtMensaje.Name = "txtMensaje";
            this.txtMensaje.Size = new System.Drawing.Size(442, 20);
            this.txtMensaje.TabIndex = 1;
            // 
            // tmrEscuchar
            // 
            this.tmrEscuchar.Tick += new System.EventHandler(this.tmrEscuchar_Tick);
            // 
            // tmrRecibir
            // 
            this.tmrRecibir.Tick += new System.EventHandler(this.tmrRecibir_Tick);
            // 
            // tmrIniciar
            // 
            this.tmrIniciar.Tick += new System.EventHandler(this.tmrIniciar_Tick);
            // 
            // frm_EnvioMensaje
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Window;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.ClientSize = new System.Drawing.Size(653, 363);
            this.Controls.Add(this.txtMensaje);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btnMostrarMensaje);
            this.Controls.Add(this.rtbMensajeEnviado);
            this.Controls.Add(this.label1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frm_EnvioMensaje";
            this.Text = "Administración de mensajes";
            this.Load += new System.EventHandler(this.frm_EnvioMensaje_Load);
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.frm_EnvioMensaje_FormClosing);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.RichTextBox rtbMensajeEnviado;
        private System.Windows.Forms.Button btnMostrarMensaje;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtMensaje;
        private System.Windows.Forms.Timer tmrEscuchar;
        private System.Windows.Forms.Timer tmrRecibir;
        private System.Windows.Forms.Timer tmrIniciar;
    }
}

