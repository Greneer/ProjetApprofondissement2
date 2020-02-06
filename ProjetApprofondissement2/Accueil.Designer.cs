namespace ProjetApprofondissement2
{
    partial class Accueil
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Accueil));
            this.labelTitle = new System.Windows.Forms.Label();
            this.panelSideMenu = new System.Windows.Forms.Panel();
            this.buttonCountryApi = new System.Windows.Forms.Button();
            this.buttonCrud = new System.Windows.Forms.Button();
            this.panelApi = new System.Windows.Forms.Panel();
            this.labelContinent = new System.Windows.Forms.Label();
            this.textBoxContinent = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.textBoxPays = new System.Windows.Forms.TextBox();
            this.dataGridViewPays = new System.Windows.Forms.DataGridView();
            this.buttonGetAllData = new System.Windows.Forms.Button();
            this.panelAjouter = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.button2 = new System.Windows.Forms.Button();
            this.labelNote = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.richTextBoxAjouterNote = new System.Windows.Forms.RichTextBox();
            this.textBoxAjouterCourriel = new System.Windows.Forms.TextBox();
            this.textBoxAjouterNom = new System.Windows.Forms.TextBox();
            this.textBoxAjouterPrenom = new System.Windows.Forms.TextBox();
            this.panelInfos = new System.Windows.Forms.Panel();
            this.labelModifier = new System.Windows.Forms.Label();
            this.buttonModifier = new System.Windows.Forms.Button();
            this.labelModifierNote = new System.Windows.Forms.Label();
            this.labelModifierCourriel = new System.Windows.Forms.Label();
            this.labelModifierNom = new System.Windows.Forms.Label();
            this.labelModifierPrenom = new System.Windows.Forms.Label();
            this.richTextBoxInfoNote = new System.Windows.Forms.RichTextBox();
            this.textBoxInfoCourriel = new System.Windows.Forms.TextBox();
            this.textBoxInfoNom = new System.Windows.Forms.TextBox();
            this.textBoxInfoPrenom = new System.Windows.Forms.TextBox();
            this.panelTop = new System.Windows.Forms.Panel();
            this.button1 = new System.Windows.Forms.Button();
            this.panelCrud = new System.Windows.Forms.Panel();
            this.buttonRecharger = new System.Windows.Forms.Button();
            this.buttonMoreInfo = new System.Windows.Forms.Button();
            this.buttonRechercher = new System.Windows.Forms.Button();
            this.buttonAjouter = new System.Windows.Forms.Button();
            this.labelCourriel = new System.Windows.Forms.Label();
            this.textBoxCourriel = new System.Windows.Forms.TextBox();
            this.labelNom = new System.Windows.Forms.Label();
            this.labelPrenom = new System.Windows.Forms.Label();
            this.textBoxNom = new System.Windows.Forms.TextBox();
            this.textBoxPrenom = new System.Windows.Forms.TextBox();
            this.buttonSupprimer = new System.Windows.Forms.Button();
            this.dataGridViewListePersonnes = new System.Windows.Forms.DataGridView();
            this.panelSideMenu.SuspendLayout();
            this.panelApi.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewPays)).BeginInit();
            this.panelAjouter.SuspendLayout();
            this.panelInfos.SuspendLayout();
            this.panelTop.SuspendLayout();
            this.panelCrud.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewListePersonnes)).BeginInit();
            this.SuspendLayout();
            // 
            // labelTitle
            // 
            this.labelTitle.AutoSize = true;
            this.labelTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelTitle.Location = new System.Drawing.Point(22, 67);
            this.labelTitle.Name = "labelTitle";
            this.labelTitle.Size = new System.Drawing.Size(109, 31);
            this.labelTitle.TabIndex = 11;
            this.labelTitle.Text = "Accueil";
            this.labelTitle.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // panelSideMenu
            // 
            this.panelSideMenu.BackColor = System.Drawing.Color.Gray;
            this.panelSideMenu.Controls.Add(this.buttonCountryApi);
            this.panelSideMenu.Controls.Add(this.buttonCrud);
            this.panelSideMenu.Controls.Add(this.labelTitle);
            this.panelSideMenu.Controls.Add(this.panelApi);
            this.panelSideMenu.Controls.Add(this.panelAjouter);
            this.panelSideMenu.Dock = System.Windows.Forms.DockStyle.Left;
            this.panelSideMenu.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.panelSideMenu.Location = new System.Drawing.Point(0, 0);
            this.panelSideMenu.Name = "panelSideMenu";
            this.panelSideMenu.Size = new System.Drawing.Size(150, 568);
            this.panelSideMenu.TabIndex = 13;
            // 
            // buttonCountryApi
            // 
            this.buttonCountryApi.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.buttonCountryApi.Location = new System.Drawing.Point(13, 314);
            this.buttonCountryApi.Name = "buttonCountryApi";
            this.buttonCountryApi.Size = new System.Drawing.Size(124, 46);
            this.buttonCountryApi.TabIndex = 14;
            this.buttonCountryApi.Text = "API";
            this.buttonCountryApi.UseVisualStyleBackColor = false;
            this.buttonCountryApi.Click += new System.EventHandler(this.buttonCountryApi_Click);
            // 
            // buttonCrud
            // 
            this.buttonCrud.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.buttonCrud.Location = new System.Drawing.Point(13, 191);
            this.buttonCrud.Name = "buttonCrud";
            this.buttonCrud.Size = new System.Drawing.Size(124, 46);
            this.buttonCrud.TabIndex = 13;
            this.buttonCrud.Text = "CRUD";
            this.buttonCrud.UseVisualStyleBackColor = false;
            this.buttonCrud.Click += new System.EventHandler(this.buttonCrud_Click);
            // 
            // panelApi
            // 
            this.panelApi.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.panelApi.Controls.Add(this.labelContinent);
            this.panelApi.Controls.Add(this.textBoxContinent);
            this.panelApi.Controls.Add(this.label1);
            this.panelApi.Controls.Add(this.textBoxPays);
            this.panelApi.Controls.Add(this.dataGridViewPays);
            this.panelApi.Controls.Add(this.buttonGetAllData);
            this.panelApi.Location = new System.Drawing.Point(150, 29);
            this.panelApi.Name = "panelApi";
            this.panelApi.Size = new System.Drawing.Size(975, 539);
            this.panelApi.TabIndex = 27;
            // 
            // labelContinent
            // 
            this.labelContinent.AutoSize = true;
            this.labelContinent.Location = new System.Drawing.Point(176, 26);
            this.labelContinent.Name = "labelContinent";
            this.labelContinent.Size = new System.Drawing.Size(52, 13);
            this.labelContinent.TabIndex = 15;
            this.labelContinent.Text = "Continent";
            // 
            // textBoxContinent
            // 
            this.textBoxContinent.Location = new System.Drawing.Point(175, 45);
            this.textBoxContinent.Name = "textBoxContinent";
            this.textBoxContinent.Size = new System.Drawing.Size(143, 20);
            this.textBoxContinent.TabIndex = 14;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 26);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(30, 13);
            this.label1.TabIndex = 13;
            this.label1.Text = "Pays";
            // 
            // textBoxPays
            // 
            this.textBoxPays.Location = new System.Drawing.Point(11, 45);
            this.textBoxPays.Name = "textBoxPays";
            this.textBoxPays.Size = new System.Drawing.Size(143, 20);
            this.textBoxPays.TabIndex = 12;
            // 
            // dataGridViewPays
            // 
            this.dataGridViewPays.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridViewPays.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.DisplayedCells;
            this.dataGridViewPays.BackgroundColor = System.Drawing.SystemColors.ControlDarkDark;
            this.dataGridViewPays.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewPays.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.dataGridViewPays.Location = new System.Drawing.Point(0, 122);
            this.dataGridViewPays.Name = "dataGridViewPays";
            this.dataGridViewPays.Size = new System.Drawing.Size(975, 417);
            this.dataGridViewPays.TabIndex = 11;
            // 
            // buttonGetAllData
            // 
            this.buttonGetAllData.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.buttonGetAllData.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.buttonGetAllData.Location = new System.Drawing.Point(12, 86);
            this.buttonGetAllData.Name = "buttonGetAllData";
            this.buttonGetAllData.Size = new System.Drawing.Size(125, 32);
            this.buttonGetAllData.TabIndex = 10;
            this.buttonGetAllData.Text = "Rechercher";
            this.buttonGetAllData.UseVisualStyleBackColor = false;
            this.buttonGetAllData.Click += new System.EventHandler(this.buttonGetAllData_Click);
            // 
            // panelAjouter
            // 
            this.panelAjouter.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.panelAjouter.Controls.Add(this.label2);
            this.panelAjouter.Controls.Add(this.button2);
            this.panelAjouter.Controls.Add(this.labelNote);
            this.panelAjouter.Controls.Add(this.label3);
            this.panelAjouter.Controls.Add(this.label4);
            this.panelAjouter.Controls.Add(this.label5);
            this.panelAjouter.Controls.Add(this.richTextBoxAjouterNote);
            this.panelAjouter.Controls.Add(this.textBoxAjouterCourriel);
            this.panelAjouter.Controls.Add(this.textBoxAjouterNom);
            this.panelAjouter.Controls.Add(this.textBoxAjouterPrenom);
            this.panelAjouter.Location = new System.Drawing.Point(150, 29);
            this.panelAjouter.Name = "panelAjouter";
            this.panelAjouter.Size = new System.Drawing.Size(975, 539);
            this.panelAjouter.TabIndex = 15;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(434, 68);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(107, 31);
            this.label2.TabIndex = 46;
            this.label2.Text = "Ajouter";
            this.label2.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button2.Location = new System.Drawing.Point(583, 426);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 45;
            this.button2.Text = "Ajouter";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2Ajouter_Click);
            // 
            // labelNote
            // 
            this.labelNote.AutoSize = true;
            this.labelNote.Location = new System.Drawing.Point(321, 283);
            this.labelNote.Name = "labelNote";
            this.labelNote.Size = new System.Drawing.Size(30, 13);
            this.labelNote.TabIndex = 44;
            this.labelNote.Text = "Note";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(317, 228);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(42, 13);
            this.label3.TabIndex = 43;
            this.label3.Text = "Courriel";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(317, 187);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(29, 13);
            this.label4.TabIndex = 42;
            this.label4.Text = "Nom";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(317, 143);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(43, 13);
            this.label5.TabIndex = 41;
            this.label5.Text = "Prénom";
            // 
            // richTextBoxAjouterNote
            // 
            this.richTextBoxAjouterNote.Location = new System.Drawing.Point(317, 299);
            this.richTextBoxAjouterNote.Name = "richTextBoxAjouterNote";
            this.richTextBoxAjouterNote.Size = new System.Drawing.Size(342, 96);
            this.richTextBoxAjouterNote.TabIndex = 40;
            this.richTextBoxAjouterNote.Text = "";
            // 
            // textBoxAjouterCourriel
            // 
            this.textBoxAjouterCourriel.Location = new System.Drawing.Point(317, 244);
            this.textBoxAjouterCourriel.Name = "textBoxAjouterCourriel";
            this.textBoxAjouterCourriel.Size = new System.Drawing.Size(342, 20);
            this.textBoxAjouterCourriel.TabIndex = 39;
            // 
            // textBoxAjouterNom
            // 
            this.textBoxAjouterNom.Location = new System.Drawing.Point(317, 203);
            this.textBoxAjouterNom.Name = "textBoxAjouterNom";
            this.textBoxAjouterNom.Size = new System.Drawing.Size(342, 20);
            this.textBoxAjouterNom.TabIndex = 38;
            // 
            // textBoxAjouterPrenom
            // 
            this.textBoxAjouterPrenom.Location = new System.Drawing.Point(317, 162);
            this.textBoxAjouterPrenom.Name = "textBoxAjouterPrenom";
            this.textBoxAjouterPrenom.Size = new System.Drawing.Size(342, 20);
            this.textBoxAjouterPrenom.TabIndex = 37;
            // 
            // panelInfos
            // 
            this.panelInfos.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.panelInfos.Controls.Add(this.labelModifier);
            this.panelInfos.Controls.Add(this.buttonModifier);
            this.panelInfos.Controls.Add(this.labelModifierNote);
            this.panelInfos.Controls.Add(this.labelModifierCourriel);
            this.panelInfos.Controls.Add(this.labelModifierNom);
            this.panelInfos.Controls.Add(this.labelModifierPrenom);
            this.panelInfos.Controls.Add(this.richTextBoxInfoNote);
            this.panelInfos.Controls.Add(this.textBoxInfoCourriel);
            this.panelInfos.Controls.Add(this.textBoxInfoNom);
            this.panelInfos.Controls.Add(this.textBoxInfoPrenom);
            this.panelInfos.ForeColor = System.Drawing.SystemColors.ControlText;
            this.panelInfos.Location = new System.Drawing.Point(150, 29);
            this.panelInfos.Name = "panelInfos";
            this.panelInfos.Size = new System.Drawing.Size(975, 539);
            this.panelInfos.TabIndex = 27;
            // 
            // labelModifier
            // 
            this.labelModifier.AutoSize = true;
            this.labelModifier.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelModifier.Location = new System.Drawing.Point(392, 79);
            this.labelModifier.Name = "labelModifier";
            this.labelModifier.Size = new System.Drawing.Size(118, 31);
            this.labelModifier.TabIndex = 41;
            this.labelModifier.Text = "Modifier";
            this.labelModifier.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // buttonModifier
            // 
            this.buttonModifier.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.buttonModifier.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.buttonModifier.Location = new System.Drawing.Point(559, 425);
            this.buttonModifier.Name = "buttonModifier";
            this.buttonModifier.Size = new System.Drawing.Size(75, 23);
            this.buttonModifier.TabIndex = 39;
            this.buttonModifier.Text = "Modifier";
            this.buttonModifier.UseVisualStyleBackColor = false;
            this.buttonModifier.Click += new System.EventHandler(this.buttonModifier_Click);
            // 
            // labelModifierNote
            // 
            this.labelModifierNote.AutoSize = true;
            this.labelModifierNote.Location = new System.Drawing.Point(293, 282);
            this.labelModifierNote.Name = "labelModifierNote";
            this.labelModifierNote.Size = new System.Drawing.Size(30, 13);
            this.labelModifierNote.TabIndex = 38;
            this.labelModifierNote.Text = "Note";
            // 
            // labelModifierCourriel
            // 
            this.labelModifierCourriel.AutoSize = true;
            this.labelModifierCourriel.Location = new System.Drawing.Point(293, 227);
            this.labelModifierCourriel.Name = "labelModifierCourriel";
            this.labelModifierCourriel.Size = new System.Drawing.Size(42, 13);
            this.labelModifierCourriel.TabIndex = 37;
            this.labelModifierCourriel.Text = "Courriel";
            // 
            // labelModifierNom
            // 
            this.labelModifierNom.AutoSize = true;
            this.labelModifierNom.Location = new System.Drawing.Point(293, 186);
            this.labelModifierNom.Name = "labelModifierNom";
            this.labelModifierNom.Size = new System.Drawing.Size(29, 13);
            this.labelModifierNom.TabIndex = 36;
            this.labelModifierNom.Text = "Nom";
            // 
            // labelModifierPrenom
            // 
            this.labelModifierPrenom.AutoSize = true;
            this.labelModifierPrenom.Location = new System.Drawing.Point(293, 142);
            this.labelModifierPrenom.Name = "labelModifierPrenom";
            this.labelModifierPrenom.Size = new System.Drawing.Size(43, 13);
            this.labelModifierPrenom.TabIndex = 35;
            this.labelModifierPrenom.Text = "Prénom";
            // 
            // richTextBoxInfoNote
            // 
            this.richTextBoxInfoNote.Location = new System.Drawing.Point(293, 298);
            this.richTextBoxInfoNote.Name = "richTextBoxInfoNote";
            this.richTextBoxInfoNote.Size = new System.Drawing.Size(342, 96);
            this.richTextBoxInfoNote.TabIndex = 34;
            this.richTextBoxInfoNote.Text = "";
            // 
            // textBoxInfoCourriel
            // 
            this.textBoxInfoCourriel.Location = new System.Drawing.Point(293, 243);
            this.textBoxInfoCourriel.Name = "textBoxInfoCourriel";
            this.textBoxInfoCourriel.Size = new System.Drawing.Size(342, 20);
            this.textBoxInfoCourriel.TabIndex = 33;
            // 
            // textBoxInfoNom
            // 
            this.textBoxInfoNom.Location = new System.Drawing.Point(293, 202);
            this.textBoxInfoNom.Name = "textBoxInfoNom";
            this.textBoxInfoNom.Size = new System.Drawing.Size(342, 20);
            this.textBoxInfoNom.TabIndex = 32;
            // 
            // textBoxInfoPrenom
            // 
            this.textBoxInfoPrenom.CausesValidation = false;
            this.textBoxInfoPrenom.Location = new System.Drawing.Point(293, 161);
            this.textBoxInfoPrenom.Name = "textBoxInfoPrenom";
            this.textBoxInfoPrenom.Size = new System.Drawing.Size(342, 20);
            this.textBoxInfoPrenom.TabIndex = 31;
            // 
            // panelTop
            // 
            this.panelTop.BackColor = System.Drawing.Color.Gray;
            this.panelTop.Controls.Add(this.button1);
            this.panelTop.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelTop.Location = new System.Drawing.Point(150, 0);
            this.panelTop.Name = "panelTop";
            this.panelTop.Size = new System.Drawing.Size(975, 30);
            this.panelTop.TabIndex = 14;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(942, -1);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(34, 32);
            this.button1.TabIndex = 15;
            this.button1.Text = "X";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.buttonExit_Click);
            // 
            // panelCrud
            // 
            this.panelCrud.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.panelCrud.Controls.Add(this.panelInfos);
            this.panelCrud.Controls.Add(this.buttonRecharger);
            this.panelCrud.Controls.Add(this.buttonMoreInfo);
            this.panelCrud.Controls.Add(this.buttonRechercher);
            this.panelCrud.Controls.Add(this.buttonAjouter);
            this.panelCrud.Controls.Add(this.labelCourriel);
            this.panelCrud.Controls.Add(this.textBoxCourriel);
            this.panelCrud.Controls.Add(this.labelNom);
            this.panelCrud.Controls.Add(this.labelPrenom);
            this.panelCrud.Controls.Add(this.textBoxNom);
            this.panelCrud.Controls.Add(this.textBoxPrenom);
            this.panelCrud.Controls.Add(this.buttonSupprimer);
            this.panelCrud.Controls.Add(this.dataGridViewListePersonnes);
            this.panelCrud.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panelCrud.Location = new System.Drawing.Point(150, 29);
            this.panelCrud.Name = "panelCrud";
            this.panelCrud.Size = new System.Drawing.Size(975, 539);
            this.panelCrud.TabIndex = 15;
            // 
            // buttonRecharger
            // 
            this.buttonRecharger.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.buttonRecharger.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.buttonRecharger.Location = new System.Drawing.Point(343, 188);
            this.buttonRecharger.Name = "buttonRecharger";
            this.buttonRecharger.Size = new System.Drawing.Size(75, 23);
            this.buttonRecharger.TabIndex = 26;
            this.buttonRecharger.Text = "Recharger";
            this.buttonRecharger.UseVisualStyleBackColor = false;
            this.buttonRecharger.Click += new System.EventHandler(this.buttonRecharger_Click);
            // 
            // buttonMoreInfo
            // 
            this.buttonMoreInfo.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.buttonMoreInfo.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.buttonMoreInfo.Location = new System.Drawing.Point(262, 188);
            this.buttonMoreInfo.Name = "buttonMoreInfo";
            this.buttonMoreInfo.Size = new System.Drawing.Size(75, 23);
            this.buttonMoreInfo.TabIndex = 25;
            this.buttonMoreInfo.Text = "Modifier";
            this.buttonMoreInfo.UseVisualStyleBackColor = false;
            this.buttonMoreInfo.Click += new System.EventHandler(this.buttonModifierPersonne_Click_1);
            // 
            // buttonRechercher
            // 
            this.buttonRechercher.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.buttonRechercher.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.buttonRechercher.Location = new System.Drawing.Point(181, 188);
            this.buttonRechercher.Name = "buttonRechercher";
            this.buttonRechercher.Size = new System.Drawing.Size(75, 23);
            this.buttonRechercher.TabIndex = 24;
            this.buttonRechercher.Text = "Rechercher";
            this.buttonRechercher.UseVisualStyleBackColor = false;
            this.buttonRechercher.Click += new System.EventHandler(this.buttonRechercher_Click_1);
            // 
            // buttonAjouter
            // 
            this.buttonAjouter.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.buttonAjouter.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.buttonAjouter.Location = new System.Drawing.Point(19, 188);
            this.buttonAjouter.Name = "buttonAjouter";
            this.buttonAjouter.Size = new System.Drawing.Size(75, 23);
            this.buttonAjouter.TabIndex = 23;
            this.buttonAjouter.Text = "Ajouter";
            this.buttonAjouter.UseVisualStyleBackColor = false;
            this.buttonAjouter.Click += new System.EventHandler(this.buttonAjouter_Click_1);
            // 
            // labelCourriel
            // 
            this.labelCourriel.AutoSize = true;
            this.labelCourriel.Location = new System.Drawing.Point(16, 144);
            this.labelCourriel.Name = "labelCourriel";
            this.labelCourriel.Size = new System.Drawing.Size(42, 13);
            this.labelCourriel.TabIndex = 21;
            this.labelCourriel.Text = "Courriel";
            // 
            // textBoxCourriel
            // 
            this.textBoxCourriel.Location = new System.Drawing.Point(61, 144);
            this.textBoxCourriel.Name = "textBoxCourriel";
            this.textBoxCourriel.Size = new System.Drawing.Size(260, 20);
            this.textBoxCourriel.TabIndex = 20;
            // 
            // labelNom
            // 
            this.labelNom.AutoSize = true;
            this.labelNom.Location = new System.Drawing.Point(16, 108);
            this.labelNom.Name = "labelNom";
            this.labelNom.Size = new System.Drawing.Size(29, 13);
            this.labelNom.TabIndex = 19;
            this.labelNom.Text = "Nom";
            // 
            // labelPrenom
            // 
            this.labelPrenom.AutoSize = true;
            this.labelPrenom.Location = new System.Drawing.Point(16, 70);
            this.labelPrenom.Name = "labelPrenom";
            this.labelPrenom.Size = new System.Drawing.Size(43, 13);
            this.labelPrenom.TabIndex = 18;
            this.labelPrenom.Text = "Prenom";
            // 
            // textBoxNom
            // 
            this.textBoxNom.Location = new System.Drawing.Point(61, 108);
            this.textBoxNom.Name = "textBoxNom";
            this.textBoxNom.Size = new System.Drawing.Size(260, 20);
            this.textBoxNom.TabIndex = 17;
            // 
            // textBoxPrenom
            // 
            this.textBoxPrenom.Location = new System.Drawing.Point(61, 70);
            this.textBoxPrenom.Name = "textBoxPrenom";
            this.textBoxPrenom.Size = new System.Drawing.Size(260, 20);
            this.textBoxPrenom.TabIndex = 16;
            // 
            // buttonSupprimer
            // 
            this.buttonSupprimer.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.buttonSupprimer.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.buttonSupprimer.Location = new System.Drawing.Point(100, 188);
            this.buttonSupprimer.Name = "buttonSupprimer";
            this.buttonSupprimer.Size = new System.Drawing.Size(75, 23);
            this.buttonSupprimer.TabIndex = 15;
            this.buttonSupprimer.Text = "Supprimer";
            this.buttonSupprimer.UseVisualStyleBackColor = false;
            this.buttonSupprimer.Click += new System.EventHandler(this.buttonSupprimer_Click);
            // 
            // dataGridViewListePersonnes
            // 
            this.dataGridViewListePersonnes.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridViewListePersonnes.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.DisplayedCells;
            this.dataGridViewListePersonnes.BackgroundColor = System.Drawing.SystemColors.ControlDarkDark;
            this.dataGridViewListePersonnes.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewListePersonnes.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.dataGridViewListePersonnes.Location = new System.Drawing.Point(0, 215);
            this.dataGridViewListePersonnes.Name = "dataGridViewListePersonnes";
            this.dataGridViewListePersonnes.Size = new System.Drawing.Size(975, 324);
            this.dataGridViewListePersonnes.TabIndex = 14;
            this.dataGridViewListePersonnes.RowHeaderMouseClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dataGridViewListeUtilisateurs_RowHeaderMouseClick_1);
            // 
            // Accueil
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.ClientSize = new System.Drawing.Size(1125, 568);
            this.Controls.Add(this.panelCrud);
            this.Controls.Add(this.panelTop);
            this.Controls.Add(this.panelSideMenu);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Accueil";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Accueil";
            this.panelSideMenu.ResumeLayout(false);
            this.panelSideMenu.PerformLayout();
            this.panelApi.ResumeLayout(false);
            this.panelApi.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewPays)).EndInit();
            this.panelAjouter.ResumeLayout(false);
            this.panelAjouter.PerformLayout();
            this.panelInfos.ResumeLayout(false);
            this.panelInfos.PerformLayout();
            this.panelTop.ResumeLayout(false);
            this.panelCrud.ResumeLayout(false);
            this.panelCrud.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewListePersonnes)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Label labelTitle;
        private System.Windows.Forms.Panel panelSideMenu;
        private System.Windows.Forms.Panel panelTop;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button buttonCountryApi;
        private System.Windows.Forms.Button buttonCrud;
        private System.Windows.Forms.Panel panelCrud;
        private System.Windows.Forms.Button buttonRechercher;
        private System.Windows.Forms.Button buttonAjouter;
        private System.Windows.Forms.Label labelCourriel;
        private System.Windows.Forms.TextBox textBoxCourriel;
        private System.Windows.Forms.Label labelNom;
        private System.Windows.Forms.Label labelPrenom;
        private System.Windows.Forms.TextBox textBoxNom;
        private System.Windows.Forms.TextBox textBoxPrenom;
        private System.Windows.Forms.Button buttonSupprimer;
        private System.Windows.Forms.DataGridView dataGridViewListePersonnes;
        private System.Windows.Forms.Panel panelApi;
        private System.Windows.Forms.Label labelContinent;
        private System.Windows.Forms.TextBox textBoxContinent;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBoxPays;
        private System.Windows.Forms.DataGridView dataGridViewPays;
        private System.Windows.Forms.Button buttonGetAllData;
        private System.Windows.Forms.Panel panelAjouter;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Label labelNote;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.RichTextBox richTextBoxAjouterNote;
        private System.Windows.Forms.TextBox textBoxAjouterCourriel;
        private System.Windows.Forms.TextBox textBoxAjouterNom;
        private System.Windows.Forms.TextBox textBoxAjouterPrenom;
        private System.Windows.Forms.Button buttonRecharger;
        private System.Windows.Forms.Button buttonMoreInfo;
        private System.Windows.Forms.Panel panelInfos;
        private System.Windows.Forms.Label labelModifier;
        private System.Windows.Forms.Button buttonModifier;
        private System.Windows.Forms.Label labelModifierNote;
        private System.Windows.Forms.Label labelModifierCourriel;
        private System.Windows.Forms.Label labelModifierNom;
        private System.Windows.Forms.Label labelModifierPrenom;
        private System.Windows.Forms.RichTextBox richTextBoxInfoNote;
        private System.Windows.Forms.TextBox textBoxInfoCourriel;
        private System.Windows.Forms.TextBox textBoxInfoNom;
        private System.Windows.Forms.TextBox textBoxInfoPrenom;
    }
}