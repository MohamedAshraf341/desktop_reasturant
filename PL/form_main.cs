using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TWQ_MangementSystem.PL
{
    public partial class form_main : Form
    {
        //دالة عرض اليوزر كونترول
        public void ShowControl(Control con)
        {
            con.Dock = DockStyle.Fill;
            panelofuser.Controls.Clear();
            con.BringToFront();
            con.Focus();
            panelofuser.Controls.Add(con);

        }
        public form_main()
        {
            InitializeComponent();
            PL.control_cover cover = new control_cover();
            ShowControl(cover);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            PL.control_showsalebill cat = new control_showsalebill();
            ShowControl(cat);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            PL.control_showbuybill pr = new control_showbuybill();
            ShowControl(pr);
        }

        private void button3_Click(object sender, EventArgs e)
        {
            PL.control_order or = new control_order();
            ShowControl(or);
        }

        private void button4_Click(object sender, EventArgs e)
        {
            PL.control_masrof ms=new control_masrof();
            ShowControl(ms);
        }

        private void button5_Click(object sender, EventArgs e)
        {
            PL.control_note no = new control_note();
            ShowControl(no);
        }

        //private void button6_Click(object sender, EventArgs e)
        //{
        //    PL.Users_control us = new Users_control();
        //    ShowControl(us);
        //}

        private void flowLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panel3_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btnreport_Click(object sender, EventArgs e)
        {
            PL.control_report report = new control_report();
            ShowControl(report);
        }

        private void btncover_Click(object sender, EventArgs e)
        {
            PL.control_cover cover = new control_cover();
            ShowControl(cover);
        }

        private void btnfood_Click(object sender, EventArgs e)
        {
            PL.control_foods food = new control_foods();
            ShowControl(food);
        }

        private void btnnote_Click(object sender, EventArgs e)
        {
            PL.control_note note = new control_note();
            ShowControl(note);
        }

        private void btnshowbuy_Click(object sender, EventArgs e)
        {
            PL.control_showbuybill bill = new control_showbuybill();
            ShowControl(bill);
        }

        private void button3_Click_1(object sender, EventArgs e)
        {
            PL.control_masrof masrof = new control_masrof();
            ShowControl(masrof);
        }

        private void btnbillbuy_Click(object sender, EventArgs e)
        {
            PL.control_addbuybill buy = new control_addbuybill();
            ShowControl(buy);
        }

        private void btnorder_Click(object sender, EventArgs e)
        {
            PL.control_order order = new control_order();
            ShowControl(order);
        }

        private void btnshowsale_Click(object sender, EventArgs e)
        {
            PL.control_showsalebill sale = new control_showsalebill();
            ShowControl(sale);
        }

        private void btnuser_Click(object sender, EventArgs e)
        {
            PL.control_user user = new control_user();
            ShowControl(user);
        }

        private void form_main_Load(object sender, EventArgs e)
        {

        }

    }
}
