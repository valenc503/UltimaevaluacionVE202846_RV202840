using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EvaluacionFinal_RV202840_VE202846
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        ClsPlantilla planillaEPSON = new ClsPlantilla();
        string ess;
        int contador=0;
        private void btnNuevo_Click(object sender, EventArgs e)
        {
            //deja controles en blanco para un proximo empleado
            txtNombres.Clear();
            txtApellidos.Clear();
            txtSueldoini.Clear();
            nudISSS.Value = 0;
            nudRenta.Value = 0;
            dtpFechaContrato.Value = DateTime.Now;
            dtpFechaNac.Value = DateTime.Now;
            groupBox1.Enabled = true;
            groupBox2.Enabled = true;
            btnNuevo.Enabled = false;
            btnAceptar.Enabled = true;
            txtNombres.Focus();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            try
            {
                //define fecha min y max que podra seleccionar en dtpFechaNac
                DateTime fecha = DateTime.Now;
                dtpFechaNac.MinDate = fecha.AddYears(-70);
                dtpFechaNac.MaxDate = fecha.AddYears(15);
                groupBox1.Enabled = false;
                groupBox2.Enabled = false;
                btnNuevo.Enabled = false;
                btnAceptar.Enabled = false;
                btnGenerarPlanilla.Enabled = false;
                btnNuevo.Focus();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnAceptar_Click(object sender, EventArgs e)
        {
            if (contador == 10)
            {
                DateTime fecha = DateTime.Now;
                dtpFechaNac.MinDate = fecha.AddYears(-70);
                dtpFechaNac.MaxDate = fecha.AddYears(15);
                groupBox1.Enabled = false;
                groupBox2.Enabled = false;
                btnNuevo.Enabled = false;
                btnGenerarPlanilla.Enabled = false;  
            }
            else
            {


                try
                {
                    //se prepara a registrar un nuevo empleado
                    ClsEmpleado trabajador = new ClsEmpleado();//Crea un objeto de la clase ClsEmpleado
                    trabajador.DefinirDatosPersonales(txtNombres.Text, txtApellidos.Text, dtpFechaNac.Value);
                    //Empleado será aceptado hasta que objeto trabajador lo confirme
                    if (trabajador.datospersonales_aceptados)
                    {
                        /*Tranfiere datos laborales, para que confirme si son correctos
                        evalua si ha escrito mal el sueldo inicial*/
                        if (!(Int32.Parse(txtSueldoini.Text) >= 0))
                        {
                            MessageBox.Show("ERROR, Sueldo inicial no valido");
                            txtSueldoini.Focus();
                            return;
                        }
                        //evalua si valor tasa isss es incorrecto
                        if (nudRenta.Value <= 0.0m)
                        {
                            MessageBox.Show("ERROR, revise tasa renta");
                            nudRenta.Focus();
                            return;
                        }
                        //evalua si valor tasa isss es incorrecto
                        if (nudISSS.Value <= 0.0m)
                        {
                            MessageBox.Show("ERROR, revise tasa ISSS");
                            nudISSS.Focus();
                            return;
                        }
                        trabajador.DefinirDatosLaborales(dtpFechaContrato.Value,
                        Convert.ToDecimal(txtSueldoini.Text));
                        if (trabajador.datoslaborales_aceptados)
                        {
                            trabajador.AsignarDescuentos(Convert.ToDecimal(nudISSS.Text),
                           Convert.ToDecimal(nudRenta.Text));
                            planillaEPSON.RecibirEmpleado(trabajador);
                            groupBox1.Enabled = false;
                            groupBox2.Enabled = false;
                            btnNuevo.Enabled = true;
                            btnAceptar.Enabled = false;
                            btnNuevo.Focus();
                        }
                        else
                        {
                            txtNombres.Focus();
                        }
                    }
                    else
                    {
                        txtNombres.Focus();
                    }
                }
                catch (Exception ess)
                {
                    MessageBox.Show(ess.Message);
                    contador += 1;
                }
            }
        }

        private void btnAbrirPlanilla_Click(object sender, EventArgs e)
        {
            btnNuevo.Enabled = true;
            btnGenerarPlanilla.Enabled = true;
            //Activa planilla actual, para que se agreguen los N empleados
            planillaEPSON.AbrirPlanilla(DateTime.Now, "Epson Internacional");
        }

        private void btnGenerarPlanilla_Click(object sender, EventArgs e)
        {
            //Finaliza ingreso empleados, para poder generar planilla completa!!
            planillaEPSON.GenerarListado(ref dataGridView1);
        }

        private void txtNombres_KeyPress(object sender, KeyPressEventArgs e)
        {
            //solo letras
            if (!(char.IsLetter(e.KeyChar)) && (e.KeyChar != (char)Keys.Back))
            {
                MessageBox.Show("Solo se permiten letras", "Advertencia",
               MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                e.Handled = true;
                return;
            }
        }

        private void txtApellidos_KeyPress(object sender, KeyPressEventArgs e)
        {
            //solo letras
            if (!(char.IsLetter(e.KeyChar)) && (e.KeyChar != (char)Keys.Back))
            {
                MessageBox.Show("Solo se permiten letras", "Advertencia",
               MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                e.Handled = true;
                return;
            }
        }

        private void txtSueldoini_KeyPress(object sender, KeyPressEventArgs e)
        {
            //solo numeros
            if (!(char.IsNumber(e.KeyChar)) && (e.KeyChar != (char)Keys.Back))
            {
                MessageBox.Show("Solo se permiten numeros", "Advertencia",
               MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                e.Handled = true;
                return;
            }
        }

        private void nudRenta_KeyPress(object sender, KeyPressEventArgs e)
        {
            //solo numeros
            if (!(char.IsNumber(e.KeyChar)) && (e.KeyChar != (char)Keys.Back))
            {
                MessageBox.Show("Solo se permiten numeros", "Advertencia",
               MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                e.Handled = true;
                return;
            }
        }

        private void nudISSS_KeyPress(object sender, KeyPressEventArgs e)
        {
            //solo numeros
            if (!(char.IsNumber(e.KeyChar)) && (e.KeyChar != (char)Keys.Back))
            {
                MessageBox.Show("Solo se permiten numeros", "Advertencia",
               MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                e.Handled = true;
                return;
            }
        }
    }
}
