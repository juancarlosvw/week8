using Microsoft.SqlServer.Server;
using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace week8
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }
        public static string sqlconnection = "server=localhost;uid=root;pwd=;database=premier_league";
        public MySqlConnection sqlconnect = new MySqlConnection(sqlconnection);
        public MySqlCommand sqlcommand;
        public MySqlDataAdapter sqladapter;
        public string sqlQuery;
        DataTable dt2 = new DataTable();
        private void Form2_Load(object sender, EventArgs e)
        {
            DataTable dtable1 = new DataTable();
            sqlQuery = "SELECT team_name as 'nama team' , team_id as 'id team ' FROM team ;";
            sqlcommand = new MySqlCommand(sqlQuery, sqlconnect);
            sqladapter = new MySqlDataAdapter(sqlcommand);
            sqladapter.Fill(dtable1);
            combobox_chooseteam1.DataSource = dtable1;
            combobox_chooseteam1.DisplayMember = "nama team";
            combobox_chooseteam1.ValueMember = "id team ";
            DataTable hometeam = new DataTable();
            sqlQuery = "SELECT t.team_name as 'nama team' ,t.team_id, m.match_id FROM team t,`match` m WHERE t.team_id = m.team_home;";
           sqlcommand = new MySqlCommand(sqlQuery, sqlconnect);
            sqladapter = new MySqlDataAdapter(sqlcommand);
            sqladapter.Fill(hometeam);
            DataTable awayteam = new DataTable();
            sqlQuery = "SELECT t.team_name as 'nama team' ,t.team_id, m.match_id FROM team t,`match` m WHERE t.team_id = m.team_away;";
            sqlcommand = new MySqlCommand(sqlQuery, sqlconnect);
            sqladapter = new MySqlDataAdapter(sqlcommand);
            sqladapter.Fill(awayteam);
            
            dt2.Columns.Add("Match id");
            dt2.Columns.Add("Home Team");
            dt2.Columns.Add("Home Team id");
            dt2.Columns.Add("Away Team");
            dt2.Columns.Add("Away Team id");
            dt2.Columns.Add("Judul");
            for(int i = 0; i < awayteam.Rows.Count; i++)
            {
                
                string matchid = hometeam.Rows[i][2].ToString();
                string home = hometeam.Rows[i][0].ToString();
                string homeid = hometeam.Rows[i][1].ToString();
                string away = awayteam.Rows[i][0].ToString();
                string awayid = awayteam.Rows[i][1].ToString();
                string judul = home + " VS " + away;
               
                dt2.Rows.Add(matchid,home,homeid,away,awayid,judul);
            }
        }

        private void com(object sender, EventArgs e)
        {
            string matchjudul = combobox_choosematch1.GetItemText(combobox_choosematch1.SelectedItem);
            string idmatch = "";
            string tim1 = "";
            string tim2 = "";
            for (int i = 0; i < dt2.Rows.Count; i++)
            {
                if (matchjudul == dt2.Rows[i][5].ToString())
                {
                    idmatch = dt2.Rows[i][0].ToString();
                    label_timkiri.Text= dt2.Rows[i][1].ToString();
                    label_timkanan.Text = dt2.Rows[i][3].ToString();
                    tim1 = dt2.Rows[i][2].ToString();
                    tim2 = dt2.Rows[i][4].ToString();
                    break;
                }
            }
            DataTable dt9 = new DataTable();
            sqlQuery = "select m.match_date, m.goal_home, m.goal_away, r.referee_name from `match` m, referee r where r.referee_id = m.referee_id and m.match_id = '"+idmatch+"';";
            sqlcommand = new MySqlCommand(sqlQuery, sqlconnect);
            sqladapter = new MySqlDataAdapter(sqlcommand);
            sqladapter.Fill(dt9);
            label_skorkiri.Text = dt9.Rows[0][1].ToString();
            label_skorkanan.Text = dt9.Rows[0][2].ToString();
            label_ref.Text = "Referee: "+dt9.Rows[0][3].ToString();
            label_date.Text = dt9.Rows[0][0].ToString();


            DataTable dt92 = new DataTable();
            sqlQuery = "select p.player_name from player p, team t where t.team_id = p.team_id and t.team_id ='"+tim1+"';";
            sqlcommand = new MySqlCommand(sqlQuery, sqlconnect);
            sqladapter = new MySqlDataAdapter(sqlcommand);
            sqladapter.Fill(dt92);
            dataGridView1.DataSource=dt92;


            DataTable dt94 = new DataTable();
            sqlQuery = "select p.player_name from player p, team t where t.team_id = p.team_id and t.team_id ='"+tim2+"';";
            sqlcommand = new MySqlCommand(sqlQuery, sqlconnect);
            sqladapter = new MySqlDataAdapter(sqlcommand);
            sqladapter.Fill(dt94);
            dataGridView2.DataSource = dt94;

            DataTable dt999 = new DataTable();
            sqlQuery = "select t.team_name, p.player_name, if(d.`type`='GO','Goal',if(d.`type`='GW','Own Goal',if(d.`type`='GP','Penalty Goal',if(d.`type`='PM','Penalty Missed',if(d.`type`='CY','Yellow Card','Red Card'))))) as 'Type', d.`minute` from dmatch d, player p, team t where t.team_id = d.team_id and d.player_id = p.player_id and d.match_id = '"+idmatch+"';";
            sqlcommand = new MySqlCommand(sqlQuery, sqlconnect);
            sqladapter = new MySqlDataAdapter(sqlcommand);
            sqladapter.Fill(dt999);
            dataGridView3.DataSource = dt999;
        }

        private void comt(object sender, EventArgs e)
        {
            //MessageBox.Show(combobox_chooseteam1.GetItemText(combobox_chooseteam1.SelectedItem));
            combobox_choosematch1.Items.Clear();
            for (int i = 0; i < dt2.Rows.Count; i++)
            {
                if (combobox_chooseteam1.GetItemText(combobox_chooseteam1.SelectedItem) == dt2.Rows[i][1].ToString() || combobox_chooseteam1.GetItemText(combobox_chooseteam1.SelectedItem) == dt2.Rows[i][3].ToString())
                {
                    //MessageBox.Show(combobox_chooseteam1.GetItemText(combobox_chooseteam1.SelectedItem));
                    combobox_choosematch1.Items.Add(dt2.Rows[i][5].ToString());
                }
            }
        }
    }
}
