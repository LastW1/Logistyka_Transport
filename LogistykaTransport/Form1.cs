using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace LogistykaTransport
{
    public partial class Form1 : Form
    {
        private int dostawcy_count = 0;
        private int odbiorcy_count = 0;
        private List<TextBox> TextBoxList = new List<TextBox>();
        private int[,] DataArray;
        private int[] PopytArray;
        private int[] PodazArray;
        private int total_popyt;
        private int total_podaz;

        private void Test_Console()
        {
            for (int i = 0; i < dostawcy_count; i++)
            {
                System.Console.WriteLine();
                for (int j = 0; j < odbiorcy_count; j++)
                {
                    System.Console.Write(DataArray[i, j]);
                }
            }
            System.Console.WriteLine();
            Console.WriteLine("Popyt: ");
            foreach (int tmp in PopytArray)
            {
                Console.Write(tmp + " ");
            }
            System.Console.WriteLine("\nPodaz: ");
            foreach (int tmp in PodazArray)
            {
                Console.Write(tmp + " ");
            }
            System.Console.WriteLine();
        }

        private void TextBoxt_to_table()
        {
            DataArray = new int[dostawcy_count , odbiorcy_count];

            for(int i =0; i<dostawcy_count; i++)
            {
                for(int j = 0; j<odbiorcy_count; j++)
                {
                    DataArray[i,j] = Int32.Parse(TextBoxList[((i*odbiorcy_count) +j)].Text);
                }
            }
        }

        public Form1()
        {
            InitializeComponent();
        }

        private void flowLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void AddDostawca_Click(object sender, EventArgs e)
        {
            if (dostawcy_count >= 10)
            {
                MessageBox.Show("za dużo dostawców jełopie");
            }
            else
            {
                Label multi1 = new Label();
                multi1.Text = "dostawca " + (dostawcy_count + 1);
                multi1.Height = 26;
                flowLayoutPanel4.Controls.Add(multi1);

                dostawcy_count++;

                flowLayoutPanel1.Controls.Clear();
                TextBoxList.Clear();
                flowLayoutPanel1.Width = 60 * odbiorcy_count;
                flowLayoutPanel1.Height = 200 * dostawcy_count;
                for (int i = 0; i < dostawcy_count; i++)
                    for (int j = 0; j < odbiorcy_count; j++)
                    {
                        TextBox textBox = new TextBox();
                        textBox.Text = "0";
                        textBox.Width = 50;
                        TextBoxList.Add(textBox);
                        flowLayoutPanel1.Controls.Add(textBox);
                    }
            }
        }

        private void AddOdbiorca_Click(object sender, EventArgs e)
        {
            if (odbiorcy_count >= 8)
            {
                MessageBox.Show("za dużo odbiorców jełopie");
            }
            else
            {

                Label multi1 = new Label();
                multi1.Text = "odb " + (odbiorcy_count + 1);
                multi1.Width = 50;
                flowLayoutPanel3.Controls.Add(multi1);

                odbiorcy_count++;

                flowLayoutPanel1.Controls.Clear();
                TextBoxList.Clear();
                flowLayoutPanel1.Width = 60 * odbiorcy_count;
                flowLayoutPanel1.Height = 200 * dostawcy_count;
                for (int i = 0; i < dostawcy_count; i++)
                    for (int j = 0; j < odbiorcy_count; j++)
                    {
                        TextBox textBox = new TextBox();
                        textBox.Text = "0";
                        textBox.Width = 50;
                        TextBoxList.Add(textBox);
                        flowLayoutPanel1.Controls.Add(textBox);
                    }
            }   
        }

        private void flowLayoutPanel3_Paint(object sender, PaintEventArgs e)
        {

        }

        private void flowLayoutPanel4_Paint(object sender, PaintEventArgs e)
        {

        }

        private void AddCeny_Click(object sender, EventArgs e)
        {
            PodazArray = new int[dostawcy_count];
            PopytArray = new int[odbiorcy_count];
            var frm = new Form2(dostawcy_count, odbiorcy_count, ref PopytArray, ref PodazArray);
            frm.Location = this.Location;
            frm.StartPosition = FormStartPosition.Manual;
            frm.FormClosing += delegate { this.Show(); };
            frm.Show();
            this.Hide();
        }

        private void Calculate_Click(object sender, EventArgs e)
        {

            total_podaz = 0;
            total_popyt = 0;
            //sprawdzanie popytu i podazy
            foreach(int tmp in PopytArray)
            {
                total_popyt += tmp;
            }
            foreach (int tmp in PodazArray)
            {
                total_podaz += tmp;
            }

            TextBoxt_to_table();
            if (total_podaz == total_popyt)
            {
                MessageBox.Show("liczymy");
            }
            else
            {
                MessageBox.Show("dodanie wirtualnego dostawcy");
                int[,] TmpDataArray = new int[dostawcy_count+1, odbiorcy_count];

                for (int i = 0; i < dostawcy_count; i++)
                    for (int j = 0; j < odbiorcy_count; j++)
                        TmpDataArray[i,j] = DataArray[i,j];

                // DataArray = new int[dostawcy_count + 1, odbiorcy_count];
                dostawcy_count++;
                DataArray = TmpDataArray;

            }
            Test_Console();
        }

        private void ExitButton_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
