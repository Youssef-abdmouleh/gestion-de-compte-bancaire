namespace tp3
{
    partial class Frm_Cpt
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Frm_Cpt));
            this.form_cpt = new System.Windows.Forms.TabControl();
            this.tab_cpt = new System.Windows.Forms.TabPage();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.dg_client = new System.Windows.Forms.DataGridView();
            this.Numero = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Titulaire = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Solde = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txt_titu = new System.Windows.Forms.TextBox();
            this.txt_sol = new System.Windows.Forms.TextBox();
            this.txt_num = new System.Windows.Forms.TextBox();
            this.ts_menu = new System.Windows.Forms.ToolStrip();
            this.Ajou = new System.Windows.Forms.ToolStripButton();
            this.sup = new System.Windows.Forms.ToolStripButton();
            this.search = new System.Windows.Forms.ToolStripButton();
            this.tab_mouv = new System.Windows.Forms.TabPage();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txtNum = new System.Windows.Forms.TextBox();
            this.txtTitu = new System.Windows.Forms.TextBox();
            this.txtSolde = new System.Windows.Forms.TextBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.btn_create_mouv = new System.Windows.Forms.Button();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.txtMt = new System.Windows.Forms.TextBox();
            this.dgMouv = new System.Windows.Forms.DataGridView();
            this.dateOp = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.typeMouv = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.mont = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.groupBox5 = new System.Windows.Forms.GroupBox();
            this.rdbVers = new System.Windows.Forms.RadioButton();
            this.rdbRet = new System.Windows.Forms.RadioButton();
            this.dateMou = new System.Windows.Forms.DateTimePicker();
            this.tab_ext = new System.Windows.Forms.TabPage();
            this.groupBox6 = new System.Windows.Forms.GroupBox();
            this.date_Fin = new System.Windows.Forms.DateTimePicker();
            this.label13 = new System.Windows.Forms.Label();
            this.btn_aff = new System.Windows.Forms.Button();
            this.label9 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.txt_Nume = new System.Windows.Forms.TextBox();
            this.txt_Titul = new System.Windows.Forms.TextBox();
            this.txt_Solde = new System.Windows.Forms.TextBox();
            this.date_Deb = new System.Windows.Forms.DateTimePicker();
            this.groupBox7 = new System.Windows.Forms.GroupBox();
            this.dg_Extrait = new System.Windows.Forms.DataGridView();
            this.date = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.type = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.debite = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.credit = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.fileSystemWatcher1 = new System.IO.FileSystemWatcher();
            this.form_cpt.SuspendLayout();
            this.tab_cpt.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dg_client)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.ts_menu.SuspendLayout();
            this.tab_mouv.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgMouv)).BeginInit();
            this.groupBox5.SuspendLayout();
            this.tab_ext.SuspendLayout();
            this.groupBox6.SuspendLayout();
            this.groupBox7.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dg_Extrait)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fileSystemWatcher1)).BeginInit();
            this.SuspendLayout();
            // 
            // form_cpt
            // 
            this.form_cpt.Controls.Add(this.tab_cpt);
            this.form_cpt.Controls.Add(this.tab_mouv);
            this.form_cpt.Controls.Add(this.tab_ext);
            this.form_cpt.Cursor = System.Windows.Forms.Cursors.Default;
            this.form_cpt.Location = new System.Drawing.Point(0, 0);
            this.form_cpt.Name = "form_cpt";
            this.form_cpt.SelectedIndex = 0;
            this.form_cpt.Size = new System.Drawing.Size(665, 519);
            this.form_cpt.TabIndex = 0;
            // 
            // tab_cpt
            // 
            this.tab_cpt.BackColor = System.Drawing.SystemColors.Control;
            this.tab_cpt.Controls.Add(this.groupBox2);
            this.tab_cpt.Controls.Add(this.groupBox1);
            this.tab_cpt.Controls.Add(this.ts_menu);
            this.tab_cpt.Location = new System.Drawing.Point(4, 22);
            this.tab_cpt.Name = "tab_cpt";
            this.tab_cpt.Padding = new System.Windows.Forms.Padding(3);
            this.tab_cpt.Size = new System.Drawing.Size(657, 493);
            this.tab_cpt.TabIndex = 0;
            this.tab_cpt.Text = "Gestion des Comptes Clients";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.dg_client);
            this.groupBox2.Location = new System.Drawing.Point(89, 147);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(518, 340);
            this.groupBox2.TabIndex = 2;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Liste des Comptes";
            // 
            // dg_client
            // 
            this.dg_client.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dg_client.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Numero,
            this.Titulaire,
            this.Solde});
            this.dg_client.Location = new System.Drawing.Point(6, 19);
            this.dg_client.Name = "dg_client";
            this.dg_client.Size = new System.Drawing.Size(506, 315);
            this.dg_client.TabIndex = 0;
            // 
            // Numero
            // 
            this.Numero.HeaderText = "Numero";
            this.Numero.Name = "Numero";
            // 
            // Titulaire
            // 
            this.Titulaire.HeaderText = "Titulaire";
            this.Titulaire.Name = "Titulaire";
            // 
            // Solde
            // 
            this.Solde.HeaderText = "Solde";
            this.Solde.Name = "Solde";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.txt_titu);
            this.groupBox1.Controls.Add(this.txt_sol);
            this.groupBox1.Controls.Add(this.txt_num);
            this.groupBox1.Location = new System.Drawing.Point(89, 3);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(518, 138);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "compte Client";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(197, 98);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(34, 13);
            this.label3.TabIndex = 5;
            this.label3.Text = "Solde";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(339, 34);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(44, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "Titulaire";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(27, 34);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(44, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "Numero";
            // 
            // txt_titu
            // 
            this.txt_titu.Location = new System.Drawing.Point(388, 31);
            this.txt_titu.Name = "txt_titu";
            this.txt_titu.Size = new System.Drawing.Size(100, 20);
            this.txt_titu.TabIndex = 2;
            // 
            // txt_sol
            // 
            this.txt_sol.Location = new System.Drawing.Point(238, 95);
            this.txt_sol.Name = "txt_sol";
            this.txt_sol.Size = new System.Drawing.Size(100, 20);
            this.txt_sol.TabIndex = 1;
            // 
            // txt_num
            // 
            this.txt_num.Location = new System.Drawing.Point(81, 31);
            this.txt_num.Name = "txt_num";
            this.txt_num.Size = new System.Drawing.Size(100, 20);
            this.txt_num.TabIndex = 0;
            // 
            // ts_menu
            // 
            this.ts_menu.Dock = System.Windows.Forms.DockStyle.Left;
            this.ts_menu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.Ajou,
            this.sup,
            this.search});
            this.ts_menu.Location = new System.Drawing.Point(3, 3);
            this.ts_menu.Name = "ts_menu";
            this.ts_menu.Size = new System.Drawing.Size(83, 487);
            this.ts_menu.TabIndex = 0;
            this.ts_menu.Text = "toolStrip1";
            // 
            // Ajou
            // 
            this.Ajou.AccessibleName = "sdf";
            this.Ajou.Image = ((System.Drawing.Image)(resources.GetObject("Ajou.Image")));
            this.Ajou.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.Ajou.Name = "Ajou";
            this.Ajou.Size = new System.Drawing.Size(80, 20);
            this.Ajou.Text = "Ajouter";
            this.Ajou.Click += new System.EventHandler(this.Ajou_Click);
            // 
            // sup
            // 
            this.sup.Image = ((System.Drawing.Image)(resources.GetObject("sup.Image")));
            this.sup.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.sup.Name = "sup";
            this.sup.Size = new System.Drawing.Size(80, 20);
            this.sup.Text = "suprimer";
            this.sup.Click += new System.EventHandler(this.sup_Click);
            // 
            // search
            // 
            this.search.Image = ((System.Drawing.Image)(resources.GetObject("search.Image")));
            this.search.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.search.Name = "search";
            this.search.Size = new System.Drawing.Size(80, 20);
            this.search.Text = "Recherche";
            // 
            // tab_mouv
            // 
            this.tab_mouv.BackColor = System.Drawing.SystemColors.Control;
            this.tab_mouv.Controls.Add(this.groupBox4);
            this.tab_mouv.Controls.Add(this.groupBox3);
            this.tab_mouv.Location = new System.Drawing.Point(4, 22);
            this.tab_mouv.Name = "tab_mouv";
            this.tab_mouv.Padding = new System.Windows.Forms.Padding(3);
            this.tab_mouv.Size = new System.Drawing.Size(657, 493);
            this.tab_mouv.TabIndex = 1;
            this.tab_mouv.Text = "Movement Compte";
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.label6);
            this.groupBox4.Controls.Add(this.label5);
            this.groupBox4.Controls.Add(this.label4);
            this.groupBox4.Controls.Add(this.txtNum);
            this.groupBox4.Controls.Add(this.txtTitu);
            this.groupBox4.Controls.Add(this.txtSolde);
            this.groupBox4.Location = new System.Drawing.Point(8, 35);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(635, 122);
            this.groupBox4.TabIndex = 2;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Compte Client";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(21, 61);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(44, 13);
            this.label6.TabIndex = 5;
            this.label6.Text = "Numero";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(206, 61);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(44, 13);
            this.label5.TabIndex = 4;
            this.label5.Text = "Titulaire";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(382, 61);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(34, 13);
            this.label4.TabIndex = 3;
            this.label4.Text = "Solde";
            // 
            // txtNum
            // 
            this.txtNum.Location = new System.Drawing.Point(68, 58);
            this.txtNum.Name = "txtNum";
            this.txtNum.Size = new System.Drawing.Size(100, 20);
            this.txtNum.TabIndex = 2;
            // 
            // txtTitu
            // 
            this.txtTitu.Location = new System.Drawing.Point(256, 58);
            this.txtTitu.Name = "txtTitu";
            this.txtTitu.Size = new System.Drawing.Size(100, 20);
            this.txtTitu.TabIndex = 1;
            // 
            // txtSolde
            // 
            this.txtSolde.Location = new System.Drawing.Point(422, 58);
            this.txtSolde.Name = "txtSolde";
            this.txtSolde.Size = new System.Drawing.Size(100, 20);
            this.txtSolde.TabIndex = 0;
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.btn_create_mouv);
            this.groupBox3.Controls.Add(this.label8);
            this.groupBox3.Controls.Add(this.label7);
            this.groupBox3.Controls.Add(this.txtMt);
            this.groupBox3.Controls.Add(this.dgMouv);
            this.groupBox3.Controls.Add(this.groupBox5);
            this.groupBox3.Controls.Add(this.dateMou);
            this.groupBox3.Location = new System.Drawing.Point(8, 163);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(635, 327);
            this.groupBox3.TabIndex = 1;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Mouvements du Compte";
            // 
            // btn_create_mouv
            // 
            this.btn_create_mouv.Location = new System.Drawing.Point(68, 228);
            this.btn_create_mouv.Name = "btn_create_mouv";
            this.btn_create_mouv.Size = new System.Drawing.Size(183, 23);
            this.btn_create_mouv.TabIndex = 8;
            this.btn_create_mouv.Text = "Creer Mouvement Compte";
            this.btn_create_mouv.UseVisualStyleBackColor = true;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(21, 50);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(77, 13);
            this.label8.TabIndex = 7;
            this.label8.Text = "Date operation";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(42, 169);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(46, 13);
            this.label7.TabIndex = 6;
            this.label7.Text = "Montant";
            // 
            // txtMt
            // 
            this.txtMt.Location = new System.Drawing.Point(105, 166);
            this.txtMt.Name = "txtMt";
            this.txtMt.Size = new System.Drawing.Size(145, 20);
            this.txtMt.TabIndex = 3;
            // 
            // dgMouv
            // 
            this.dgMouv.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgMouv.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dateOp,
            this.typeMouv,
            this.mont});
            this.dgMouv.Location = new System.Drawing.Point(290, 19);
            this.dgMouv.Name = "dgMouv";
            this.dgMouv.Size = new System.Drawing.Size(345, 302);
            this.dgMouv.TabIndex = 3;
            // 
            // dateOp
            // 
            this.dateOp.HeaderText = "Date Operation";
            this.dateOp.Name = "dateOp";
            // 
            // typeMouv
            // 
            this.typeMouv.HeaderText = "Type Mouvement";
            this.typeMouv.Name = "typeMouv";
            // 
            // mont
            // 
            this.mont.HeaderText = "Montant";
            this.mont.Name = "mont";
            // 
            // groupBox5
            // 
            this.groupBox5.Controls.Add(this.rdbVers);
            this.groupBox5.Controls.Add(this.rdbRet);
            this.groupBox5.Location = new System.Drawing.Point(24, 87);
            this.groupBox5.Name = "groupBox5";
            this.groupBox5.Size = new System.Drawing.Size(200, 73);
            this.groupBox5.TabIndex = 2;
            this.groupBox5.TabStop = false;
            this.groupBox5.Text = "Type operation";
            // 
            // rdbVers
            // 
            this.rdbVers.AutoSize = true;
            this.rdbVers.Location = new System.Drawing.Point(21, 42);
            this.rdbVers.Name = "rdbVers";
            this.rdbVers.Size = new System.Drawing.Size(72, 17);
            this.rdbVers.TabIndex = 1;
            this.rdbVers.TabStop = true;
            this.rdbVers.Text = "Versemen";
            this.rdbVers.UseVisualStyleBackColor = true;
            // 
            // rdbRet
            // 
            this.rdbRet.AutoSize = true;
            this.rdbRet.Location = new System.Drawing.Point(21, 19);
            this.rdbRet.Name = "rdbRet";
            this.rdbRet.Size = new System.Drawing.Size(56, 17);
            this.rdbRet.TabIndex = 0;
            this.rdbRet.TabStop = true;
            this.rdbRet.Text = "Retrait";
            this.rdbRet.UseVisualStyleBackColor = true;
            // 
            // dateMou
            // 
            this.dateMou.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateMou.Location = new System.Drawing.Point(105, 50);
            this.dateMou.Name = "dateMou";
            this.dateMou.Size = new System.Drawing.Size(145, 20);
            this.dateMou.TabIndex = 0;
            this.dateMou.Value = new System.DateTime(2022, 10, 30, 21, 13, 36, 0);
            // 
            // tab_ext
            // 
            this.tab_ext.BackColor = System.Drawing.SystemColors.Control;
            this.tab_ext.Controls.Add(this.groupBox6);
            this.tab_ext.Controls.Add(this.groupBox7);
            this.tab_ext.Location = new System.Drawing.Point(4, 22);
            this.tab_ext.Name = "tab_ext";
            this.tab_ext.Size = new System.Drawing.Size(657, 493);
            this.tab_ext.TabIndex = 2;
            this.tab_ext.Text = "Extrait de Compte";
            // 
            // groupBox6
            // 
            this.groupBox6.Controls.Add(this.date_Fin);
            this.groupBox6.Controls.Add(this.label13);
            this.groupBox6.Controls.Add(this.btn_aff);
            this.groupBox6.Controls.Add(this.label9);
            this.groupBox6.Controls.Add(this.label12);
            this.groupBox6.Controls.Add(this.label10);
            this.groupBox6.Controls.Add(this.label11);
            this.groupBox6.Controls.Add(this.txt_Nume);
            this.groupBox6.Controls.Add(this.txt_Titul);
            this.groupBox6.Controls.Add(this.txt_Solde);
            this.groupBox6.Controls.Add(this.date_Deb);
            this.groupBox6.Location = new System.Drawing.Point(11, 19);
            this.groupBox6.Name = "groupBox6";
            this.groupBox6.Size = new System.Drawing.Size(635, 122);
            this.groupBox6.TabIndex = 4;
            this.groupBox6.TabStop = false;
            this.groupBox6.Text = "Compte Client";
            // 
            // date_Fin
            // 
            this.date_Fin.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.date_Fin.Location = new System.Drawing.Point(320, 85);
            this.date_Fin.Name = "date_Fin";
            this.date_Fin.Size = new System.Drawing.Size(145, 20);
            this.date_Fin.TabIndex = 9;
            this.date_Fin.Value = new System.DateTime(2022, 10, 30, 21, 13, 36, 0);
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(268, 90);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(49, 13);
            this.label13.TabIndex = 6;
            this.label13.Text = "Jusqu\'a :";
            // 
            // btn_aff
            // 
            this.btn_aff.Location = new System.Drawing.Point(515, 84);
            this.btn_aff.Name = "btn_aff";
            this.btn_aff.Size = new System.Drawing.Size(103, 23);
            this.btn_aff.TabIndex = 8;
            this.btn_aff.Text = "Afficher";
            this.btn_aff.UseVisualStyleBackColor = true;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(21, 61);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(44, 13);
            this.label9.TabIndex = 5;
            this.label9.Text = "Numero";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(21, 91);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(57, 13);
            this.label12.TabIndex = 7;
            this.label12.Text = "Extrait de :";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(206, 61);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(44, 13);
            this.label10.TabIndex = 4;
            this.label10.Text = "Titulaire";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(382, 61);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(34, 13);
            this.label11.TabIndex = 3;
            this.label11.Text = "Solde";
            // 
            // txt_Nume
            // 
            this.txt_Nume.Location = new System.Drawing.Point(68, 58);
            this.txt_Nume.Name = "txt_Nume";
            this.txt_Nume.Size = new System.Drawing.Size(100, 20);
            this.txt_Nume.TabIndex = 2;
            // 
            // txt_Titul
            // 
            this.txt_Titul.Location = new System.Drawing.Point(256, 58);
            this.txt_Titul.Name = "txt_Titul";
            this.txt_Titul.Size = new System.Drawing.Size(100, 20);
            this.txt_Titul.TabIndex = 1;
            // 
            // txt_Solde
            // 
            this.txt_Solde.Location = new System.Drawing.Point(422, 58);
            this.txt_Solde.Name = "txt_Solde";
            this.txt_Solde.Size = new System.Drawing.Size(100, 20);
            this.txt_Solde.TabIndex = 0;
            // 
            // date_Deb
            // 
            this.date_Deb.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.date_Deb.Location = new System.Drawing.Point(117, 84);
            this.date_Deb.Name = "date_Deb";
            this.date_Deb.Size = new System.Drawing.Size(145, 20);
            this.date_Deb.TabIndex = 0;
            this.date_Deb.Value = new System.DateTime(2022, 10, 30, 21, 13, 36, 0);
            // 
            // groupBox7
            // 
            this.groupBox7.Controls.Add(this.dg_Extrait);
            this.groupBox7.Location = new System.Drawing.Point(11, 147);
            this.groupBox7.Name = "groupBox7";
            this.groupBox7.Size = new System.Drawing.Size(635, 327);
            this.groupBox7.TabIndex = 3;
            this.groupBox7.TabStop = false;
            this.groupBox7.Text = "Mouvements du Compte";
            // 
            // dg_Extrait
            // 
            this.dg_Extrait.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dg_Extrait.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.date,
            this.type,
            this.debite,
            this.credit});
            this.dg_Extrait.Location = new System.Drawing.Point(43, 19);
            this.dg_Extrait.Name = "dg_Extrait";
            this.dg_Extrait.Size = new System.Drawing.Size(550, 302);
            this.dg_Extrait.TabIndex = 3;
            // 
            // date
            // 
            this.date.HeaderText = "Date ";
            this.date.Name = "date";
            // 
            // type
            // 
            this.type.HeaderText = "Type ";
            this.type.Name = "type";
            // 
            // debite
            // 
            this.debite.HeaderText = "Debit";
            this.debite.Name = "debite";
            // 
            // credit
            // 
            this.credit.HeaderText = "Credit";
            this.credit.Name = "credit";
            // 
            // fileSystemWatcher1
            // 
            this.fileSystemWatcher1.EnableRaisingEvents = true;
            this.fileSystemWatcher1.SynchronizingObject = this;
            // 
            // Frm_Cpt
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.CausesValidation = false;
            this.ClientSize = new System.Drawing.Size(684, 518);
            this.Controls.Add(this.form_cpt);
            this.Cursor = System.Windows.Forms.Cursors.Default;
            this.Name = "Frm_Cpt";
            this.Text = "Gestion Des Compte Bancaires";
            this.form_cpt.ResumeLayout(false);
            this.tab_cpt.ResumeLayout(false);
            this.tab_cpt.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dg_client)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ts_menu.ResumeLayout(false);
            this.ts_menu.PerformLayout();
            this.tab_mouv.ResumeLayout(false);
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgMouv)).EndInit();
            this.groupBox5.ResumeLayout(false);
            this.groupBox5.PerformLayout();
            this.tab_ext.ResumeLayout(false);
            this.groupBox6.ResumeLayout(false);
            this.groupBox6.PerformLayout();
            this.groupBox7.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dg_Extrait)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fileSystemWatcher1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl form_cpt;
        private System.Windows.Forms.TabPage tab_cpt;
        private System.Windows.Forms.TabPage tab_mouv;
        private System.Windows.Forms.ToolStrip ts_menu;
        private System.Windows.Forms.ToolStripButton Ajou;
        private System.Windows.Forms.ToolStripButton sup;
        private System.Windows.Forms.ToolStripButton search;
        private System.Windows.Forms.TabPage tab_ext;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.DataGridView dg_client;
        private System.Windows.Forms.DataGridViewTextBoxColumn Numero;
        private System.Windows.Forms.DataGridViewTextBoxColumn Titulaire;
        private System.Windows.Forms.DataGridViewTextBoxColumn Solde;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txt_titu;
        private System.Windows.Forms.TextBox txt_sol;
        private System.Windows.Forms.TextBox txt_num;
        private System.IO.FileSystemWatcher fileSystemWatcher1;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.DateTimePicker dateMou;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtNum;
        private System.Windows.Forms.TextBox txtTitu;
        private System.Windows.Forms.TextBox txtSolde;
        private System.Windows.Forms.TextBox txtMt;
        private System.Windows.Forms.DataGridView dgMouv;
        private System.Windows.Forms.GroupBox groupBox5;
        private System.Windows.Forms.RadioButton rdbVers;
        private System.Windows.Forms.RadioButton rdbRet;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Button btn_create_mouv;
        private System.Windows.Forms.DataGridViewTextBoxColumn dateOp;
        private System.Windows.Forms.DataGridViewTextBoxColumn typeMouv;
        private System.Windows.Forms.DataGridViewTextBoxColumn mont;
        private System.Windows.Forms.GroupBox groupBox6;
        private System.Windows.Forms.DateTimePicker date_Fin;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Button btn_aff;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox txt_Nume;
        private System.Windows.Forms.TextBox txt_Titul;
        private System.Windows.Forms.TextBox txt_Solde;
        private System.Windows.Forms.DateTimePicker date_Deb;
        private System.Windows.Forms.GroupBox groupBox7;
        private System.Windows.Forms.DataGridView dg_Extrait;
        private System.Windows.Forms.DataGridViewTextBoxColumn date;
        private System.Windows.Forms.DataGridViewTextBoxColumn type;
        private System.Windows.Forms.DataGridViewTextBoxColumn debite;
        private System.Windows.Forms.DataGridViewTextBoxColumn credit;
    }
}

