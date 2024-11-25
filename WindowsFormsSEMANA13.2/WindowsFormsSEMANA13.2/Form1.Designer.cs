namespace WindowsFormsSEMANA13._2
{
    partial class Form1
    {
        /// <summary>
        /// Variable del diseñador requerida.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén utilizando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben eliminar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido del método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.textBox1name = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.comboBox1days = new System.Windows.Forms.ComboBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label10 = new System.Windows.Forms.Label();
            this.textBoxAdult = new System.Windows.Forms.TextBox();
            this.textBoxkid = new System.Windows.Forms.TextBox();
            this.checkBoxAdult = new System.Windows.Forms.CheckBox();
            this.checkBoxKid = new System.Windows.Forms.CheckBox();
            this.button1add = new System.Windows.Forms.Button();
            this.button2new = new System.Windows.Forms.Button();
            this.button3exit = new System.Windows.Forms.Button();
            this.listBox1names = new System.Windows.Forms.ListBox();
            this.listBox2days = new System.Windows.Forms.ListBox();
            this.listBox3mAdulto = new System.Windows.Forms.ListBox();
            this.listBox4mKids = new System.Windows.Forms.ListBox();
            this.listBox5total = new System.Windows.Forms.ListBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.textBox1montoAdulto = new System.Windows.Forms.TextBox();
            this.textBox2montoKids = new System.Windows.Forms.TextBox();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(32, 30);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(57, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "NOMBRE:";
            // 
            // textBox1name
            // 
            this.textBox1name.Location = new System.Drawing.Point(93, 27);
            this.textBox1name.Name = "textBox1name";
            this.textBox1name.Size = new System.Drawing.Size(167, 20);
            this.textBox1name.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(32, 66);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(104, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "DÍAS DE FUNCIÓN:";
            // 
            // comboBox1days
            // 
            this.comboBox1days.FormattingEnabled = true;
            this.comboBox1days.Location = new System.Drawing.Point(35, 82);
            this.comboBox1days.Name = "comboBox1days";
            this.comboBox1days.Size = new System.Drawing.Size(188, 21);
            this.comboBox1days.TabIndex = 3;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label10);
            this.groupBox1.Controls.Add(this.textBoxAdult);
            this.groupBox1.Controls.Add(this.textBoxkid);
            this.groupBox1.Controls.Add(this.checkBoxAdult);
            this.groupBox1.Controls.Add(this.checkBoxKid);
            this.groupBox1.Location = new System.Drawing.Point(288, 27);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(210, 76);
            this.groupBox1.TabIndex = 4;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "TIPO ENTRADA:";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(109, 0);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(66, 13);
            this.label10.TabIndex = 4;
            this.label10.Text = "(Cantidades)";
            // 
            // textBoxAdult
            // 
            this.textBoxAdult.Location = new System.Drawing.Point(88, 46);
            this.textBoxAdult.Name = "textBoxAdult";
            this.textBoxAdult.Size = new System.Drawing.Size(100, 20);
            this.textBoxAdult.TabIndex = 3;
            // 
            // textBoxkid
            // 
            this.textBoxkid.Location = new System.Drawing.Point(88, 20);
            this.textBoxkid.Name = "textBoxkid";
            this.textBoxkid.Size = new System.Drawing.Size(100, 20);
            this.textBoxkid.TabIndex = 2;
            // 
            // checkBoxAdult
            // 
            this.checkBoxAdult.AutoSize = true;
            this.checkBoxAdult.Location = new System.Drawing.Point(7, 48);
            this.checkBoxAdult.Name = "checkBoxAdult";
            this.checkBoxAdult.Size = new System.Drawing.Size(73, 17);
            this.checkBoxAdult.TabIndex = 1;
            this.checkBoxAdult.Text = "ADULTO:";
            this.checkBoxAdult.UseVisualStyleBackColor = true;
            this.checkBoxAdult.CheckedChanged += new System.EventHandler(this.checkBoxAdult_CheckedChanged);
            // 
            // checkBoxKid
            // 
            this.checkBoxKid.AutoSize = true;
            this.checkBoxKid.Location = new System.Drawing.Point(7, 20);
            this.checkBoxKid.Name = "checkBoxKid";
            this.checkBoxKid.Size = new System.Drawing.Size(56, 17);
            this.checkBoxKid.TabIndex = 0;
            this.checkBoxKid.Text = "NIÑO:";
            this.checkBoxKid.UseVisualStyleBackColor = true;
            this.checkBoxKid.CheckedChanged += new System.EventHandler(this.checkBoxKid_CheckedChanged);
            // 
            // button1add
            // 
            this.button1add.Location = new System.Drawing.Point(32, 122);
            this.button1add.Name = "button1add";
            this.button1add.Size = new System.Drawing.Size(108, 37);
            this.button1add.TabIndex = 5;
            this.button1add.Text = "AGREGAR";
            this.button1add.UseVisualStyleBackColor = true;
            this.button1add.Click += new System.EventHandler(this.button1add_Click);
            // 
            // button2new
            // 
            this.button2new.Location = new System.Drawing.Point(168, 122);
            this.button2new.Name = "button2new";
            this.button2new.Size = new System.Drawing.Size(108, 37);
            this.button2new.TabIndex = 6;
            this.button2new.Text = "NUEVO";
            this.button2new.UseVisualStyleBackColor = true;
            this.button2new.Click += new System.EventHandler(this.button2new_Click);
            // 
            // button3exit
            // 
            this.button3exit.Location = new System.Drawing.Point(301, 122);
            this.button3exit.Name = "button3exit";
            this.button3exit.Size = new System.Drawing.Size(108, 37);
            this.button3exit.TabIndex = 7;
            this.button3exit.Text = "SALIR";
            this.button3exit.UseVisualStyleBackColor = true;
            this.button3exit.Click += new System.EventHandler(this.button3exit_Click);
            // 
            // listBox1names
            // 
            this.listBox1names.FormattingEnabled = true;
            this.listBox1names.Location = new System.Drawing.Point(30, 220);
            this.listBox1names.Name = "listBox1names";
            this.listBox1names.Size = new System.Drawing.Size(121, 134);
            this.listBox1names.TabIndex = 8;
            // 
            // listBox2days
            // 
            this.listBox2days.FormattingEnabled = true;
            this.listBox2days.Location = new System.Drawing.Point(168, 220);
            this.listBox2days.Name = "listBox2days";
            this.listBox2days.Size = new System.Drawing.Size(92, 134);
            this.listBox2days.TabIndex = 9;
            // 
            // listBox3mAdulto
            // 
            this.listBox3mAdulto.FormattingEnabled = true;
            this.listBox3mAdulto.Location = new System.Drawing.Point(288, 220);
            this.listBox3mAdulto.Name = "listBox3mAdulto";
            this.listBox3mAdulto.Size = new System.Drawing.Size(64, 134);
            this.listBox3mAdulto.TabIndex = 10;
            // 
            // listBox4mKids
            // 
            this.listBox4mKids.FormattingEnabled = true;
            this.listBox4mKids.Location = new System.Drawing.Point(378, 220);
            this.listBox4mKids.Name = "listBox4mKids";
            this.listBox4mKids.Size = new System.Drawing.Size(64, 134);
            this.listBox4mKids.TabIndex = 11;
            // 
            // listBox5total
            // 
            this.listBox5total.FormattingEnabled = true;
            this.listBox5total.Location = new System.Drawing.Point(468, 220);
            this.listBox5total.Name = "listBox5total";
            this.listBox5total.Size = new System.Drawing.Size(68, 134);
            this.listBox5total.TabIndex = 12;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(30, 201);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(57, 13);
            this.label3.TabIndex = 13;
            this.label3.Text = "NOMBRE:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(165, 201);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(28, 13);
            this.label4.TabIndex = 14;
            this.label4.Text = "DÍA:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(285, 191);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(51, 26);
            this.label5.TabIndex = 15;
            this.label5.Text = "MONTO \r\nADULTO";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(375, 188);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(50, 26);
            this.label6.TabIndex = 16;
            this.label6.Text = "MONTO \rNIÑO";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(465, 188);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(50, 26);
            this.label7.TabIndex = 17;
            this.label7.Text = "MONTO \r\nTOTAL";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(30, 379);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(135, 13);
            this.label8.TabIndex = 18;
            this.label8.Text = "MONTO TOTAL ADULTO:";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(30, 422);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(118, 13);
            this.label9.TabIndex = 19;
            this.label9.Text = "MONTO TOTAL NIÑO:";
            // 
            // textBox1montoAdulto
            // 
            this.textBox1montoAdulto.Location = new System.Drawing.Point(168, 379);
            this.textBox1montoAdulto.Name = "textBox1montoAdulto";
            this.textBox1montoAdulto.Size = new System.Drawing.Size(100, 20);
            this.textBox1montoAdulto.TabIndex = 20;
            // 
            // textBox2montoKids
            // 
            this.textBox2montoKids.Location = new System.Drawing.Point(168, 419);
            this.textBox2montoKids.Name = "textBox2montoKids";
            this.textBox2montoKids.Size = new System.Drawing.Size(100, 20);
            this.textBox2montoKids.TabIndex = 21;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(570, 478);
            this.Controls.Add(this.textBox2montoKids);
            this.Controls.Add(this.textBox1montoAdulto);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.listBox5total);
            this.Controls.Add(this.listBox4mKids);
            this.Controls.Add(this.listBox3mAdulto);
            this.Controls.Add(this.listBox2days);
            this.Controls.Add(this.listBox1names);
            this.Controls.Add(this.button3exit);
            this.Controls.Add(this.button2new);
            this.Controls.Add(this.button1add);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.comboBox1days);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.textBox1name);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBox1name;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox comboBox1days;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox textBoxAdult;
        private System.Windows.Forms.TextBox textBoxkid;
        private System.Windows.Forms.CheckBox checkBoxAdult;
        private System.Windows.Forms.CheckBox checkBoxKid;
        private System.Windows.Forms.Button button1add;
        private System.Windows.Forms.Button button2new;
        private System.Windows.Forms.Button button3exit;
        private System.Windows.Forms.ListBox listBox1names;
        private System.Windows.Forms.ListBox listBox2days;
        private System.Windows.Forms.ListBox listBox3mAdulto;
        private System.Windows.Forms.ListBox listBox4mKids;
        private System.Windows.Forms.ListBox listBox5total;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox textBox1montoAdulto;
        private System.Windows.Forms.TextBox textBox2montoKids;
        private System.Windows.Forms.Label label10;
    }
}

