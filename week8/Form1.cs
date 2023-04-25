using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;
using Org.BouncyCastle.Security.Certificates;

namespace week8
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            label1.Text = "player name";
            label2.Text = "team name";
            label3.Text = "nation";
            label4.Text = "pos";
            label5.Text = "number";
            label6.Text = "yellow card";
            label7.Text = "red card";
            label8.Text = "goal";
            label9.Text = "goal own";
            label10.Text = "penalty missed";
            label11.Text = "goal penalty";
        }
        public static string sqlconnection = "server=localhost;uid=root;pwd=;database=premier_league";
        public MySqlConnection sqlconnect = new MySqlConnection(sqlconnection);
        public MySqlCommand sqlcommand;
        public MySqlDataAdapter sqladapter;
        public string sqlQuery;
        DataTable dt1 = new DataTable();
        DataTable dt2 = new DataTable();
        DataTable dt3 = new DataTable();
        int cy = 0;
        int cr = 0;
        int go = 0;
        int gw = 0;
        int pm = 0;
        int gp = 0;
        private void pLAYERDATAToolStripMenuItem_Click(object sender, EventArgs e)
        {
            sqlQuery = "SELECT team_name as 'nama team' , team_id as 'id team ' FROM team ;";
            sqlcommand = new MySqlCommand(sqlQuery, sqlconnect);
            sqladapter = new MySqlDataAdapter(sqlcommand);
            sqladapter.Fill(dt1);
            combobox_pilihteam.DataSource = dt1;
            combobox_pilihteam.DisplayMember = "nama team";
            combobox_pilihteam.ValueMember = "id team ";
            combobox_pilihteam.Visible = true;
            label_chooseteam.Visible = true;
            panel2.Visible = false;
        }

        private void combobox_pilihteam_SelectionChangeCommitted(object sender, EventArgs e)
        {
            dt2 = new DataTable();
            string nyimpen = combobox_pilihteam.SelectedValue.ToString();
            sqlQuery = $"SELECT player_name as 'nama player' FROM player p where p.team_id = '{nyimpen}';";
            sqlcommand = new MySqlCommand(sqlQuery, sqlconnect);
            sqladapter = new MySqlDataAdapter(sqlcommand);
            sqladapter.Fill(dt2);
            combobox_pilihplayer.DataSource = dt2;
            combobox_pilihplayer.DisplayMember = "nama player";
            combobox_pilihplayer.Visible = true;
            label_chooseplayer.Visible = true;
        }

        private void combobox_pilihplayer_SelectionChangeCommitted(object sender, EventArgs e)
        {
            dt3 = new DataTable();
            string nyimpen = combobox_pilihplayer.GetItemText(combobox_pilihplayer.SelectedItem).ToString();
            string nyimpenteam = combobox_pilihteam.GetItemText(combobox_pilihteam.SelectedItem).ToString();
            sqlQuery = $"SELECT player_name as 'nama player', team_name as 'nama team', nation as 'nationality',playing_pos as 'playing pos',team_number as 'squad number' FROM player p,nationality n,dmatch d,team t where player_name = '{nyimpen}' and team_name = '{nyimpenteam}' and p.nationality_id = n.nationality_id;";
            sqlcommand = new MySqlCommand(sqlQuery, sqlconnect);
            sqladapter = new MySqlDataAdapter(sqlcommand);
            sqladapter.Fill(dt3);
            label1.Text = dt3.Rows[0][0].ToString();
            label2.Text = dt3.Rows[0][1].ToString();
            label3.Text = dt3.Rows[0][2].ToString();
            label4.Text = dt3.Rows[0][3].ToString();
            label5.Text = dt3.Rows[0][4].ToString();
            DataTable dt4 = new DataTable();
            string nyimpenplayer = combobox_pilihplayer.GetItemText(combobox_pilihplayer.SelectedItem).ToString();
            sqlQuery = $"SELECT `type` as 'Cards' FROM dmatch d, player p WHERE d.player_id = p.player_id and p.player_name = '{nyimpenplayer}';";
            sqlcommand = new MySqlCommand(sqlQuery, sqlconnect);
            sqladapter = new MySqlDataAdapter(sqlcommand);
            sqladapter.Fill(dt4);
   
            cy = 0;
            cr = 0;
            go = 0;
            gw = 0;
            pm = 0;
            gw = 0;
            for(int i = 0; i < dt4.Rows.Count;i++)
            {
                if (dt4.Rows[i][0].ToString() == "CY")
                {
                    cy++;
                }
                if (dt4.Rows[i][0].ToString() == "CR")
                {
                    cr++;
                }
                if (dt4.Rows[i][0].ToString() == "GO")
                {
                    go++;
                }
                if (dt4.Rows[i][0].ToString() == "GW")
                {
                    gw++;
                }
                if (dt4.Rows[i][0].ToString() == "PM")
                {
                    pm++;
                }
                if (dt4.Rows[i][0].ToString() == "GP")
                {
                    gp++;
                }
            }
            label6.Text = cy.ToString();
            label7.Text = cr.ToString();
            label8.Text = go.ToString();
            label9.Text = gw.ToString();
            label10.Text = pm.ToString();
            label11.Text = gp.ToString();
            //dataGridView1.DataSource = dt4;
        }

        private void mATCHDETAILSToolStripMenuItem_Click(object sender, EventArgs e)
        {
            label_chooseplayer.Visible = false;
            label_chooseteam.Visible = false;
            combobox_pilihteam.Visible = false;
            combobox_pilihplayer.Visible = false;
            panel2.Visible = true;
            Form2 second = new Form2();
            second.TopLevel = false;
            panel2.Controls.Add(second);
            second.Show();
            
        }
    }
}
