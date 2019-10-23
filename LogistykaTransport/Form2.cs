using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LogistykaTransport
{
    public partial class Form2 : Form
    {
        private int odbiorcy_count;
        private int dostawcy_count;
        private int[] popyt;
        private int[] podaz;
        private List <TextBox> popytTable = new List<TextBox>();
        private List <TextBox> podazTable = new List<TextBox>();

        public Form2(int dostawcy_count, int odbiorcy_count, ref int[] popyt, ref int[] podaz)
        {
            InitializeComponent();
            this.odbiorcy_count = odbiorcy_count;
            this.dostawcy_count = dostawcy_count;
            this.popyt = popyt;
            this.podaz = podaz;
           // popyt = new int[odbiorcy_count];
           // podaz = new int[dostawcy_count];

            for (int i = 0; i < dostawcy_count; i++)
            {
                Label multi1 = new Label();
                multi1.Text = "dostawca " + (i + 1).ToString();
                multi1.Width = 100;
                multi1.Height = 26;
                flowLayoutPanel3.Controls.Add(multi1);

                TextBox multi2 = new TextBox();
                multi2.Text = "0";
                flowLayoutPanel4.Controls.Add(multi2);

                podazTable.Add(multi2);
            }

            for (int i = 0; i < odbiorcy_count; i++)
            {
                Label multi1 = new Label();
                multi1.Text = "odbiorca " + (i + 1).ToString();
                multi1.Width = 100;
                multi1.Height = 26;
                flowLayoutPanel1.Controls.Add(multi1);

                TextBox multi2 = new TextBox();
                multi2.Text = "0";
                flowLayoutPanel2.Controls.Add(multi2);
                popytTable.Add(multi2);
            }
        }

        private void SavePrices_Click(object sender, EventArgs e)
        {
            int i = 0;
            foreach (TextBox tmp in popytTable)
            {
                popyt[i] = Int32.Parse(tmp.Text);
                i++;
            }
            i = 0;
            foreach (TextBox tmp in podazTable)
            {
                podaz[i] = Int32.Parse(tmp.Text);
                i++;
            }

            this.Close();
        }

        private void flowLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {
            
        }

        private void flowLayoutPanel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void flowLayoutPanel3_Paint(object sender, PaintEventArgs e)
        {

        }

        private void flowLayoutPanel4_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
