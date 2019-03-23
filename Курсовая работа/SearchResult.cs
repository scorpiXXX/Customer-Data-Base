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
    public partial class SearchResult : Form
    {
        List<string> items;
        public int activeSort = 0;
        Form1 frm;
        public SearchResult(Form1 form,List<string> list)
        {
            items = list;
            frm = form;
            InitializeComponent();
            Output();
            SortList.Text = "Сначала старые";
        }

        public void Output()
        {
            ResultLB.Items.Clear();
            string info = "name,kind_of_activity";
            if (emailCB.Checked) info += ",email";
            if (siteCB.Checked) info += ",site";
            if (addressCB.Checked) info += ",address";
            if (typeCB.Checked) info += ",type";
            for (int i = 0; i < items.Count; i++)
            {
                MySqlConnection con = new MySqlConnection(frm.connectBD);
                con.Open();
                string request = "SELECT "+info+" FROM client WHERE id_client=" + items[i] + ";";
                MySqlCommand command = new MySqlCommand(request, con);

                MySqlDataReader reader = command.ExecuteReader();
                while (reader.Read())
                {
                    string result = reader[0] + " (" + reader[1] + ")";
                    int iReader = 2;
                    if (emailCB.Checked)
                    {
                        if (reader[iReader].ToString() != "")
                        {
                            result += "," + reader[iReader];
                            iReader++;
                        }
                    }
                    if (siteCB.Checked)
                    {
                        if (reader[iReader].ToString() != "")
                        {
                            result += "," + reader[iReader];
                            iReader++;
                        }
                    }
                    if (addressCB.Checked)
                    {
                        if (reader[iReader].ToString() != "")
                        {
                            result += ",[" + reader[iReader] + "]";
                            iReader++;
                        }                        
                    }
                    if (typeCB.Checked)
                    {
                        if (reader[iReader].ToString() != "0")
                        {
                            result += ", Юридическое лицо";
                        }
                        else
                        {
                            result += ", Физическое лицо";
                        }
                    }
                    ResultLB.Items.Add(result);
                }
            }
        }
        private void CloseBTN_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void emailCB_CheckedChanged(object sender, EventArgs e)
        {
            Output();
        }

        private void ResultLB_DoubleClick(object sender, EventArgs e)
        {
            int result = ResultLB.SelectedIndex;
            ClientForm cf = new ClientForm(Convert.ToInt32(items[result]), frm);
            cf.Show();
        }

        private void SortList_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (SortList.SelectedIndex == 0 && activeSort != 0)
            {
                items.Reverse();
                Output();
                activeSort = 0;
            }
            if (SortList.SelectedIndex == 1 && activeSort != 1)
            {
                items.Reverse();
                Output();
                activeSort = 1;
            }
        }
    }
}
