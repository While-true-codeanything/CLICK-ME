using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CLICK_ME
{
    public partial class Form1 : System.Windows.Forms.Form
    {
        int ClickNumber;
        public Form1()
        {
            ClickNumber = 0;
            InitializeComponent();
            Button.Font= new System.Drawing.Font("Segoe Print", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            Button.Text = "CLICK ME";
            this.Text = "Click me";
        }

        private void Button_Click(object sender, EventArgs e)
        {
            if (ClickNumber == 0) { Button.Text = "You clicked me!!!!";ClickNumber++; }
            else Close();
        }
    }
}
