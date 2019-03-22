using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Курсовая_работа
{
    public partial class Statistics : Form
    {
        public Form1 frm;
        public int activeTab;
        public Statistics(Form1 form, int tab)
        {
            frm = form;
            InitializeComponent();
            activeTab = tab;
            periodTB.Mask = "[##-##-####]-[##-##-####]";
            telephoneClient.Mask = "(##)###-##-##";
            tabControl1.SelectedIndex = tab;
            if (tab == 0) OpenTab1();
            if (tab == 1) OpenTab2();
            if (tab == 2) OpenTab3();
            if (tab == 3) OpenTab4();
            if (tab == 4) OpenTab5();
            if (tab == 5) OpenTab6();
        }

        public void OpenTab1()
        {
            label1.Text = "Получено новых услуг: ";
            label2.Text = "Выполнено услуг: ";
            label3.Text = "Получено денежных средств за выполненную работу: ";
            label4.Text = "Ожидается оплата: ";
            label5.Text = "Получено предоплаты: ";
            label6.Text = "Итого доход за месяц: ";

            MySqlConnection con = new MySqlConnection(frm.connectBD);
            con.Open();

            string request = "SELECT id_service FROM tservice WHERE MONTH(period_ot) = MONTH(NOW()) AND YEAR(period_ot) = YEAR(NOW());";
            MySqlCommand command = new MySqlCommand(request, con);
            MySqlDataReader reader = command.ExecuteReader();
            int i = 0;
            while (reader.Read())
            {
                i++;
            }
            reader.Close();
            label1.Text += i;

            request = "SELECT id_service FROM tservice WHERE MONTH(period_do) = MONTH(NOW()) AND YEAR(period_do) = YEAR(NOW());";
            command = new MySqlCommand(request, con);
            reader = command.ExecuteReader();
            i = 0;
            while (reader.Read())
            {
                i++;
            }
            reader.Close();
            label2.Text += i;

            request = "SELECT price FROM tservice WHERE MONTH(period_do) = MONTH(NOW()) AND YEAR(period_do) = YEAR(NOW()) AND yesorno LIKE 'false';";
            command = new MySqlCommand(request, con);
            reader = command.ExecuteReader();
            double i2 = 0;
            while (reader.Read())
            {
                i2 = i2 + Convert.ToDouble(reader[0].ToString());
            }
            reader.Close();
            label4.Text += i2 + " бел.руб.";

            request = "SELECT predoplata FROM (tservice LEFT JOIN tpredoplata ON tservice.id_service = tpredoplata.service) WHERE MONTH(period_ot) = MONTH(NOW()) AND YEAR(period_ot) = YEAR(NOW()) AND tpredoplata.yesorno like 'true' AND tservice.yesorno like 'false';";
            command = new MySqlCommand(request, con);
            reader = command.ExecuteReader();
            i2 = 0;
            while (reader.Read())
            {
                i2 = i2 + Convert.ToDouble(reader[0].ToString());
            }
            reader.Close();
            double predoplata = i2;
            label5.Text += i2 + " бел.руб.";

            request = "SELECT price FROM tservice WHERE MONTH(period_do) = MONTH(NOW()) AND YEAR(period_do) = YEAR(NOW()) AND yesorno LIKE 'true';";
            command = new MySqlCommand(request, con);
            reader = command.ExecuteReader();
            i2 = 0;
            while (reader.Read())
            {
                i2 = i2 + Convert.ToDouble(reader[0].ToString());
            }
            reader.Close();
            label3.Text += i2+ " бел.руб.";

            label6.Text += i2 + predoplata + " бел.руб.";
            con.Close();
        }
        public void OpenTab2()
        {
            label12.Text = "Получено новых услуг: ";
            label11.Text = "Выполнено услуг: ";
            label10.Text = "Получено денежных средств за выполненную работу: ";
            label9.Text = "Ожидается оплата: ";
            label8.Text = "Получено предоплаты: ";
            label7.Text = "Итого доход за месяц: ";

            MySqlConnection con = new MySqlConnection(frm.connectBD);
            con.Open();

            string request = "SELECT id_service FROM tservice WHERE MONTH(period_ot) BETWEEN MONTH(NOW())-2 AND MONTH(NOW()) AND YEAR(period_ot) = YEAR(NOW());";
            MySqlCommand command = new MySqlCommand(request, con);
            MySqlDataReader reader = command.ExecuteReader();
            int i = 0;
            while (reader.Read())
            {
                i++;
            }
            reader.Close();
            label12.Text += i;

            request = "SELECT id_service FROM tservice WHERE MONTH(period_do) BETWEEN MONTH(NOW())-2 AND MONTH(NOW()) AND YEAR(period_do) = YEAR(NOW());";
            command = new MySqlCommand(request, con);
            reader = command.ExecuteReader();
            i = 0;
            while (reader.Read())
            {
                i++;
            }
            reader.Close();
            label11.Text += i;

            request = "SELECT price FROM tservice WHERE MONTH(period_do) BETWEEN MONTH(NOW())-2 AND MONTH(NOW()) AND YEAR(period_do) = YEAR(NOW()) AND yesorno LIKE 'false';";
            command = new MySqlCommand(request, con);
            reader = command.ExecuteReader();
            double ii = 0;
            while (reader.Read())
            {
                ii+=Convert.ToDouble(reader[0].ToString());
            }
            reader.Close();
            label9.Text += ii+" бел.руб.";

            request = "SELECT predoplata FROM (tservice LEFT JOIN tpredoplata ON tservice.id_service = tpredoplata.service) WHERE MONTH(period_do) BETWEEN MONTH(NOW())-2 AND MONTH(NOW()) AND YEAR(period_do) = YEAR(NOW()) AND tpredoplata.yesorno like 'true' AND tservice.yesorno like 'false';";
            command = new MySqlCommand(request, con);
            reader = command.ExecuteReader();
            ii = 0;
            while (reader.Read())
            {
                ii += Convert.ToDouble(reader[0].ToString());
            }
            reader.Close();
            double predoplata = ii;
            label8.Text += ii + " бел.руб.";

            request = "SELECT price FROM tservice WHERE MONTH(period_do) BETWEEN MONTH(NOW())-2 AND MONTH(NOW()) AND YEAR(period_do) = YEAR(NOW()) AND yesorno LIKE 'true';";
            command = new MySqlCommand(request, con);
            reader = command.ExecuteReader();
            ii = 0;
            while (reader.Read())
            {
                ii += Convert.ToDouble(reader[0].ToString());
            }
            reader.Close();
            label10.Text += ii + " бел.руб.";

            label7.Text += ii + predoplata + " бел.руб.";

            con.Close();
        }
        public void OpenTab3()
        {
            label18.Text = "Получено новых услуг: ";
            label17.Text = "Выполнено услуг: ";
            label16.Text = "Получено денежных средств за выполненную работу: ";
            label15.Text = "Ожидается оплата: ";
            label14.Text = "Получено предоплаты: ";
            label13.Text = "Итого доход за год: ";

            MySqlConnection con = new MySqlConnection(frm.connectBD);
            con.Open();

            string request = "SELECT id_service FROM tservice WHERE MONTH(period_ot) BETWEEN MONTH(NOW())-11 AND MONTH(NOW()) AND YEAR(period_ot) = YEAR(NOW());";
            MySqlCommand command = new MySqlCommand(request, con);
            MySqlDataReader reader = command.ExecuteReader();
            int i = 0;
            while (reader.Read())
            {
                i++;
            }
            reader.Close();
            label18.Text += i;

            request = "SELECT id_service FROM tservice WHERE MONTH(period_do) BETWEEN MONTH(NOW())-11 AND MONTH(NOW()) AND YEAR(period_do) = YEAR(NOW());";
            command = new MySqlCommand(request, con);
            reader = command.ExecuteReader();
            i = 0;
            while (reader.Read())
            {
                i++;
            }
            reader.Close();
            label17.Text += i;

            request = "SELECT price, id_service FROM tservice WHERE MONTH(period_do) BETWEEN MONTH(NOW())-11 AND MONTH(NOW()) AND YEAR(period_do) = YEAR(NOW()) AND yesorno LIKE 'false';";
            command = new MySqlCommand(request, con);
            reader = command.ExecuteReader();
            double ii = 0;
            while (reader.Read())
            {
                ii += Convert.ToDouble(reader[0].ToString());               
            }
            reader.Close();
            label15.Text += ii + " бел.руб.";

            request = "SELECT predoplata FROM (tservice LEFT JOIN tpredoplata ON tservice.id_service = tpredoplata.service) WHERE MONTH(period_do) BETWEEN MONTH(NOW())-11 AND MONTH(NOW()) AND YEAR(period_do) = YEAR(NOW()) AND tpredoplata.yesorno like 'true' AND tservice.yesorno like 'false';";
            command = new MySqlCommand(request, con);
            reader = command.ExecuteReader();
            ii = 0;
            while (reader.Read())
            {
                ii += Convert.ToDouble(reader[0].ToString());
            }
            reader.Close();
            double predoplata = ii;
            label14.Text += ii + " бел.руб.";

            request = "SELECT price FROM tservice WHERE MONTH(period_do) BETWEEN MONTH(NOW())-11 AND MONTH(NOW()) AND YEAR(period_do) = YEAR(NOW()) AND yesorno LIKE 'true';";
            command = new MySqlCommand(request, con);
            reader = command.ExecuteReader();
            ii = 0;
            while (reader.Read())
            {
                ii += Convert.ToDouble(reader[0].ToString());
            }
            reader.Close();
            label16.Text += ii + " бел.руб.";

            label13.Text += ii + predoplata + " бел.руб.";

            con.Close();
        }
        public void OpenTab4()
        {
            label24.Text = "Получено услуг: ";
            label22.Text = "Получено денежных средств за выполненную работу: ";
            label21.Text = "Ожидается оплата: ";
            label20.Text = "Получено предоплаты: ";
            label19.Text = "Итого доход за все время: ";

            MySqlConnection con = new MySqlConnection(frm.connectBD);
            con.Open();

            string request = "SELECT id_service FROM tservice;";
            MySqlCommand command = new MySqlCommand(request, con);
            MySqlDataReader reader = command.ExecuteReader();
            int i = 0;
            while (reader.Read())
            {
                i++;
            }
            reader.Close();
            label24.Text += i;

            request = "SELECT price,id_service FROM tservice WHERE yesorno LIKE 'false';";
            command = new MySqlCommand(request, con);
            reader = command.ExecuteReader();
            double ii = 0;
            while (reader.Read())
            {
                ii += Convert.ToDouble(reader[0].ToString());                
            }
            reader.Close();
            label21.Text += ii + " бел.руб.";

            request = "SELECT predoplata FROM (tservice LEFT JOIN tpredoplata ON tservice.id_service = tpredoplata.service) WHERE tpredoplata.yesorno like 'true' AND tservice.yesorno like 'false';";
            command = new MySqlCommand(request, con);
            reader = command.ExecuteReader();
            ii = 0;
            while (reader.Read())
            {
                ii += Convert.ToDouble(reader[0].ToString());
            }
            reader.Close();
            double predoplata = ii;
            label20.Text += ii + " бел.руб.";

            request = "SELECT price FROM tservice WHERE yesorno LIKE 'true';";
            command = new MySqlCommand(request, con);
            reader = command.ExecuteReader();
            ii = 0;
            while (reader.Read())
            {
                ii += Convert.ToDouble(reader[0].ToString());
            }
            reader.Close();
            label22.Text += ii + " бел.руб.";

            label19.Text += ii + predoplata + " бел.руб.";

            con.Close();
        }
        public void OpenTab5()
        {
            label29.Text = "Получено новых услуг: ";
            label28.Text = "Выполнено услуг: ";
            label27.Text = "Получено денежных средств за выполненную работу: ";
            label26.Text = "Ожидается оплата: ";
            label25.Text = "Получено предоплаты: ";
            label23.Text = "Итого доход: ";

            MySqlConnection con = new MySqlConnection(frm.connectBD);
            con.Open();
            string request = Regex.Replace(periodTB.Text, @"[^\d]+", "");
            if (request.Length > 0)
            {
                request = "SELECT id_service FROM tservice WHERE period_ot BETWEEN STR_TO_DATE('" + request.Substring(0, 8) + "', '%d%m%Y')" + " AND" + " STR_TO_DATE('" + request.Substring(8, 8) + "', '%d%m%Y');";
                MySqlCommand command = new MySqlCommand(request, con);
                MySqlDataReader reader = command.ExecuteReader();
                int i = 0;
                while (reader.Read())
                {
                    i++;
                }
                reader.Close();
                label29.Text += i;

                request = Regex.Replace(periodTB.Text, @"[^\d]+", "");
                request = "SELECT id_service FROM tservice WHERE period_do BETWEEN STR_TO_DATE('" + request.Substring(0, 8) + "', '%d%m%Y')" + " AND" + " STR_TO_DATE('" + request.Substring(8, 8) + "', '%d%m%Y');";
                command = new MySqlCommand(request, con);
                reader = command.ExecuteReader();
                i = 0;
                while (reader.Read())
                {
                    i++;
                }
                reader.Close();
                label28.Text += i;

                request = Regex.Replace(periodTB.Text, @"[^\d]+", "");
                request = "SELECT price FROM tservice WHERE period_ot BETWEEN STR_TO_DATE('" + request.Substring(0, 8) + "', '%d%m%Y')" + " AND" + " STR_TO_DATE('" + request.Substring(8, 8) + "', '%d%m%Y') AND yesorno LIKE 'false';";
                command = new MySqlCommand(request, con);
                reader = command.ExecuteReader();
                double ii = 0;
                while (reader.Read())
                {
                    ii += Convert.ToDouble(reader[0].ToString());
                }
                reader.Close();
                label26.Text += ii + " бел.руб.";

                request = Regex.Replace(periodTB.Text, @"[^\d]+", "");
                request = "SELECT predoplata FROM (tservice LEFT JOIN tpredoplata ON tservice.id_service = tpredoplata.service) WHERE period_ot BETWEEN STR_TO_DATE('" + request.Substring(0, 8) + "', '%d%m%Y')" + " AND" + " STR_TO_DATE('" + request.Substring(8, 8) + "', '%d%m%Y') AND tpredoplata.yesorno like 'true' AND tservice.yesorno like 'false';";
                command = new MySqlCommand(request, con);
                reader = command.ExecuteReader();
                ii = 0;
                while (reader.Read())
                {
                    ii += Convert.ToDouble(reader[0].ToString());
                }
                reader.Close();
                double predoplata = ii;
                label25.Text += ii + " бел.руб.";

                request = Regex.Replace(periodTB.Text, @"[^\d]+", "");
                request = "SELECT price FROM tservice WHERE period_ot BETWEEN STR_TO_DATE('" + request.Substring(0, 8) + "', '%d%m%Y')" + " AND" + " STR_TO_DATE('" + request.Substring(8, 8) + "', '%d%m%Y') AND yesorno LIKE 'true';";
                command = new MySqlCommand(request, con);
                reader = command.ExecuteReader();
                ii = 0;
                while (reader.Read())
                {
                    ii += Convert.ToDouble(reader[0].ToString());
                }
                reader.Close();
                label27.Text += ii + " бел.руб.";

                label23.Text += ii + predoplata + " бел.руб.";
            }
            con.Close();
        }
        public void OpenTab6()
        {

        }
        private void tabControl1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (tabControl1.SelectedIndex == 0) OpenTab1();
            if (tabControl1.SelectedIndex == 1) OpenTab2();
            if (tabControl1.SelectedIndex == 2) OpenTab3();
            if (tabControl1.SelectedIndex == 3) OpenTab4();
            if (tabControl1.SelectedIndex == 4) OpenTab5();
            if (tabControl1.SelectedIndex == 5) OpenTab6();
        }

        private void closeBTN_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            OpenTab5();
        }

        private void nameClient_TextChanged(object sender, EventArgs e)
        {
            nameClientLB.Items.Clear();
            MySqlConnection con = new MySqlConnection(frm.connectBD);
            con.Open();
            string request = "SELECT id_client,name FROM client;";
            MySqlCommand command = new MySqlCommand(request, con);

            MySqlDataReader reader = command.ExecuteReader();
            while (reader.Read())
            {
                if (reader[1].ToString().ToLower().Contains(nameClient.Text.ToLower())) nameClientLB.Items.Add("[" + reader[0].ToString() + "] " + reader[1]);
            }
            if (nameClient.Text == "")
                nameClientLB.Items.Clear();
            con.Close();
        }
        public void CheckInfoAboutClient(int number)
        {
            label39.Text = "Получено услуг: ";
            label37.Text = "Получено денежных средств за выполненную работу: ";
            label36.Text = "Ожидается оплата: ";
            label35.Text = "Получено предоплаты: ";
            label34.Text = "Итого доход: ";

            MySqlConnection con = new MySqlConnection(frm.connectBD);
            con.Open();

            string request = "SELECT id_service FROM tservice WHERE client =" + number + ";";
            MySqlCommand command = new MySqlCommand(request, con);
            MySqlDataReader reader = command.ExecuteReader();
            int i = 0;
            while (reader.Read())
            {
                i++;
            }
            reader.Close();
            label39.Text += i;

            request = "SELECT price,id_service FROM tservice WHERE yesorno LIKE 'false' AND client =" + number + ";";
            command = new MySqlCommand(request, con);
            reader = command.ExecuteReader();
            double ii = 0;
            while (reader.Read())
            {
                ii += Convert.ToDouble(reader[0].ToString());
            }
            reader.Close();
            label36.Text += ii + " бел.руб.";

            request = "SELECT predoplata FROM (tservice LEFT JOIN tpredoplata ON tservice.id_service = tpredoplata.service) WHERE tpredoplata.yesorno like 'true' AND tservice.yesorno like 'false' AND client =" + number + ";";
            command = new MySqlCommand(request, con);
            reader = command.ExecuteReader();
            ii = 0;
            while (reader.Read())
            {
                ii += Convert.ToDouble(reader[0].ToString());
            }
            reader.Close();
            double predoplata = ii;
            label35.Text += ii + " бел.руб.";

            request = "SELECT price FROM tservice WHERE yesorno LIKE 'true' AND client =" + number + ";";
            command = new MySqlCommand(request, con);
            reader = command.ExecuteReader();
            ii = 0;
            while (reader.Read())
            {
                ii += Convert.ToDouble(reader[0].ToString());
            }
            reader.Close();
            label37.Text += ii + " бел.руб.";

            label34.Text += ii + predoplata + " бел.руб.";

            con.Close();
        }
        private void telephoneClientBTN_Click(object sender, EventArgs e)
        {
            try
            {
                MySqlConnection con = new MySqlConnection(frm.connectBD);
                con.Open();
                string request = "SELECT client from ttelephone WHERE telephone='" + telephoneClient.Text + "';";
                MySqlCommand command = new MySqlCommand(request, con);
                command.ExecuteNonQuery();
                CheckInfoAboutClient(Convert.ToInt32(command.ExecuteScalar().ToString()));
                con.Close();
            }
            catch
            {
                MessageBox.Show("Клиент с данным номером телефона не найден!", "Ошибка!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void idClientBTN_Click(object sender, EventArgs e)
        {
            MySqlConnection con = new MySqlConnection(frm.connectBD);
            con.Open();
            string request = "SELECT name from client where id_client=" + idClient.Text + ";";
            MySqlCommand command = new MySqlCommand(request, con);
            try
            {
                if (command.ExecuteScalar().ToString() != "")
                {
                    con.Close();
                    CheckInfoAboutClient(Convert.ToInt32(idClient.Text));
                }
            }
            catch
            {
                MessageBox.Show("Пользователь с таким ID не найден!", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                con.Close();
            }
            idClient.Text = "";
        }

        private void nameClientLB_DoubleClick(object sender, EventArgs e)
        {
            string result = Regex.Match(nameClientLB.GetItemText(nameClientLB.SelectedItem), @"\[(.*?)\]").Groups[1].Value;
            CheckInfoAboutClient(Convert.ToInt32(result));
        }
    }
}
