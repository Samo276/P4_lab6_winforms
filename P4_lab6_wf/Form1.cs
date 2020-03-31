using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using System.Threading;

namespace P4_lab6_wf
{
    public partial class Form1 : Form
    {
       // BindingList<Number> numbers = new BindingList<Number>(); //specialna lista posiadająca event
        public Form1()
        {
            InitializeComponent();
            //dataGridView1.DataSource = numbers; //datagrid viev czyta tylko property, wiec trzba utworzyc klase która opakuje stringa
        }

        private void button1_Click(object sender, EventArgs e)
        {
            openFileDialog1.ShowDialog();
            
        }

        private void openFileDialog1_FileOk(object sender, CancelEventArgs e)
        {
            /*var dialog = (OpenFileDialog)sender; //rzutowanie object -> openFileDialog
            var path = dialog.FileName;
            var fileContent = File.ReadAllText(path);
            foreach (var item in fileContent.Split(new[] { "\n", "\r" }, StringSplitOptions.RemoveEmptyEntries))
            {
                numbers.Add(new Number() { Value = item });
            };*/

            var dialog = (OpenFileDialog)sender; //rzutowanie object -> openFileDialog
            var path = dialog.FileName;
            var fileContent = File.ReadAllText(path);
            label1.Visible = true;
            button2.Enabled = true;
            foreach (var item in fileContent.Split(new[] { "\n", "\r" }, StringSplitOptions.RemoveEmptyEntries))
            {
                flowLayoutPanel1.Controls.Add(GenerateNumberTextBox(Convert.ToInt32(item)));
            }


        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private TextBox GenerateNumberTextBox(int number)
        {
            return new TextBox()
            {
                Text = number.ToString(),
                ReadOnly = true,
                Width = 25
            };
        }

        private void button2_Click(object sender, EventArgs e)
        {
            timer1.Start();
            
        }

        private void textBox2_TextChanged_1(object sender, EventArgs e)
        {

        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            Random rand = new Random();
            
                var randomNumber = rand.Next(100);
                textBox2.Text = randomNumber.ToString();
                flowLayoutPanel2.Controls.Add(GenerateNumberTextBox(randomNumber));
                Application.DoEvents();


            
        }
    }
}
