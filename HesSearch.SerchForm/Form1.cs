using HesSearch.Services;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HesSearch.SerchForm
{
    public partial class Form1 : Form
    {


        public IHesSearhServices HesSearhServices { get; set; }
        public Form1()
        {
            HesSearhServices = new HesSearhServices();
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            label3.Text = "";
            label2.Text = "";
            
            var hesCode = textBox1.Text;
            var result = HesSearhServices.GetHesCodeSeacrh(hesCode);

            if (result == null)
            {
                MessageBox.Show("Gecersiz Hes Kodu");
            }
            else if (result.IsRisky == false)
            {
                label2.Text = "Riskli Değil";
                label2.BackColor = Color.Green;

            }
            else if (result.IsRisky == true)
            {
                label2.Text = "RİSKLİ";
                label2.BackColor = Color.Red;
            }


            if (result != null && result.VaccinationHistory?.Count>0)
            {
                label3.Text = result.Name + " " + result.Surname;

                foreach (var item in result.VaccinationHistory)
                {
                    label3.Text = label3.Text + "\n" + item.Dose;
                    label3.Text = label3.Text + "\n" + item.VaccinationDate;
                    label3.Text = label3.Text + "\n" + item.VaccinationType;
                    label3.Text = label3.Text + "\n" + "______________________";
                }
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            label3.Text = "";
            label2.Text = "";
        }
    }
}
