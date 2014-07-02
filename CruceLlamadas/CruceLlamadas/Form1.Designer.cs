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
            this.grdResultados = new System.Windows.Forms.DataGridView();
            this.Orden = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TelefonoOrigen = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TelefonoDestino = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.FechaHoraLlamado = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Duracion = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnAnalizar = new System.Windows.Forms.Button();
            this.grpOrigen = new System.Windows.Forms.GroupBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.cmbOperadorOrigen = new System.Windows.Forms.ComboBox();
            this.txtTitularOrigen = new System.Windows.Forms.TextBox();
            this.txtTelefonoOrigen = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.cmbOperadorDestino = new System.Windows.Forms.ComboBox();
            this.txtTitularDestino = new System.Windows.Forms.TextBox();
            this.txtTelefonoDestino = new System.Windows.Forms.TextBox();
            this.grpInfo = new System.Windows.Forms.GroupBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txtDescripcion = new System.Windows.Forms.TextBox();
            this.txtNombre = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.grdResultados)).BeginInit();
            this.grpOrigen.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.grpInfo.SuspendLayout();
            this.SuspendLayout();
            // 
            // grdResultados
            // 
            this.grdResultados.AllowUserToAddRows = false;
            this.grdResultados.AllowUserToDeleteRows = false;
            this.grdResultados.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grdResultados.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Orden,
            this.TelefonoOrigen,
            this.TelefonoDestino,
            this.FechaHoraLlamado,
            this.Duracion});
            this.grdResultados.Location = new System.Drawing.Point(12, 326);
            this.grdResultados.Name = "grdResultados";
            this.grdResultados.ReadOnly = true;
            this.grdResultados.Size = new System.Drawing.Size(842, 182);
            this.grdResultados.TabIndex = 0;
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
            this.btnAnalizar.Location = new System.Drawing.Point(369, 274);
            this.btnAnalizar.Name = "btnAnalizar";
            this.btnAnalizar.Size = new System.Drawing.Size(128, 34);
            this.btnAnalizar.TabIndex = 1;
            this.btnAnalizar.Text = "&Analizar";
            this.btnAnalizar.UseVisualStyleBackColor = true;
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
            this.grpOrigen.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grpOrigen.Location = new System.Drawing.Point(12, 107);
            this.grpOrigen.Name = "grpOrigen";
            this.grpOrigen.Size = new System.Drawing.Size(415, 150);
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
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.label8);
            this.groupBox1.Controls.Add(this.cmbOperadorDestino);
            this.groupBox1.Controls.Add(this.txtTitularDestino);
            this.groupBox1.Controls.Add(this.txtTelefonoDestino);
            this.groupBox1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(439, 107);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(415, 150);
            this.groupBox1.TabIndex = 14;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Destino";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(6, 87);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(54, 13);
            this.label6.TabIndex = 18;
            this.label6.Text = "Operador:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(6, 60);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(39, 13);
            this.label7.TabIndex = 17;
            this.label7.Text = "Titular:";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(6, 33);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(83, 13);
            this.label8.TabIndex = 16;
            this.label8.Text = "Nro. Telefonico:";
            // 
            // cmbOperadorDestino
            // 
            this.cmbOperadorDestino.FormattingEnabled = true;
            this.cmbOperadorDestino.Location = new System.Drawing.Point(105, 87);
            this.cmbOperadorDestino.Name = "cmbOperadorDestino";
            this.cmbOperadorDestino.Size = new System.Drawing.Size(169, 21);
            this.cmbOperadorDestino.TabIndex = 15;
            // 
            // txtTitularDestino
            // 
            this.txtTitularDestino.Location = new System.Drawing.Point(105, 60);
            this.txtTitularDestino.Name = "txtTitularDestino";
            this.txtTitularDestino.Size = new System.Drawing.Size(253, 20);
            this.txtTitularDestino.TabIndex = 14;
            // 
            // txtTelefonoDestino
            // 
            this.txtTelefonoDestino.Location = new System.Drawing.Point(105, 33);
            this.txtTelefonoDestino.Name = "txtTelefonoDestino";
            this.txtTelefonoDestino.Size = new System.Drawing.Size(199, 20);
            this.txtTelefonoDestino.TabIndex = 13;
            // 
            // grpInfo
            // 
            this.grpInfo.Controls.Add(this.label2);
            this.grpInfo.Controls.Add(this.label1);
            this.grpInfo.Controls.Add(this.txtDescripcion);
            this.grpInfo.Controls.Add(this.txtNombre);
            this.grpInfo.Location = new System.Drawing.Point(12, 12);
            this.grpInfo.Name = "grpInfo";
            this.grpInfo.Size = new System.Drawing.Size(842, 89);
            this.grpInfo.TabIndex = 15;
            this.grpInfo.TabStop = false;
            this.grpInfo.Text = "Informacion";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(437, 24);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(66, 13);
            this.label2.TabIndex = 10;
            this.label2.Text = "Descripcion:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 21);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(47, 13);
            this.label1.TabIndex = 9;
            this.label1.Text = "Nombre:";
            // 
            // txtDescripcion
            // 
            this.txtDescripcion.Location = new System.Drawing.Point(509, 21);
            this.txtDescripcion.Multiline = true;
            this.txtDescripcion.Name = "txtDescripcion";
            this.txtDescripcion.Size = new System.Drawing.Size(319, 50);
            this.txtDescripcion.TabIndex = 8;
            // 
            // txtNombre
            // 
            this.txtNombre.Location = new System.Drawing.Point(59, 21);
            this.txtNombre.Name = "txtNombre";
            this.txtNombre.Size = new System.Drawing.Size(321, 20);
            this.txtNombre.TabIndex = 7;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(866, 520);
            this.Controls.Add(this.grpInfo);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.grpOrigen);
            this.Controls.Add(this.btnAnalizar);
            this.Controls.Add(this.grdResultados);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Form1";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.grdResultados)).EndInit();
            this.grpOrigen.ResumeLayout(false);
            this.grpOrigen.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.grpInfo.ResumeLayout(false);
            this.grpInfo.PerformLayout();
            this.ResumeLayout(false);

        }

        private void btnAnalizar_Click(object sender, System.EventArgs e)
        {
            throw new System.NotImplementedException();
        }

        #endregion

        private System.Windows.Forms.DataGridView grdResultados;
        private System.Windows.Forms.Button btnAnalizar;
        private System.Windows.Forms.DataGridViewTextBoxColumn Orden;
        private System.Windows.Forms.DataGridViewTextBoxColumn TelefonoOrigen;
        private System.Windows.Forms.DataGridViewTextBoxColumn TelefonoDestino;
        private System.Windows.Forms.DataGridViewTextBoxColumn FechaHoraLlamado;
        private System.Windows.Forms.DataGridViewTextBoxColumn Duracion;
        private System.Windows.Forms.GroupBox grpOrigen;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox cmbOperadorOrigen;
        private System.Windows.Forms.TextBox txtTitularOrigen;
        private System.Windows.Forms.TextBox txtTelefonoOrigen;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.ComboBox cmbOperadorDestino;
        private System.Windows.Forms.TextBox txtTitularDestino;
        private System.Windows.Forms.TextBox txtTelefonoDestino;
        private System.Windows.Forms.GroupBox grpInfo;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtDescripcion;
        private System.Windows.Forms.TextBox txtNombre;
    }
}

