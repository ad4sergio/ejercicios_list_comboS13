namespace WindowsFormsSEMANA13._1
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
            this.label3 = new System.Windows.Forms.Label();
            this.comboBox1cat = new System.Windows.Forms.ComboBox();
            this.comboBox2prom = new System.Windows.Forms.ComboBox();
            this.textBox1name = new System.Windows.Forms.TextBox();
            this.button1save = new System.Windows.Forms.Button();
            this.button2new = new System.Windows.Forms.Button();
            this.button3exit = new System.Windows.Forms.Button();
            this.listBox1names = new System.Windows.Forms.ListBox();
            this.listBox2men = new System.Windows.Forms.ListBox();
            this.listBox3desc = new System.Windows.Forms.ListBox();
            this.listBox4total = new System.Windows.Forms.ListBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(42, 36);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(130, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "NOMBRE DEL ALUMNO:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(39, 75);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(142, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "SELECCIONE CATEGORÍA:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(39, 111);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(138, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "SELECCIONE PROMEDIO:";
            // 
            // comboBox1cat
            // 
            this.comboBox1cat.FormattingEnabled = true;
            this.comboBox1cat.Location = new System.Drawing.Point(199, 72);
            this.comboBox1cat.Name = "comboBox1cat";
            this.comboBox1cat.Size = new System.Drawing.Size(269, 21);
            this.comboBox1cat.TabIndex = 3;
            // 
            // comboBox2prom
            // 
            this.comboBox2prom.FormattingEnabled = true;
            this.comboBox2prom.Location = new System.Drawing.Point(199, 102);
            this.comboBox2prom.Name = "comboBox2prom";
            this.comboBox2prom.Size = new System.Drawing.Size(269, 21);
            this.comboBox2prom.TabIndex = 4;
            // 
            // textBox1name
            // 
            this.textBox1name.Location = new System.Drawing.Point(199, 33);
            this.textBox1name.Name = "textBox1name";
            this.textBox1name.Size = new System.Drawing.Size(269, 20);
            this.textBox1name.TabIndex = 5;
            this.textBox1name.Leave += new System.EventHandler(this.textBox1name_Leave);
            // 
            // button1save
            // 
            this.button1save.Location = new System.Drawing.Point(42, 155);
            this.button1save.Name = "button1save";
            this.button1save.Size = new System.Drawing.Size(135, 28);
            this.button1save.TabIndex = 6;
            this.button1save.Text = "GUARDAR";
            this.button1save.UseVisualStyleBackColor = true;
            this.button1save.Click += new System.EventHandler(this.button1save_Click);
            // 
            // button2new
            // 
            this.button2new.Location = new System.Drawing.Point(192, 155);
            this.button2new.Name = "button2new";
            this.button2new.Size = new System.Drawing.Size(135, 28);
            this.button2new.TabIndex = 7;
            this.button2new.Text = "NUEVO";
            this.button2new.UseVisualStyleBackColor = true;
            this.button2new.Click += new System.EventHandler(this.button2new_Click);
            // 
            // button3exit
            // 
            this.button3exit.Location = new System.Drawing.Point(333, 155);
            this.button3exit.Name = "button3exit";
            this.button3exit.Size = new System.Drawing.Size(135, 28);
            this.button3exit.TabIndex = 8;
            this.button3exit.Text = "SALIR";
            this.button3exit.UseVisualStyleBackColor = true;
            this.button3exit.Click += new System.EventHandler(this.button3exit_Click);
            // 
            // listBox1names
            // 
            this.listBox1names.FormattingEnabled = true;
            this.listBox1names.Location = new System.Drawing.Point(42, 230);
            this.listBox1names.Name = "listBox1names";
            this.listBox1names.Size = new System.Drawing.Size(131, 134);
            this.listBox1names.TabIndex = 9;
            // 
            // listBox2men
            // 
            this.listBox2men.FormattingEnabled = true;
            this.listBox2men.Location = new System.Drawing.Point(179, 230);
            this.listBox2men.Name = "listBox2men";
            this.listBox2men.Size = new System.Drawing.Size(120, 134);
            this.listBox2men.TabIndex = 10;
            // 
            // listBox3desc
            // 
            this.listBox3desc.FormattingEnabled = true;
            this.listBox3desc.Location = new System.Drawing.Point(305, 230);
            this.listBox3desc.Name = "listBox3desc";
            this.listBox3desc.Size = new System.Drawing.Size(120, 134);
            this.listBox3desc.TabIndex = 11;
            // 
            // listBox4total
            // 
            this.listBox4total.FormattingEnabled = true;
            this.listBox4total.Location = new System.Drawing.Point(431, 230);
            this.listBox4total.Name = "listBox4total";
            this.listBox4total.Size = new System.Drawing.Size(120, 134);
            this.listBox4total.TabIndex = 12;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(42, 211);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(54, 13);
            this.label4.TabIndex = 13;
            this.label4.Text = "NOMBRE";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(176, 211);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(85, 13);
            this.label5.TabIndex = 14;
            this.label5.Text = "MENSUALIDAD";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(302, 211);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(74, 13);
            this.label6.TabIndex = 15;
            this.label6.Text = "DESCUENTO";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(428, 211);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(42, 13);
            this.label7.TabIndex = 16;
            this.label7.Text = "TOTAL";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(576, 404);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.listBox4total);
            this.Controls.Add(this.listBox3desc);
            this.Controls.Add(this.listBox2men);
            this.Controls.Add(this.listBox1names);
            this.Controls.Add(this.button3exit);
            this.Controls.Add(this.button2new);
            this.Controls.Add(this.button1save);
            this.Controls.Add(this.textBox1name);
            this.Controls.Add(this.comboBox2prom);
            this.Controls.Add(this.comboBox1cat);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox comboBox1cat;
        private System.Windows.Forms.ComboBox comboBox2prom;
        public System.Windows.Forms.TextBox textBox1name;
        private System.Windows.Forms.Button button1save;
        private System.Windows.Forms.Button button2new;
        private System.Windows.Forms.Button button3exit;
        private System.Windows.Forms.ListBox listBox1names;
        private System.Windows.Forms.ListBox listBox2men;
        private System.Windows.Forms.ListBox listBox3desc;
        private System.Windows.Forms.ListBox listBox4total;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
    }
}

