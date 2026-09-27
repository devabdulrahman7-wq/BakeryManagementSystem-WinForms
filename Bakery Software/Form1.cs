using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace Bakery_Software
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void nimkoradiobtn_CheckedChanged(object sender, EventArgs e)
        {
            sweetsradiobtn.ForeColor = System.Drawing.Color.BurlyWood;
            nimkoradiobtn.ForeColor = System.Drawing.Color.DarkBlue;
            combobox.Items.Clear();
            combobox.Items.Add("Salva");
            combobox.Items.Add("Baba");
            combobox.Items.Add("Mix spicy");
        }

        private void sweetsradiobtn_CheckedChanged(object sender, EventArgs e)
        {

            nimkoradiobtn.ForeColor = System.Drawing.Color.BurlyWood;
            sweetsradiobtn.ForeColor = System.Drawing.Color.DarkBlue;
            combobox.Items.Clear();
            combobox.Items.Add("Qalaqand");
            combobox.Items.Add("Balo shahi");
            combobox.Items.Add("Gulab");
        }

        private void combobox_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (combobox.SelectedItem.ToString() == "Salva")
            {
                pricetxt.Text = "100";
            }
            else if (combobox.SelectedItem.ToString() == "Baba")
            {
                pricetxt.Text = "120";
            }
            else if (combobox.SelectedItem.ToString() == "Mix spicy")
            {
                pricetxt.Text = "150";
            }
            else if (combobox.SelectedItem.ToString() == "Qalaqand")
            {
                pricetxt.Text = "200";
            }
            else if (combobox.SelectedItem.ToString() == "Balo shahi")
            {
                pricetxt.Text = "180";
            }
            else if (combobox.SelectedItem.ToString() == "Gulab")
            {
                pricetxt.Text = "170";
            }
            else
            {
                pricetxt.Text = "0";
            }
            quantitytxt.Text = "";
            totaltxt.Text = "";
        }

        private void quantitytxt_TextChanged(object sender, EventArgs e)
        {
            if (quantitytxt.Text.Length > 0)
            {
                totaltxt.Text = (Convert.ToInt16(quantitytxt.Text) * Convert.ToInt16(pricetxt.Text)).ToString();
            }
        }

        private void addbtn_Click(object sender, EventArgs e)
        {
            dataGridView1.Rows.Add(combobox.Text, pricetxt.Text, quantitytxt.Text, totaltxt.Text);
           
            pricetxt.Text = "";
            quantitytxt.Text = "";
            totaltxt.Text = "";
            CalculateSubtotal();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
        }
        void CalculateSubtotal()
        {
            int sum = 0;
            foreach (DataGridViewRow r in dataGridView1.Rows)
                sum += Convert.ToInt32(r.Cells[3].Value ?? 0);
            subtotaltxt.Text = sum.ToString();
        }
        private void subtotaltxt_TextChanged(object sender, EventArgs e)
        {
            //int sum = 0;
            //foreach (DataGridViewRow r in dataGridView1.Rows)
            //    sum += Convert.ToInt32(r.Cells[3].Value ?? 0);
            //subtotaltxt.Text = sum.ToString();
        }
        private void discounttxt_TextChanged(object sender, EventArgs e)
        {
            if (discounttxt.Text.Length > 0)
            {
                nettxt.Text = (Convert.ToInt32(subtotaltxt.Text) - Convert.ToInt32(discounttxt.Text)).ToString();
            }
        }
        private void nettxt_TextChanged(object sender, EventArgs e)
        {
        }
        private void paidtxt_TextChanged(object sender, EventArgs e)
        {
            if (paidtxt.Text.Length > 0)
            {
                balancetxt.Text = (Convert.ToInt16(nettxt.Text) - Convert.ToInt16(paidtxt.Text)).ToString();
            }
        }
        private void balancetxt_TextChanged(object sender, EventArgs e)
        {
        }

        private void totaltxt_TextChanged(object sender, EventArgs e)
        {
          
        }
    }
}
