using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsSEMANA13._4
{
    public partial class Form1 : Form
    {   //VARIABLE GLOBAL
        int contadorSeguros = 0;

        public Form1()
        {
            InitializeComponent();
        }



        private void Form1_Load(object sender, EventArgs e)
        {
            for (int i = 1; i < 100; i++)
            {
                comboBox1edad.Items.Add(i);

            }

            string[] sexos = { "masculino", "femenino" };
            foreach (var item in sexos)
            {
                comboBox2sexo.Items.Add(item);

            }




        }

        private void button1add_Click(object sender, EventArgs e)
        {
            listBox1name.Items.Add(textBox1name.Text);
            listBox2edad.Items.Add(comboBox1edad.SelectedItem);
            listBox3sexo.Items.Add(comboBox2sexo.SelectedItem);
            listBox4domici.Items.Add(textBox2domi.Text);
            listBox5telf.Items.Add(textBox3telf.Text);


            //contar seguros


            if (checkBoxSeguro.Checked)
            {
                contadorSeguros++;
            }
            double porcentajeSeguro = (contadorSeguros * 100) / listBox2edad.Items.Count;


        }


        //datos adicionales
        private void button1_Click(object sender, EventArgs e)
        {
            int countNinos = 0;
            int countJovenes = 0;
            int countAdultos = 0;

            // Iterar con for
            for (int i = 0; i < listBox2edad.Items.Count; i++)
            {
                int edad = int.Parse(listBox2edad.Items[i].ToString());

                // Categorizar las edades
                if (edad <= 13)
                {
                    countNinos++;
                }
                else if (edad <= 30)
                {
                    countJovenes++;
                }
                else
                {
                    countAdultos++;
                }
            }
            double porcentajeNinos = (countNinos * 100) / listBox2edad.Items.Count;
            double porcentajeJovenes = (countJovenes * 100) / listBox2edad.Items.Count;
            double porcentajeAdultos = (countAdultos * 100) / listBox2edad.Items.Count;

            textBoxCountN.Text = countNinos.ToString();
            textBoxCountJ.Text = countJovenes.ToString();
            textBoxCountA.Text = countAdultos.ToString();

            textBoxpn.Text = porcentajeNinos.ToString();
            textBoxpj.Text = porcentajeJovenes.ToString();
            textBoxpa.Text = porcentajeAdultos.ToString();

            // Contar h y m  del ComboBox
            string sexoSelected = comboBox2sexo.SelectedItem.ToString();
            int nHombres = 0, nMujeres = 0;

            if (sexoSelected == "masculino")
            {
                nHombres++;  // Incrementar el contador hombres
            }
            else if (sexoSelected == "femenino")
            {
                nMujeres++;  // Incrementar el contador mujeres
            }

            textBoxhh.Text = nHombres.ToString();
            textBoxhm.Text = nMujeres.ToString();


            // Mostrar seguros
            textBoxS.Text = contadorSeguros.ToString();

            textBoxSp.Text = ((contadorSeguros * 100) / listBox2edad.Items.Count).ToString();

            //adultos hombres mujeres hospi
            int aHombre = 0, aMujer = 0;

            for (int i = 0; i < listBox2edad.Items.Count; i++)
            {
                // Obtener la edad de la lista de edades
                int edad = int.Parse(listBox2edad.Items[i].ToString());

                // Verificar si la persona es adulta (mayor a 30 años)
                if (edad > 30)
                {
                    // Obtener el sexo correspondiente usando el mismo índice
                    string sexo = listBox3sexo.Items[i].ToString();

                    // Contar según el género
                    if (sexo == "masculino")
                    {
                        aHombre++; // Incrementar adultos hombres hospitalizados
                    }
                    else if (sexo == "femenino")
                    {
                        aMujer++; // Incrementar adultos mujeres hospitalizadas
                    }
                   
                }

            }
            textBoxAHombres.Text = aHombre.ToString();
            textBoxAMujeres.Text = aMujer.ToString();

        }
    }
}
