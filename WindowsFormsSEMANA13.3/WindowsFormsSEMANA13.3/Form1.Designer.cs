namespace WindowsFormsSEMANA13._3
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
            this.label2 = new System.Windows.Forms.Label();
            this.textBox1na = new System.Windows.Forms.TextBox();
            this.textBox2pasa = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.button3exit = new System.Windows.Forms.Button();
            this.button1add = new System.Windows.Forms.Button();
            this.button2new = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.listBoxDestino = new System.Windows.Forms.ListBox();
            this.label4 = new System.Windows.Forms.Label();
            this.textBox2precio = new System.Windows.Forms.TextBox();
            this.textBox2cantidad = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.listBoxDesc = new System.Windows.Forms.ListBox();
            this.label6 = new System.Windows.Forms.Label();
            this.textBox2desc = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.listBox1nA = new System.Windows.Forms.ListBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.listBox2p = new System.Windows.Forms.ListBox();
            this.label10 = new System.Windows.Forms.Label();
            this.listBox3d = new System.Windows.Forms.ListBox();
            this.label11 = new System.Windows.Forms.Label();
            this.listBox4st = new System.Windows.Forms.ListBox();
            this.label12 = new System.Windows.Forms.Label();
            this.textBoxTotal = new System.Windows.Forms.TextBox();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(33, 33);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(68, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "N ASIENTO:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(33, 81);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(66, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "PASAJERO:";
            // 
            // textBox1na
            // 
            this.textBox1na.Location = new System.Drawing.Point(105, 30);
            this.textBox1na.Name = "textBox1na";
            this.textBox1na.Size = new System.Drawing.Size(155, 20);
            this.textBox1na.TabIndex = 2;
            // 
            // textBox2pasa
            // 
            this.textBox2pasa.Location = new System.Drawing.Point(105, 74);
            this.textBox2pasa.Name = "textBox2pasa";
            this.textBox2pasa.Size = new System.Drawing.Size(155, 20);
            this.textBox2pasa.TabIndex = 3;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.button3exit);
            this.groupBox1.Controls.Add(this.button1add);
            this.groupBox1.Controls.Add(this.button2new);
            this.groupBox1.Location = new System.Drawing.Point(289, 33);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(200, 113);
            this.groupBox1.TabIndex = 4;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "OPCIONES";
            // 
            // button3exit
            // 
            this.button3exit.Location = new System.Drawing.Point(6, 77);
            this.button3exit.Name = "button3exit";
            this.button3exit.Size = new System.Drawing.Size(187, 23);
            this.button3exit.TabIndex = 2;
            this.button3exit.Text = "SALIR";
            this.button3exit.UseVisualStyleBackColor = true;
            this.button3exit.Click += new System.EventHandler(this.button3exit_Click);
            // 
            // button1add
            // 
            this.button1add.Location = new System.Drawing.Point(7, 19);
            this.button1add.Name = "button1add";
            this.button1add.Size = new System.Drawing.Size(187, 23);
            this.button1add.TabIndex = 1;
            this.button1add.Text = "AÑADIR";
            this.button1add.UseVisualStyleBackColor = true;
            this.button1add.Click += new System.EventHandler(this.button1add_Click);
            // 
            // button2new
            // 
            this.button2new.Location = new System.Drawing.Point(7, 48);
            this.button2new.Name = "button2new";
            this.button2new.Size = new System.Drawing.Size(187, 23);
            this.button2new.TabIndex = 0;
            this.button2new.Text = "NUEVO";
            this.button2new.UseVisualStyleBackColor = true;
            this.button2new.Click += new System.EventHandler(this.button2new_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(36, 148);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(55, 13);
            this.label3.TabIndex = 5;
            this.label3.Text = "DESTINO";
            // 
            // listBoxDestino
            // 
            this.listBoxDestino.FormattingEnabled = true;
            this.listBoxDestino.Location = new System.Drawing.Point(36, 165);
            this.listBoxDestino.Name = "listBoxDestino";
            this.listBoxDestino.Size = new System.Drawing.Size(142, 134);
            this.listBoxDestino.TabIndex = 6;
            this.listBoxDestino.SelectedIndexChanged += new System.EventHandler(this.listBoxDestino_SelectedIndexChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(184, 165);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(47, 13);
            this.label4.TabIndex = 7;
            this.label4.Text = "PRECIO";
            // 
            // textBox2precio
            // 
            this.textBox2precio.Location = new System.Drawing.Point(185, 182);
            this.textBox2precio.Name = "textBox2precio";
            this.textBox2precio.Size = new System.Drawing.Size(100, 20);
            this.textBox2precio.TabIndex = 8;
            // 
            // textBox2cantidad
            // 
            this.textBox2cantidad.Location = new System.Drawing.Point(184, 250);
            this.textBox2cantidad.Name = "textBox2cantidad";
            this.textBox2cantidad.Size = new System.Drawing.Size(100, 20);
            this.textBox2cantidad.TabIndex = 10;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(184, 234);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(62, 13);
            this.label5.TabIndex = 9;
            this.label5.Text = "CANTIDAD";
            // 
            // listBoxDesc
            // 
            this.listBoxDesc.FormattingEnabled = true;
            this.listBoxDesc.Location = new System.Drawing.Point(340, 165);
            this.listBoxDesc.Name = "listBoxDesc";
            this.listBoxDesc.Size = new System.Drawing.Size(142, 56);
            this.listBoxDesc.TabIndex = 12;
            this.listBoxDesc.SelectedIndexChanged += new System.EventHandler(this.listBoxDesc_SelectedIndexChanged);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(340, 148);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(119, 13);
            this.label6.TabIndex = 11;
            this.label6.Text = "DESCUENTO (Unitario)";
            // 
            // textBox2desc
            // 
            this.textBox2desc.Location = new System.Drawing.Point(343, 250);
            this.textBox2desc.Name = "textBox2desc";
            this.textBox2desc.Size = new System.Drawing.Size(100, 20);
            this.textBox2desc.TabIndex = 14;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(343, 234);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(77, 13);
            this.label7.TabIndex = 13;
            this.label7.Text = "DESCUENTO:";
            // 
            // listBox1nA
            // 
            this.listBox1nA.FormattingEnabled = true;
            this.listBox1nA.Location = new System.Drawing.Point(36, 347);
            this.listBox1nA.Name = "listBox1nA";
            this.listBox1nA.Size = new System.Drawing.Size(65, 108);
            this.listBox1nA.TabIndex = 15;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(36, 331);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(65, 13);
            this.label8.TabIndex = 16;
            this.label8.Text = "N ASIENTO";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(111, 331);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(63, 13);
            this.label9.TabIndex = 18;
            this.label9.Text = "PASAJERO";
            // 
            // listBox2p
            // 
            this.listBox2p.FormattingEnabled = true;
            this.listBox2p.Location = new System.Drawing.Point(111, 347);
            this.listBox2p.Name = "listBox2p";
            this.listBox2p.Size = new System.Drawing.Size(120, 108);
            this.listBox2p.TabIndex = 17;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(249, 331);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(55, 13);
            this.label10.TabIndex = 20;
            this.label10.Text = "DESTINO";
            // 
            // listBox3d
            // 
            this.listBox3d.FormattingEnabled = true;
            this.listBox3d.Location = new System.Drawing.Point(249, 347);
            this.listBox3d.Name = "listBox3d";
            this.listBox3d.Size = new System.Drawing.Size(120, 108);
            this.listBox3d.TabIndex = 19;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(387, 331);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(64, 13);
            this.label11.TabIndex = 22;
            this.label11.Text = "SUBTOTAL";
            // 
            // listBox4st
            // 
            this.listBox4st.FormattingEnabled = true;
            this.listBox4st.Location = new System.Drawing.Point(387, 347);
            this.listBox4st.Name = "listBox4st";
            this.listBox4st.Size = new System.Drawing.Size(120, 108);
            this.listBox4st.TabIndex = 21;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(328, 480);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(42, 13);
            this.label12.TabIndex = 23;
            this.label12.Text = "TOTAL";
            // 
            // textBoxTotal
            // 
            this.textBoxTotal.Location = new System.Drawing.Point(390, 472);
            this.textBoxTotal.Name = "textBoxTotal";
            this.textBoxTotal.Size = new System.Drawing.Size(100, 20);
            this.textBoxTotal.TabIndex = 24;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(533, 518);
            this.Controls.Add(this.textBoxTotal);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.listBox4st);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.listBox3d);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.listBox2p);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.listBox1nA);
            this.Controls.Add(this.textBox2desc);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.listBoxDesc);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.textBox2cantidad);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.textBox2precio);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.listBoxDestino);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.textBox2pasa);
            this.Controls.Add(this.textBox1na);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.groupBox1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBox1na;
        private System.Windows.Forms.TextBox textBox2pasa;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button button3exit;
        private System.Windows.Forms.Button button1add;
        private System.Windows.Forms.Button button2new;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ListBox listBoxDestino;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox textBox2precio;
        private System.Windows.Forms.TextBox textBox2cantidad;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ListBox listBoxDesc;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox textBox2desc;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.ListBox listBox1nA;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.ListBox listBox2p;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.ListBox listBox3d;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.ListBox listBox4st;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.TextBox textBoxTotal;
    }
}

