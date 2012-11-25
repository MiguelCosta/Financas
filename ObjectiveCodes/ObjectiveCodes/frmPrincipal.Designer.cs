namespace ObjectiveCodes
{
    partial class frmPrincipal
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmPrincipal));
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.toolStripDropDownButton1 = new System.Windows.Forms.ToolStripDropDownButton();
            this.abrirFicheirocsvToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.sairToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tbcCSV = new System.Windows.Forms.TabControl();
            this.tbpDados = new System.Windows.Forms.TabPage();
            this.lblProgresso = new System.Windows.Forms.Label();
            this.pgbAnalise = new System.Windows.Forms.ProgressBar();
            this.lblProgressoCount = new System.Windows.Forms.Label();
            this.btnLimpar = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.btnAbrirFicheiro = new System.Windows.Forms.Button();
            this.dgvDados = new System.Windows.Forms.DataGridView();
            this.dgvDados_KYCRSPFUNDNO = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvDados_FSTYBEGDT = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvDados_FSTYENDDT = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvDados_LIPPERCLASS = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvDados_LIPPEROBJCD = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tbpResultado = new System.Windows.Forms.TabPage();
            this.dgvResultado = new System.Windows.Forms.DataGridView();
            this.dgvResultado_KYCRSPFUNDNO = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvResultado_FSTYBEGDT = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvResultado_FSTYENDDT = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvResultado_LIPPERCLASS = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvResultado_LIPPEROBJCD = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvResultado_Warning = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.dgvResultado_Remover = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.tbpWarnings = new System.Windows.Forms.TabPage();
            this.dgvWarning = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewCheckBoxColumn1 = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.dataGridViewCheckBoxColumn2 = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.tbpRemovido = new System.Windows.Forms.TabPage();
            this.dgvRemovido = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn7 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn8 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn9 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn10 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewCheckBoxColumn3 = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.dataGridViewCheckBoxColumn4 = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.tbpFinal = new System.Windows.Forms.TabPage();
            this.dgvResultadoFinal = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn11 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn12 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn13 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn14 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn15 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewCheckBoxColumn5 = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.dataGridViewCheckBoxColumn6 = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.toolStrip1.SuspendLayout();
            this.tbcCSV.SuspendLayout();
            this.tbpDados.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDados)).BeginInit();
            this.tbpResultado.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvResultado)).BeginInit();
            this.tbpWarnings.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvWarning)).BeginInit();
            this.tbpRemovido.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvRemovido)).BeginInit();
            this.tbpFinal.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvResultadoFinal)).BeginInit();
            this.SuspendLayout();
            // 
            // toolStrip1
            // 
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripDropDownButton1});
            this.toolStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(685, 25);
            this.toolStrip1.TabIndex = 0;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // toolStripDropDownButton1
            // 
            this.toolStripDropDownButton1.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.abrirFicheirocsvToolStripMenuItem,
            this.toolStripSeparator1,
            this.sairToolStripMenuItem});
            this.toolStripDropDownButton1.Image = global::ObjectiveCodes.Properties.Resources.home;
            this.toolStripDropDownButton1.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripDropDownButton1.Name = "toolStripDropDownButton1";
            this.toolStripDropDownButton1.Size = new System.Drawing.Size(65, 22);
            this.toolStripDropDownButton1.Text = "Inicio";
            // 
            // abrirFicheirocsvToolStripMenuItem
            // 
            this.abrirFicheirocsvToolStripMenuItem.Image = global::ObjectiveCodes.Properties.Resources.csv_text;
            this.abrirFicheirocsvToolStripMenuItem.Name = "abrirFicheirocsvToolStripMenuItem";
            this.abrirFicheirocsvToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.O)));
            this.abrirFicheirocsvToolStripMenuItem.Size = new System.Drawing.Size(214, 22);
            this.abrirFicheirocsvToolStripMenuItem.Text = "Abrir ficheiro (csv)";
            this.abrirFicheirocsvToolStripMenuItem.Click += new System.EventHandler(this.abrirFicheirocsvToolStripMenuItem_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(211, 6);
            // 
            // sairToolStripMenuItem
            // 
            this.sairToolStripMenuItem.Name = "sairToolStripMenuItem";
            this.sairToolStripMenuItem.Size = new System.Drawing.Size(214, 22);
            this.sairToolStripMenuItem.Text = "Sair";
            this.sairToolStripMenuItem.Click += new System.EventHandler(this.sairToolStripMenuItem_Click);
            // 
            // tbcCSV
            // 
            this.tbcCSV.Controls.Add(this.tbpDados);
            this.tbcCSV.Controls.Add(this.tbpResultado);
            this.tbcCSV.Controls.Add(this.tbpWarnings);
            this.tbcCSV.Controls.Add(this.tbpRemovido);
            this.tbcCSV.Controls.Add(this.tbpFinal);
            this.tbcCSV.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tbcCSV.Location = new System.Drawing.Point(0, 25);
            this.tbcCSV.Name = "tbcCSV";
            this.tbcCSV.SelectedIndex = 0;
            this.tbcCSV.Size = new System.Drawing.Size(685, 415);
            this.tbcCSV.SizeMode = System.Windows.Forms.TabSizeMode.Fixed;
            this.tbcCSV.TabIndex = 1;
            // 
            // tbpDados
            // 
            this.tbpDados.BackColor = System.Drawing.SystemColors.Control;
            this.tbpDados.Controls.Add(this.lblProgresso);
            this.tbpDados.Controls.Add(this.pgbAnalise);
            this.tbpDados.Controls.Add(this.lblProgressoCount);
            this.tbpDados.Controls.Add(this.btnLimpar);
            this.tbpDados.Controls.Add(this.button1);
            this.tbpDados.Controls.Add(this.btnAbrirFicheiro);
            this.tbpDados.Controls.Add(this.dgvDados);
            this.tbpDados.Location = new System.Drawing.Point(4, 22);
            this.tbpDados.Name = "tbpDados";
            this.tbpDados.Padding = new System.Windows.Forms.Padding(3);
            this.tbpDados.Size = new System.Drawing.Size(677, 389);
            this.tbpDados.TabIndex = 0;
            this.tbpDados.Text = "Dados";
            // 
            // lblProgresso
            // 
            this.lblProgresso.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.lblProgresso.AutoSize = true;
            this.lblProgresso.Location = new System.Drawing.Point(260, 329);
            this.lblProgresso.Name = "lblProgresso";
            this.lblProgresso.Size = new System.Drawing.Size(64, 13);
            this.lblProgresso.TabIndex = 7;
            this.lblProgresso.Text = "lblProgresso";
            this.lblProgresso.Visible = false;
            // 
            // pgbAnalise
            // 
            this.pgbAnalise.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pgbAnalise.Location = new System.Drawing.Point(260, 360);
            this.pgbAnalise.Name = "pgbAnalise";
            this.pgbAnalise.Size = new System.Drawing.Size(409, 23);
            this.pgbAnalise.TabIndex = 6;
            this.pgbAnalise.Visible = false;
            // 
            // lblProgressoCount
            // 
            this.lblProgressoCount.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.lblProgressoCount.AutoSize = true;
            this.lblProgressoCount.Location = new System.Drawing.Point(260, 344);
            this.lblProgressoCount.Name = "lblProgressoCount";
            this.lblProgressoCount.Size = new System.Drawing.Size(35, 13);
            this.lblProgressoCount.TabIndex = 5;
            this.lblProgressoCount.Text = "label1";
            this.lblProgressoCount.Visible = false;
            // 
            // btnLimpar
            // 
            this.btnLimpar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnLimpar.Image = global::ObjectiveCodes.Properties.Resources.gnome_edit_clear;
            this.btnLimpar.Location = new System.Drawing.Point(176, 329);
            this.btnLimpar.Name = "btnLimpar";
            this.btnLimpar.Size = new System.Drawing.Size(78, 54);
            this.btnLimpar.TabIndex = 3;
            this.btnLimpar.Text = "Limpar";
            this.btnLimpar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btnLimpar.UseVisualStyleBackColor = true;
            this.btnLimpar.Click += new System.EventHandler(this.btnLimpar_Click);
            // 
            // button1
            // 
            this.button1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.button1.Image = global::ObjectiveCodes.Properties.Resources.edit_find;
            this.button1.Location = new System.Drawing.Point(92, 329);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(78, 54);
            this.button1.TabIndex = 2;
            this.button1.Text = "Analisar";
            this.button1.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.btnAnalisar_Click);
            // 
            // btnAbrirFicheiro
            // 
            this.btnAbrirFicheiro.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnAbrirFicheiro.Image = global::ObjectiveCodes.Properties.Resources.human_document_open;
            this.btnAbrirFicheiro.Location = new System.Drawing.Point(8, 329);
            this.btnAbrirFicheiro.Name = "btnAbrirFicheiro";
            this.btnAbrirFicheiro.Size = new System.Drawing.Size(78, 54);
            this.btnAbrirFicheiro.TabIndex = 1;
            this.btnAbrirFicheiro.Text = "Abrir Ficheiro";
            this.btnAbrirFicheiro.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btnAbrirFicheiro.UseVisualStyleBackColor = true;
            this.btnAbrirFicheiro.Click += new System.EventHandler(this.btnAbrirFicheiro_Click);
            // 
            // dgvDados
            // 
            this.dgvDados.AllowUserToAddRows = false;
            this.dgvDados.AllowUserToDeleteRows = false;
            this.dgvDados.AllowUserToResizeRows = false;
            this.dgvDados.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvDados.BackgroundColor = System.Drawing.SystemColors.Control;
            this.dgvDados.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvDados.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dgvDados_KYCRSPFUNDNO,
            this.dgvDados_FSTYBEGDT,
            this.dgvDados_FSTYENDDT,
            this.dgvDados_LIPPERCLASS,
            this.dgvDados_LIPPEROBJCD});
            this.dgvDados.Location = new System.Drawing.Point(8, 6);
            this.dgvDados.Name = "dgvDados";
            this.dgvDados.RowHeadersVisible = false;
            this.dgvDados.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvDados.Size = new System.Drawing.Size(661, 317);
            this.dgvDados.TabIndex = 0;
            // 
            // dgvDados_KYCRSPFUNDNO
            // 
            this.dgvDados_KYCRSPFUNDNO.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.dgvDados_KYCRSPFUNDNO.HeaderText = "KYCRSP FUNDNO";
            this.dgvDados_KYCRSPFUNDNO.Name = "dgvDados_KYCRSPFUNDNO";
            // 
            // dgvDados_FSTYBEGDT
            // 
            this.dgvDados_FSTYBEGDT.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.dgvDados_FSTYBEGDT.HeaderText = "FSTYBEGDT";
            this.dgvDados_FSTYBEGDT.Name = "dgvDados_FSTYBEGDT";
            // 
            // dgvDados_FSTYENDDT
            // 
            this.dgvDados_FSTYENDDT.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.dgvDados_FSTYENDDT.HeaderText = "FSTYENDDT";
            this.dgvDados_FSTYENDDT.Name = "dgvDados_FSTYENDDT";
            // 
            // dgvDados_LIPPERCLASS
            // 
            this.dgvDados_LIPPERCLASS.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.dgvDados_LIPPERCLASS.HeaderText = "LIPPER CLASS";
            this.dgvDados_LIPPERCLASS.Name = "dgvDados_LIPPERCLASS";
            // 
            // dgvDados_LIPPEROBJCD
            // 
            this.dgvDados_LIPPEROBJCD.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.dgvDados_LIPPEROBJCD.HeaderText = "LIPPER OBJ CD";
            this.dgvDados_LIPPEROBJCD.Name = "dgvDados_LIPPEROBJCD";
            // 
            // tbpResultado
            // 
            this.tbpResultado.BackColor = System.Drawing.SystemColors.Control;
            this.tbpResultado.Controls.Add(this.dgvResultado);
            this.tbpResultado.Location = new System.Drawing.Point(4, 22);
            this.tbpResultado.Name = "tbpResultado";
            this.tbpResultado.Padding = new System.Windows.Forms.Padding(3);
            this.tbpResultado.Size = new System.Drawing.Size(677, 389);
            this.tbpResultado.TabIndex = 1;
            this.tbpResultado.Text = "Resultado";
            // 
            // dgvResultado
            // 
            this.dgvResultado.AllowUserToAddRows = false;
            this.dgvResultado.AllowUserToDeleteRows = false;
            this.dgvResultado.AllowUserToResizeRows = false;
            this.dgvResultado.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvResultado.BackgroundColor = System.Drawing.SystemColors.Control;
            this.dgvResultado.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvResultado.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dgvResultado_KYCRSPFUNDNO,
            this.dgvResultado_FSTYBEGDT,
            this.dgvResultado_FSTYENDDT,
            this.dgvResultado_LIPPERCLASS,
            this.dgvResultado_LIPPEROBJCD,
            this.dgvResultado_Warning,
            this.dgvResultado_Remover});
            this.dgvResultado.Location = new System.Drawing.Point(8, 6);
            this.dgvResultado.Name = "dgvResultado";
            this.dgvResultado.RowHeadersVisible = false;
            this.dgvResultado.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvResultado.Size = new System.Drawing.Size(661, 317);
            this.dgvResultado.TabIndex = 1;
            // 
            // dgvResultado_KYCRSPFUNDNO
            // 
            this.dgvResultado_KYCRSPFUNDNO.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.dgvResultado_KYCRSPFUNDNO.HeaderText = "KYCRSP FUNDNO";
            this.dgvResultado_KYCRSPFUNDNO.Name = "dgvResultado_KYCRSPFUNDNO";
            // 
            // dgvResultado_FSTYBEGDT
            // 
            this.dgvResultado_FSTYBEGDT.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.dgvResultado_FSTYBEGDT.HeaderText = "FSTYBEGDT";
            this.dgvResultado_FSTYBEGDT.Name = "dgvResultado_FSTYBEGDT";
            // 
            // dgvResultado_FSTYENDDT
            // 
            this.dgvResultado_FSTYENDDT.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.dgvResultado_FSTYENDDT.HeaderText = "FSTYENDDT";
            this.dgvResultado_FSTYENDDT.Name = "dgvResultado_FSTYENDDT";
            // 
            // dgvResultado_LIPPERCLASS
            // 
            this.dgvResultado_LIPPERCLASS.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.dgvResultado_LIPPERCLASS.HeaderText = "LIPPER CLASS";
            this.dgvResultado_LIPPERCLASS.Name = "dgvResultado_LIPPERCLASS";
            // 
            // dgvResultado_LIPPEROBJCD
            // 
            this.dgvResultado_LIPPEROBJCD.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.dgvResultado_LIPPEROBJCD.HeaderText = "LIPPER OBJ CD";
            this.dgvResultado_LIPPEROBJCD.Name = "dgvResultado_LIPPEROBJCD";
            // 
            // dgvResultado_Warning
            // 
            this.dgvResultado_Warning.HeaderText = "Warning";
            this.dgvResultado_Warning.Name = "dgvResultado_Warning";
            // 
            // dgvResultado_Remover
            // 
            this.dgvResultado_Remover.HeaderText = "Remover";
            this.dgvResultado_Remover.Name = "dgvResultado_Remover";
            // 
            // tbpWarnings
            // 
            this.tbpWarnings.BackColor = System.Drawing.SystemColors.Control;
            this.tbpWarnings.Controls.Add(this.dgvWarning);
            this.tbpWarnings.Location = new System.Drawing.Point(4, 22);
            this.tbpWarnings.Name = "tbpWarnings";
            this.tbpWarnings.Size = new System.Drawing.Size(677, 389);
            this.tbpWarnings.TabIndex = 2;
            this.tbpWarnings.Text = "Warnings";
            // 
            // dgvWarning
            // 
            this.dgvWarning.AllowUserToAddRows = false;
            this.dgvWarning.AllowUserToDeleteRows = false;
            this.dgvWarning.AllowUserToResizeRows = false;
            this.dgvWarning.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvWarning.BackgroundColor = System.Drawing.SystemColors.Control;
            this.dgvWarning.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvWarning.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn3,
            this.dataGridViewTextBoxColumn4,
            this.dataGridViewTextBoxColumn5,
            this.dataGridViewCheckBoxColumn1,
            this.dataGridViewCheckBoxColumn2});
            this.dgvWarning.Location = new System.Drawing.Point(8, 6);
            this.dgvWarning.Name = "dgvWarning";
            this.dgvWarning.RowHeadersVisible = false;
            this.dgvWarning.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvWarning.Size = new System.Drawing.Size(661, 317);
            this.dgvWarning.TabIndex = 2;
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.dataGridViewTextBoxColumn1.HeaderText = "KYCRSP FUNDNO";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.dataGridViewTextBoxColumn2.HeaderText = "FSTYBEGDT";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.dataGridViewTextBoxColumn3.HeaderText = "FSTYENDDT";
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            // 
            // dataGridViewTextBoxColumn4
            // 
            this.dataGridViewTextBoxColumn4.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.dataGridViewTextBoxColumn4.HeaderText = "LIPPER CLASS";
            this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            // 
            // dataGridViewTextBoxColumn5
            // 
            this.dataGridViewTextBoxColumn5.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.dataGridViewTextBoxColumn5.HeaderText = "LIPPER OBJ CD";
            this.dataGridViewTextBoxColumn5.Name = "dataGridViewTextBoxColumn5";
            // 
            // dataGridViewCheckBoxColumn1
            // 
            this.dataGridViewCheckBoxColumn1.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
            this.dataGridViewCheckBoxColumn1.HeaderText = "Warning";
            this.dataGridViewCheckBoxColumn1.Name = "dataGridViewCheckBoxColumn1";
            this.dataGridViewCheckBoxColumn1.Width = 53;
            // 
            // dataGridViewCheckBoxColumn2
            // 
            this.dataGridViewCheckBoxColumn2.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
            this.dataGridViewCheckBoxColumn2.HeaderText = "Remover";
            this.dataGridViewCheckBoxColumn2.Name = "dataGridViewCheckBoxColumn2";
            this.dataGridViewCheckBoxColumn2.Width = 56;
            // 
            // tbpRemovido
            // 
            this.tbpRemovido.BackColor = System.Drawing.SystemColors.Control;
            this.tbpRemovido.Controls.Add(this.dgvRemovido);
            this.tbpRemovido.Location = new System.Drawing.Point(4, 22);
            this.tbpRemovido.Name = "tbpRemovido";
            this.tbpRemovido.Size = new System.Drawing.Size(677, 389);
            this.tbpRemovido.TabIndex = 3;
            this.tbpRemovido.Text = "Removido";
            // 
            // dgvRemovido
            // 
            this.dgvRemovido.AllowUserToAddRows = false;
            this.dgvRemovido.AllowUserToDeleteRows = false;
            this.dgvRemovido.AllowUserToResizeRows = false;
            this.dgvRemovido.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvRemovido.BackgroundColor = System.Drawing.SystemColors.Control;
            this.dgvRemovido.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvRemovido.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn6,
            this.dataGridViewTextBoxColumn7,
            this.dataGridViewTextBoxColumn8,
            this.dataGridViewTextBoxColumn9,
            this.dataGridViewTextBoxColumn10,
            this.dataGridViewCheckBoxColumn3,
            this.dataGridViewCheckBoxColumn4});
            this.dgvRemovido.Location = new System.Drawing.Point(8, 6);
            this.dgvRemovido.Name = "dgvRemovido";
            this.dgvRemovido.RowHeadersVisible = false;
            this.dgvRemovido.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvRemovido.Size = new System.Drawing.Size(661, 317);
            this.dgvRemovido.TabIndex = 3;
            // 
            // dataGridViewTextBoxColumn6
            // 
            this.dataGridViewTextBoxColumn6.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.dataGridViewTextBoxColumn6.HeaderText = "KYCRSP FUNDNO";
            this.dataGridViewTextBoxColumn6.Name = "dataGridViewTextBoxColumn6";
            // 
            // dataGridViewTextBoxColumn7
            // 
            this.dataGridViewTextBoxColumn7.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.dataGridViewTextBoxColumn7.HeaderText = "FSTYBEGDT";
            this.dataGridViewTextBoxColumn7.Name = "dataGridViewTextBoxColumn7";
            // 
            // dataGridViewTextBoxColumn8
            // 
            this.dataGridViewTextBoxColumn8.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.dataGridViewTextBoxColumn8.HeaderText = "FSTYENDDT";
            this.dataGridViewTextBoxColumn8.Name = "dataGridViewTextBoxColumn8";
            // 
            // dataGridViewTextBoxColumn9
            // 
            this.dataGridViewTextBoxColumn9.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.dataGridViewTextBoxColumn9.HeaderText = "LIPPER CLASS";
            this.dataGridViewTextBoxColumn9.Name = "dataGridViewTextBoxColumn9";
            // 
            // dataGridViewTextBoxColumn10
            // 
            this.dataGridViewTextBoxColumn10.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.dataGridViewTextBoxColumn10.HeaderText = "LIPPER OBJ CD";
            this.dataGridViewTextBoxColumn10.Name = "dataGridViewTextBoxColumn10";
            // 
            // dataGridViewCheckBoxColumn3
            // 
            this.dataGridViewCheckBoxColumn3.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
            this.dataGridViewCheckBoxColumn3.HeaderText = "Warning";
            this.dataGridViewCheckBoxColumn3.Name = "dataGridViewCheckBoxColumn3";
            this.dataGridViewCheckBoxColumn3.Width = 53;
            // 
            // dataGridViewCheckBoxColumn4
            // 
            this.dataGridViewCheckBoxColumn4.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
            this.dataGridViewCheckBoxColumn4.HeaderText = "Remover";
            this.dataGridViewCheckBoxColumn4.Name = "dataGridViewCheckBoxColumn4";
            this.dataGridViewCheckBoxColumn4.Width = 56;
            // 
            // tbpFinal
            // 
            this.tbpFinal.BackColor = System.Drawing.SystemColors.Control;
            this.tbpFinal.Controls.Add(this.dgvResultadoFinal);
            this.tbpFinal.Location = new System.Drawing.Point(4, 22);
            this.tbpFinal.Name = "tbpFinal";
            this.tbpFinal.Size = new System.Drawing.Size(677, 389);
            this.tbpFinal.TabIndex = 4;
            this.tbpFinal.Text = "Resultado Final";
            // 
            // dgvResultadoFinal
            // 
            this.dgvResultadoFinal.AllowUserToAddRows = false;
            this.dgvResultadoFinal.AllowUserToDeleteRows = false;
            this.dgvResultadoFinal.AllowUserToResizeRows = false;
            this.dgvResultadoFinal.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvResultadoFinal.BackgroundColor = System.Drawing.SystemColors.Control;
            this.dgvResultadoFinal.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvResultadoFinal.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn11,
            this.dataGridViewTextBoxColumn12,
            this.dataGridViewTextBoxColumn13,
            this.dataGridViewTextBoxColumn14,
            this.dataGridViewTextBoxColumn15,
            this.dataGridViewCheckBoxColumn5,
            this.dataGridViewCheckBoxColumn6});
            this.dgvResultadoFinal.Location = new System.Drawing.Point(8, 6);
            this.dgvResultadoFinal.Name = "dgvResultadoFinal";
            this.dgvResultadoFinal.RowHeadersVisible = false;
            this.dgvResultadoFinal.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvResultadoFinal.Size = new System.Drawing.Size(661, 317);
            this.dgvResultadoFinal.TabIndex = 3;
            // 
            // dataGridViewTextBoxColumn11
            // 
            this.dataGridViewTextBoxColumn11.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.dataGridViewTextBoxColumn11.HeaderText = "KYCRSP FUNDNO";
            this.dataGridViewTextBoxColumn11.Name = "dataGridViewTextBoxColumn11";
            // 
            // dataGridViewTextBoxColumn12
            // 
            this.dataGridViewTextBoxColumn12.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.dataGridViewTextBoxColumn12.HeaderText = "FSTYBEGDT";
            this.dataGridViewTextBoxColumn12.Name = "dataGridViewTextBoxColumn12";
            // 
            // dataGridViewTextBoxColumn13
            // 
            this.dataGridViewTextBoxColumn13.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.dataGridViewTextBoxColumn13.HeaderText = "FSTYENDDT";
            this.dataGridViewTextBoxColumn13.Name = "dataGridViewTextBoxColumn13";
            // 
            // dataGridViewTextBoxColumn14
            // 
            this.dataGridViewTextBoxColumn14.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.dataGridViewTextBoxColumn14.HeaderText = "LIPPER CLASS";
            this.dataGridViewTextBoxColumn14.Name = "dataGridViewTextBoxColumn14";
            // 
            // dataGridViewTextBoxColumn15
            // 
            this.dataGridViewTextBoxColumn15.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.dataGridViewTextBoxColumn15.HeaderText = "LIPPER OBJ CD";
            this.dataGridViewTextBoxColumn15.Name = "dataGridViewTextBoxColumn15";
            // 
            // dataGridViewCheckBoxColumn5
            // 
            this.dataGridViewCheckBoxColumn5.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
            this.dataGridViewCheckBoxColumn5.HeaderText = "Warning";
            this.dataGridViewCheckBoxColumn5.Name = "dataGridViewCheckBoxColumn5";
            this.dataGridViewCheckBoxColumn5.Width = 53;
            // 
            // dataGridViewCheckBoxColumn6
            // 
            this.dataGridViewCheckBoxColumn6.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
            this.dataGridViewCheckBoxColumn6.HeaderText = "Remover";
            this.dataGridViewCheckBoxColumn6.Name = "dataGridViewCheckBoxColumn6";
            this.dataGridViewCheckBoxColumn6.Width = 56;
            // 
            // frmPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(685, 440);
            this.Controls.Add(this.tbcCSV);
            this.Controls.Add(this.toolStrip1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmPrincipal";
            this.Text = "Objective Codes";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.frmPrincipal_Load);
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.tbcCSV.ResumeLayout(false);
            this.tbpDados.ResumeLayout(false);
            this.tbpDados.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDados)).EndInit();
            this.tbpResultado.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvResultado)).EndInit();
            this.tbpWarnings.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvWarning)).EndInit();
            this.tbpRemovido.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvRemovido)).EndInit();
            this.tbpFinal.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvResultadoFinal)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripDropDownButton toolStripDropDownButton1;
        private System.Windows.Forms.ToolStripMenuItem abrirFicheirocsvToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripMenuItem sairToolStripMenuItem;
        private System.Windows.Forms.TabControl tbcCSV;
        private System.Windows.Forms.TabPage tbpDados;
        private System.Windows.Forms.TabPage tbpResultado;
        private System.Windows.Forms.TabPage tbpWarnings;
        private System.Windows.Forms.TabPage tbpRemovido;
        private System.Windows.Forms.TabPage tbpFinal;
        private System.Windows.Forms.Button btnAbrirFicheiro;
        private System.Windows.Forms.DataGridView dgvDados;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgvDados_KYCRSPFUNDNO;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgvDados_FSTYBEGDT;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgvDados_FSTYENDDT;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgvDados_LIPPERCLASS;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgvDados_LIPPEROBJCD;
        private System.Windows.Forms.DataGridView dgvResultado;
        private System.Windows.Forms.Button btnLimpar;
        private System.Windows.Forms.DataGridView dgvWarning;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn5;
        private System.Windows.Forms.DataGridViewCheckBoxColumn dataGridViewCheckBoxColumn1;
        private System.Windows.Forms.DataGridViewCheckBoxColumn dataGridViewCheckBoxColumn2;
        private System.Windows.Forms.DataGridView dgvRemovido;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn6;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn7;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn8;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn9;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn10;
        private System.Windows.Forms.DataGridViewCheckBoxColumn dataGridViewCheckBoxColumn3;
        private System.Windows.Forms.DataGridViewCheckBoxColumn dataGridViewCheckBoxColumn4;
        private System.Windows.Forms.DataGridView dgvResultadoFinal;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn11;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn12;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn13;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn14;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn15;
        private System.Windows.Forms.DataGridViewCheckBoxColumn dataGridViewCheckBoxColumn5;
        private System.Windows.Forms.DataGridViewCheckBoxColumn dataGridViewCheckBoxColumn6;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgvResultado_KYCRSPFUNDNO;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgvResultado_FSTYBEGDT;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgvResultado_FSTYENDDT;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgvResultado_LIPPERCLASS;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgvResultado_LIPPEROBJCD;
        private System.Windows.Forms.DataGridViewCheckBoxColumn dgvResultado_Warning;
        private System.Windows.Forms.DataGridViewCheckBoxColumn dgvResultado_Remover;
        private System.Windows.Forms.Label lblProgressoCount;
        private System.Windows.Forms.ProgressBar pgbAnalise;
        private System.Windows.Forms.Label lblProgresso;
    }
}

