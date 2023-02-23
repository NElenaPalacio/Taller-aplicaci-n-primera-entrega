namespace Taller_aplicación
{
    partial class Form11
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
            this.SuspendLayout();
            // 
            // listBox1
            // 
            this.listBox1.FormattingEnabled = true;
            this.listBox1.Items.AddRange(new object[] {
            "EN GENERAL:",
            "",
            "El personal siempre DEBE aplicar su opinión profesional independiente y mantener " +
                "el más alto nivel de conducta profesional.",
            "El personal DEBE respetar el derecho del paciente competente a aceptar o rechazar" +
                " un tratamiento.",
            "El personal NO DEBE permitir que su opinión sea influenciada por beneficio person" +
                "al o discriminación injusta.",
            "El personal DEBE dedicarse a proporcionar un servicio médico competente, con plen" +
                "a independencia",
            " profesional y moral, con compasión y respeto por la dignidad humana.",
            "El personal DEBE tratar con honestidad a pacientes y colegas, e informar a las au" +
                "toridades apropiadas sobre los médicos que practiquen en",
            " forma antiética e incompetente o a los que incurran en fraude o engaño.",
            "El personal NO DEBE recibir ningún beneficio financiero ni otros incentivos sólo " +
                "por derivar pacientes o prescribir productos específicos.",
            "El personal DEBE respetar los derechos y preferencias del paciente, de los colega" +
                "s y de otros profesionales de la salud.",
            "El personal DEBE reconocer su importante función en la educación de la opinión pú" +
                "blica, pero debe obrar con la debida cautela al divulgar ",
            "descubrimientos o nuevas técnicas, o tratamientos a través de canales no profesio" +
                "nales.",
            "El personal DEBE certificar sólo lo que ha verificado personalmente.",
            "El personal DEBE esforzarse por utilizar los recursos de salud de la mejor manera" +
                " para beneficio de los pacientes y su comunidad."});
            this.listBox1.Location = new System.Drawing.Point(33, 21);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(676, 212);
            this.listBox1.TabIndex = 0;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(537, 265);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 1;
            this.button1.Text = "Imprimir";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(634, 265);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 2;
            this.button2.Text = "Regresar";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // Form11
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(744, 300);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.listBox1);
            this.Name = "Form11";
            this.Text = "Derechos y Deberes de los empleados ";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
    }
}