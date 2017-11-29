using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AirMonit_Admin
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            ListViewItem item1 = new ListViewItem("Something");
            item1.SubItems.Add("SubItem1a");
            item1.SubItems.Add("SubItem1b");
            item1.SubItems.Add("SubItem1c");

            ListViewItem item2 = new ListViewItem("Something2");
            item2.SubItems.Add("SubItem2a");
            item2.SubItems.Add("SubItem2b");
            item2.SubItems.Add("SubItem2c");

            ListViewItem item3 = new ListViewItem("Something3");
            item3.SubItems.Add("SubItem3a");
            item3.SubItems.Add("SubItem3b");
            item3.SubItems.Add("SubItem3c");

            listViewEvents.Items.AddRange(new ListViewItem[] { item1, item2, item3 });
        }

        private void btnStatistics_Click(object sender, EventArgs e)
        {
            Statistics statisticsForm = new Statistics();
            statisticsForm.ShowDialog();
        }

        private void cBoxCityList_SelectedIndexChanged(object sender, EventArgs e)
        {
            listBoxCidades.Items.Clear();
            //TODO: popular a lista de cidades com os dados do serviço

            listViewAlarms.Items.Clear(); //usar listView ou listBox? Rever qnd houverem dados
            //TODO: popular a lista de alarmes com os dados do serviço

            listViewEvents.Items.Clear(); //usar listView ou listBox? Rever qnd houverem dados
            //TODO: popular a lista de eventos com os dados do serviço

            btnStatistics.Enabled = true;
            btnStatistics.Text = "Statistics for " + cBoxCityList
        }

        private void chkBoxFilterDate_CheckedChanged(object sender, EventArgs e)
        {
            listViewAlarms.Items.Clear(); //usar listView ou listBox? Rever qnd houverem dados
            //TODO: filtrar para mostrar apenas o intervalo definido pelo user
        }
    }
}
