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
            this.tabCruceLlamadas = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.grpInfo = new System.Windows.Forms.GroupBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txtDescripcion = new System.Windows.Forms.TextBox();
            this.txtNombre = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.cmbOperadorDestino = new System.Windows.Forms.ComboBox();
            this.txtTitularDestino = new System.Windows.Forms.TextBox();
            this.txtTelefonoDestino = new System.Windows.Forms.TextBox();
            this.grpOrigen = new System.Windows.Forms.GroupBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.cmbOperadorOrigen = new System.Windows.Forms.ComboBox();
            this.txtTitularOrigen = new System.Windows.Forms.TextBox();
            this.txtTelefonoOrigen = new System.Windows.Forms.TextBox();
            this.btnAnalizar = new System.Windows.Forms.Button();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.grdListadoOrigen = new System.Windows.Forms.DataGridView();
            this.grpListadoOrigen = new System.Windows.Forms.GroupBox();
            this.lblDatosOrigen = new System.Windows.Forms.Label();
            this.btnCargarOrigen = new System.Windows.Forms.Button();
            this.label9 = new System.Windows.Forms.Label();
            this.txtArchivoOrigen = new System.Windows.Forms.TextBox();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.tabPage4 = new System.Windows.Forms.TabPage();
            this.grdResultados = new System.Windows.Forms.DataGridView();
            this.Orden = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TelefonoOrigen = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TelefonoDestino = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.FechaHoraLlamado = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Duracion = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.lblDatosDestino = new System.Windows.Forms.Label();
            this.btnCargarDestino = new System.Windows.Forms.Button();
            this.label11 = new System.Windows.Forms.Label();
            this.txtArchivoDestino = new System.Windows.Forms.TextBox();
            this.OrdenOrigen = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NroTelefonoOrigen = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.FechaHoraOrigen = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DuracionOrigen = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tabCruceLlamadas.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.grpInfo.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.grpOrigen.SuspendLayout();
            this.tabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grdListadoOrigen)).BeginInit();
            this.grpListadoOrigen.SuspendLayout();
            this.tabPage3.SuspendLayout();
            this.tabPage4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grdResultados)).BeginInit();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // tabCruceLlamadas
            // 
            this.tabCruceLlamadas.Controls.Add(this.tabPage1);
            this.tabCruceLlamadas.Controls.Add(this.tabPage2);
            this.tabCruceLlamadas.Controls.Add(this.tabPage3);
            this.tabCruceLlamadas.Controls.Add(this.tabPage4);
            this.tabCruceLlamadas.Location = new System.Drawing.Point(12, 12);
            this.tabCruceLlamadas.Name = "tabCruceLlamadas";
            this.tabCruceLlamadas.SelectedIndex = 0;
            this.tabCruceLlamadas.Size = new System.Drawing.Size(870, 537);
            this.tabCruceLlamadas.SizeMode = System.Windows.Forms.TabSizeMode.Fixed;
            this.tabCruceLlamadas.TabIndex = 16;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.grpInfo);
            this.tabPage1.Controls.Add(this.groupBox1);
            this.tabPage1.Controls.Add(this.grpOrigen);
            this.tabPage1.Controls.Add(this.btnAnalizar);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(862, 511);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "General";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // grpInfo
            // 
            this.grpInfo.Controls.Add(this.label2);
            this.grpInfo.Controls.Add(this.label1);
            this.grpInfo.Controls.Add(this.txtDescripcion);
            this.grpInfo.Controls.Add(this.txtNombre);
            this.grpInfo.Location = new System.Drawing.Point(10, 4);
            this.grpInfo.Name = "grpInfo";
            this.grpInfo.Size = new System.Drawing.Size(842, 188);
            this.grpInfo.TabIndex = 20;
            this.grpInfo.TabStop = false;
            this.grpInfo.Text = "Informacion";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 81);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(66, 13);
            this.label2.TabIndex = 10;
            this.label2.Text = "Descripcion:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 40);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(47, 13);
            this.label1.TabIndex = 9;
            this.label1.Text = "Nombre:";
            // 
            // txtDescripcion
            // 
            this.txtDescripcion.Location = new System.Drawing.Point(78, 78);
            this.txtDescripcion.Multiline = true;
            this.txtDescripcion.Name = "txtDescripcion";
            this.txtDescripcion.Size = new System.Drawing.Size(394, 90);
            this.txtDescripcion.TabIndex = 8;
            // 
            // txtNombre
            // 
            this.txtNombre.Location = new System.Drawing.Point(78, 40);
            this.txtNombre.Name = "txtNombre";
            this.txtNombre.Size = new System.Drawing.Size(394, 20);
            this.txtNombre.TabIndex = 7;
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
            this.groupBox1.Location = new System.Drawing.Point(437, 198);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(415, 177);
            this.groupBox1.TabIndex = 19;
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
            this.grpOrigen.Location = new System.Drawing.Point(10, 198);
            this.grpOrigen.Name = "grpOrigen";
            this.grpOrigen.Size = new System.Drawing.Size(415, 177);
            this.grpOrigen.TabIndex = 18;
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
            // btnAnalizar
            // 
            this.btnAnalizar.Location = new System.Drawing.Point(369, 429);
            this.btnAnalizar.Name = "btnAnalizar";
            this.btnAnalizar.Size = new System.Drawing.Size(128, 34);
            this.btnAnalizar.TabIndex = 17;
            this.btnAnalizar.Text = "&ANALIZAR";
            this.btnAnalizar.UseVisualStyleBackColor = true;
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.grdListadoOrigen);
            this.tabPage2.Controls.Add(this.grpListadoOrigen);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(862, 511);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Origen";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // grdListadoOrigen
            // 
            this.grdListadoOrigen.AllowUserToAddRows = false;
            this.grdListadoOrigen.AllowUserToDeleteRows = false;
            this.grdListadoOrigen.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grdListadoOrigen.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.OrdenOrigen,
            this.NroTelefonoOrigen,
            this.FechaHoraOrigen,
            this.DuracionOrigen});
            this.grdListadoOrigen.Location = new System.Drawing.Point(7, 140);
            this.grdListadoOrigen.Name = "grdListadoOrigen";
            this.grdListadoOrigen.ReadOnly = true;
            this.grdListadoOrigen.Size = new System.Drawing.Size(849, 365);
            this.grdListadoOrigen.TabIndex = 1;
            // 
            // grpListadoOrigen
            // 
            this.grpListadoOrigen.Controls.Add(this.lblDatosOrigen);
            this.grpListadoOrigen.Controls.Add(this.btnCargarOrigen);
            this.grpListadoOrigen.Controls.Add(this.label9);
            this.grpListadoOrigen.Controls.Add(this.txtArchivoOrigen);
            this.grpListadoOrigen.Location = new System.Drawing.Point(7, 7);
            this.grpListadoOrigen.Name = "grpListadoOrigen";
            this.grpListadoOrigen.Size = new System.Drawing.Size(849, 126);
            this.grpListadoOrigen.TabIndex = 0;
            this.grpListadoOrigen.TabStop = false;
            // 
            // lblDatosOrigen
            // 
            this.lblDatosOrigen.AutoSize = true;
            this.lblDatosOrigen.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDatosOrigen.Location = new System.Drawing.Point(7, 20);
            this.lblDatosOrigen.Name = "lblDatosOrigen";
            this.lblDatosOrigen.Size = new System.Drawing.Size(157, 13);
            this.lblDatosOrigen.TabIndex = 3;
            this.lblDatosOrigen.Text = "Todos los datos del origen";
            // 
            // btnCargarOrigen
            // 
            this.btnCargarOrigen.Location = new System.Drawing.Point(696, 51);
            this.btnCargarOrigen.Name = "btnCargarOrigen";
            this.btnCargarOrigen.Size = new System.Drawing.Size(75, 23);
            this.btnCargarOrigen.TabIndex = 2;
            this.btnCargarOrigen.Text = "Cargar";
            this.btnCargarOrigen.UseVisualStyleBackColor = true;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(7, 81);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(46, 13);
            this.label9.TabIndex = 1;
            this.label9.Text = "Archivo:";
            // 
            // txtArchivoOrigen
            // 
            this.txtArchivoOrigen.Enabled = false;
            this.txtArchivoOrigen.Location = new System.Drawing.Point(59, 81);
            this.txtArchivoOrigen.Name = "txtArchivoOrigen";
            this.txtArchivoOrigen.Size = new System.Drawing.Size(478, 20);
            this.txtArchivoOrigen.TabIndex = 0;
            // 
            // tabPage3
            // 
            this.tabPage3.Controls.Add(this.dataGridView1);
            this.tabPage3.Controls.Add(this.groupBox2);
            this.tabPage3.Location = new System.Drawing.Point(4, 22);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage3.Size = new System.Drawing.Size(862, 511);
            this.tabPage3.TabIndex = 2;
            this.tabPage3.Text = "Destino";
            this.tabPage3.UseVisualStyleBackColor = true;
            // 
            // tabPage4
            // 
            this.tabPage4.Controls.Add(this.groupBox3);
            this.tabPage4.Controls.Add(this.grdResultados);
            this.tabPage4.Location = new System.Drawing.Point(4, 22);
            this.tabPage4.Name = "tabPage4";
            this.tabPage4.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage4.Size = new System.Drawing.Size(862, 511);
            this.tabPage4.TabIndex = 3;
            this.tabPage4.Text = "Resultados";
            this.tabPage4.UseVisualStyleBackColor = true;
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
            this.grdResultados.Location = new System.Drawing.Point(7, 164);
            this.grdResultados.Name = "grdResultados";
            this.grdResultados.ReadOnly = true;
            this.grdResultados.Size = new System.Drawing.Size(849, 341);
            this.grdResultados.TabIndex = 17;
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
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.lblDatosDestino);
            this.groupBox2.Controls.Add(this.btnCargarDestino);
            this.groupBox2.Controls.Add(this.label11);
            this.groupBox2.Controls.Add(this.txtArchivoDestino);
            this.groupBox2.Location = new System.Drawing.Point(7, 6);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(849, 126);
            this.groupBox2.TabIndex = 2;
            this.groupBox2.TabStop = false;
            // 
            // lblDatosDestino
            // 
            this.lblDatosDestino.AutoSize = true;
            this.lblDatosDestino.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDatosDestino.Location = new System.Drawing.Point(7, 20);
            this.lblDatosDestino.Name = "lblDatosDestino";
            this.lblDatosDestino.Size = new System.Drawing.Size(157, 13);
            this.lblDatosDestino.TabIndex = 3;
            this.lblDatosDestino.Text = "Todos los datos del origen";
            // 
            // btnCargarDestino
            // 
            this.btnCargarDestino.Location = new System.Drawing.Point(696, 51);
            this.btnCargarDestino.Name = "btnCargarDestino";
            this.btnCargarDestino.Size = new System.Drawing.Size(75, 23);
            this.btnCargarDestino.TabIndex = 2;
            this.btnCargarDestino.Text = "Cargar";
            this.btnCargarDestino.UseVisualStyleBackColor = true;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(7, 81);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(46, 13);
            this.label11.TabIndex = 1;
            this.label11.Text = "Archivo:";
            // 
            // txtArchivoDestino
            // 
            this.txtArchivoDestino.Enabled = false;
            this.txtArchivoDestino.Location = new System.Drawing.Point(59, 81);
            this.txtArchivoDestino.Name = "txtArchivoDestino";
            this.txtArchivoDestino.Size = new System.Drawing.Size(478, 20);
            this.txtArchivoDestino.TabIndex = 0;
            // 
            // OrdenOrigen
            // 
            this.OrdenOrigen.HeaderText = "Orden";
            this.OrdenOrigen.MinimumWidth = 50;
            this.OrdenOrigen.Name = "OrdenOrigen";
            this.OrdenOrigen.ReadOnly = true;
            this.OrdenOrigen.Width = 50;
            // 
            // NroTelefonoOrigen
            // 
            this.NroTelefonoOrigen.HeaderText = "Telefono";
            this.NroTelefonoOrigen.MinimumWidth = 250;
            this.NroTelefonoOrigen.Name = "NroTelefonoOrigen";
            this.NroTelefonoOrigen.ReadOnly = true;
            this.NroTelefonoOrigen.Width = 250;
            // 
            // FechaHoraOrigen
            // 
            this.FechaHoraOrigen.HeaderText = "Fecha/Hora";
            this.FechaHoraOrigen.MinimumWidth = 150;
            this.FechaHoraOrigen.Name = "FechaHoraOrigen";
            this.FechaHoraOrigen.ReadOnly = true;
            this.FechaHoraOrigen.Width = 150;
            // 
            // DuracionOrigen
            // 
            this.DuracionOrigen.HeaderText = "Duracion";
            this.DuracionOrigen.MinimumWidth = 200;
            this.DuracionOrigen.Name = "DuracionOrigen";
            this.DuracionOrigen.ReadOnly = true;
            this.DuracionOrigen.Width = 200;
            // 
            // groupBox3
            // 
            this.groupBox3.Location = new System.Drawing.Point(7, 7);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(849, 151);
            this.groupBox3.TabIndex = 18;
            this.groupBox3.TabStop = false;
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn3,
            this.dataGridViewTextBoxColumn4});
            this.dataGridView1.Location = new System.Drawing.Point(7, 138);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.Size = new System.Drawing.Size(849, 365);
            this.dataGridView1.TabIndex = 3;
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.HeaderText = "Orden";
            this.dataGridViewTextBoxColumn1.MinimumWidth = 50;
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.ReadOnly = true;
            this.dataGridViewTextBoxColumn1.Width = 50;
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.HeaderText = "Telefono";
            this.dataGridViewTextBoxColumn2.MinimumWidth = 250;
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            this.dataGridViewTextBoxColumn2.ReadOnly = true;
            this.dataGridViewTextBoxColumn2.Width = 250;
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.HeaderText = "Fecha/Hora";
            this.dataGridViewTextBoxColumn3.MinimumWidth = 150;
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            this.dataGridViewTextBoxColumn3.ReadOnly = true;
            this.dataGridViewTextBoxColumn3.Width = 150;
            // 
            // dataGridViewTextBoxColumn4
            // 
            this.dataGridViewTextBoxColumn4.HeaderText = "Duracion";
            this.dataGridViewTextBoxColumn4.MinimumWidth = 200;
            this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            this.dataGridViewTextBoxColumn4.ReadOnly = true;
            this.dataGridViewTextBoxColumn4.Width = 200;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(894, 561);
            this.Controls.Add(this.tabCruceLlamadas);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Form1";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Form1";
            this.tabCruceLlamadas.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.grpInfo.ResumeLayout(false);
            this.grpInfo.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.grpOrigen.ResumeLayout(false);
            this.grpOrigen.PerformLayout();
            this.tabPage2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.grdListadoOrigen)).EndInit();
            this.grpListadoOrigen.ResumeLayout(false);
            this.grpListadoOrigen.PerformLayout();
            this.tabPage3.ResumeLayout(false);
            this.tabPage4.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.grdResultados)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);

        }

        private void btnAnalizar_Click(object sender, System.EventArgs e)
        {
            throw new System.NotImplementedException();
        }

        #endregion

        private System.Windows.Forms.TabControl tabCruceLlamadas;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.TabPage tabPage3;
        private System.Windows.Forms.TabPage tabPage4;
        private System.Windows.Forms.GroupBox grpInfo;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtDescripcion;
        private System.Windows.Forms.TextBox txtNombre;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.ComboBox cmbOperadorDestino;
        private System.Windows.Forms.TextBox txtTitularDestino;
        private System.Windows.Forms.TextBox txtTelefonoDestino;
        private System.Windows.Forms.GroupBox grpOrigen;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox cmbOperadorOrigen;
        private System.Windows.Forms.TextBox txtTitularOrigen;
        private System.Windows.Forms.TextBox txtTelefonoOrigen;
        private System.Windows.Forms.Button btnAnalizar;
        private System.Windows.Forms.DataGridView grdListadoOrigen;
        private System.Windows.Forms.GroupBox grpListadoOrigen;
        private System.Windows.Forms.Button btnCargarOrigen;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox txtArchivoOrigen;
        private System.Windows.Forms.Label lblDatosOrigen;
        private System.Windows.Forms.DataGridView grdResultados;
        private System.Windows.Forms.DataGridViewTextBoxColumn Orden;
        private System.Windows.Forms.DataGridViewTextBoxColumn TelefonoOrigen;
        private System.Windows.Forms.DataGridViewTextBoxColumn TelefonoDestino;
        private System.Windows.Forms.DataGridViewTextBoxColumn FechaHoraLlamado;
        private System.Windows.Forms.DataGridViewTextBoxColumn Duracion;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label lblDatosDestino;
        private System.Windows.Forms.Button btnCargarDestino;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox txtArchivoDestino;
        private System.Windows.Forms.DataGridViewTextBoxColumn OrdenOrigen;
        private System.Windows.Forms.DataGridViewTextBoxColumn NroTelefonoOrigen;
        private System.Windows.Forms.DataGridViewTextBoxColumn FechaHoraOrigen;
        private System.Windows.Forms.DataGridViewTextBoxColumn DuracionOrigen;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;

    }
}

