namespace Ejercicio2_CalculoHorasTrabajadas
{
    partial class Form1
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
            this.label1 = new System.Windows.Forms.Label();
            this.labelSueldoHora = new System.Windows.Forms.Label();
            this.labelSueldoMes = new System.Windows.Forms.Label();
            this.labelHorasDias = new System.Windows.Forms.Label();
            this.labelDiasSemana = new System.Windows.Forms.Label();
            this.labelHorasSemana = new System.Windows.Forms.Label();
            this.salaryPerHour = new System.Windows.Forms.TextBox();
            this.salaryPerMonth = new System.Windows.Forms.TextBox();
            this.hourPerWeek = new System.Windows.Forms.TextBox();
            this.txtMessage = new System.Windows.Forms.TextBox();
            this.btnCal = new System.Windows.Forms.Button();
            this.btnClear = new System.Windows.Forms.Button();
            this.btnExit = new System.Windows.Forms.Button();
            this.comboBoxHourPerDay = new System.Windows.Forms.ComboBox();
            this.comboBoxDaysPerWeek = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(245, 26);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(309, 24);
            this.label1.TabIndex = 0;
            this.label1.Text = "Calculadora de Salario por Hora";
            // 
            // labelSueldoHora
            // 
            this.labelSueldoHora.AutoSize = true;
            this.labelSueldoHora.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelSueldoHora.Location = new System.Drawing.Point(87, 109);
            this.labelSueldoHora.Name = "labelSueldoHora";
            this.labelSueldoHora.Size = new System.Drawing.Size(134, 18);
            this.labelSueldoHora.TabIndex = 1;
            this.labelSueldoHora.Text = "Sueldo por hora:";
            // 
            // labelSueldoMes
            // 
            this.labelSueldoMes.AutoSize = true;
            this.labelSueldoMes.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelSueldoMes.Location = new System.Drawing.Point(87, 205);
            this.labelSueldoMes.Name = "labelSueldoMes";
            this.labelSueldoMes.Size = new System.Drawing.Size(132, 18);
            this.labelSueldoMes.TabIndex = 2;
            this.labelSueldoMes.Text = "Sueldo por mes:";
            // 
            // labelHorasDias
            // 
            this.labelHorasDias.AutoSize = true;
            this.labelHorasDias.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelHorasDias.Location = new System.Drawing.Point(87, 310);
            this.labelHorasDias.Name = "labelHorasDias";
            this.labelHorasDias.Size = new System.Drawing.Size(116, 18);
            this.labelHorasDias.TabIndex = 3;
            this.labelHorasDias.Text = "Horas por dia:";
            // 
            // labelDiasSemana
            // 
            this.labelDiasSemana.AutoSize = true;
            this.labelDiasSemana.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelDiasSemana.Location = new System.Drawing.Point(323, 310);
            this.labelDiasSemana.Name = "labelDiasSemana";
            this.labelDiasSemana.Size = new System.Drawing.Size(141, 18);
            this.labelDiasSemana.TabIndex = 4;
            this.labelDiasSemana.Text = "Dias por semana:";
            // 
            // labelHorasSemana
            // 
            this.labelHorasSemana.AutoSize = true;
            this.labelHorasSemana.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelHorasSemana.Location = new System.Drawing.Point(559, 310);
            this.labelHorasSemana.Name = "labelHorasSemana";
            this.labelHorasSemana.Size = new System.Drawing.Size(153, 18);
            this.labelHorasSemana.TabIndex = 5;
            this.labelHorasSemana.Text = "Horas por semana:";
            // 
            // salaryPerHour
            // 
            this.salaryPerHour.Location = new System.Drawing.Point(88, 140);
            this.salaryPerHour.Multiline = true;
            this.salaryPerHour.Name = "salaryPerHour";
            this.salaryPerHour.Size = new System.Drawing.Size(131, 35);
            this.salaryPerHour.TabIndex = 6;
            // 
            // salaryPerMonth
            // 
            this.salaryPerMonth.Location = new System.Drawing.Point(90, 238);
            this.salaryPerMonth.Multiline = true;
            this.salaryPerMonth.Name = "salaryPerMonth";
            this.salaryPerMonth.ReadOnly = true;
            this.salaryPerMonth.Size = new System.Drawing.Size(131, 35);
            this.salaryPerMonth.TabIndex = 7;
            // 
            // hourPerWeek
            // 
            this.hourPerWeek.Location = new System.Drawing.Point(562, 347);
            this.hourPerWeek.Multiline = true;
            this.hourPerWeek.Name = "hourPerWeek";
            this.hourPerWeek.ReadOnly = true;
            this.hourPerWeek.Size = new System.Drawing.Size(131, 35);
            this.hourPerWeek.TabIndex = 10;
            // 
            // txtMessage
            // 
            this.txtMessage.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtMessage.ForeColor = System.Drawing.Color.DarkGreen;
            this.txtMessage.Location = new System.Drawing.Point(326, 140);
            this.txtMessage.Multiline = true;
            this.txtMessage.Name = "txtMessage";
            this.txtMessage.Size = new System.Drawing.Size(386, 93);
            this.txtMessage.TabIndex = 11;
            this.txtMessage.Text = "<= Introduzca el sueldo por hora para obtener el salario mensual.";
            // 
            // btnCal
            // 
            this.btnCal.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCal.Location = new System.Drawing.Point(93, 436);
            this.btnCal.Name = "btnCal";
            this.btnCal.Size = new System.Drawing.Size(165, 46);
            this.btnCal.TabIndex = 14;
            this.btnCal.Text = "Calcular";
            this.btnCal.UseVisualStyleBackColor = true;
            this.btnCal.Click += new System.EventHandler(this.btnCal_Click);
            // 
            // btnClear
            // 
            this.btnClear.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnClear.Location = new System.Drawing.Point(326, 436);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(165, 46);
            this.btnClear.TabIndex = 15;
            this.btnClear.Text = "Limpiar";
            this.btnClear.UseVisualStyleBackColor = true;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // btnExit
            // 
            this.btnExit.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnExit.Location = new System.Drawing.Point(562, 436);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(165, 46);
            this.btnExit.TabIndex = 16;
            this.btnExit.Text = "Salir";
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // comboBoxHourPerDay
            // 
            this.comboBoxHourPerDay.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBoxHourPerDay.FormattingEnabled = true;
            this.comboBoxHourPerDay.Items.AddRange(new object[] {
            "1",
            "2",
            "3",
            "4",
            "5",
            "6",
            "7",
            "8",
            "9",
            "10",
            "11",
            "12",
            "13",
            "14",
            "15",
            "16",
            "17",
            "18",
            "19",
            "20",
            "21",
            "22",
            "23",
            "24"});
            this.comboBoxHourPerDay.Location = new System.Drawing.Point(90, 358);
            this.comboBoxHourPerDay.Name = "comboBoxHourPerDay";
            this.comboBoxHourPerDay.Size = new System.Drawing.Size(128, 24);
            this.comboBoxHourPerDay.TabIndex = 17;
            // 
            // comboBoxDaysPerWeek
            // 
            this.comboBoxDaysPerWeek.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBoxDaysPerWeek.FormattingEnabled = true;
            this.comboBoxDaysPerWeek.Items.AddRange(new object[] {
            "1",
            "2",
            "3",
            "4",
            "5",
            "6",
            "7"});
            this.comboBoxDaysPerWeek.Location = new System.Drawing.Point(326, 358);
            this.comboBoxDaysPerWeek.Name = "comboBoxDaysPerWeek";
            this.comboBoxDaysPerWeek.Size = new System.Drawing.Size(128, 24);
            this.comboBoxDaysPerWeek.TabIndex = 18;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 536);
            this.Controls.Add(this.comboBoxDaysPerWeek);
            this.Controls.Add(this.comboBoxHourPerDay);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.btnClear);
            this.Controls.Add(this.btnCal);
            this.Controls.Add(this.txtMessage);
            this.Controls.Add(this.hourPerWeek);
            this.Controls.Add(this.salaryPerMonth);
            this.Controls.Add(this.salaryPerHour);
            this.Controls.Add(this.labelHorasSemana);
            this.Controls.Add(this.labelDiasSemana);
            this.Controls.Add(this.labelHorasDias);
            this.Controls.Add(this.labelSueldoMes);
            this.Controls.Add(this.labelSueldoHora);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label labelSueldoHora;
        private System.Windows.Forms.Label labelSueldoMes;
        private System.Windows.Forms.Label labelHorasDias;
        private System.Windows.Forms.Label labelDiasSemana;
        private System.Windows.Forms.Label labelHorasSemana;
        private System.Windows.Forms.TextBox salaryPerHour;
        private System.Windows.Forms.TextBox salaryPerMonth;
        private System.Windows.Forms.TextBox hourPerWeek;
        private System.Windows.Forms.TextBox txtMessage;
        private System.Windows.Forms.Button btnCal;
        private System.Windows.Forms.Button btnClear;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.ComboBox comboBoxHourPerDay;
        private System.Windows.Forms.ComboBox comboBoxDaysPerWeek;
    }
}

