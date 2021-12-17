using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Project_Class_unit6
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btn_1_Click(object sender, EventArgs e)
        {
            int num, denom, w1;
            Physics f1;
            num = int.Parse(tb_1.Text);
            denom = int.Parse(tb_2.Text);

            f1 = new Physics();
            f1.setNumerator(num);
            f1.setDenominator(denom);
            f1.calcWeight();
            tb_ans1.Text = f1.getWeight().ToString();

        }

        private void btn_2_Click(object sender, EventArgs e)
        {
            int work, time, p1;
            Physics f2;
            work = int.Parse(tb_work.Text);
            time = int.Parse(tb_time.Text);

            f2 = new Physics();
            f2.setWork(work);
            f2.setTime(time);
            f2.calcPower();
            lb_ans2.Text = f2.getPower().ToString();
        }
    }
}
