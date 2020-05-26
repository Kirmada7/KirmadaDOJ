using System;
using System.CodeDom.Compiler;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace Kirmada_DOJ
{
    public partial class Form1 : Form
    {
        double fine;
        int month;
        public void reset()
        {
            
            mjr1.Checked = false;
            mjr2.Checked = false;
            mjr3.Checked = false;
            mjr4.Checked = false;
            mjr5.Checked = false;
            mjr6.Checked = false;
            mjr7.Checked = false;
            mjr8.Checked = false;
            mjr9.Checked = false;
            mjr10.Checked = false;
            mjr11.Checked = false;
            mjr12.Checked = false;
            mjr13.Checked = false;
            mjr14.Checked = false;
            fine = 0;
            month = 0;
            monthlbl.Text = month + " Month";
            finelbl.Text = "$" + fine;
            bailm(month);
        }
        
        public void bailm(int m)
        {
            if (m == 0)
            {
                baillbl.Text = "$0";
            }
            else if (m <= 25)
            {
                baillbl.Text = "$2500" ;
            }
            else if (m <= 50)
            {
                baillbl.Text = "$5000";
            }
            else if (m <= 99)
            {
                baillbl.Text = "$7500";
            }
            else if (m <= 199)
            {
                baillbl.Text = "$10000";
            }
            else if (m >= 200)
            {
                baillbl.Text = "$20000";
            }
        }
        public void add(int f , int m)
        {
            fine = fine + f;
            month = month + m;
            finelbl.Text = "$" + fine;
            monthlbl.Text = month + " Month";
            bailm(month);
        }
        public void subt(int f, int m)
        {
            fine = fine - f;
            month = month - m;
            finelbl.Text = "$" + fine;
            monthlbl.Text = month + " Month";
            bailm(month);
        }

        public Form1()
        {
            InitializeComponent();
            
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {

        }

        private void majorBtn_Click(object sender, EventArgs e)
        {

        }

        private void userControl11_Load(object sender, EventArgs e)
        {

        }

        private void mjr1_CheckedChanged(object sender, EventArgs e)
        {
            int mrjonef = 350;
            int mrjonem = 25;
            if(mjr1.Checked==true)
            {
                add(mrjonef, mrjonem);
                
            }
            else if(mjr1.Checked==false)
            {
                subt(mrjonef, mrjonem);
            }
          

        }

        private void mjr2_CheckedChanged(object sender, EventArgs e)
        {
            int mrjtwof=750, mrjtwom=45;
            if (mjr2.Checked == true)
            {
                add(mrjtwof, mrjtwom);

            }
            else if (mjr2.Checked == false)
            {
                subt(mrjtwof, mrjtwom);
            }
           
        }

        private void mjr3_CheckedChanged(object sender, EventArgs e)
        {
            int mrjthreef=1250,mrjthreem=75;
            if (mjr3.Checked == true)
            {
                add(mrjthreef,mrjthreem);

            }
            else if (mjr3.Checked == false)
            {
                subt(mrjthreef, mrjthreem);
            }
            
        }

        private void mjr4_CheckedChanged(object sender, EventArgs e)
        {
            int mrjfourf = 900, mrjfourm = 55;
            if (mjr4.Checked == true)
            {
                add(mrjfourf, mrjfourm);

            }
            else if (mjr4.Checked == false)
            {
                subt(mrjfourf, mrjfourm);
            }
        }

        private void mjr5_CheckedChanged(object sender, EventArgs e)
        {
            int mrjfivef = 1050, mrjfivem = 80;
            if (mjr5.Checked == true)
            {
                add(mrjfivef, mrjfivem);

            }
            else if (mjr5.Checked == false)
            {
                subt(mrjfivef, mrjfivem);
            }
        }

        private void mjr6_CheckedChanged(object sender, EventArgs e)
        {
            int mrjsixf = 250, mrjsixm = 40;
            if (mjr6.Checked == true)
            {
                add(mrjsixf, mrjsixm);

            }
            else if (mjr6.Checked == false)
            {
                subt(mrjsixf, mrjsixm);
            }
        }

        private void mjr7_CheckedChanged(object sender, EventArgs e)
        {
            int mrjsevenf = 950, mrjsevenm = 80;
            if (mjr7.Checked == true)
            {
                add(mrjsevenf, mrjsevenm);

            }
            else if (mjr7.Checked == false)
            {
                subt(mrjsevenf, mrjsevenm);
            }
        }

        private void mjr8_CheckedChanged(object sender, EventArgs e)
        {
            int mrjeightf = 1050, mrjeightm = 75;
            if (mjr8.Checked == true)
            {
                add(mrjeightf, mrjeightm);

            }
            else if (mjr8.Checked == false)
            {
                subt(mrjeightf, mrjeightm);
            }
        }

        private void mjr9_CheckedChanged(object sender, EventArgs e)
        {
            int mrjninef = 1050, mrjninem = 60;
            if (mjr9.Checked == true)
            {
                add(mrjninef, mrjninem);

            }
            else if (mjr9.Checked == false)
            {
                subt(mrjninef, mrjninem);
            }
        }

        private void mjr10_CheckedChanged(object sender, EventArgs e)
        {
            int mrjtenf = 1750, mrjtenm = 0;
            if (mjr10.Checked == true)
            {
                add(mrjtenf, mrjtenm);

            }
            else if (mjr10.Checked == false)
            {
                subt(mrjtenf, mrjtenm);
            }
        }

        private void mjr11_CheckedChanged(object sender, EventArgs e)
        {
            int mrjelef = 1700, mrjelem = 120;
            if (mjr11.Checked == true)
            {
                add(mrjelef, mrjelem);

            }
            else if (mjr11.Checked == false)
            {
                subt(mrjelef, mrjelem);
            }
        }

        private void rst_Click(object sender, EventArgs e)
        {
            reset();
        }

        private void mjr12_CheckedChanged(object sender, EventArgs e)
        {
            int mrjtwlvef = 325, mrjtwlvem = 25;
            if (mjr12.Checked == true)
            {
                add(mrjtwlvef, mrjtwlvem);

            }
            else if (mjr12.Checked == false)
            {
                subt(mrjtwlvef, mrjtwlvem);
            }
        }

        private void mjr13_CheckedChanged(object sender, EventArgs e)
        {
            int mrjtthirtnf = 350, mrjtthirtnm = 20;
            if (mjr13.Checked == true)
            {
                add(mrjtthirtnf, mrjtthirtnm);

            }
            else if (mjr13.Checked == false)
            {
                subt(mrjtthirtnf, mrjtthirtnm);
            }
        }

        private void mjr14_CheckedChanged(object sender, EventArgs e)
        {
            int mrjtfourtnf = 3000, mrjtfourtnm = 30;
            if (mjr14.Checked == true)
            {
                add(mrjtfourtnf, mrjtfourtnm);

            }
            else if (mjr14.Checked == false)
            {
                subt(mrjtfourtnf, mrjtfourtnm);
            }
        }
    }

}
