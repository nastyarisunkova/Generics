using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace Generics
{
    public partial class Form1 : Form
    {
        List<Companies> companies = new List<Companies>();
        Sony sony;

        BindingSource bsCompanies = new BindingSource();
        BindingSource bsSony = new BindingSource();
        public Form1()
        {
            InitializeComponent();
            InitializeCompanies();
            sony = new Sony(companies);
            bsSony.DataSource = sony.TakeSony();
            bsCompanies.DataSource = companies;

            dataGridView1.DataSource = bsCompanies;
            dataGridView2.DataSource = bsSony;
        }
        private void InitializeCompanies()
        {
            companies.Add(new Companies { CompanyName = "Sony", Product = "Phone" });
            companies.Add(new Companies { CompanyName = "Sony", Product = "TV" });
            companies.Add(new Companies { CompanyName = "Samsung", Product = "Phone" });
            companies.Add(new Companies { CompanyName = "Aple", Product = "Phone" });
            companies.Add(new Companies { CompanyName = "Aple", Product = "Macbook" });
        }
        private void button2_Click(object sender, EventArgs e)
        {
            companies.Add(new Companies
            {
                CompanyName = textBox1.Text,
                Product = textBox2.Text
            });
            if(textBox1.Text.ToLower() == "sony")
            {
                sony.SonyList.Add(new Companies
                {
                    CompanyName = textBox1.Text,
                    Product = textBox2.Text
                });
            }
            bsSony.ResetBindings(false);
            bsCompanies.ResetBindings(false);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            sony.Sort();
            bsSony.ResetBindings(false);
        }

        private void button3_Click(object sender, EventArgs e)
        {
            MessageBox.Show(sony.Fraction().ToString(), "Доля");
        }
    }
}
