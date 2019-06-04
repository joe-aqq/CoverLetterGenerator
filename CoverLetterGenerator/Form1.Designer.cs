namespace CoverLetterGenerator
{
    partial class CoverLetterGenerator
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CoverLetterGenerator));
            this.lb_companyName = new System.Windows.Forms.Label();
            this.lb_jobPosition = new System.Windows.Forms.Label();
            this.tf_companyName = new System.Windows.Forms.TextBox();
            this.tf_jobPosition = new System.Windows.Forms.TextBox();
            this.bt_generate = new System.Windows.Forms.Button();
            this.bt_editConfig = new System.Windows.Forms.Button();
            this.tf_path = new System.Windows.Forms.TextBox();
            this.lb_path = new System.Windows.Forms.Label();
            this.di_pathBrowser = new System.Windows.Forms.FolderBrowserDialog();
            this.bt_choosePath = new System.Windows.Forms.Button();
            this.tf_outro = new System.Windows.Forms.TextBox();
            this.lb_outro = new System.Windows.Forms.Label();
            this.tf_intro = new System.Windows.Forms.TextBox();
            this.lb_intro = new System.Windows.Forms.Label();
            this.bt_saveConfig = new System.Windows.Forms.Button();
            this.tf_email = new System.Windows.Forms.TextBox();
            this.lb_email = new System.Windows.Forms.Label();
            this.tf_phone = new System.Windows.Forms.TextBox();
            this.lb_phone = new System.Windows.Forms.Label();
            this.tf_addressCont = new System.Windows.Forms.TextBox();
            this.lb_addressCont = new System.Windows.Forms.Label();
            this.tf_address = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.tf_name = new System.Windows.Forms.TextBox();
            this.lb_address = new System.Windows.Forms.Label();
            this.lb_name = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.dp_datePicker = new System.Windows.Forms.DateTimePicker();
            this.lb_date = new System.Windows.Forms.Label();
            this.bt_editLetter = new System.Windows.Forms.Button();
            this.cb_openAfter = new System.Windows.Forms.CheckBox();
            this.tp_tabPage = new System.Windows.Forms.TabControl();
            this.tab_config = new System.Windows.Forms.TabPage();
            this.tab_document = new System.Windows.Forms.TabPage();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.tb_margins = new System.Windows.Forms.TrackBar();
            this.lb_moderate = new System.Windows.Forms.Label();
            this.lb_vlarge = new System.Windows.Forms.Label();
            this.lb_none = new System.Windows.Forms.Label();
            this.lb_firstLineIndent = new System.Windows.Forms.Label();
            this.tb_firstLineIndent = new System.Windows.Forms.TrackBar();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.tool_file = new System.Windows.Forms.ToolStripMenuItem();
            this.saveConfigToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.generateFileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tool_edit = new System.Windows.Forms.ToolStripMenuItem();
            this.clearConfigFieldsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.clearCompanyFieldsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.label7 = new System.Windows.Forms.Label();
            this.lb_githubLink = new System.Windows.Forms.LinkLabel();
            this.lb_websiteLink = new System.Windows.Forms.LinkLabel();
            this.lb_twitterLink = new System.Windows.Forms.LinkLabel();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.lb_fontSize = new System.Windows.Forms.Label();
            this.tb_fontSize = new System.Windows.Forms.TrackBar();
            this.tp_tabPage.SuspendLayout();
            this.tab_config.SuspendLayout();
            this.tab_document.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tb_margins)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tb_firstLineIndent)).BeginInit();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tb_fontSize)).BeginInit();
            this.SuspendLayout();
            // 
            // lb_companyName
            // 
            this.lb_companyName.AutoSize = true;
            this.lb_companyName.Location = new System.Drawing.Point(13, 30);
            this.lb_companyName.Name = "lb_companyName";
            this.lb_companyName.Size = new System.Drawing.Size(82, 13);
            this.lb_companyName.TabIndex = 0;
            this.lb_companyName.Text = "Company Name";
            // 
            // lb_jobPosition
            // 
            this.lb_jobPosition.AutoSize = true;
            this.lb_jobPosition.Location = new System.Drawing.Point(31, 57);
            this.lb_jobPosition.Name = "lb_jobPosition";
            this.lb_jobPosition.Size = new System.Drawing.Size(64, 13);
            this.lb_jobPosition.TabIndex = 1;
            this.lb_jobPosition.Text = "Job Position";
            // 
            // tf_companyName
            // 
            this.tf_companyName.Location = new System.Drawing.Point(101, 27);
            this.tf_companyName.Name = "tf_companyName";
            this.tf_companyName.Size = new System.Drawing.Size(284, 20);
            this.tf_companyName.TabIndex = 0;
            // 
            // tf_jobPosition
            // 
            this.tf_jobPosition.Location = new System.Drawing.Point(101, 54);
            this.tf_jobPosition.Name = "tf_jobPosition";
            this.tf_jobPosition.Size = new System.Drawing.Size(284, 20);
            this.tf_jobPosition.TabIndex = 1;
            // 
            // bt_generate
            // 
            this.bt_generate.BackColor = System.Drawing.SystemColors.Control;
            this.bt_generate.Cursor = System.Windows.Forms.Cursors.Hand;
            this.bt_generate.ForeColor = System.Drawing.SystemColors.ControlText;
            this.bt_generate.Location = new System.Drawing.Point(12, 488);
            this.bt_generate.Name = "bt_generate";
            this.bt_generate.Size = new System.Drawing.Size(374, 45);
            this.bt_generate.TabIndex = 14;
            this.bt_generate.Text = "Generate";
            this.bt_generate.UseVisualStyleBackColor = false;
            this.bt_generate.Click += new System.EventHandler(this.bt_generate_Click);
            // 
            // bt_editConfig
            // 
            this.bt_editConfig.Cursor = System.Windows.Forms.Cursors.Hand;
            this.bt_editConfig.Location = new System.Drawing.Point(13, 539);
            this.bt_editConfig.Name = "bt_editConfig";
            this.bt_editConfig.Size = new System.Drawing.Size(185, 23);
            this.bt_editConfig.TabIndex = 15;
            this.bt_editConfig.Text = "Edit Config";
            this.bt_editConfig.UseVisualStyleBackColor = true;
            this.bt_editConfig.Click += new System.EventHandler(this.bt_editFile_Click);
            // 
            // tf_path
            // 
            this.tf_path.Location = new System.Drawing.Point(101, 106);
            this.tf_path.Name = "tf_path";
            this.tf_path.Size = new System.Drawing.Size(234, 20);
            this.tf_path.TabIndex = 3;
            // 
            // lb_path
            // 
            this.lb_path.AutoSize = true;
            this.lb_path.Location = new System.Drawing.Point(66, 109);
            this.lb_path.Name = "lb_path";
            this.lb_path.Size = new System.Drawing.Size(29, 13);
            this.lb_path.TabIndex = 7;
            this.lb_path.Text = "Path";
            // 
            // bt_choosePath
            // 
            this.bt_choosePath.Cursor = System.Windows.Forms.Cursors.Hand;
            this.bt_choosePath.Location = new System.Drawing.Point(341, 105);
            this.bt_choosePath.Name = "bt_choosePath";
            this.bt_choosePath.Size = new System.Drawing.Size(44, 22);
            this.bt_choosePath.TabIndex = 4;
            this.bt_choosePath.Text = "...";
            this.bt_choosePath.UseVisualStyleBackColor = true;
            this.bt_choosePath.Click += new System.EventHandler(this.bt_choosePath_Click);
            // 
            // tf_outro
            // 
            this.tf_outro.Location = new System.Drawing.Point(94, 192);
            this.tf_outro.Name = "tf_outro";
            this.tf_outro.Size = new System.Drawing.Size(254, 20);
            this.tf_outro.TabIndex = 12;
            // 
            // lb_outro
            // 
            this.lb_outro.AutoSize = true;
            this.lb_outro.Location = new System.Drawing.Point(55, 195);
            this.lb_outro.Name = "lb_outro";
            this.lb_outro.Size = new System.Drawing.Size(33, 13);
            this.lb_outro.TabIndex = 25;
            this.lb_outro.Text = "Outro";
            // 
            // tf_intro
            // 
            this.tf_intro.Location = new System.Drawing.Point(94, 166);
            this.tf_intro.Name = "tf_intro";
            this.tf_intro.Size = new System.Drawing.Size(254, 20);
            this.tf_intro.TabIndex = 11;
            // 
            // lb_intro
            // 
            this.lb_intro.AutoSize = true;
            this.lb_intro.Location = new System.Drawing.Point(60, 169);
            this.lb_intro.Name = "lb_intro";
            this.lb_intro.Size = new System.Drawing.Size(28, 13);
            this.lb_intro.TabIndex = 23;
            this.lb_intro.Text = "Intro";
            // 
            // bt_saveConfig
            // 
            this.bt_saveConfig.Cursor = System.Windows.Forms.Cursors.Hand;
            this.bt_saveConfig.Location = new System.Drawing.Point(13, 231);
            this.bt_saveConfig.Name = "bt_saveConfig";
            this.bt_saveConfig.Size = new System.Drawing.Size(341, 24);
            this.bt_saveConfig.TabIndex = 11;
            this.bt_saveConfig.Text = "Save To Config...";
            this.bt_saveConfig.UseVisualStyleBackColor = true;
            this.bt_saveConfig.Click += new System.EventHandler(this.bt_saveConfig_Click);
            // 
            // tf_email
            // 
            this.tf_email.Location = new System.Drawing.Point(94, 140);
            this.tf_email.Name = "tf_email";
            this.tf_email.Size = new System.Drawing.Size(254, 20);
            this.tf_email.TabIndex = 10;
            // 
            // lb_email
            // 
            this.lb_email.AutoSize = true;
            this.lb_email.Location = new System.Drawing.Point(56, 143);
            this.lb_email.Name = "lb_email";
            this.lb_email.Size = new System.Drawing.Size(32, 13);
            this.lb_email.TabIndex = 19;
            this.lb_email.Text = "Email";
            // 
            // tf_phone
            // 
            this.tf_phone.Location = new System.Drawing.Point(94, 114);
            this.tf_phone.Name = "tf_phone";
            this.tf_phone.Size = new System.Drawing.Size(254, 20);
            this.tf_phone.TabIndex = 9;
            // 
            // lb_phone
            // 
            this.lb_phone.AutoSize = true;
            this.lb_phone.Location = new System.Drawing.Point(10, 117);
            this.lb_phone.Name = "lb_phone";
            this.lb_phone.Size = new System.Drawing.Size(78, 13);
            this.lb_phone.TabIndex = 17;
            this.lb_phone.Text = "Phone Number";
            // 
            // tf_addressCont
            // 
            this.tf_addressCont.Location = new System.Drawing.Point(94, 88);
            this.tf_addressCont.Name = "tf_addressCont";
            this.tf_addressCont.Size = new System.Drawing.Size(254, 20);
            this.tf_addressCont.TabIndex = 8;
            // 
            // lb_addressCont
            // 
            this.lb_addressCont.AutoSize = true;
            this.lb_addressCont.Location = new System.Drawing.Point(15, 91);
            this.lb_addressCont.Name = "lb_addressCont";
            this.lb_addressCont.Size = new System.Drawing.Size(73, 13);
            this.lb_addressCont.TabIndex = 15;
            this.lb_addressCont.Text = "Address Cont.";
            // 
            // tf_address
            // 
            this.tf_address.Location = new System.Drawing.Point(94, 62);
            this.tf_address.Name = "tf_address";
            this.tf_address.Size = new System.Drawing.Size(254, 20);
            this.tf_address.TabIndex = 7;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(9, 12);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(92, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Config Information";
            // 
            // tf_name
            // 
            this.tf_name.Location = new System.Drawing.Point(94, 35);
            this.tf_name.Name = "tf_name";
            this.tf_name.Size = new System.Drawing.Size(254, 20);
            this.tf_name.TabIndex = 6;
            // 
            // lb_address
            // 
            this.lb_address.AutoSize = true;
            this.lb_address.Location = new System.Drawing.Point(43, 65);
            this.lb_address.Name = "lb_address";
            this.lb_address.Size = new System.Drawing.Size(45, 13);
            this.lb_address.TabIndex = 12;
            this.lb_address.Text = "Address";
            // 
            // lb_name
            // 
            this.lb_name.AutoSize = true;
            this.lb_name.Location = new System.Drawing.Point(53, 38);
            this.lb_name.Name = "lb_name";
            this.lb_name.Size = new System.Drawing.Size(35, 13);
            this.lb_name.TabIndex = 11;
            this.lb_name.Text = "Name";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.ForeColor = System.Drawing.SystemColors.ButtonShadow;
            this.label4.Location = new System.Drawing.Point(10, 137);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(274, 13);
            this.label4.TabIndex = 11;
            this.label4.Text = "*Cover letter body can only be edited within the letter file.";
            // 
            // dp_datePicker
            // 
            this.dp_datePicker.Location = new System.Drawing.Point(101, 80);
            this.dp_datePicker.Name = "dp_datePicker";
            this.dp_datePicker.Size = new System.Drawing.Size(284, 20);
            this.dp_datePicker.TabIndex = 2;
            // 
            // lb_date
            // 
            this.lb_date.AutoSize = true;
            this.lb_date.Location = new System.Drawing.Point(65, 83);
            this.lb_date.Name = "lb_date";
            this.lb_date.Size = new System.Drawing.Size(30, 13);
            this.lb_date.TabIndex = 13;
            this.lb_date.Text = "Date";
            // 
            // bt_editLetter
            // 
            this.bt_editLetter.Cursor = System.Windows.Forms.Cursors.Hand;
            this.bt_editLetter.Location = new System.Drawing.Point(204, 539);
            this.bt_editLetter.Name = "bt_editLetter";
            this.bt_editLetter.Size = new System.Drawing.Size(182, 23);
            this.bt_editLetter.TabIndex = 16;
            this.bt_editLetter.Text = "Edit Letter";
            this.bt_editLetter.UseVisualStyleBackColor = true;
            this.bt_editLetter.Click += new System.EventHandler(this.bt_editLetter_Click);
            // 
            // cb_openAfter
            // 
            this.cb_openAfter.AutoSize = true;
            this.cb_openAfter.ForeColor = System.Drawing.SystemColors.InfoText;
            this.cb_openAfter.Location = new System.Drawing.Point(12, 465);
            this.cb_openAfter.Name = "cb_openAfter";
            this.cb_openAfter.Size = new System.Drawing.Size(198, 17);
            this.cb_openAfter.TabIndex = 13;
            this.cb_openAfter.Text = "Open file after it has been generated";
            this.cb_openAfter.UseVisualStyleBackColor = true;
            // 
            // tp_tabPage
            // 
            this.tp_tabPage.Appearance = System.Windows.Forms.TabAppearance.FlatButtons;
            this.tp_tabPage.Controls.Add(this.tab_config);
            this.tp_tabPage.Controls.Add(this.tab_document);
            this.tp_tabPage.Location = new System.Drawing.Point(13, 160);
            this.tp_tabPage.Name = "tp_tabPage";
            this.tp_tabPage.SelectedIndex = 0;
            this.tp_tabPage.Size = new System.Drawing.Size(373, 297);
            this.tp_tabPage.TabIndex = 5;
            // 
            // tab_config
            // 
            this.tab_config.Controls.Add(this.tf_outro);
            this.tab_config.Controls.Add(this.label1);
            this.tab_config.Controls.Add(this.bt_saveConfig);
            this.tab_config.Controls.Add(this.lb_phone);
            this.tab_config.Controls.Add(this.tf_address);
            this.tab_config.Controls.Add(this.lb_outro);
            this.tab_config.Controls.Add(this.tf_name);
            this.tab_config.Controls.Add(this.tf_phone);
            this.tab_config.Controls.Add(this.tf_email);
            this.tab_config.Controls.Add(this.lb_name);
            this.tab_config.Controls.Add(this.lb_intro);
            this.tab_config.Controls.Add(this.tf_addressCont);
            this.tab_config.Controls.Add(this.lb_addressCont);
            this.tab_config.Controls.Add(this.tf_intro);
            this.tab_config.Controls.Add(this.lb_address);
            this.tab_config.Controls.Add(this.lb_email);
            this.tab_config.Location = new System.Drawing.Point(4, 25);
            this.tab_config.Name = "tab_config";
            this.tab_config.Padding = new System.Windows.Forms.Padding(3);
            this.tab_config.Size = new System.Drawing.Size(365, 268);
            this.tab_config.TabIndex = 0;
            this.tab_config.Text = "Config";
            this.tab_config.UseVisualStyleBackColor = true;
            // 
            // tab_document
            // 
            this.tab_document.Controls.Add(this.label8);
            this.tab_document.Controls.Add(this.label9);
            this.tab_document.Controls.Add(this.label10);
            this.tab_document.Controls.Add(this.lb_fontSize);
            this.tab_document.Controls.Add(this.tb_fontSize);
            this.tab_document.Controls.Add(this.label2);
            this.tab_document.Controls.Add(this.label3);
            this.tab_document.Controls.Add(this.label5);
            this.tab_document.Controls.Add(this.label6);
            this.tab_document.Controls.Add(this.tb_margins);
            this.tab_document.Controls.Add(this.lb_moderate);
            this.tab_document.Controls.Add(this.lb_vlarge);
            this.tab_document.Controls.Add(this.lb_none);
            this.tab_document.Controls.Add(this.lb_firstLineIndent);
            this.tab_document.Controls.Add(this.tb_firstLineIndent);
            this.tab_document.Location = new System.Drawing.Point(4, 25);
            this.tab_document.Name = "tab_document";
            this.tab_document.Padding = new System.Windows.Forms.Padding(3);
            this.tab_document.Size = new System.Drawing.Size(365, 268);
            this.tab_document.TabIndex = 1;
            this.tab_document.Text = "Document";
            this.tab_document.UseVisualStyleBackColor = true;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.ForeColor = System.Drawing.SystemColors.ControlDark;
            this.label2.Location = new System.Drawing.Point(158, 161);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(52, 13);
            this.label2.TabIndex = 9;
            this.label2.Text = "Moderate";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.ForeColor = System.Drawing.SystemColors.ControlDark;
            this.label3.Location = new System.Drawing.Point(312, 161);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(34, 13);
            this.label3.TabIndex = 8;
            this.label3.Text = "Large";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.ForeColor = System.Drawing.SystemColors.ControlDark;
            this.label5.Location = new System.Drawing.Point(22, 161);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(33, 13);
            this.label5.TabIndex = 7;
            this.label5.Text = "None";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(10, 98);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(44, 13);
            this.label6.TabIndex = 6;
            this.label6.Text = "Margins";
            // 
            // tb_margins
            // 
            this.tb_margins.LargeChange = 40;
            this.tb_margins.Location = new System.Drawing.Point(24, 113);
            this.tb_margins.Maximum = 100;
            this.tb_margins.Name = "tb_margins";
            this.tb_margins.Size = new System.Drawing.Size(319, 45);
            this.tb_margins.SmallChange = 18;
            this.tb_margins.TabIndex = 0;
            this.tb_margins.TabStop = false;
            this.tb_margins.TickFrequency = 25;
            this.tb_margins.TickStyle = System.Windows.Forms.TickStyle.Both;
            this.tb_margins.Value = 50;
            // 
            // lb_moderate
            // 
            this.lb_moderate.AutoSize = true;
            this.lb_moderate.ForeColor = System.Drawing.SystemColors.ControlDark;
            this.lb_moderate.Location = new System.Drawing.Point(158, 76);
            this.lb_moderate.Name = "lb_moderate";
            this.lb_moderate.Size = new System.Drawing.Size(52, 13);
            this.lb_moderate.TabIndex = 4;
            this.lb_moderate.Text = "Moderate";
            // 
            // lb_vlarge
            // 
            this.lb_vlarge.AutoSize = true;
            this.lb_vlarge.ForeColor = System.Drawing.SystemColors.ControlDark;
            this.lb_vlarge.Location = new System.Drawing.Point(312, 76);
            this.lb_vlarge.Name = "lb_vlarge";
            this.lb_vlarge.Size = new System.Drawing.Size(34, 13);
            this.lb_vlarge.TabIndex = 3;
            this.lb_vlarge.Text = "Large";
            // 
            // lb_none
            // 
            this.lb_none.AutoSize = true;
            this.lb_none.ForeColor = System.Drawing.SystemColors.ControlDark;
            this.lb_none.Location = new System.Drawing.Point(22, 76);
            this.lb_none.Name = "lb_none";
            this.lb_none.Size = new System.Drawing.Size(33, 13);
            this.lb_none.TabIndex = 2;
            this.lb_none.Text = "None";
            // 
            // lb_firstLineIndent
            // 
            this.lb_firstLineIndent.AutoSize = true;
            this.lb_firstLineIndent.Location = new System.Drawing.Point(10, 13);
            this.lb_firstLineIndent.Name = "lb_firstLineIndent";
            this.lb_firstLineIndent.Size = new System.Drawing.Size(105, 13);
            this.lb_firstLineIndent.TabIndex = 1;
            this.lb_firstLineIndent.Text = "First Line Indentation";
            // 
            // tb_firstLineIndent
            // 
            this.tb_firstLineIndent.LargeChange = 40;
            this.tb_firstLineIndent.Location = new System.Drawing.Point(24, 28);
            this.tb_firstLineIndent.Maximum = 80;
            this.tb_firstLineIndent.Name = "tb_firstLineIndent";
            this.tb_firstLineIndent.Size = new System.Drawing.Size(319, 45);
            this.tb_firstLineIndent.SmallChange = 20;
            this.tb_firstLineIndent.TabIndex = 17;
            this.tb_firstLineIndent.TabStop = false;
            this.tb_firstLineIndent.TickFrequency = 20;
            this.tb_firstLineIndent.TickStyle = System.Windows.Forms.TickStyle.Both;
            this.tb_firstLineIndent.Value = 40;
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tool_file,
            this.tool_edit});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(397, 24);
            this.menuStrip1.TabIndex = 17;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // tool_file
            // 
            this.tool_file.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.saveConfigToolStripMenuItem,
            this.generateFileToolStripMenuItem,
            this.exitToolStripMenuItem});
            this.tool_file.Name = "tool_file";
            this.tool_file.Size = new System.Drawing.Size(37, 20);
            this.tool_file.Text = "File";
            // 
            // saveConfigToolStripMenuItem
            // 
            this.saveConfigToolStripMenuItem.Name = "saveConfigToolStripMenuItem";
            this.saveConfigToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.S)));
            this.saveConfigToolStripMenuItem.Size = new System.Drawing.Size(184, 22);
            this.saveConfigToolStripMenuItem.Text = "Save Config";
            this.saveConfigToolStripMenuItem.Click += new System.EventHandler(this.saveConfigToolStripMenuItem_Click);
            // 
            // generateFileToolStripMenuItem
            // 
            this.generateFileToolStripMenuItem.Name = "generateFileToolStripMenuItem";
            this.generateFileToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.G)));
            this.generateFileToolStripMenuItem.Size = new System.Drawing.Size(184, 22);
            this.generateFileToolStripMenuItem.Text = "Generate File";
            this.generateFileToolStripMenuItem.Click += new System.EventHandler(this.generateFileToolStripMenuItem_Click);
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Alt | System.Windows.Forms.Keys.F4)));
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(184, 22);
            this.exitToolStripMenuItem.Text = "Exit";
            this.exitToolStripMenuItem.Click += new System.EventHandler(this.exitToolStripMenuItem_Click);
            // 
            // tool_edit
            // 
            this.tool_edit.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.clearConfigFieldsToolStripMenuItem,
            this.clearCompanyFieldsToolStripMenuItem});
            this.tool_edit.Name = "tool_edit";
            this.tool_edit.Size = new System.Drawing.Size(39, 20);
            this.tool_edit.Text = "Edit";
            // 
            // clearConfigFieldsToolStripMenuItem
            // 
            this.clearConfigFieldsToolStripMenuItem.Name = "clearConfigFieldsToolStripMenuItem";
            this.clearConfigFieldsToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Alt | System.Windows.Forms.Keys.C)));
            this.clearConfigFieldsToolStripMenuItem.Size = new System.Drawing.Size(227, 22);
            this.clearConfigFieldsToolStripMenuItem.Text = "Clear Config Fields";
            this.clearConfigFieldsToolStripMenuItem.Click += new System.EventHandler(this.clearConfigFieldsToolStripMenuItem_Click);
            // 
            // clearCompanyFieldsToolStripMenuItem
            // 
            this.clearCompanyFieldsToolStripMenuItem.Name = "clearCompanyFieldsToolStripMenuItem";
            this.clearCompanyFieldsToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Alt | System.Windows.Forms.Keys.D)));
            this.clearCompanyFieldsToolStripMenuItem.Size = new System.Drawing.Size(227, 22);
            this.clearCompanyFieldsToolStripMenuItem.Text = "Clear Company Fields";
            this.clearCompanyFieldsToolStripMenuItem.Click += new System.EventHandler(this.clearCompanyFieldsToolStripMenuItem_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.ForeColor = System.Drawing.SystemColors.ButtonShadow;
            this.label7.Location = new System.Drawing.Point(41, 569);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(323, 13);
            this.label7.TabIndex = 18;
            this.label7.Text = "Software created by Joseph Aquiare under the GNU public license.";
            // 
            // lb_githubLink
            // 
            this.lb_githubLink.AutoSize = true;
            this.lb_githubLink.Location = new System.Drawing.Point(139, 590);
            this.lb_githubLink.Name = "lb_githubLink";
            this.lb_githubLink.Size = new System.Drawing.Size(40, 13);
            this.lb_githubLink.TabIndex = 19;
            this.lb_githubLink.TabStop = true;
            this.lb_githubLink.Text = "GitHub";
            this.lb_githubLink.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.lb_githubLink_LinkClicked);
            // 
            // lb_websiteLink
            // 
            this.lb_websiteLink.AutoSize = true;
            this.lb_websiteLink.Location = new System.Drawing.Point(180, 590);
            this.lb_websiteLink.Name = "lb_websiteLink";
            this.lb_websiteLink.Size = new System.Drawing.Size(46, 13);
            this.lb_websiteLink.TabIndex = 20;
            this.lb_websiteLink.TabStop = true;
            this.lb_websiteLink.Text = "Website";
            this.lb_websiteLink.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.lb_websiteLink_LinkClicked);
            // 
            // lb_twitterLink
            // 
            this.lb_twitterLink.AutoSize = true;
            this.lb_twitterLink.Location = new System.Drawing.Point(227, 590);
            this.lb_twitterLink.Name = "lb_twitterLink";
            this.lb_twitterLink.Size = new System.Drawing.Size(39, 13);
            this.lb_twitterLink.TabIndex = 21;
            this.lb_twitterLink.TabStop = true;
            this.lb_twitterLink.Text = "Twitter";
            this.lb_twitterLink.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.lb_twitterLink_LinkClicked);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.ForeColor = System.Drawing.SystemColors.ControlDark;
            this.label8.Location = new System.Drawing.Point(159, 245);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(52, 13);
            this.label8.TabIndex = 22;
            this.label8.Text = "Moderate";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.ForeColor = System.Drawing.SystemColors.ControlDark;
            this.label9.Location = new System.Drawing.Point(313, 245);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(34, 13);
            this.label9.TabIndex = 21;
            this.label9.Text = "Large";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.ForeColor = System.Drawing.SystemColors.ControlDark;
            this.label10.Location = new System.Drawing.Point(23, 245);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(33, 13);
            this.label10.TabIndex = 20;
            this.label10.Text = "None";
            // 
            // lb_fontSize
            // 
            this.lb_fontSize.AutoSize = true;
            this.lb_fontSize.Location = new System.Drawing.Point(11, 182);
            this.lb_fontSize.Name = "lb_fontSize";
            this.lb_fontSize.Size = new System.Drawing.Size(51, 13);
            this.lb_fontSize.TabIndex = 19;
            this.lb_fontSize.Text = "Font Size";
            // 
            // tb_fontSize
            // 
            this.tb_fontSize.LargeChange = 2;
            this.tb_fontSize.Location = new System.Drawing.Point(25, 197);
            this.tb_fontSize.Maximum = 18;
            this.tb_fontSize.Minimum = 6;
            this.tb_fontSize.Name = "tb_fontSize";
            this.tb_fontSize.Size = new System.Drawing.Size(319, 45);
            this.tb_fontSize.TabIndex = 18;
            this.tb_fontSize.TabStop = false;
            this.tb_fontSize.TickFrequency = 3;
            this.tb_fontSize.TickStyle = System.Windows.Forms.TickStyle.Both;
            this.tb_fontSize.Value = 12;
            // 
            // CoverLetterGenerator
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(397, 613);
            this.Controls.Add(this.lb_twitterLink);
            this.Controls.Add(this.lb_websiteLink);
            this.Controls.Add(this.lb_githubLink);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.tp_tabPage);
            this.Controls.Add(this.cb_openAfter);
            this.Controls.Add(this.bt_editLetter);
            this.Controls.Add(this.lb_date);
            this.Controls.Add(this.dp_datePicker);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.bt_choosePath);
            this.Controls.Add(this.tf_path);
            this.Controls.Add(this.lb_path);
            this.Controls.Add(this.bt_editConfig);
            this.Controls.Add(this.bt_generate);
            this.Controls.Add(this.tf_jobPosition);
            this.Controls.Add(this.tf_companyName);
            this.Controls.Add(this.lb_jobPosition);
            this.Controls.Add(this.lb_companyName);
            this.Controls.Add(this.menuStrip1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip1;
            this.MaximizeBox = false;
            this.Name = "CoverLetterGenerator";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Cover Letter Generator";
            this.tp_tabPage.ResumeLayout(false);
            this.tab_config.ResumeLayout(false);
            this.tab_config.PerformLayout();
            this.tab_document.ResumeLayout(false);
            this.tab_document.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tb_margins)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tb_firstLineIndent)).EndInit();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tb_fontSize)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lb_companyName;
        private System.Windows.Forms.Label lb_jobPosition;
        private System.Windows.Forms.TextBox tf_companyName;
        private System.Windows.Forms.TextBox tf_jobPosition;
        private System.Windows.Forms.Button bt_generate;
        private System.Windows.Forms.Button bt_editConfig;
        private System.Windows.Forms.TextBox tf_path;
        private System.Windows.Forms.Label lb_path;
        private System.Windows.Forms.FolderBrowserDialog di_pathBrowser;
        private System.Windows.Forms.Button bt_choosePath;
        private System.Windows.Forms.Button bt_saveConfig;
        private System.Windows.Forms.TextBox tf_email;
        private System.Windows.Forms.Label lb_email;
        private System.Windows.Forms.TextBox tf_phone;
        private System.Windows.Forms.Label lb_phone;
        private System.Windows.Forms.TextBox tf_addressCont;
        private System.Windows.Forms.Label lb_addressCont;
        private System.Windows.Forms.TextBox tf_address;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox tf_name;
        private System.Windows.Forms.Label lb_address;
        private System.Windows.Forms.Label lb_name;
        private System.Windows.Forms.Label lb_intro;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox tf_outro;
        private System.Windows.Forms.Label lb_outro;
        private System.Windows.Forms.TextBox tf_intro;
        private System.Windows.Forms.DateTimePicker dp_datePicker;
        private System.Windows.Forms.Label lb_date;
        private System.Windows.Forms.Button bt_editLetter;
        private System.Windows.Forms.CheckBox cb_openAfter;
        private System.Windows.Forms.TabControl tp_tabPage;
        private System.Windows.Forms.TabPage tab_config;
        private System.Windows.Forms.TabPage tab_document;
        private System.Windows.Forms.TrackBar tb_firstLineIndent;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TrackBar tb_margins;
        private System.Windows.Forms.Label lb_moderate;
        private System.Windows.Forms.Label lb_vlarge;
        private System.Windows.Forms.Label lb_none;
        private System.Windows.Forms.Label lb_firstLineIndent;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem tool_file;
        private System.Windows.Forms.ToolStripMenuItem saveConfigToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem generateFileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem tool_edit;
        private System.Windows.Forms.ToolStripMenuItem clearConfigFieldsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem clearCompanyFieldsToolStripMenuItem;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.LinkLabel lb_githubLink;
        private System.Windows.Forms.LinkLabel lb_websiteLink;
        private System.Windows.Forms.LinkLabel lb_twitterLink;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label lb_fontSize;
        private System.Windows.Forms.TrackBar tb_fontSize;
    }
}

