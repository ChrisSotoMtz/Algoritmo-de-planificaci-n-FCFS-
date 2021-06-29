
namespace Actividad_6
{
    partial class Form1
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.buttonStart = new System.Windows.Forms.Button();
            this.botonCerrar = new System.Windows.Forms.PictureBox();
            this.botonMinimizar = new System.Windows.Forms.PictureBox();
            this.buttonAgregar = new System.Windows.Forms.Button();
            this.tablaMemoria = new System.Windows.Forms.ListView();
            this.id = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.op = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.resultado = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.tablaBloqueados = new System.Windows.Forms.ListView();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader9 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.tablaTerminados = new System.Windows.Forms.ListView();
            this.columnHeader6 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader7 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader8 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader3 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader4 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader5 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader10 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader11 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader12 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.textBox8 = new System.Windows.Forms.TextBox();
            this.textBox7 = new System.Windows.Forms.TextBox();
            this.textBox5 = new System.Windows.Forms.TextBox();
            this.tbTiempo = new System.Windows.Forms.TextBox();
            this.tbOp = new System.Windows.Forms.TextBox();
            this.tbID = new System.Windows.Forms.TextBox();
            this.RepeatButton = new System.Windows.Forms.PictureBox();
            this.estado_Tb = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.textBox9 = new System.Windows.Forms.TextBox();
            this.cantidad_tb = new System.Windows.Forms.TextBox();
            this.shapeContainer1 = new Microsoft.VisualBasic.PowerPacks.ShapeContainer();
            this.lineShape2 = new Microsoft.VisualBasic.PowerPacks.LineShape();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.bloqueo = new System.Windows.Forms.Timer(this.components);
            this.Respuesta = new System.Windows.Forms.Timer(this.components);
            this.nuevos = new System.Windows.Forms.TextBox();
            this.tiempoTranscurrido = new System.Windows.Forms.TextBox();
            this.nuevos_tb = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.botonCerrar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.botonMinimizar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.RepeatButton)).BeginInit();
            this.SuspendLayout();
            // 
            // buttonStart
            // 
            this.buttonStart.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(248)))), ((int)(((byte)(158)))), ((int)(((byte)(76)))));
            this.buttonStart.FlatAppearance.BorderSize = 0;
            this.buttonStart.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonStart.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonStart.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(206)))), ((int)(((byte)(41)))), ((int)(((byte)(73)))));
            this.buttonStart.Location = new System.Drawing.Point(754, 139);
            this.buttonStart.Name = "buttonStart";
            this.buttonStart.Size = new System.Drawing.Size(181, 41);
            this.buttonStart.TabIndex = 18;
            this.buttonStart.Text = "Start";
            this.buttonStart.UseVisualStyleBackColor = false;
            this.buttonStart.Click += new System.EventHandler(this.buttonStart_Click);
            // 
            // botonCerrar
            // 
            this.botonCerrar.Image = ((System.Drawing.Image)(resources.GetObject("botonCerrar.Image")));
            this.botonCerrar.Location = new System.Drawing.Point(930, 3);
            this.botonCerrar.Name = "botonCerrar";
            this.botonCerrar.Size = new System.Drawing.Size(31, 31);
            this.botonCerrar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.botonCerrar.TabIndex = 15;
            this.botonCerrar.TabStop = false;
            this.botonCerrar.Click += new System.EventHandler(this.botonCerrar_Click);
            // 
            // botonMinimizar
            // 
            this.botonMinimizar.Image = ((System.Drawing.Image)(resources.GetObject("botonMinimizar.Image")));
            this.botonMinimizar.Location = new System.Drawing.Point(893, 3);
            this.botonMinimizar.Name = "botonMinimizar";
            this.botonMinimizar.Size = new System.Drawing.Size(31, 31);
            this.botonMinimizar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.botonMinimizar.TabIndex = 16;
            this.botonMinimizar.TabStop = false;
            this.botonMinimizar.Click += new System.EventHandler(this.botonMinimizar_Click);
            // 
            // buttonAgregar
            // 
            this.buttonAgregar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(248)))), ((int)(((byte)(158)))), ((int)(((byte)(76)))));
            this.buttonAgregar.FlatAppearance.BorderSize = 0;
            this.buttonAgregar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonAgregar.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonAgregar.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(206)))), ((int)(((byte)(41)))), ((int)(((byte)(73)))));
            this.buttonAgregar.Location = new System.Drawing.Point(754, 92);
            this.buttonAgregar.Name = "buttonAgregar";
            this.buttonAgregar.Size = new System.Drawing.Size(181, 41);
            this.buttonAgregar.TabIndex = 28;
            this.buttonAgregar.Text = "Agregar";
            this.buttonAgregar.UseVisualStyleBackColor = false;
            this.buttonAgregar.Click += new System.EventHandler(this.buttonAgregar_Click);
            // 
            // tablaMemoria
            // 
            this.tablaMemoria.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(239)))), ((int)(((byte)(70)))), ((int)(((byte)(72)))));
            this.tablaMemoria.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.tablaMemoria.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.id,
            this.op,
            this.resultado,
            this.columnHeader2});
            this.tablaMemoria.Cursor = System.Windows.Forms.Cursors.Default;
            this.tablaMemoria.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tablaMemoria.ForeColor = System.Drawing.Color.Ivory;
            this.tablaMemoria.HideSelection = false;
            this.tablaMemoria.Location = new System.Drawing.Point(12, 53);
            this.tablaMemoria.Name = "tablaMemoria";
            this.tablaMemoria.Size = new System.Drawing.Size(360, 174);
            this.tablaMemoria.TabIndex = 29;
            this.tablaMemoria.UseCompatibleStateImageBehavior = false;
            this.tablaMemoria.View = System.Windows.Forms.View.Details;
            // 
            // id
            // 
            this.id.Text = "ID";
            // 
            // op
            // 
            this.op.Text = "Operacion";
            this.op.Width = 114;
            // 
            // resultado
            // 
            this.resultado.Text = "TT";
            this.resultado.Width = 113;
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "TE";
            // 
            // tablaBloqueados
            // 
            this.tablaBloqueados.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(239)))), ((int)(((byte)(70)))), ((int)(((byte)(72)))));
            this.tablaBloqueados.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.tablaBloqueados.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader9});
            this.tablaBloqueados.Cursor = System.Windows.Forms.Cursors.Default;
            this.tablaBloqueados.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tablaBloqueados.ForeColor = System.Drawing.Color.Ivory;
            this.tablaBloqueados.HideSelection = false;
            this.tablaBloqueados.Location = new System.Drawing.Point(401, 53);
            this.tablaBloqueados.Name = "tablaBloqueados";
            this.tablaBloqueados.Size = new System.Drawing.Size(269, 174);
            this.tablaBloqueados.TabIndex = 30;
            this.tablaBloqueados.UseCompatibleStateImageBehavior = false;
            this.tablaBloqueados.View = System.Windows.Forms.View.Details;
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "ID";
            // 
            // columnHeader9
            // 
            this.columnHeader9.Text = "Tiempo de bloqueo";
            this.columnHeader9.Width = 208;
            // 
            // tablaTerminados
            // 
            this.tablaTerminados.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(239)))), ((int)(((byte)(70)))), ((int)(((byte)(72)))));
            this.tablaTerminados.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.tablaTerminados.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader6,
            this.columnHeader7,
            this.columnHeader8,
            this.columnHeader3,
            this.columnHeader4,
            this.columnHeader5,
            this.columnHeader10,
            this.columnHeader11,
            this.columnHeader12});
            this.tablaTerminados.Cursor = System.Windows.Forms.Cursors.Default;
            this.tablaTerminados.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tablaTerminados.ForeColor = System.Drawing.Color.Ivory;
            this.tablaTerminados.HideSelection = false;
            this.tablaTerminados.Location = new System.Drawing.Point(0, 403);
            this.tablaTerminados.Name = "tablaTerminados";
            this.tablaTerminados.Size = new System.Drawing.Size(957, 230);
            this.tablaTerminados.TabIndex = 31;
            this.tablaTerminados.UseCompatibleStateImageBehavior = false;
            this.tablaTerminados.View = System.Windows.Forms.View.Details;
            // 
            // columnHeader6
            // 
            this.columnHeader6.Text = "ID";
            this.columnHeader6.Width = 45;
            // 
            // columnHeader7
            // 
            this.columnHeader7.Text = "Operacion";
            this.columnHeader7.Width = 114;
            // 
            // columnHeader8
            // 
            this.columnHeader8.Text = "Resultado";
            this.columnHeader8.Width = 108;
            // 
            // columnHeader3
            // 
            this.columnHeader3.Text = "Tiempo_Ll";
            this.columnHeader3.Width = 108;
            // 
            // columnHeader4
            // 
            this.columnHeader4.Text = "Tiempo_Fina";
            this.columnHeader4.Width = 130;
            // 
            // columnHeader5
            // 
            this.columnHeader5.Text = "TiempoRetor";
            this.columnHeader5.Width = 128;
            // 
            // columnHeader10
            // 
            this.columnHeader10.Text = "TiempoResp";
            this.columnHeader10.Width = 126;
            // 
            // columnHeader11
            // 
            this.columnHeader11.Text = "TiempoEsp";
            this.columnHeader11.Width = 113;
            // 
            // columnHeader12
            // 
            this.columnHeader12.Text = "TiempoServ";
            this.columnHeader12.Width = 120;
            // 
            // textBox8
            // 
            this.textBox8.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(125)))), ((int)(((byte)(43)))), ((int)(((byte)(58)))));
            this.textBox8.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox8.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox8.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.textBox8.Location = new System.Drawing.Point(172, 323);
            this.textBox8.Name = "textBox8";
            this.textBox8.ReadOnly = true;
            this.textBox8.Size = new System.Drawing.Size(159, 24);
            this.textBox8.TabIndex = 60;
            this.textBox8.Text = "Tiempo Estimado";
            this.textBox8.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // textBox7
            // 
            this.textBox7.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(125)))), ((int)(((byte)(43)))), ((int)(((byte)(58)))));
            this.textBox7.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox7.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox7.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.textBox7.Location = new System.Drawing.Point(172, 288);
            this.textBox7.Name = "textBox7";
            this.textBox7.ReadOnly = true;
            this.textBox7.ScrollBars = System.Windows.Forms.ScrollBars.Horizontal;
            this.textBox7.Size = new System.Drawing.Size(159, 24);
            this.textBox7.TabIndex = 59;
            this.textBox7.Text = "Operacion";
            this.textBox7.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // textBox5
            // 
            this.textBox5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(125)))), ((int)(((byte)(43)))), ((int)(((byte)(58)))));
            this.textBox5.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox5.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox5.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.textBox5.Location = new System.Drawing.Point(172, 248);
            this.textBox5.Name = "textBox5";
            this.textBox5.ReadOnly = true;
            this.textBox5.Size = new System.Drawing.Size(159, 24);
            this.textBox5.TabIndex = 58;
            this.textBox5.Text = "ID";
            this.textBox5.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // tbTiempo
            // 
            this.tbTiempo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(125)))), ((int)(((byte)(43)))), ((int)(((byte)(58)))));
            this.tbTiempo.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbTiempo.ForeColor = System.Drawing.Color.LimeGreen;
            this.tbTiempo.Location = new System.Drawing.Point(337, 321);
            this.tbTiempo.Name = "tbTiempo";
            this.tbTiempo.ReadOnly = true;
            this.tbTiempo.Size = new System.Drawing.Size(148, 27);
            this.tbTiempo.TabIndex = 57;
            this.tbTiempo.TabStop = false;
            // 
            // tbOp
            // 
            this.tbOp.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(125)))), ((int)(((byte)(43)))), ((int)(((byte)(58)))));
            this.tbOp.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbOp.ForeColor = System.Drawing.Color.LimeGreen;
            this.tbOp.Location = new System.Drawing.Point(337, 285);
            this.tbOp.Name = "tbOp";
            this.tbOp.ReadOnly = true;
            this.tbOp.Size = new System.Drawing.Size(148, 27);
            this.tbOp.TabIndex = 56;
            this.tbOp.TabStop = false;
            // 
            // tbID
            // 
            this.tbID.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(125)))), ((int)(((byte)(43)))), ((int)(((byte)(58)))));
            this.tbID.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbID.ForeColor = System.Drawing.Color.LimeGreen;
            this.tbID.Location = new System.Drawing.Point(337, 248);
            this.tbID.Name = "tbID";
            this.tbID.ReadOnly = true;
            this.tbID.Size = new System.Drawing.Size(148, 27);
            this.tbID.TabIndex = 55;
            this.tbID.TabStop = false;
            // 
            // RepeatButton
            // 
            this.RepeatButton.Image = ((System.Drawing.Image)(resources.GetObject("RepeatButton.Image")));
            this.RepeatButton.Location = new System.Drawing.Point(798, 301);
            this.RepeatButton.Name = "RepeatButton";
            this.RepeatButton.Size = new System.Drawing.Size(68, 68);
            this.RepeatButton.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.RepeatButton.TabIndex = 69;
            this.RepeatButton.TabStop = false;
            this.RepeatButton.Click += new System.EventHandler(this.RepeatButton_Click);
            // 
            // estado_Tb
            // 
            this.estado_Tb.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(125)))), ((int)(((byte)(43)))), ((int)(((byte)(58)))));
            this.estado_Tb.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.estado_Tb.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.estado_Tb.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.estado_Tb.Location = new System.Drawing.Point(772, 275);
            this.estado_Tb.Name = "estado_Tb";
            this.estado_Tb.ReadOnly = true;
            this.estado_Tb.Size = new System.Drawing.Size(135, 20);
            this.estado_Tb.TabIndex = 66;
            this.estado_Tb.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // textBox2
            // 
            this.textBox2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(125)))), ((int)(((byte)(43)))), ((int)(((byte)(58)))));
            this.textBox2.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox2.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox2.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.textBox2.Location = new System.Drawing.Point(738, 245);
            this.textBox2.Name = "textBox2";
            this.textBox2.ReadOnly = true;
            this.textBox2.Size = new System.Drawing.Size(186, 24);
            this.textBox2.TabIndex = 65;
            this.textBox2.Text = "Estado";
            this.textBox2.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // textBox9
            // 
            this.textBox9.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(125)))), ((int)(((byte)(43)))), ((int)(((byte)(58)))));
            this.textBox9.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox9.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox9.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.textBox9.Location = new System.Drawing.Point(749, 186);
            this.textBox9.Name = "textBox9";
            this.textBox9.ReadOnly = true;
            this.textBox9.Size = new System.Drawing.Size(186, 24);
            this.textBox9.TabIndex = 63;
            this.textBox9.Text = "Tiempo Transcurrido";
            this.textBox9.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // cantidad_tb
            // 
            this.cantidad_tb.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(125)))), ((int)(((byte)(43)))), ((int)(((byte)(58)))));
            this.cantidad_tb.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.cantidad_tb.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cantidad_tb.ForeColor = System.Drawing.Color.Silver;
            this.cantidad_tb.Location = new System.Drawing.Point(724, 53);
            this.cantidad_tb.Name = "cantidad_tb";
            this.cantidad_tb.Size = new System.Drawing.Size(226, 24);
            this.cantidad_tb.TabIndex = 70;
            this.cantidad_tb.Text = "Cantidad de Procesos";
            this.cantidad_tb.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.cantidad_tb.Enter += new System.EventHandler(this.cantidad_tb_Enter);
            this.cantidad_tb.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.cantidad_tb_KeyPress);
            this.cantidad_tb.Leave += new System.EventHandler(this.cantidad_tb_Leave);
            // 
            // shapeContainer1
            // 
            this.shapeContainer1.Location = new System.Drawing.Point(0, 0);
            this.shapeContainer1.Margin = new System.Windows.Forms.Padding(0);
            this.shapeContainer1.Name = "shapeContainer1";
            this.shapeContainer1.Shapes.AddRange(new Microsoft.VisualBasic.PowerPacks.Shape[] {
            this.lineShape2});
            this.shapeContainer1.Size = new System.Drawing.Size(963, 636);
            this.shapeContainer1.TabIndex = 71;
            this.shapeContainer1.TabStop = false;
            // 
            // lineShape2
            // 
            this.lineShape2.BorderColor = System.Drawing.Color.White;
            this.lineShape2.BorderWidth = 2;
            this.lineShape2.Name = "lineShape2";
            this.lineShape2.X1 = 740;
            this.lineShape2.X2 = 941;
            this.lineShape2.Y1 = 82;
            this.lineShape2.Y2 = 82;
            // 
            // timer1
            // 
            this.timer1.Interval = 1000;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // bloqueo
            // 
            this.bloqueo.Interval = 1000;
            this.bloqueo.Tick += new System.EventHandler(this.bloqueo_Tick);
            // 
            // Respuesta
            // 
            this.Respuesta.Interval = 1000;
            // 
            // nuevos
            // 
            this.nuevos.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(125)))), ((int)(((byte)(43)))), ((int)(((byte)(58)))));
            this.nuevos.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.nuevos.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nuevos.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.nuevos.Location = new System.Drawing.Point(12, 3);
            this.nuevos.Name = "nuevos";
            this.nuevos.ReadOnly = true;
            this.nuevos.Size = new System.Drawing.Size(270, 24);
            this.nuevos.TabIndex = 74;
            this.nuevos.Text = "Procesos Nuevos(En espera)";
            this.nuevos.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // tiempoTranscurrido
            // 
            this.tiempoTranscurrido.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(125)))), ((int)(((byte)(43)))), ((int)(((byte)(58)))));
            this.tiempoTranscurrido.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.tiempoTranscurrido.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tiempoTranscurrido.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(248)))), ((int)(((byte)(158)))), ((int)(((byte)(76)))));
            this.tiempoTranscurrido.Location = new System.Drawing.Point(772, 219);
            this.tiempoTranscurrido.Name = "tiempoTranscurrido";
            this.tiempoTranscurrido.ReadOnly = true;
            this.tiempoTranscurrido.Size = new System.Drawing.Size(135, 20);
            this.tiempoTranscurrido.TabIndex = 75;
            this.tiempoTranscurrido.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // nuevos_tb
            // 
            this.nuevos_tb.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(125)))), ((int)(((byte)(43)))), ((int)(((byte)(58)))));
            this.nuevos_tb.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.nuevos_tb.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nuevos_tb.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(248)))), ((int)(((byte)(158)))), ((int)(((byte)(76)))));
            this.nuevos_tb.Location = new System.Drawing.Point(288, 3);
            this.nuevos_tb.Multiline = true;
            this.nuevos_tb.Name = "nuevos_tb";
            this.nuevos_tb.ReadOnly = true;
            this.nuevos_tb.Size = new System.Drawing.Size(68, 28);
            this.nuevos_tb.TabIndex = 76;
            this.nuevos_tb.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(125)))), ((int)(((byte)(43)))), ((int)(((byte)(58)))));
            this.ClientSize = new System.Drawing.Size(963, 636);
            this.Controls.Add(this.nuevos_tb);
            this.Controls.Add(this.tiempoTranscurrido);
            this.Controls.Add(this.nuevos);
            this.Controls.Add(this.cantidad_tb);
            this.Controls.Add(this.RepeatButton);
            this.Controls.Add(this.estado_Tb);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.textBox9);
            this.Controls.Add(this.textBox8);
            this.Controls.Add(this.textBox7);
            this.Controls.Add(this.textBox5);
            this.Controls.Add(this.tbTiempo);
            this.Controls.Add(this.tbOp);
            this.Controls.Add(this.tbID);
            this.Controls.Add(this.tablaTerminados);
            this.Controls.Add(this.tablaBloqueados);
            this.Controls.Add(this.tablaMemoria);
            this.Controls.Add(this.buttonAgregar);
            this.Controls.Add(this.buttonStart);
            this.Controls.Add(this.botonMinimizar);
            this.Controls.Add(this.botonCerrar);
            this.Controls.Add(this.shapeContainer1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.ImeMode = System.Windows.Forms.ImeMode.Off;
            this.KeyPreview = true;
            this.Name = "Form1";
            this.Opacity = 0.99D;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Agregar";
            this.Load += new System.EventHandler(this.Form1_Load_1);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Form1_KeyDown);
            ((System.ComponentModel.ISupportInitialize)(this.botonCerrar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.botonMinimizar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.RepeatButton)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button buttonStart;
        private System.Windows.Forms.PictureBox botonCerrar;
        private System.Windows.Forms.PictureBox botonMinimizar;
        private System.Windows.Forms.Button buttonAgregar;
        public System.Windows.Forms.ListView tablaMemoria;
        private System.Windows.Forms.ColumnHeader id;
        private System.Windows.Forms.ColumnHeader op;
        private System.Windows.Forms.ColumnHeader resultado;
        public System.Windows.Forms.ListView tablaBloqueados;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        public System.Windows.Forms.ListView tablaTerminados;
        private System.Windows.Forms.ColumnHeader columnHeader6;
        private System.Windows.Forms.ColumnHeader columnHeader7;
        private System.Windows.Forms.ColumnHeader columnHeader8;
        private System.Windows.Forms.TextBox textBox8;
        private System.Windows.Forms.TextBox textBox7;
        private System.Windows.Forms.TextBox textBox5;
        private System.Windows.Forms.TextBox tbTiempo;
        private System.Windows.Forms.TextBox tbOp;
        private System.Windows.Forms.TextBox tbID;
        private System.Windows.Forms.PictureBox RepeatButton;
        private System.Windows.Forms.TextBox estado_Tb;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.TextBox textBox9;
        private System.Windows.Forms.TextBox cantidad_tb;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.ColumnHeader columnHeader9;
        private Microsoft.VisualBasic.PowerPacks.ShapeContainer shapeContainer1;
        private Microsoft.VisualBasic.PowerPacks.LineShape lineShape2;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.ColumnHeader columnHeader3;
        private System.Windows.Forms.ColumnHeader columnHeader4;
        private System.Windows.Forms.ColumnHeader columnHeader5;
        private System.Windows.Forms.ColumnHeader columnHeader10;
        private System.Windows.Forms.ColumnHeader columnHeader11;
        private System.Windows.Forms.ColumnHeader columnHeader12;
        private System.Windows.Forms.Timer bloqueo;
        private System.Windows.Forms.Timer Respuesta;
        private System.Windows.Forms.TextBox nuevos;
        private System.Windows.Forms.TextBox tiempoTranscurrido;
        private System.Windows.Forms.TextBox nuevos_tb;
    }
}

