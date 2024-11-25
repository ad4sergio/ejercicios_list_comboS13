using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsSEMANA13._1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {  //ADD CATEGORIAS
            comboBox1cat.Items.Add("A"); comboBox1cat.Items.Add("B");
            comboBox1cat.Items.Add("C"); comboBox1cat.Items.Add("D");
            textBox1name.Focus();
            comboBox1cat.Enabled = false; comboBox2prom.Enabled = false;

            comboBox1cat.DropDownStyle = ComboBoxStyle.DropDownList;
            comboBox2prom.DropDownStyle = ComboBoxStyle.DropDownList;

            //ADD ITEMS FORMA NORMAL A PROMEDIOS
            //comboBox2prom.Items.Add("1");................
             
            //Add items desde un vector usando for
            int[] promedios = { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 12, 13, 14, 15, 16, 17, 18, 19, 20 };
            for (int i = 0; i < promedios.Length; i++)
            {
                comboBox2prom.Items.Add(promedios[i]);
                
            }



        }

        private void button1save_Click(object sender, EventArgs e)
        {

            //TEXT A LIST
            listBox1names.Items.Add(textBox1name.Text.ToUpper());
            //categorias
            double pension = 0;

            string cate = comboBox1cat.SelectedItem.ToString();

            switch (cate)
            {
                case "A":
                    pension = 850;
                    break;
                case "B":
                    pension = 750;
                    break;
                case "C":
                    pension = 650;
                    break;
                case "D":
                    pension = 500;
                    break;

            }

             //Agregar mensualidad
            listBox2men.Items.Add(pension.ToString());
            //Okey


            // Descuento según el promedio

            double desc = 0;
            int promedio = int.Parse(comboBox2prom.SelectedItem.ToString());

            //la variable a comparar no era "pension" sino promedio jejejeje
   
            if (promedio >= 13 && promedio <= 15) { desc = 0.1; }
            else if (promedio >= 16 && promedio <= 17) { desc = 0.15; }
            else if (promedio >= 18 && promedio <= 19) { desc = 0.25; }
            else if (promedio == 20) { desc = 0.5; }

            // Calcular descuento y total
            double descuento = pension * desc;
            double total = pension - descuento;
            
            //Add descuento y total a listas
            listBox3desc.Items.Add(descuento.ToString());
            listBox4total.Items.Add(total.ToString());



        }



        //OPCIONAL 
        //PARA VALIDAR QUE SE INGRESE UN TEXTO NO ESPACIOS VACIOS
        private void textBox1name_Leave(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(textBox1name.Text))
            {
                MessageBox.Show("Ingrese un Nombre", "ERROR",
                    MessageBoxButtons.OK, MessageBoxIcon.Exclamation); textBox1name.Focus();
            }
            else { comboBox1cat.Enabled = true; comboBox1cat.Focus(); comboBox2prom.Enabled = true; }



        }

        private void button2new_Click(object sender, EventArgs e)
        {
            //BORRAR DATOS DE FORMA NORMAL MANUAL 1 A UNO

            textBox1name.Clear(); comboBox1cat.SelectedIndex = -1; comboBox2prom.SelectedIndex = -1;
            textBox1name.Focus();



        }

        private void button3exit_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
