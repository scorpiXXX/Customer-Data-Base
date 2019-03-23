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
using System.Text.RegularExpressions;

namespace Курсовая_работа
{
    public partial class Form1 : Form
    {
        public string connectBD = "server=localhost;user=root;database=client_db;password=2011;charset=utf8";
        List<string> items = new List<string>();
        List<string> cache = new List<string>();
        List<int> listService = new List<int>();
        public Form1()
        {
            InitializeComponent();
            
            MySqlConnection con = new MySqlConnection(connectBD);
            con.Open();
            string request = "SELECT name from client where id_client=2;";
            MySqlCommand command = new MySqlCommand(request,con);
            con.Close();
            telephoneClient.Mask = "(##)###-##-##";
        }

        private void запросКБДToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Request req = new Request(this);
            req.Show();
        }

        private void newClient_Click(object sender, EventArgs e)
        {
            ClientForm cf = new ClientForm(0,this);
            cf.Show();
        }

        private void idClientBTN_Click(object sender, EventArgs e)
        {
            
        }

        private void telephoneClientBTN_Click(object sender, EventArgs e)
        {
            try
            {
                MySqlConnection con = new MySqlConnection(connectBD);
                con.Open();
                string request = "SELECT client from ttelephone WHERE telephone='" + telephoneClient.Text + "';";
                MySqlCommand command = new MySqlCommand(request, con);
                command.ExecuteNonQuery();
                ClientForm cf = new ClientForm(Convert.ToInt32(command.ExecuteScalar().ToString()), this);
                cf.Show();
                con.Close();
            }
            catch
            {
                MessageBox.Show("Клиент с данным номером телефона не найден!","Ошибка!",MessageBoxButtons.OK,MessageBoxIcon.Error);
            }
        }

        private void kindOfActivityBTN_Click(object sender, EventArgs e)
        {
            items.Clear();
            cache.Clear();
            string activity = kindOfActivity.Text;
            string[] values = activity.Split(',');
            for (int i = 0; i < values.Length; i++)
            {
                values[i] = values[i].Trim();
            }

            MySqlConnection con = new MySqlConnection(connectBD);
            con.Open();
            string request = "SELECT kind_of_activity,id_client FROM client;";
            MySqlCommand command = new MySqlCommand(request, con);

            MySqlDataReader reader = command.ExecuteReader();
            while (reader.Read())
            {
                for (int i = 0; i < values.Length; i++)
                {
                    if (reader[0].ToString().Contains(values[i]))
                    {
                        cache.Add((reader[1].ToString()));
                    }
                }
            }
            items = cache.Distinct().ToList();
            if(items.Count!=0)
            {
                SearchResult sr = new SearchResult(this,items);
                sr.Show();
            }
            reader.Close();
            con.Close();
        }
        public void nameClient_TextChanged(object sender, EventArgs e)
        {
            nameClientLB.Items.Clear();
            MySqlConnection con = new MySqlConnection(connectBD);
            con.Open();
            string request = "SELECT id_client,name FROM client;";
            MySqlCommand command = new MySqlCommand(request, con);

            MySqlDataReader reader = command.ExecuteReader();
            while (reader.Read())
            {
                if (reader[1].ToString().ToLower().Contains(nameClient.Text.ToLower()))
                {
                    nameClientLB.Items.Add(reader[1]);
                    listService.Add(Convert.ToInt32(reader[0].ToString()));
                }
            }
            if (nameClient.Text == "")
                nameClientLB.Items.Clear();
            con.Close();
        }
        private void nameClientLB_DoubleClick(object sender, EventArgs e)
        {
            int result = nameClientLB.SelectedIndex;
            ClientForm cf = new ClientForm(listService[result], this);
            cf.Show();
        }

        private void statistics_Click(object sender, EventArgs e)
        {
            Statistics st = new Statistics(this, 0);
            st.Show();
        }

        private void за3МесяцаToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Statistics st = new Statistics(this, 1);
            st.Show();
        }

        private void заГодToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Statistics st = new Statistics(this, 2);
            st.Show();
        }

        private void пользовательскоеЗначениеToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Statistics st = new Statistics(this, 4);
            st.Show();
        }

        private void статистикаПоКлиентуToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Statistics st = new Statistics(this, 5);
            st.Show();
        }

        private void заВсеВремяToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Statistics st = new Statistics(this, 3);
            st.Show();
        }
    }
}
//ALTER TABLE client_db.client CONVERT TO CHARACTER SET utf8 COLLATE utf8_general_ci;
//create table client(id_client int(3) not null auto_increment primary key, name char(40) not null,email char(30), site char(20), address char(70),kind_of_activity char(60), type int(1) not null);
//alter table tnote add constraint tnote_to_client foreign key(client) references client(id_client);