using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Net.Mime.MediaTypeNames;

namespace ArraysEnMethodes_FayaazAbdoel
{
    public partial class Form1 : Form
    {
        string[] namen = { "Sam", "Dio", "Setsuna", "Joseph", "Ren", "Tanjiro", "Suzie", "Ann", "Giyuu", "Lester" };
       // int[] getallen = { 0, 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };
        int[] getallen = new int[100];
        public Form1(){
            InitializeComponent();
        }

        private void ShowArray()
        {
            lbNames.Items.AddRange(namen);
          
        }

        private void VulGetallenArray()
        {
            int Min = 0;
            int Max = 10;

            Random rnd = new Random();
            for (int i = 0; i < getallen.Length; i++)
            {
                getallen[i] = rnd.Next(Min, Max);
                lstGetallen.Items.Add(getallen[i]);
            }

        }

        private void btnShowArray_Click(object sender, EventArgs e)
        {
            ShowArray();
        }

        private void btnSortAsc_Click(object sender, EventArgs e)
        {
            try
            { //Sorteert de array namen alfabetisch en typt de array in lbNames
                Array.Sort(namen);
                foreach (string s in namen)
                {
                    lbNames.Text = s;
                }
                ShowArray();
                Array.Sort(getallen);
                foreach (int i in getallen)
                {
                    lstGetallen.Items.Add(i);
                }
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnSortDesc_Click(object sender, EventArgs e)
        {
            try
            { //Sorteert de array namen in reverse en typt de array in lbNames
                Array.Reverse(namen);
                foreach (string r in namen)
                {
                    lbNames.Text = r;
                }
                ShowArray();
                Array.Reverse(getallen);
                foreach (int r in getallen)
                {
                    lstGetallen.Items.Add(r);
                }
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            try
            { //Voegt nieuwe item aan array en typt de array in lbNames
                string newElement = txtNewArrayItem.Text;
                List<string> list = new List<string>(namen.ToList());
                list.Add(newElement);
                namen = list.ToArray();
                foreach (string a in namen)
                {
                    lbNames.Text = a;
                }



            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }

        private void btnVulGetalArray_Click(object sender, EventArgs e)
        {
            VulGetallenArray();
            
        }

        private void btnShowArrayLength_Click(object sender, EventArgs e)
        {
           
        }
    }
}
