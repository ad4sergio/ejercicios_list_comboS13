using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsSEMANA13._2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {   //agregar días desde un vector
            string[] weekdays = {"Lunes", "Martes", "Miércoles", 
                                "Jueves", "Viernes", "Sábado", "Domingo"};
            for (int i = 0; i < weekdays.Length; i++)
                comboBox1days.Items.Add(weekdays[i].ToString());
            textBoxAdult.Enabled= false ; textBoxkid.Enabled = false;
            textBoxAdult.ReadOnly =true; textBoxkid.ReadOnly = true;
            textBoxkid.Text = "0"; textBoxAdult.Text = "0";
            checkBoxKid.Checked = false; checkBoxAdult.Checked = false;
            //Style combo box
            comboBox1days.DropDownStyle = ComboBoxStyle.DropDownList;

        }

        private void button1add_Click(object sender, EventArgs e)
        {
            listBox1names.Items.Add(textBox1name.Text.ToUpper());

            listBox2days.Items.Add((comboBox1days.SelectedItem.ToString()).ToUpper());

            int nTicketsKid = int.Parse(textBoxkid.Text);
            int nTicketsAdult = int.Parse(textBoxAdult.Text);
            //precio según días en este caso por index 
            double precioKid = 0, precioAdult=0;
            //valido según index del día

            switch (comboBox1days.SelectedIndex)
            {   //Lunes 0............. Domingo 6
                case 0:
                    precioAdult=10;precioKid = 5;
                    break;
                case 1:
                    precioAdult = 8; precioKid = 4;
                    break;
                case 2:
                    precioAdult = 16; precioKid = 8;
                    break;
                case 3:
                    precioAdult = 19; precioKid = 9.5;
                    break;
                case 4:
                    precioAdult = 25; precioKid = 12.5;
                    break;
                case 5:
                    precioAdult = 35; precioKid = 25;
                    break;
                case 6:
                    precioAdult = 50; precioKid = 35;
                    break;

                default:
                //Por ahora no usaremos un default
                    break;
                
            }
            //agregar monto adulto y niño
            double montoKid = nTicketsKid * precioKid;
            double montoAdult = nTicketsAdult * precioAdult;

            listBox3mAdulto.Items.Add(montoAdult.ToString());
            listBox4mKids.Items.Add(montoKid.ToString());

            //monto total


            double montoTotal = montoKid + montoAdult;
            listBox5total.Items.Add(montoTotal.ToString());

            //contar items en lista adultos y sumarlos.
            int nAdultos= listBox3mAdulto.Items.Count;
            double totalAdult = 0, totalKid = 0;
            for (int i = 0; i < nAdultos; i++)
            {  
                totalAdult = totalAdult + double.Parse(listBox3mAdulto.Items[i].ToString()) ;
                
            }
            textBox1montoAdulto.Text = totalAdult.ToString();
          
            //contar de items en lista kids  y sumarlos
            int nKids = listBox4mKids.Items.Count;
            for (int i = 0; i < listBox4mKids.Items.Count; i++)
            {
                totalKid = totalKid + double.Parse(listBox4mKids.Items[i].ToString());
                
            }
            textBox2montoKids.Text = totalKid.ToString();



        }


        //OPCIONAL ACTIVACIÓN DE CHECKBOXS
        private void checkBoxKid_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBoxKid.Checked) {textBoxkid.Enabled= true ; textBoxkid.ReadOnly = false; }
            else { textBoxkid.Enabled = false; textBoxkid.ReadOnly = true; textBoxkid.Text = "0"; }
        }

        //OPCIONAL ACTIVACIÓN DE CHECKBOXS
        private void checkBoxAdult_CheckedChanged(object sender, EventArgs e)
        {
             if (checkBoxAdult.Checked) {textBoxAdult.Enabled= true ; textBoxAdult.ReadOnly = false; }
             else { textBoxAdult.Enabled = false; textBoxAdult.ReadOnly = true; textBoxAdult.Text = "0"; }
        }

        //Botón nuevo
        private void button2new_Click(object sender, EventArgs e)
        {    //opciones normales
            textBox1name.Clear(); textBox1name.Focus();
            comboBox1days.SelectedItem = null;
            //por ciclo foreach
            foreach (var control in groupBox1.Controls.OfType<CheckBox>())
            {
                control.Checked = false; 
                
            }
            foreach (var controltxt in this.Controls.OfType<TextBox>())
            {
                controltxt.Clear();
            }


        }

        private void button3exit_Click(object sender, EventArgs e)
        {
            Close();
        }
        }




    }

