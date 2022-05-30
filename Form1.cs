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

namespace Praktikum_Week_14
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        MySqlConnection sqlConnect = new MySqlConnection("server=localhost;uid=root;pwd=;database=premier_league");
        MySqlCommand sqlCommand;
        MySqlDataAdapter sqlAdapter;
        String sqlQuery;
        DataTable dtTypePlayer = new DataTable();
        private void Form1_Load(object sender, EventArgs e)
        {
            sqlQuery = "SELECT * FROM dt_type";
            sqlCommand = new MySqlCommand(sqlQuery, sqlConnect);
            sqlAdapter = new MySqlDataAdapter(sqlCommand);
            sqlAdapter.Fill(dtTypePlayer);
            IsiDataPlayer(0);
        }

        private void IsiDataPlayer(int v)
        {
            throw new NotImplementedException();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            IsiDataPlayer(0);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            IsiDataPlayer(-1);
        }

        private void button3_Click(object sender, EventArgs e)
        {
            IsiDataPlayer(+1);
        }

        private void button4_Click(object sender, EventArgs e)
        {
            IsiDataPlayer(dtTypePlayer.Rows.Count - 1);
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            
        }
    }
}
