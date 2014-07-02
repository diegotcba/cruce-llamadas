namespace CruceLlamadas
{
    partial class Form1
    {
        /// <summary>
        /// Variable del diseñador requerida.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén utilizando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben eliminar; false en caso contrario.</param>
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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.Orden = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TelefonoOrigen = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TelefonoDestino = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.FechaHoraLlamado = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Duracion = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnAnalizar = new System.Windows.Forms.Button();
            this.txtNombre = new System.Windows.Forms.TextBox();
            this.txtDescripcion = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.grpOrigen = new System.Windows.Forms.GroupBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.cmbOperadorOrigen = new System.Windows.Forms.ComboBox();
            this.txtTitularOrigen = new System.Windows.Forms.TextBox();
            this.txtTelefonoOrigen = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.grpOrigen.SuspendLayout();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Orden,
            this.TelefonoOrigen,
            this.TelefonoDestino,
            this.FechaHoraLlamado,
            this.Duracion});
            this.dataGridView1.Location = new System.Drawing.Point(12, 304);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.Size = new System.Drawing.Size(842, 204);
            this.dataGridView1.TabIndex = 0;
            // 
            // Orden
            // 
            this.Orden.HeaderText = "Orden";
            this.Orden.MinimumWidth = 50;
            this.Orden.Name = "Orden";
            this.Orden.ReadOnly = true;
            this.Orden.Width = 50;
            // 
            // TelefonoOrigen
            // 
            this.TelefonoOrigen.HeaderText = "De";
            this.TelefonoOrigen.MinimumWidth = 250;
            this.TelefonoOrigen.Name = "TelefonoOrigen";
            this.TelefonoOrigen.ReadOnly = true;
            this.TelefonoOrigen.Width = 250;
            // 
            // TelefonoDestino
            // 
            this.TelefonoDestino.HeaderText = "A";
            this.TelefonoDestino.MinimumWidth = 250;
            this.TelefonoDestino.Name = "TelefonoDestino";
            this.TelefonoDestino.ReadOnly = true;
            this.TelefonoDestino.Width = 250;
            // 
            // FechaHoraLlamado
            // 
            this.FechaHoraLlamado.HeaderText = "Fecha/Hora";
            this.FechaHoraLlamado.MinimumWidth = 130;
            this.FechaHoraLlamado.Name = "FechaHoraLlamado";
            this.FechaHoraLlamado.ReadOnly = true;
            this.FechaHoraLlamado.Width = 130;
            // 
            // Duracion
            // 
            this.Duracion.HeaderText = "Duracion";
            this.Duracion.MinimumWidth = 100;
            this.Duracion.Name = "Duracion";
            this.Duracion.ReadOnly = true;
            // 
            // btnAnalizar
            // 
            this.btnAnalizar.Location = new System.Drawing.Point(369, 253);
            this.btnAnalizar.Name = "btnAnalizar";
            this.btnAnalizar.Size = new System.Drawing.Size(128, 34);
            this.btnAnalizar.TabIndex = 1;
            this.btnAnalizar.Text = "&Analizar";
            this.btnAnalizar.UseVisualStyleBackColor = true;
            // 
            // txtNombre
            // 
            this.txtNombre.Location = new System.Drawing.Point(62, 13);
            this.txtNombre.Name = "txtNombre";
            this.txtNombre.Size = new System.Drawing.Size(354, 20);
            this.txtNombre.TabIndex = 3;
            // 
            // txtDescripcion
            // 
            this.txtDescripcion.Location = new System.Drawing.Point(504, 16);
            this.txtDescripcion.Multiline = true;
            this.txtDescripcion.Name = "txtDescripcion";
            this.txtDescripcion.Size = new System.Drawing.Size(350, 61);
            this.txtDescripcion.TabIndex = 4;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(9, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(47, 13);
            this.label1.TabIndex = 5;
            this.label1.Text = "Nombre:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(432, 19);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(66, 13);
            this.label2.TabIndex = 6;
            this.label2.Text = "Descripcion:";
            // 
            // grpOrigen
            // 
            this.grpOrigen.Controls.Add(this.label5);
            this.grpOrigen.Controls.Add(this.label4);
            this.grpOrigen.Controls.Add(this.label3);
            this.grpOrigen.Controls.Add(this.cmbOperadorOrigen);
            this.grpOrigen.Controls.Add(this.txtTitularOrigen);
            this.grpOrigen.Controls.Add(this.txtTelefonoOrigen);
            this.grpOrigen.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.grpOrigen.Location = new System.Drawing.Point(12, 95);
            this.grpOrigen.Name = "grpOrigen";
            this.grpOrigen.Size = new System.Drawing.Size(421, 141);
            this.grpOrigen.TabIndex = 13;
            this.grpOrigen.TabStop = false;
            this.grpOrigen.Text = "Origen";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(6, 87);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(54, 13);
            this.label5.TabIndex = 18;
            this.label5.Text = "Operador:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(6, 60);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(39, 13);
            this.label4.TabIndex = 17;
            this.label4.Text = "Titular:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(6, 33);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(83, 13);
            this.label3.TabIndex = 16;
            this.label3.Text = "Nro. Telefonico:";
            // 
            // cmbOperadorOrigen
            // 
            this.cmbOperadorOrigen.FormattingEnabled = true;
            this.cmbOperadorOrigen.Location = new System.Drawing.Point(105, 87);
            this.cmbOperadorOrigen.Name = "cmbOperadorOrigen";
            this.cmbOperadorOrigen.Size = new System.Drawing.Size(169, 21);
            this.cmbOperadorOrigen.TabIndex = 15;
            // 
            // txtTitularOrigen
            // 
            this.txtTitularOrigen.Location = new System.Drawing.Point(105, 60);
            this.txtTitularOrigen.Name = "txtTitularOrigen";
            this.txtTitularOrigen.Size = new System.Drawing.Size(253, 20);
            this.txtTitularOrigen.TabIndex = 14;
            // 
            // txtTelefonoOrigen
            // 
            this.txtTelefonoOrigen.Location = new System.Drawing.Point(105, 33);
            this.txtTelefonoOrigen.Name = "txtTelefonoOrigen";
            this.txtTelefonoOrigen.Size = new System.Drawing.Size(199, 20);
            this.txtTelefonoOrigen.TabIndex = 13;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(866, 520);
            this.Controls.Add(this.grpOrigen);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtDescripcion);
            this.Controls.Add(this.txtNombre);
            this.Controls.Add(this.btnAnalizar);
            this.Controls.Add(this.dataGridView1);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Form1";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.grpOrigen.ResumeLayout(false);
            this.grpOrigen.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        private void btnAnalizar_Click(object sender, System.EventArgs e)
        {
            throw new System.NotImplementedException();
        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button btnAnalizar;
        private System.Windows.Forms.DataGridViewTextBoxColumn Orden;
        private System.Windows.Forms.DataGridViewTextBoxColumn TelefonoOrigen;
        private System.Windows.Forms.DataGridViewTextBoxColumn TelefonoDestino;
        private System.Windows.Forms.DataGridViewTextBoxColumn FechaHoraLlamado;
        private System.Windows.Forms.DataGridViewTextBoxColumn Duracion;
        private System.Windows.Forms.TextBox txtNombre;
        private System.Windows.Forms.TextBox txtDescripcion;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.GroupBox grpOrigen;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox cmbOperadorOrigen;
        private System.Windows.Forms.TextBox txtTitularOrigen;
        private System.Windows.Forms.TextBox txtTelefonoOrigen;
    }
}

