using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ejercicio2_CalculoHorasTrabajadas
{
    public partial class Form1 : Form
    {
        double valueSalaryPerHour, valueSalaryPerMonth, valueHourPerDay, valueDaysPerWeek, valueHourPerWeek;
        string valTxtMessage;
        public Form1()
        {
            InitializeComponent();

            comboBoxHourPerDay.SelectedIndex = comboBoxHourPerDay.Items.Count - 17;
            comboBoxDaysPerWeek.SelectedIndex = comboBoxDaysPerWeek.Items.Count - 3;
        }

        private void btnCal_Click(object sender, EventArgs e)
        {
            //Asignar valor a las variables
            valueSalaryPerHour = Convert.ToInt32(salaryPerHour.Text);
            valueHourPerDay = Convert.ToInt32(comboBoxHourPerDay.SelectedItem);
            valueDaysPerWeek = Convert.ToInt32(comboBoxDaysPerWeek.SelectedItem);

            //Calculos matematicos
            valueHourPerWeek = valueHourPerDay * valueDaysPerWeek;
            valueSalaryPerMonth = (valueSalaryPerHour * valueHourPerWeek) * 4.5;
            valTxtMessage = "$" + valueSalaryPerHour + " por hora es igual a " + "$" + valueSalaryPerMonth + " por mes. (Si trabaja " + valueHourPerDay + " horas por dia, " + valueDaysPerWeek + " dias por semana, es decir " + valueHourPerWeek + " horas por semana).";


            //Mostrar los resultados
            this.hourPerWeek.Text = valueHourPerWeek.ToString();
            this.salaryPerMonth.Text = valueSalaryPerMonth.ToString();
            this.txtMessage.Text = valTxtMessage.ToString();
        }


        //Función que cierra la aplicación
        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        //Función que limpia todos los campos
        private void btnClear_Click(object sender, EventArgs e)
        {
            salaryPerHour.Clear();
            salaryPerMonth.Clear();
            hourPerWeek.Clear();
            comboBoxHourPerDay.SelectedIndex = comboBoxHourPerDay.Items.Count - 17;
            comboBoxDaysPerWeek.SelectedIndex = comboBoxDaysPerWeek.Items.Count - 3;
            txtMessage.Clear();

            valTxtMessage = "<= Introduzca el sueldo por hora para obtener el salario mensual.";
            this.txtMessage.Text = valTxtMessage.ToString();


        }
    }
}
