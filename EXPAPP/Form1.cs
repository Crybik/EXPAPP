using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EXPAPP
{

    public partial class Form1 : Form
    {
        private bool dragging = false;
        private Point startPoint = new Point(0, 0);
        public Form1()
        {
           

            InitializeComponent();

        }



        private void Form1_Load(object sender, EventArgs e)
        {

            uiRadioButton1.Checked = true;
            uiRadioButton4.Checked = true;


        }

        private void Form1_MouseDown(object sender, MouseEventArgs e)
        {
            dragging = true;
            startPoint = new Point(e.X, e.Y);
        }

        private void Form1_MouseUp(object sender, MouseEventArgs e)
        {
            dragging = false;
        }

        private void Form1_MouseMove(object sender, MouseEventArgs e)
        {
            if (dragging)
            {
                Point p = PointToScreen(e.Location);
                Location = new Point(p.X - this.startPoint.X, p.Y - this.startPoint.Y);
            }
        }

        private void Panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void Panel1_MouseDown(object sender, MouseEventArgs e)
        {
            dragging = true;
            startPoint = new Point(e.X, e.Y);
        }

        private void Panel1_MouseUp(object sender, MouseEventArgs e)
        {
            dragging = false;
        }

        private void Panel1_MouseMove(object sender, MouseEventArgs e)
        {
            if (dragging)
            {
                Point p = PointToScreen(e.Location);
                Location = new Point(p.X - this.startPoint.X, p.Y - this.startPoint.Y);
            }
        }

        private void Button3_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Max_Click(object sender, EventArgs e)
        {
            if (WindowState.ToString() == "Normal")
            {
                this.WindowState = FormWindowState.Maximized;
            }
            else
            {
                this.WindowState = FormWindowState.Normal;
            }
        }

        private void Min_Click(object sender, EventArgs e)
        {
            if (WindowState.ToString() == "Normal")
            {
                this.WindowState = FormWindowState.Minimized;
            }
            else
            {
                this.WindowState = FormWindowState.Normal;
            }
        }

        private void Initxx__TextChanged(object sender, EventArgs e)
        {

        }



        private void UiTitlePanel1_Click(object sender, EventArgs e)
        {

        }

        private void Button1_Click_2(object sender, EventArgs e)
        {
            if (uiRadioButton1.Checked == true)
            {
                if (uiRadioButton4.Checked == true)
                {

                    Double initd = Convert.ToDouble(init.Text);
                    double incd = Convert.ToDouble(inc.Text);
                    double durationd = Convert.ToDouble(duration.Text);

                    Double Vinc = incd / 100 + 1;

                    Double iw = Math.Pow(Vinc, durationd);
                    Double w = initd * iw;
                    Double x = Math.Pow(Vinc, durationd) - 1;
                    Double rebv = Convert.ToDouble(reb.Text);
                    Double y = rebv * x / (Vinc - 1);
                    Double holy = w - y;
                    res.Text = "The result is : " + holy.ToString("0.00");

                }
                // 
                else if (disabledx.Checked == true)
                {
                    Double initd = Convert.ToDouble(init.Text);
                    double incd = Convert.ToDouble(inc.Text);
                    double durationd = Convert.ToDouble(duration.Text);
                    Double Vinc = incd / 100 + 1;

                    Double iw = Math.Pow(Vinc, durationd);
                    Double w = initd * iw;
                    Double x = Math.Pow(Vinc, durationd) - 1;
                    Double rebv = Convert.ToDouble(reb.Text);
                    Double y = rebv * x / (Vinc - 1);

                    Double holy = w + y;
                    res.Text = "The result is : " + holy.ToString("0.00");
                }
            }



            // #####################################
            // THIS IS THE ELSE IF. 
            else if (dradio.Checked == true)
            {
                

                if (uiRadioButton4.Checked == true)
                {

                    Double initd = Convert.ToDouble(init.Text);
                    double incd = Convert.ToDouble(inc.Text);
                    double durationd = Convert.ToDouble(duration.Text);

                    Double Vinc = incd / 100 - 1;

                    Double iw = Math.Pow(Vinc, durationd);
                    Double w = initd * iw;
                    Double x = Math.Pow(Vinc, durationd) - 1;
                    Double rebv = Convert.ToDouble(reb.Text);
                    Double y = rebv * x / (Vinc - 1);

                    Double holy = w - y;
                    res.Text = "The result is : " + holy.ToString("0.00");

                }
                // 
                else if (disabledx.Checked == true)
                {

                    Double initd = Convert.ToDouble(init.Text);
                    double incd = Convert.ToDouble(inc.Text);
                    double durationd = Convert.ToDouble(duration.Text);

                    Double Vinc = incd / 100 - 1;

                    Double iw = Math.Pow(Vinc, durationd);
                    Double w = initd * iw;
                    Double x = Math.Pow(Vinc, durationd) - 1;
                    Double rebv = Convert.ToDouble(reb.Text);
                    rebv = 0;
                    Double y = rebv * x / (Vinc - 1);

                    Double holy = w + y;
                    res.Text = "The result is : " + holy.ToString("0.00");
                }

            }
        }

        private void UiRadioButton1_ValueChanged(object sender, bool value)
        {
            disabledx.Enabled = true;
        }

        private void UiSymbolButton1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void UiSymbolButton2_Click(object sender, EventArgs e)
        {
            if (WindowState.ToString() == "Normal")
            {
                this.WindowState = FormWindowState.Maximized;
            }
            else
            {
                this.WindowState = FormWindowState.Normal;
            }
        }

        private void UiSymbolButton3_Click(object sender, EventArgs e)
        {
            if (WindowState.ToString() == "Normal")
            {
                this.WindowState = FormWindowState.Minimized;
            }
            else
            {
                this.WindowState = FormWindowState.Normal;
            }
        }


        private void UiPanel1_MouseDown(object sender, MouseEventArgs e)
        {
            dragging = true;
            startPoint = new Point(e.X, e.Y);
        }

        private void UiPanel1_MouseUp(object sender, MouseEventArgs e)
        {
            dragging = false;
        }

        private void UiPanel1_MouseMove(object sender, MouseEventArgs e)
        {
            if (dragging)
            {
                Point p = PointToScreen(e.Location);
                Location = new Point(p.X - this.startPoint.X, p.Y - this.startPoint.Y);
            }
        }

        private void UiTitlePanel1_MouseDown(object sender, MouseEventArgs e)
        {
            dragging = true;
            startPoint = new Point(e.X, e.Y);
        }

        private void UiTitlePanel1_MouseUp(object sender, MouseEventArgs e)
        {
            dragging = false;
        }

        private void UiTitlePanel1_MouseMove(object sender, MouseEventArgs e)
        {
            if (dragging)
            {
                Point p = PointToScreen(e.Location);
                Location = new Point(p.X - this.startPoint.X, p.Y - this.startPoint.Y);
            }
        }

        private void UiSymbolButton4_MouseDown(object sender, MouseEventArgs e)
        {
            dragging = true;
            startPoint = new Point(e.X, e.Y);
        }

        private void UiSymbolButton4_MouseUp(object sender, MouseEventArgs e)
        {
            dragging = false;
        }

        private void UiSymbolButton4_MouseMove(object sender, MouseEventArgs e)
        {
            if (dragging)
            {
                Point p = PointToScreen(e.Location);
                Location = new Point(p.X - this.startPoint.X, p.Y - this.startPoint.Y);
            }
        }

        private void UiRadioButton4_ValueChanged(object sender, bool value)
        {

        }

        private void UiRadioButton3_ValueChanged(object sender, bool value)
        {

        }

        private void Dradio_ValueChanged(object sender, bool value)
        {
            disabledx.Enabled = false;
        }

        private void UiLinkLabel1_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("https://www.github.com/crybik");

        }
    }
}
