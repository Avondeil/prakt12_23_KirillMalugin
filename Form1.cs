using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace prakt12
{
    public partial class Robot : Form
    {
        public Robot()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }
        private void button1_Click(object sender, EventArgs e)
         private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                robot robot1 = new robot();
                robot robot2 = new robot();
                robot robot3 = new robot();
                Random rn = new Random();
                int b = rn.Next(0, 100);
                robot1.min(b);
                if (Convert.ToInt32(textBox1.Text) > 0 && Convert.ToInt32(textBox1.Text) > 0 && Convert.ToInt32(textBox1.Text) > 0)
                {
                    robot1.kollife = Convert.ToInt32(textBox1.Text);
                    label1.Text = "Количество жизней робота1 в начале игры " + robot1.kollife;
                    robot2.kollife = Convert.ToInt32(textBox2.Text);
                    label7.Text = "Количество жизней робота2 в начале игры " + robot2.kollife;
                    robot3.kollife = Convert.ToInt32(textBox3.Text);
                    label9.Text = "Количество жизней робота3 в начале игры " + robot3.kollife;
                    int a = robot1.kollife;
                    robot1.min(robot1.kollife);
                    label2.Text = "Количество жизней робота 1 в конце игры " + Convert.ToString(robot1.getlife());
                    robot2.kol(a, robot1.kollife);
                    label6.Text = "Количество жизней робота 2 в конце игры " + Convert.ToString(robot2.getlife());
                    robot3.kol(a, robot1.kollife);
                    label8.Text = "Количество жизней робота 3 в конце игры " + Convert.ToString(robot3.getlife());
                } else MessageBox.Show("Ввод отрицательного числа", "Ошибка", MessageBoxButtons.OK);
            }
            catch { MessageBox.Show("Ошибка ввода данных", "Ошибка", MessageBoxButtons.OK); }
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        
    }
}
