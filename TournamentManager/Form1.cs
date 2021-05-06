using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TournamentManager
{
    public partial class TournamentManager : Form
    {
        Tournament t;
        Team team;
        Player p;
        Queue<Team> m;
        Matches match;
        
        public TournamentManager()
        {
            InitializeComponent();
          
        }

        private void BtnCreateTour_Click(object sender, EventArgs e)
        {
            toursListBox.Text = "";
            toursListBox2.Text = "";
            if (tourName.Text == "" || nbOfTeams.Text == "")
            {
                MessageBox.Show("Your fields cannot be empty", "Alert", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            if (int.Parse(nbOfTeams.Text) == 8 || int.Parse(nbOfTeams.Text) == 16)

            {
                t = new Tournament();

                t.Name = tourName.Text;
                t.NbOfTeams = int.Parse(nbOfTeams.Text);
                toursListBox.Items.Add(t);
                toursListBox2.Items.Add(t);
                toursComboBox.Items.Add(t);
                toursComboBox2.Items.Add(t);
                t.Teams = new List<Team>();
                t.Matches = new List<Matches>();
                tourName.Clear();
                nbOfTeams.Clear();

            }
            else
            {
                MessageBox.Show("The number of teams can be either 8 or 16 only", "Alert", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

           
        }

        private void BtnAddTeam_Click(object sender, EventArgs e)
        {
            if (teamName.Text == "")
            {
                MessageBox.Show("Your field cannot be empty", "Alert", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            if (((Tournament)toursListBox2.SelectedItem).Teams.Count < ((Tournament)toursListBox2.SelectedItem).NbOfTeams) { 
            team = new Team();
            team.Players = new List<Player>();


            team.Name = teamName.Text;
            teamsListBox.Items.Add(team);
                teamsListBox2.Items.Add(team);
            teamsComboBox.Items.Add(team);

            ((Tournament)toursListBox2.SelectedItem).Teams.Add(team);
        }
            else
            {
                MessageBox.Show("This Tournament is full", "Success", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
                
            }
            teamName.Clear();
        }

        private void BtnRemoveTeam_Click(object sender, EventArgs e)
        {
            ((Tournament)toursListBox2.SelectedItem).Teams.Remove((Team)teamsListBox.SelectedItem);
            teamsListBox.Items.Remove(teamsListBox.SelectedItem);
        }
        private void ToursListBox2_SelectedIndexChanged(object sender, EventArgs e)
        {

            int countTeams = ((Tournament)toursListBox2.SelectedItem).Teams.Count;
        
            if(countTeams != 0 || toursListBox2.SelectedIndex != 0)
            {if (teamsListBox.Items.Count != 0)
                {
                    teamsListBox.Items.Clear();
                }
                for (int a = 0; a < countTeams; a++)
                {
                    teamsListBox.Items.Add(((Tournament)toursListBox2.SelectedItem).Teams[a]);
                }
            }



        }

        private void BtnAddPlayer_Click(object sender, EventArgs e)
        {
            if (playerName.Text == "" || playerNb.Text == "")
            {
                MessageBox.Show("Your fields cannot be empty", "Alert", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            if (((Team)teamsComboBox.SelectedItem).Players.Count != 11)
            {
                p = new Player();
                p.Name = playerName.Text;
                p.Number = int.Parse(playerNb.Text);
                if (GK.Checked)
                    p.Role = "Gk";
                if (defender.Checked)
                    p.Role = "Defender";
                if (midfielder.Checked)
                    p.Role = "Midfielder";
                if (attacker.Checked)
                    p.Role = "Attacker";

                playersListBox.Items.Add(p);

                ((Team)teamsComboBox.SelectedItem).Players.Add(p);
            }
            else { 
                MessageBox.Show("This Team is now full", "Success", MessageBoxButtons.OK, MessageBoxIcon.Warning);

            }

            playerName.Clear();
            playerNb.Clear();

        }

        private void ToursComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            int count = ((Tournament)toursComboBox.SelectedItem).Teams.Count;

            if (count != 0 &&  toursComboBox.SelectedIndex != -1)
            {
                if (teamsComboBox.Items.Count != 0)
                {
                    teamsComboBox.Items.Clear();
                }
                for (int a = 0; a < count; a++)
                {
                    teamsComboBox.Items.Add(((Tournament)toursComboBox.SelectedItem).Teams[a]);
                }
            }


        }

        private void TeamsComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            int count = ((Team)teamsComboBox.SelectedItem).Players.Count;

            if (count != 0 || teamsComboBox.SelectedIndex != 0)
            {
                if (playersListBox.Items.Count != 0)
                {
                    playersListBox.Items.Clear();
                }
                for (int a = 0; a < count; a++)
                {
                    playersListBox.Items.Add(((Team)teamsComboBox.SelectedItem).Players[a]);
                }
            }
        }

        private void BtnGeneratePole_Click(object sender, EventArgs e)
        {
           
            matchesListBox.Items.Clear();
            Random r = new Random();
            m = new Queue<Team>();
           
            int temp;
            for (int i = 0; i < ((Tournament)toursComboBox2.SelectedItem).Teams.Count; i++)
            { temp = r.Next(0, 21);
                ((Tournament)toursComboBox2.SelectedItem).Teams[i].PoleResult = temp;
               
                
            }
            int a = 0;
            int j = ((Tournament)toursComboBox2.SelectedItem).Teams.Count -1 ;
            int countTeams = 0;
            while (countTeams != ((Tournament)toursComboBox2.SelectedItem).Teams.Count)
            {
               
                if (((Tournament)toursComboBox2.SelectedItem).Teams[a].PoleResult > ((Tournament)toursComboBox2.SelectedItem).Teams[a+1].PoleResult)
                {
                    m.Enqueue(((Tournament)toursComboBox2.SelectedItem).Teams[a]);
                    a++;
                    countTeams++;
                    m.Enqueue(((Tournament)toursComboBox2.SelectedItem).Teams[a]);
                    a++;
                    countTeams++;
                    match = new Matches(m.Dequeue(), m.Dequeue());
                    matchesListBox.Items.Add(match);
            


                }
                else if (((Tournament)toursComboBox2.SelectedItem).Teams[a].PoleResult <= ((Tournament)toursComboBox2.SelectedItem).Teams[a + 1].PoleResult)
                {
                    m.Enqueue(((Tournament)toursComboBox2.SelectedItem).Teams[a]);
                    countTeams++;
                    m.Enqueue(((Tournament)toursComboBox2.SelectedItem).Teams[j]);
                    countTeams++;
                    match = new Matches(m.Dequeue(), m.Dequeue());
                    matchesListBox.Items.Add(match);
                    a++;
                    j--;
                   
                }
            }
            if(((Tournament)toursComboBox2.SelectedItem).Teams.Count == 2)
            {
                btnGeneratePole.Visible = false;
            }

            }

        private void BtnAddDate_Click(object sender, EventArgs e)
        {
           
            ((Matches)matchesListBox.SelectedItem).Date = dateTimePicker1.Value;


        }

        private void BtnSubmit_Click(object sender, EventArgs e)
        {
            if (scorer.Text == "" || nbofgoals.Text == "")
            {
                MessageBox.Show("Your fields cannot be empty", "Alert", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            String player = "";
            int goals =0;
            for (int i = 0; i < ((Tournament)toursComboBox2.SelectedItem).Teams[teamsListBox2.SelectedIndex].Players.Count; i++) {
                if (((Tournament)(toursComboBox2.SelectedItem)).Teams[teamsListBox2.SelectedIndex].Players[i].Name == scorer.Text)
                    ((Tournament)(toursComboBox2.SelectedItem)).Teams[teamsListBox2.SelectedIndex].Players[i].PlayerGoals += int.Parse(nbofgoals.Text);
            
            }
            for (int i = 0; i < ((Tournament)toursComboBox2.SelectedItem).Teams[teamsListBox2.SelectedIndex].Players.Count; i++)
            {
                if (((Tournament)(toursComboBox2.SelectedItem)).Teams[teamsListBox2.SelectedIndex].Players[i].PlayerGoals > goals) { 
                goals = ((Tournament)(toursComboBox2.SelectedItem)).Teams[teamsListBox2.SelectedIndex].Players[i].PlayerGoals;
                player = ((Tournament)(toursComboBox2.SelectedItem)).Teams[teamsListBox2.SelectedIndex].Players[i].Name; }
              
            }
            if (checkBox1.Checked)
            {
                MessageBox.Show("The Top Scorer is:" +  player +" with " + goals + " goals"  , "Congrats", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                btnSubmit.Visible = false;
                
            }
            scorer.Clear();
            nbofgoals.Clear();
           }
        

        private void ToursComboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {
            int count = ((Tournament)toursComboBox2.SelectedItem).Teams.Count;

            if (count != 0 || toursComboBox2.SelectedIndex != 0)
            {
                if (teamsListBox2.Items.Count != 0)
                {
                    teamsListBox2.Items.Clear();
                }
                for (int a = 0; a < count; a++)
                {
                    teamsListBox2.Items.Add(((Tournament)toursComboBox2.SelectedItem).Teams[a]);
                }
            }
        }

        private void BtnRemovePlayer_Click(object sender, EventArgs e)
        {
            ((Team)teamsComboBox.SelectedItem).Players.Remove((Player)playersListBox.SelectedItem);
            playersListBox.Items.Remove(playersListBox.SelectedItem);
            
        }

        private void RemoveTeam_Click(object sender, EventArgs e)
        {
            ((Tournament)(toursComboBox2.SelectedItem)).Teams.Remove(((Team)teamsListBox2.SelectedItem));
            teamsListBox2.Items.Remove(((Team)teamsListBox2.SelectedItem));
            if (((Tournament)toursComboBox2.SelectedItem).Teams.Count == 1)
            {
                MessageBox.Show("The winner team is:" + ((Tournament)toursComboBox2.SelectedItem).Teams[0], "Congrats", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                RemoveTeam.Visible = false;
                linkLabel2.Visible = true;
                
                return;
                
            }
        }

        private void StartAgain_Click(object sender, EventArgs e)
        {
            TournamentManager NewForm = new TournamentManager();
            NewForm.Show();
            this.Dispose(false);
        }

        private void LinkLabel2_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            e.Link.LinkData = "google.com";
            
        }

        private void TournamentManager_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.X && e.Control)
                this.Close();
           
        }
    }
    }
