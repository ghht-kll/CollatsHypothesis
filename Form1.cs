using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GenerPassForm
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int x = new int();
            try
            {
                 x = int.Parse(this.textBox1.Text);
            }
            catch (Exception exp)
            {
                MessageBox.Show(exp.Message);
            }
            CollatsHypothesis collatsHypothesis = new CollatsHypothesis(x);
            while(collatsHypothesis.GetN() != 1)
            {
                if(collatsHypothesis.GetN() % 2 != 0)
                {
                    collatsHypothesis.Odd();
                    this.richTextBox1.Text += collatsHypothesis.GetStrIfnOdd();
                }
                else
                {
                    collatsHypothesis.Even();
                    this.richTextBox1.Text += collatsHypothesis.GetStrIfnEven();
                }
            }
            this.richTextBox1.Text += "\n==================\n\n";
        }
    }

    class CollatsHypothesis
    {
        private int n;
        public CollatsHypothesis(int n)
        {
            this.n = n;
        }
        public void Even() => this.n = this.n / 2;
        public void Odd() => this.n = this.n * 3 + 1;
        
        public int GetN() => this.n;
        public string GetStrIfnEven()
        {
            return $"n / 2 = {this.n}\n";
        }
        public string GetStrIfnOdd()
        {
            return $"n * 3 + 1 = {this.n}\n";
        }
    }
}


