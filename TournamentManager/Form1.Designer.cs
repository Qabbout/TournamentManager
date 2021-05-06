namespace TournamentManager
{
    partial class TournamentManager
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
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabTournaments = new System.Windows.Forms.TabPage();
            this.label4 = new System.Windows.Forms.Label();
            this.nbOfTeams = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.tourName = new System.Windows.Forms.TextBox();
            this.btnCreateTour = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.toursListBox = new System.Windows.Forms.ListBox();
            this.tabTeams = new System.Windows.Forms.TabPage();
            this.label7 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.toursListBox2 = new System.Windows.Forms.ListBox();
            this.teamName = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.btnRemoveTeam = new System.Windows.Forms.Button();
            this.btnAddTeam = new System.Windows.Forms.Button();
            this.teamsListBox = new System.Windows.Forms.ListBox();
            this.tabPlayers = new System.Windows.Forms.TabPage();
            this.btnRemovePlayer = new System.Windows.Forms.Button();
            this.label8 = new System.Windows.Forms.Label();
            this.playerNb = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.playerName = new System.Windows.Forms.TextBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.btnAddPlayer = new System.Windows.Forms.Button();
            this.groupBox5 = new System.Windows.Forms.GroupBox();
            this.attacker = new System.Windows.Forms.RadioButton();
            this.GK = new System.Windows.Forms.RadioButton();
            this.midfielder = new System.Windows.Forms.RadioButton();
            this.defender = new System.Windows.Forms.RadioButton();
            this.panel1 = new System.Windows.Forms.Panel();
            this.playersListBox = new System.Windows.Forms.ListBox();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.toursComboBox = new System.Windows.Forms.ComboBox();
            this.teamsComboBox = new System.Windows.Forms.ComboBox();
            this.tabGeneration = new System.Windows.Forms.TabPage();
            this.startAgain = new System.Windows.Forms.Button();
            this.linkLabel2 = new System.Windows.Forms.LinkLabel();
            this.checkBox1 = new System.Windows.Forms.CheckBox();
            this.RemoveTeam = new System.Windows.Forms.Button();
            this.teamsListBox2 = new System.Windows.Forms.ListBox();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.toursComboBox2 = new System.Windows.Forms.ComboBox();
            this.btnSubmit = new System.Windows.Forms.Button();
            this.label13 = new System.Windows.Forms.Label();
            this.nbofgoals = new System.Windows.Forms.TextBox();
            this.scorer = new System.Windows.Forms.TextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.btnAddDate = new System.Windows.Forms.Button();
            this.matchesListBox = new System.Windows.Forms.ListBox();
            this.label10 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.btnGeneratePole = new System.Windows.Forms.Button();
            this.tabControl1.SuspendLayout();
            this.tabTournaments.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.tabTeams.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.tabPlayers.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox5.SuspendLayout();
            this.panel1.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.tabGeneration.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabTournaments);
            this.tabControl1.Controls.Add(this.tabTeams);
            this.tabControl1.Controls.Add(this.tabPlayers);
            this.tabControl1.Controls.Add(this.tabGeneration);
            this.tabControl1.Location = new System.Drawing.Point(3, 2);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(835, 436);
            this.tabControl1.TabIndex = 0;
            // 
            // tabTournaments
            // 
            this.tabTournaments.Controls.Add(this.label4);
            this.tabTournaments.Controls.Add(this.nbOfTeams);
            this.tabTournaments.Controls.Add(this.label3);
            this.tabTournaments.Controls.Add(this.tourName);
            this.tabTournaments.Controls.Add(this.btnCreateTour);
            this.tabTournaments.Controls.Add(this.label2);
            this.tabTournaments.Controls.Add(this.label1);
            this.tabTournaments.Controls.Add(this.groupBox2);
            this.tabTournaments.Location = new System.Drawing.Point(4, 25);
            this.tabTournaments.Name = "tabTournaments";
            this.tabTournaments.Padding = new System.Windows.Forms.Padding(3);
            this.tabTournaments.Size = new System.Drawing.Size(827, 407);
            this.tabTournaments.TabIndex = 0;
            this.tabTournaments.Text = "Create Tournament";
            this.tabTournaments.UseVisualStyleBackColor = true;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(108, 164);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(180, 17);
            this.label4.TabIndex = 6;
            this.label4.Text = "Number of Teams (8 or 16)";
            // 
            // nbOfTeams
            // 
            this.nbOfTeams.Location = new System.Drawing.Point(297, 161);
            this.nbOfTeams.Name = "nbOfTeams";
            this.nbOfTeams.Size = new System.Drawing.Size(193, 22);
            this.nbOfTeams.TabIndex = 5;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(162, 108);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(126, 17);
            this.label3.TabIndex = 4;
            this.label3.Text = "Tournament Name";
            // 
            // tourName
            // 
            this.tourName.Location = new System.Drawing.Point(297, 105);
            this.tourName.Name = "tourName";
            this.tourName.Size = new System.Drawing.Size(193, 22);
            this.tourName.TabIndex = 3;
            // 
            // btnCreateTour
            // 
            this.btnCreateTour.Location = new System.Drawing.Point(297, 211);
            this.btnCreateTour.Name = "btnCreateTour";
            this.btnCreateTour.Size = new System.Drawing.Size(193, 40);
            this.btnCreateTour.TabIndex = 2;
            this.btnCreateTour.Text = "Create";
            this.btnCreateTour.UseVisualStyleBackColor = true;
            this.btnCreateTour.Click += new System.EventHandler(this.BtnCreateTour_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(307, 38);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(210, 17);
            this.label2.TabIndex = 1;
            this.label2.Text = "Please create a tournament first";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(294, 12);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(223, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "Welcome to Tournament Manager";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.toursListBox);
            this.groupBox2.Location = new System.Drawing.Point(95, 58);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(634, 329);
            this.groupBox2.TabIndex = 8;
            this.groupBox2.TabStop = false;
            // 
            // toursListBox
            // 
            this.toursListBox.FormattingEnabled = true;
            this.toursListBox.HorizontalScrollbar = true;
            this.toursListBox.ItemHeight = 16;
            this.toursListBox.Location = new System.Drawing.Point(438, 41);
            this.toursListBox.Name = "toursListBox";
            this.toursListBox.Size = new System.Drawing.Size(145, 276);
            this.toursListBox.TabIndex = 0;
            // 
            // tabTeams
            // 
            this.tabTeams.Controls.Add(this.label7);
            this.tabTeams.Controls.Add(this.groupBox1);
            this.tabTeams.Location = new System.Drawing.Point(4, 25);
            this.tabTeams.Name = "tabTeams";
            this.tabTeams.Padding = new System.Windows.Forms.Padding(3);
            this.tabTeams.Size = new System.Drawing.Size(827, 407);
            this.tabTeams.TabIndex = 1;
            this.tabTeams.Text = "Add Teams";
            this.tabTeams.UseVisualStyleBackColor = true;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(237, 29);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(337, 17);
            this.label7.TabIndex = 5;
            this.label7.Text = "Select a tournament that you want add the teams to.";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.toursListBox2);
            this.groupBox1.Controls.Add(this.teamName);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.btnRemoveTeam);
            this.groupBox1.Controls.Add(this.btnAddTeam);
            this.groupBox1.Controls.Add(this.teamsListBox);
            this.groupBox1.Location = new System.Drawing.Point(125, 61);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(592, 281);
            this.groupBox1.TabIndex = 3;
            this.groupBox1.TabStop = false;
            // 
            // toursListBox2
            // 
            this.toursListBox2.BackColor = System.Drawing.Color.White;
            this.toursListBox2.FormattingEnabled = true;
            this.toursListBox2.HorizontalScrollbar = true;
            this.toursListBox2.ItemHeight = 16;
            this.toursListBox2.Location = new System.Drawing.Point(305, 21);
            this.toursListBox2.Name = "toursListBox2";
            this.toursListBox2.Size = new System.Drawing.Size(123, 244);
            this.toursListBox2.TabIndex = 7;
            this.toursListBox2.SelectedIndexChanged += new System.EventHandler(this.ToursListBox2_SelectedIndexChanged);
            // 
            // teamName
            // 
            this.teamName.Location = new System.Drawing.Point(115, 36);
            this.teamName.Name = "teamName";
            this.teamName.Size = new System.Drawing.Size(168, 22);
            this.teamName.TabIndex = 6;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(20, 36);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(89, 17);
            this.label5.TabIndex = 0;
            this.label5.Text = "Team Name:";
            // 
            // btnRemoveTeam
            // 
            this.btnRemoveTeam.Location = new System.Drawing.Point(115, 139);
            this.btnRemoveTeam.Name = "btnRemoveTeam";
            this.btnRemoveTeam.Size = new System.Drawing.Size(168, 39);
            this.btnRemoveTeam.TabIndex = 5;
            this.btnRemoveTeam.Text = "Remove";
            this.btnRemoveTeam.UseVisualStyleBackColor = true;
            this.btnRemoveTeam.Click += new System.EventHandler(this.BtnRemoveTeam_Click);
            // 
            // btnAddTeam
            // 
            this.btnAddTeam.Location = new System.Drawing.Point(115, 78);
            this.btnAddTeam.Name = "btnAddTeam";
            this.btnAddTeam.Size = new System.Drawing.Size(168, 38);
            this.btnAddTeam.TabIndex = 1;
            this.btnAddTeam.Text = "Add";
            this.btnAddTeam.UseVisualStyleBackColor = true;
            this.btnAddTeam.Click += new System.EventHandler(this.BtnAddTeam_Click);
            // 
            // teamsListBox
            // 
            this.teamsListBox.BackColor = System.Drawing.Color.White;
            this.teamsListBox.FormattingEnabled = true;
            this.teamsListBox.HorizontalScrollbar = true;
            this.teamsListBox.ItemHeight = 16;
            this.teamsListBox.Location = new System.Drawing.Point(453, 21);
            this.teamsListBox.Name = "teamsListBox";
            this.teamsListBox.Size = new System.Drawing.Size(123, 244);
            this.teamsListBox.TabIndex = 0;
            // 
            // tabPlayers
            // 
            this.tabPlayers.Controls.Add(this.btnRemovePlayer);
            this.tabPlayers.Controls.Add(this.label8);
            this.tabPlayers.Controls.Add(this.playerNb);
            this.tabPlayers.Controls.Add(this.label6);
            this.tabPlayers.Controls.Add(this.playerName);
            this.tabPlayers.Controls.Add(this.groupBox3);
            this.tabPlayers.Controls.Add(this.panel1);
            this.tabPlayers.Location = new System.Drawing.Point(4, 25);
            this.tabPlayers.Name = "tabPlayers";
            this.tabPlayers.Size = new System.Drawing.Size(827, 407);
            this.tabPlayers.TabIndex = 2;
            this.tabPlayers.Text = "Add Players";
            this.tabPlayers.UseVisualStyleBackColor = true;
            // 
            // btnRemovePlayer
            // 
            this.btnRemovePlayer.Location = new System.Drawing.Point(561, 241);
            this.btnRemovePlayer.Name = "btnRemovePlayer";
            this.btnRemovePlayer.Size = new System.Drawing.Size(168, 33);
            this.btnRemovePlayer.TabIndex = 12;
            this.btnRemovePlayer.Text = "Remove";
            this.btnRemovePlayer.UseVisualStyleBackColor = true;
            this.btnRemovePlayer.Click += new System.EventHandler(this.BtnRemovePlayer_Click);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(377, 153);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(106, 17);
            this.label8.TabIndex = 11;
            this.label8.Text = "Player Number:";
            // 
            // playerNb
            // 
            this.playerNb.Location = new System.Drawing.Point(489, 150);
            this.playerNb.Name = "playerNb";
            this.playerNb.Size = new System.Drawing.Size(168, 22);
            this.playerNb.TabIndex = 10;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(390, 125);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(93, 17);
            this.label6.TabIndex = 5;
            this.label6.Text = "Player Name:";
            // 
            // playerName
            // 
            this.playerName.Location = new System.Drawing.Point(489, 122);
            this.playerName.Name = "playerName";
            this.playerName.Size = new System.Drawing.Size(168, 22);
            this.playerName.TabIndex = 4;
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.btnAddPlayer);
            this.groupBox3.Controls.Add(this.groupBox5);
            this.groupBox3.Location = new System.Drawing.Point(243, 103);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(500, 189);
            this.groupBox3.TabIndex = 13;
            this.groupBox3.TabStop = false;
            // 
            // btnAddPlayer
            // 
            this.btnAddPlayer.Location = new System.Drawing.Point(82, 138);
            this.btnAddPlayer.Name = "btnAddPlayer";
            this.btnAddPlayer.Size = new System.Drawing.Size(168, 33);
            this.btnAddPlayer.TabIndex = 2;
            this.btnAddPlayer.Text = "Add";
            this.btnAddPlayer.UseVisualStyleBackColor = true;
            this.btnAddPlayer.Click += new System.EventHandler(this.BtnAddPlayer_Click);
            // 
            // groupBox5
            // 
            this.groupBox5.Controls.Add(this.attacker);
            this.groupBox5.Controls.Add(this.GK);
            this.groupBox5.Controls.Add(this.midfielder);
            this.groupBox5.Controls.Add(this.defender);
            this.groupBox5.Location = new System.Drawing.Point(30, 75);
            this.groupBox5.Name = "groupBox5";
            this.groupBox5.Size = new System.Drawing.Size(456, 51);
            this.groupBox5.TabIndex = 16;
            this.groupBox5.TabStop = false;
            this.groupBox5.Text = "Choose His Role";
            // 
            // attacker
            // 
            this.attacker.AutoSize = true;
            this.attacker.Location = new System.Drawing.Point(354, 21);
            this.attacker.Name = "attacker";
            this.attacker.Size = new System.Drawing.Size(80, 21);
            this.attacker.TabIndex = 8;
            this.attacker.Text = "attacker";
            this.attacker.UseVisualStyleBackColor = true;
            // 
            // GK
            // 
            this.GK.AutoSize = true;
            this.GK.Checked = true;
            this.GK.Location = new System.Drawing.Point(107, 21);
            this.GK.Name = "GK";
            this.GK.Size = new System.Drawing.Size(49, 21);
            this.GK.TabIndex = 15;
            this.GK.TabStop = true;
            this.GK.Text = "GK";
            this.GK.UseVisualStyleBackColor = true;
            // 
            // midfielder
            // 
            this.midfielder.AutoSize = true;
            this.midfielder.Location = new System.Drawing.Point(258, 21);
            this.midfielder.Name = "midfielder";
            this.midfielder.Size = new System.Drawing.Size(90, 21);
            this.midfielder.TabIndex = 7;
            this.midfielder.Text = "midfielder";
            this.midfielder.UseVisualStyleBackColor = true;
            // 
            // defender
            // 
            this.defender.AutoSize = true;
            this.defender.Location = new System.Drawing.Point(166, 21);
            this.defender.Name = "defender";
            this.defender.Size = new System.Drawing.Size(86, 21);
            this.defender.TabIndex = 6;
            this.defender.Text = "defender";
            this.defender.UseVisualStyleBackColor = true;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.playersListBox);
            this.panel1.Controls.Add(this.groupBox4);
            this.panel1.Location = new System.Drawing.Point(39, 40);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(715, 290);
            this.panel1.TabIndex = 14;
            // 
            // playersListBox
            // 
            this.playersListBox.FormattingEnabled = true;
            this.playersListBox.HorizontalScrollbar = true;
            this.playersListBox.ItemHeight = 16;
            this.playersListBox.Location = new System.Drawing.Point(38, 29);
            this.playersListBox.Name = "playersListBox";
            this.playersListBox.Size = new System.Drawing.Size(160, 244);
            this.playersListBox.TabIndex = 1;
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.toursComboBox);
            this.groupBox4.Controls.Add(this.teamsComboBox);
            this.groupBox4.Location = new System.Drawing.Point(3, 4);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(709, 283);
            this.groupBox4.TabIndex = 2;
            this.groupBox4.TabStop = false;
            // 
            // toursComboBox
            // 
            this.toursComboBox.FormattingEnabled = true;
            this.toursComboBox.Location = new System.Drawing.Point(272, 29);
            this.toursComboBox.Name = "toursComboBox";
            this.toursComboBox.Size = new System.Drawing.Size(175, 24);
            this.toursComboBox.TabIndex = 1;
            this.toursComboBox.Text = "--Select--";
            this.toursComboBox.SelectedIndexChanged += new System.EventHandler(this.ToursComboBox_SelectedIndexChanged);
            // 
            // teamsComboBox
            // 
            this.teamsComboBox.Location = new System.Drawing.Point(453, 29);
            this.teamsComboBox.Name = "teamsComboBox";
            this.teamsComboBox.Size = new System.Drawing.Size(212, 24);
            this.teamsComboBox.TabIndex = 0;
            this.teamsComboBox.TabStop = false;
            this.teamsComboBox.Text = "--Select--";
            this.teamsComboBox.SelectedIndexChanged += new System.EventHandler(this.TeamsComboBox_SelectedIndexChanged);
            // 
            // tabGeneration
            // 
            this.tabGeneration.Controls.Add(this.startAgain);
            this.tabGeneration.Controls.Add(this.linkLabel2);
            this.tabGeneration.Controls.Add(this.checkBox1);
            this.tabGeneration.Controls.Add(this.RemoveTeam);
            this.tabGeneration.Controls.Add(this.teamsListBox2);
            this.tabGeneration.Controls.Add(this.dateTimePicker1);
            this.tabGeneration.Controls.Add(this.toursComboBox2);
            this.tabGeneration.Controls.Add(this.btnSubmit);
            this.tabGeneration.Controls.Add(this.label13);
            this.tabGeneration.Controls.Add(this.nbofgoals);
            this.tabGeneration.Controls.Add(this.scorer);
            this.tabGeneration.Controls.Add(this.label12);
            this.tabGeneration.Controls.Add(this.label11);
            this.tabGeneration.Controls.Add(this.btnAddDate);
            this.tabGeneration.Controls.Add(this.matchesListBox);
            this.tabGeneration.Controls.Add(this.label10);
            this.tabGeneration.Controls.Add(this.label9);
            this.tabGeneration.Controls.Add(this.btnGeneratePole);
            this.tabGeneration.Location = new System.Drawing.Point(4, 25);
            this.tabGeneration.Name = "tabGeneration";
            this.tabGeneration.Size = new System.Drawing.Size(827, 407);
            this.tabGeneration.TabIndex = 3;
            this.tabGeneration.Text = "Generation and Scores";
            this.tabGeneration.UseVisualStyleBackColor = true;
            // 
            // startAgain
            // 
            this.startAgain.ForeColor = System.Drawing.Color.Red;
            this.startAgain.Location = new System.Drawing.Point(5, 339);
            this.startAgain.Name = "startAgain";
            this.startAgain.Size = new System.Drawing.Size(231, 31);
            this.startAgain.TabIndex = 22;
            this.startAgain.Text = "Start Again";
            this.startAgain.UseVisualStyleBackColor = true;
            this.startAgain.Click += new System.EventHandler(this.StartAgain_Click);
            // 
            // linkLabel2
            // 
            this.linkLabel2.AutoSize = true;
            this.linkLabel2.Location = new System.Drawing.Point(179, 390);
            this.linkLabel2.Name = "linkLabel2";
            this.linkLabel2.Size = new System.Drawing.Size(380, 17);
            this.linkLabel2.TabIndex = 21;
            this.linkLabel2.TabStop = true;
            this.linkLabel2.Text = "We will love to hear your feedback, consider filling this form";
            this.linkLabel2.Visible = false;
            this.linkLabel2.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.LinkLabel2_LinkClicked);
            // 
            // checkBox1
            // 
            this.checkBox1.AutoSize = true;
            this.checkBox1.Location = new System.Drawing.Point(357, 267);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.Size = new System.Drawing.Size(189, 21);
            this.checkBox1.TabIndex = 20;
            this.checkBox1.Text = "Finished Entering Goals?";
            this.checkBox1.UseVisualStyleBackColor = true;
            // 
            // RemoveTeam
            // 
            this.RemoveTeam.Location = new System.Drawing.Point(374, 149);
            this.RemoveTeam.Name = "RemoveTeam";
            this.RemoveTeam.Size = new System.Drawing.Size(100, 31);
            this.RemoveTeam.TabIndex = 19;
            this.RemoveTeam.Text = "Remove";
            this.RemoveTeam.UseVisualStyleBackColor = true;
            this.RemoveTeam.Click += new System.EventHandler(this.RemoveTeam_Click);
            // 
            // teamsListBox2
            // 
            this.teamsListBox2.FormattingEnabled = true;
            this.teamsListBox2.ItemHeight = 16;
            this.teamsListBox2.Location = new System.Drawing.Point(573, 14);
            this.teamsListBox2.Name = "teamsListBox2";
            this.teamsListBox2.Size = new System.Drawing.Size(120, 356);
            this.teamsListBox2.TabIndex = 18;
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.CustomFormat = "MM/dd/yyyy hh:mm:ss";
            this.dateTimePicker1.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dateTimePicker1.Location = new System.Drawing.Point(394, 109);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(173, 22);
            this.dateTimePicker1.TabIndex = 17;
            // 
            // toursComboBox2
            // 
            this.toursComboBox2.FormattingEnabled = true;
            this.toursComboBox2.Location = new System.Drawing.Point(62, 14);
            this.toursComboBox2.Name = "toursComboBox2";
            this.toursComboBox2.Size = new System.Drawing.Size(338, 24);
            this.toursComboBox2.TabIndex = 16;
            this.toursComboBox2.Text = "--Select--";
            this.toursComboBox2.SelectedIndexChanged += new System.EventHandler(this.ToursComboBox2_SelectedIndexChanged);
            // 
            // btnSubmit
            // 
            this.btnSubmit.Location = new System.Drawing.Point(357, 294);
            this.btnSubmit.Name = "btnSubmit";
            this.btnSubmit.Size = new System.Drawing.Size(171, 31);
            this.btnSubmit.TabIndex = 15;
            this.btnSubmit.Text = "Submit";
            this.btnSubmit.UseVisualStyleBackColor = true;
            this.btnSubmit.Click += new System.EventHandler(this.BtnSubmit_Click);
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(20, 239);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(325, 17);
            this.label13.TabIndex = 14;
            this.label13.Text = "Select his team and enter the number of his goals:";
            // 
            // nbofgoals
            // 
            this.nbofgoals.Location = new System.Drawing.Point(357, 239);
            this.nbofgoals.Name = "nbofgoals";
            this.nbofgoals.Size = new System.Drawing.Size(171, 22);
            this.nbofgoals.TabIndex = 13;
            // 
            // scorer
            // 
            this.scorer.Location = new System.Drawing.Point(357, 213);
            this.scorer.Name = "scorer";
            this.scorer.Size = new System.Drawing.Size(171, 22);
            this.scorer.TabIndex = 12;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(41, 213);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(268, 17);
            this.label12.TabIndex = 11;
            this.label12.Text = "Enter the name of the player who scored:";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(20, 156);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(348, 17);
            this.label11.TabIndex = 9;
            this.label11.Text = "Select the loser team from the list of teams to Remove";
            // 
            // btnAddDate
            // 
            this.btnAddDate.Location = new System.Drawing.Point(285, 108);
            this.btnAddDate.Name = "btnAddDate";
            this.btnAddDate.Size = new System.Drawing.Size(100, 29);
            this.btnAddDate.TabIndex = 7;
            this.btnAddDate.Text = "Add";
            this.btnAddDate.UseVisualStyleBackColor = true;
            this.btnAddDate.Click += new System.EventHandler(this.BtnAddDate_Click);
            // 
            // matchesListBox
            // 
            this.matchesListBox.FormattingEnabled = true;
            this.matchesListBox.HorizontalScrollbar = true;
            this.matchesListBox.ItemHeight = 16;
            this.matchesListBox.Location = new System.Drawing.Point(699, 14);
            this.matchesListBox.Name = "matchesListBox";
            this.matchesListBox.Size = new System.Drawing.Size(125, 356);
            this.matchesListBox.TabIndex = 6;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(32, 108);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(234, 17);
            this.label10.TabIndex = 3;
            this.label10.Text = "Enter a date for the selected match:";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(41, 65);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(168, 17);
            this.label9.TabIndex = 2;
            this.label9.Text = "Random pole generation:";
            // 
            // btnGeneratePole
            // 
            this.btnGeneratePole.Location = new System.Drawing.Point(285, 58);
            this.btnGeneratePole.Name = "btnGeneratePole";
            this.btnGeneratePole.Size = new System.Drawing.Size(173, 30);
            this.btnGeneratePole.TabIndex = 1;
            this.btnGeneratePole.Text = "Generate";
            this.btnGeneratePole.UseVisualStyleBackColor = true;
            this.btnGeneratePole.Click += new System.EventHandler(this.BtnGeneratePole_Click);
            // 
            // TournamentManager
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(850, 450);
            this.Controls.Add(this.tabControl1);
            this.KeyPreview = true;
            this.Name = "TournamentManager";
            this.Text = "TournamentManager";
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.TournamentManager_KeyDown);
            this.tabControl1.ResumeLayout(false);
            this.tabTournaments.ResumeLayout(false);
            this.tabTournaments.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.tabTeams.ResumeLayout(false);
            this.tabTeams.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.tabPlayers.ResumeLayout(false);
            this.tabPlayers.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox5.ResumeLayout(false);
            this.groupBox5.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.groupBox4.ResumeLayout(false);
            this.tabGeneration.ResumeLayout(false);
            this.tabGeneration.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabTournaments;
        private System.Windows.Forms.TabPage tabTeams;
        private System.Windows.Forms.TabPage tabPlayers;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnCreateTour;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox tourName;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox nbOfTeams;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.ListBox toursListBox;
        private System.Windows.Forms.ListBox teamsListBox;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btnAddTeam;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox teamName;
        private System.Windows.Forms.Button btnRemoveTeam;
        private System.Windows.Forms.Button btnAddPlayer;
        private System.Windows.Forms.Button btnRemovePlayer;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox playerNb;
        private System.Windows.Forms.RadioButton attacker;
        private System.Windows.Forms.RadioButton midfielder;
        private System.Windows.Forms.RadioButton defender;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox playerName;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.ListBox playersListBox;
        private System.Windows.Forms.ComboBox teamsComboBox;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.ListBox toursListBox2;
        private System.Windows.Forms.TabPage tabGeneration;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Button btnGeneratePole;
        private System.Windows.Forms.Button btnAddDate;
        private System.Windows.Forms.ListBox matchesListBox;
        private System.Windows.Forms.TextBox scorer;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.TextBox nbofgoals;
        private System.Windows.Forms.Button btnSubmit;
        private System.Windows.Forms.RadioButton GK;
        private System.Windows.Forms.GroupBox groupBox5;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.ComboBox toursComboBox;
        private System.Windows.Forms.ComboBox toursComboBox2;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.ListBox teamsListBox2;
        private System.Windows.Forms.Button RemoveTeam;
        private System.Windows.Forms.CheckBox checkBox1;
        private System.Windows.Forms.LinkLabel linkLabel2;
        private System.Windows.Forms.Button startAgain;
    }
}

