using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace COM418_Project
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            
        }


        public double[,] GetData()
        {
            // Create Array
            var tbl = new double[51, 51];
            using (StreamReader sr = new StreamReader(@"..\Data.csv"))
            {
                // Create Variables
                string line = "";
                int count = 0;
                while ((line = sr.ReadLine()) != null)
                {
                    // Data de-limiter
                    String[] row = line.Split(',');

                    for (int i = 0; i < row.Length; i++)
                    {
                        if (row[i] == "#")
                        {
                            row[i] = "0";
                        }
                        tbl[count, i] = double.Parse(row[i]);
                    }
                    count++;

                }
            }
            return tbl;
        }

        // Generating lists

        public string SelectFriendsRow(int Id, double[,] tbl)
        {
            string returned = "";

            for (int i = 0; i < tbl.GetLength(1); i++)
            {
                if(tbl[Id,i] == 1)
                {
                    returned = returned + "Friend : " + i.ToString() + " Value :" + tbl[Id, i].ToString() + "\n";
                }
            }
            return returned;
        }

        

        public string SelectFriendsColumn(int Id, double[,] tbl)
        {
            string returned = "";

            for (int i = 0; i < tbl.GetLength(0); i++)
            {
                if (tbl[i, Id] == 1)
                {
                    returned = returned + "Friend : " + i.ToString() + " Value :" + tbl[i, Id].ToString() + "\n";
                }
            }
            return returned;
        }

        public string SelectPotentialFriendsRow(int Id, double[,] tbl)
        {
            string returned = "";

            for (int i = 0; i < tbl.GetLength(1); i++)
            {
                if (tbl[Id, i] < 1)
                {
                    returned = returned + "Potential Friend : " + i.ToString() + " Value :" + tbl[Id, i].ToString() + "\n";
                }
            }
            return returned;
        }



        public string SelectPotentialFriendsColumn(int Id, double[,] tbl)
        {
            string returned = "";

            for (int i = 0; i < tbl.GetLength(0); i++)
            {
                if (tbl[i, Id] < 1)
                {
                    returned = returned + "Potential Friend : " + i.ToString() + " Value :" + tbl[i, Id].ToString() + "\n";
                }
            }
            return returned;
        }

        // Output results to form

        private void button1_Click(object sender, EventArgs e)
        {
            double[,] tbl = GetData();
            lblFriendsRow.Text =  SelectFriendsRow(int.Parse(textBox1.Text), tbl);
            lblFriendsColumn.Text = SelectFriendsColumn(int.Parse(textBox1.Text), tbl);
            lblPotentialFriendsRow.Text = SelectPotentialFriendsRow(int.Parse(textBox1.Text), tbl);
            lblPotentialFriendsColumn.Text = SelectPotentialFriendsColumn(int.Parse(textBox1.Text), tbl);



        }
    }

}
