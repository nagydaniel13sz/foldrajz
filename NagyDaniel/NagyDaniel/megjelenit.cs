using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace NagyDaniel
{
    public partial class megjelenit : Form
    {
        Lekerdezes aktualis;
        
        
        public static class Conn
        {

            public static readonly MySqlConnection conn = new MySqlConnection("server=localhost;user=root;port=3306;password=;database=foldrajz");
        }
        public megjelenit(int sorszam)
        {
            InitializeComponent();

            aktualis = Lekerdezesek.Query(sorszam);
            
        }

        private void richTextBox2_TextChanged(object sender, EventArgs e)
        {
           
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Conn.conn.Close();
            this.Hide();
        }

        private void megjelenit_Load(object sender, EventArgs e)
        {
            richTextBox1.ReadOnly = true;
            richTextBox2.ReadOnly = true;
            string connStr = "server=localhost;user=root;port=3306;password=";

            MySqlConnection connNoDB = new MySqlConnection(connStr);
            MySqlCommand drdatabase = new MySqlCommand("DROP DATABASE IF EXISTS foldrajz", connNoDB);
            connNoDB.Open();
            drdatabase.ExecuteNonQuery();
            connNoDB.Close();
            MySqlCommand crdatabase = new MySqlCommand("CREATE DATABASE foldrajz DEFAULT CHARSET latin2 COLLATE latin2_hungarian_ci", connNoDB);
            connNoDB.Open();
            crdatabase.ExecuteNonQuery();
            connNoDB.Close();

            Conn.conn.Open();
            
            try
            {
                //SQL CREATE

                string sql_create = File.ReadAllText("orszagok.sql");
                MySqlCommand cmd_create = new MySqlCommand(sql_create, Conn.conn);
                cmd_create.ExecuteNonQuery();
                
                Thread.Sleep(100);


            }
            catch (Exception err)
            {
                richTextBox1.Text += " \n " + err.ToString();
            }

            richTextBox2.Text += Convert.ToString(aktualis.leiras);

            try
            {
                //SQL SELECT
                string sql_select1 = aktualis.query;
                MySqlCommand cmd_select1 = new MySqlCommand(sql_select1, Conn.conn);
                MySqlDataReader rdr_select1 = cmd_select1.ExecuteReader();


                //megjelenítés
                
                while (rdr_select1.Read())
                {
                    richTextBox1.Text += " \n " + rdr_select1[0];
                }
                rdr_select1.Close();
                richTextBox1.Text += " \n ";
            }
            catch (Exception err)
            {
                richTextBox1.Text += " \n " + err.ToString();
            }



        }
    }
}
