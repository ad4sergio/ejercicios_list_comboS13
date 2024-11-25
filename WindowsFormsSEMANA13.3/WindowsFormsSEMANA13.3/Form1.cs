using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsSEMANA13._3
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            textBox2precio.ReadOnly = true;

            string[] destinos = { "LIMA", "CUZCO" ,"TACNA","PUNO","AREQUIPA","AYACUCHO","ICA","LORETO"};
            foreach (var destino in destinos)
            {
                listBoxDestino.Items.Add(destino);
            }

            int[] descuentos = { 20, 25, 30, 40 };
            foreach (var descuento in descuentos)
            {
                listBoxDesc.Items.Add(descuento.ToString());
            }

        }

        private void button1add_Click(object sender, EventArgs e)
        {
            listBox1nA.Items.Add(textBox1na.Text);
            listBox2p.Items.Add(textBox2pasa.Text);
            listBox3d.Items.Add(listBoxDestino.SelectedItem.ToString());
            double subtotal = (int.Parse(textBox2precio.Text) - int.Parse(textBox2desc.Text)) * int.Parse(textBox2cantidad.Text);
            listBox4st.Items.Add(subtotal.ToString());
            
            double total=0;
            foreach (var item in listBox4st.Items)
            {
                total = total + int.Parse(item.ToString());
            }
            textBoxTotal.Text = total.ToString();

        }

        private void listBoxDestino_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (listBoxDestino.SelectedIndex == 0)
            {textBox2precio.Text = "120"; // Precio para el primer ítem
            }
            else if (listBoxDestino.SelectedIndex == 1)
            { textBox2precio.Text = "200"; // Precio para el segundo ítem
            }
            else if (listBoxDestino.SelectedIndex == 2)
            {textBox2precio.Text = "250"; // Precio para el tercer ítem
            }
            else if (listBoxDestino.SelectedIndex == 3)
            {textBox2precio.Text = "300"; // Precio para el cuarto ítem
            }
            else if (listBoxDestino.SelectedIndex == 4)
            {textBox2precio.Text = "210"; // Precio para el quinto ítem
            }
            else if (listBoxDestino.SelectedIndex == 5)
            {textBox2precio.Text = "280"; // Precio para el sexto ítem
            }
            else if (listBoxDestino.SelectedIndex == 6)
            {textBox2precio.Text = "100"; // Precio para el séptimo ítem
            }
            else if (listBoxDestino.SelectedIndex == 7)
            {textBox2precio.Text = "220"; // Precio para el octavo ítem
            }



        }

        private void listBoxDesc_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (listBoxDesc.SelectedIndex == 0)
            {
                textBox2desc.Text = "20"; // Valor para el primer ítem
            }
            else if (listBoxDesc.SelectedIndex == 1)
            {
                textBox2desc.Text = "25"; // Valor para el segundo ítem
            }
            else if (listBoxDesc.SelectedIndex == 2)
            {
                textBox2desc.Text = "30"; // Valor para el tercer ítem
            }
            else if (listBoxDesc.SelectedIndex == 3)
            {
                textBox2desc.Text = "40"; // Valor para el cuarto ítem
            }
        }

        private void button2new_Click(object sender, EventArgs e)
        {
            foreach (var item in this.Controls.OfType<TextBox>())
            {
                item.Clear();
                
            }

            foreach (var item in this.Controls.OfType<ListBox>())
            {
                item.SelectedIndex=-1;

            }



        }

        private void button3exit_Click(object sender, EventArgs e)
        {

        }
   











    }
}
