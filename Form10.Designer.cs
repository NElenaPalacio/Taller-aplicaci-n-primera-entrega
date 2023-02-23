namespace Taller_aplicación
{
    partial class Form10
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // listBox1
            // 
            this.listBox1.FormattingEnabled = true;
            this.listBox1.Items.AddRange(new object[] {
            "HISTORIA CLINICA ",
            "DATOS PERSONALES:",
            "Apellido y Nombre: Irene del Mar Cruz Char",
            "Documento: CC No 1047595143",
            "Fecha de Nacimiento: 7 de Febrero de 1990",
            "País: Colombia",
            "Departamento: Bolivar",
            "Ciudad: Cartagena",
            "Edad: 27 años",
            "Sexo: Femenino",
            "Ocupación: Estudiante  ",
            "Estado Civil: Casada",
            "Dirección: Crespo avenida segunda #75 - 40",
            "Entidad: Colsanitas EPS",
            "Régimen: contributibo ",
            "Religion: Catolica ",
            "Escolaridad: Universitaria ",
            "",
            "ANAMNESISMOTIVO DE CONSULTA:",
            " “amanezco con la cara hinchada”",
            "ENFERMEDAD ACTUAL:  Paciente femenina de 27 años de edad primigestante (G1P0C0A0)" +
                " quien acude a consulta por manifestar edema facial ",
            "bilateral matutino de carácter leve que cede con las horas.",
            "La paciente tambien refiere edema de miembro inferiores grado 2 de carácter vespe" +
                "rtino y cuadros de cefaleas de aproximadamente dos horas ",
            "que ceden al reposo y a la hidratacion. ",
            "ANTECEDENTES HEREDOFAMILIARES:",
            " Padre: (vive) hiperuricemia",
            "Madre: (vive) ",
            "ANTECEDENTES PERSONALES: ",
            " Hábitos Tóxicos:",
            " Alcohol: niega",
            "Tabaco: niega ",
            "Drogas: niega",
            "Infusiones: niega  ",
            "Fisiológicos: ",
            "Alimentación: 4 comidas al día, de preparacion en casa",
            "Desayuno: 1 taza de café con leche, 1 vaso de jugo de naranja, media porcion de p" +
                "apaya y una arepa de quinoa y linaza"});
            this.listBox1.Location = new System.Drawing.Point(12, 9);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(721, 485);
            this.listBox1.TabIndex = 0;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(16, 503);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 1;
            this.button1.Text = "Cancelar";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(632, 503);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 2;
            this.button2.Text = "<Anterior";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(713, 503);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(75, 23);
            this.button3.TabIndex = 3;
            this.button3.Text = "Siguiente>";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(97, 503);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(75, 23);
            this.button4.TabIndex = 4;
            this.button4.Text = "Editar ";
            this.button4.UseVisualStyleBackColor = true;
            // 
            // button5
            // 
            this.button5.Location = new System.Drawing.Point(178, 503);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(75, 23);
            this.button5.TabIndex = 5;
            this.button5.Text = "Guardar";
            this.button5.UseVisualStyleBackColor = true;
            // 
            // Form10
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 538);
            this.Controls.Add(this.button5);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.listBox1);
            this.Name = "Form10";
            this.Text = "Historial Impreso";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button5;
    }
}