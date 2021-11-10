using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EvaluacionFinal_RV202840_VE202846
{
    class ClsEmpleado
    {
        /*
*--------------------------------
* Atributos
* --------------------------------
* Datos Personales */
        private string Nombres;
        private string Apellidos;
        private DateTime FechaNacimiento;
        private int Edad;
        //Datos Laborales
        private DateTime FechaContratacion;
        private decimal TasaIsss;
        private decimal TasaRenta;
        private decimal SueldoBase;
        private decimal SueldoFinal;
        //Banderas: indican estado registro de datos de c/empleado
        private Boolean DatosCompletos;
        private Boolean DatosLaboralesListos;
        /*
        *--------------------------------
 * PROPIEDADES
 * --------------------------------
 * Propiedades(Procedimiento de Propiedad) */
        public string nombrecompleto
        {
            get
            {
                return Apellidos + "," + Nombres;
            }
        }
        public Boolean datospersonales_aceptados
        {
            get
            {
                return DatosCompletos;
            }
        }
        public Boolean datoslaborales_aceptados
        {
            get
            {
                return DatosLaboralesListos;
            }
        }
        /*
         *--------------------------------
         * METODOS
         * --------------------------------
         * Metodo Constructor*/
        public ClsEmpleado()
        {
            TasaIsss = 3; //3% por defecto
            TasaRenta = 10; //10% por defecto
            FechaContratacion = DateTime.Now;
            //Establece que sus datos personales y laborales aun no han sido registrados
            DatosCompletos = false;
            DatosLaboralesListos = false;
        }
        //METODOS DefinirDatosPersonales
        public void DefinirDatosPersonales(string nom, string apel1, DateTime fechanac)
        {
            /*Recibe c/dato personal, para evaluar si son correctos y
            asignarlos a los atributos internos*/
            long totalannos;//diferencia años entre 2 fechas cualquiera
            DatosCompletos = false; //asume datos recibidos son incorrectos
            nom = nom.Trim();
            if (nom.Length == 0)
            {
                MessageBox.Show("Falta ingresar nombres a empleados");
                return;
            }
            else
            {
                Nombres = nom;//asigna parametro recibido a atributo nombres
            }
            apel1 = apel1.Trim();
            if (apel1.Length == 0)
            {
                MessageBox.Show("Falta ingresar apellidos de empleado");
                return;
            }
            else
            {
                Apellidos = apel1;//asigna parametro recibido a atributo nombres
            }
            //determina si fecha nacimiento esta ubicada 18(min) hasta 50(max) años
            //antes de la fecha actual del SO de la PC
            totalannos = DateTime.Now.Year - fechanac.Year;
            if (totalannos > 50)
            {
                MessageBox.Show("ERROR:Empleado debe jubilarse,segun codigo de trabajo de ES");
                return;
            }
            else if (totalannos > 0 && totalannos < 18)
            {
                MessageBox.Show("ERROR:Persona menor de edad segun codigo trabajo de ES");
                return;
            }
            else if (totalannos < 0)
            {
                MessageBox.Show("ERROR:Revise fecha de nacimiento ingresada");
                return;
            }
            else
            {
                FechaNacimiento = fechanac;
                Edad = Convert.ToInt32(totalannos);
            }
            DatosCompletos = true;
        }

        public void DefinirDatosLaborales(DateTime fechacontrato, decimal sueldoinic)
        {
            //Recibe datos laborales de empleado(fecha contratacion y sueldo base)
            long totalannos;//diferencia años entre 2 fechas cualquiera
            DateTime fechainic18;//fecha min laboral de empleado segun du fecha nacimiento
            DatosLaboralesListos = false;
            //Antes de continuar, evalua si datos personales estan incompletos.
            if (!(DatosCompletos))
            {
                MessageBox.Show("Datos laborales no aceptados", "ERROR", MessageBoxButtons.OK,
               MessageBoxIcon.Error);
                MessageBox.Show("Antes de continuar, Revise los datos personales", "Información", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            /* Revisa datos laborales recibidos en parametros.
            * Determina si diferencia fecha contrato esta ubicada entre 18 años despues
            * de la fecha nacimiento de empleado(edad min. laboral) y hasta la fecha de hoy
            */
            fechainic18 = FechaNacimiento.AddYears(18);
            totalannos = fechacontrato.Year - DateTime.Now.Year;

            if (fechacontrato < fechainic18)
            {
                MessageBox.Show("Fecha contrato debe ser posterior al" + fechainic18);
                return;
            }
            else if (fechacontrato > DateTime.Now)
            {
                MessageBox.Show("Fecha contrato valida solo entre " + fechainic18 + "y hoy" +
               DateTime.Now.ToString());
                return;
            }
            else
            {
                SueldoBase = sueldoinic;
            }
            //Datos laborales son correctos y completos
            DatosLaboralesListos = true;
            CalcularSueldoNeto();
        }
        ///
        public void AsignarDescuentos(decimal isss = 2.50m, decimal renta = 10.50m)
        {
            //Evalua procentaje recibidos en parametros
            if (isss > 2.50m && isss < 40)
            {
                TasaIsss = isss;//asigna tasa del isss recibido en parametros
            }
            else
            {
                MessageBox.Show("Porcentaje de isss incorrecto, se usara" +
               TasaIsss.ToString() + " %");
            }
            if (renta > 10.5m && renta < 40)
            {
                TasaRenta = renta;
            }
            else
            {
                TasaRenta = 10.5m;//asigna tasa 10.5% predeterminado
            }
        }
        public void VerSueldos(ref string sb, ref string sf)
        {
            //Retorna valores de sueldo base y final de empleado
            sb = SueldoBase.ToString();
            sf = SueldoFinal.ToString();
        }
        private void CalcularSueldoNeto()
        {
            //Hace los calculos de su propio sueldo neto
            decimal Desc;
            SueldoFinal = SueldoBase;
            Desc = SueldoBase * (TasaIsss / 100);
            SueldoFinal -= Desc;
            Desc = SueldoBase * (TasaRenta / 100);
            SueldoFinal -= Desc;
        }
    }
}
