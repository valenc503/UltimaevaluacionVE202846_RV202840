using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EvaluacionFinal_RV202840_VE202846
{
    class ClsPlantilla
    {
        /*

       *--------------------------------
* Atributos
* --------------------------------
* Define avance de generacion planilla contable
*/
        private int Estado;//Valores:1.Sin iniciar,2.En proceso,3.Finalizada
                           //Identificacion de propietario de planilla
        private String Empresa;
        private DateTime FechaPlanilla;
        //Diccionario de objetos con informe de c/u de los empleados
        private Dictionary<int, ClsEmpleado> Listaempleados = new Dictionary<int, ClsEmpleado>();
        //Totales finales al generar planilla
        private int TotalEmpleados;


        //METODO CONSTRUCTOR
        public ClsPlantilla()
        {
            Estado = 1;//planilla sin autorizacion de apertura.
            Empresa = "";//empresa que requiere planilla.
            FechaPlanilla = DateTime.Now;//asume que planilla se inicia hoy mismo.
            TotalEmpleados = 0;//ningun empleado registrado.
        }

        //METODO AbrirPlanilla
        public void AbrirPlanilla(DateTime fechaInicio, string nombreempresa = "(Sin nombre)")
        {
            /*Activa una nueva planilla
            evalua estado actual del objeto*/
            nombreempresa = nombreempresa.Trim();
            switch (Estado)
            {
                case 1:
                    //Asigna atributos para identificacion de planilla
                    FechaPlanilla = fechaInicio;
                    if (nombreempresa.Length > 0)
                    {
                        Empresa = nombreempresa;
                    }
                    Estado = 2;//Estado planilla ya esta activa en proceso
                    MessageBox.Show("Planilla Abierta, inicie registro empleados", "Planilla   de " + Empresa + ", APERTURA: " + FechaPlanilla.ToString());
                    break;
                case 2:
                    //La planilla ya esta activa, se le indica a usuario
                    MessageBox.Show("Planilla ya esta abierta desde el: " + FechaPlanilla.ToString(), "Planilla de " + Empresa);
                    break;
                case 3:
                    //La planilla ya finalizo
                    MessageBox.Show("Planilla creada el" + FechaPlanilla.ToString() + " ya se cerro", "Planilla de" + Empresa);
                    break;
            }
        }
        //METODO RecibirEmpleado
        public void RecibirEmpleado(ClsEmpleado nuevoEmpleado)
        {
            /*Agrega trabajador recibido al dictionay de empleados de la planilla
            evalua que Estado Actual de planilla sea 2 (En proceso)*/
            if (Estado == 2)
            {
                //Evalua si ha recibido un trabajdor con todos sus datos completos
                if (nuevoEmpleado.datospersonales_aceptados == false)
                {
                    MessageBox.Show("Error, datos personales estan incompletos", "Control planilla");
                    return;
                }
                if (nuevoEmpleado.datoslaborales_aceptados == false)
                {
                    MessageBox.Show("Error, datos laborales estan incompletos", "Control planilla");
                    return;
                }
                //Registra un nuevo empleado al listado de la planilla abierta
                TotalEmpleados += 1;
                Listaempleados.Add(TotalEmpleados, nuevoEmpleado);
            }
            else
            {
                MessageBox.Show("Planilla aun no esta abierta", "Planilla de" + Empresa);
                return;
            }
        }
        //METODO GenerarListado
        public void GenerarListado(ref DataGridView cuadro)
        {
            //se prepara a generar y mostrar lista en objeto Datagridview recibido en parametro
            int i = 1;
            string sb = "0";
            string sn = "0";
            //Evalua si planilla AUN no esta abierta!!
            switch (Estado)
            {
                case 1:
                    MessageBox.Show("Planilla aun no ha sido abierta", "Planilla" + Empresa);
                    
                    return;
                    break;
                case 2:
                    //evalua si listado esta vacio
                    if (TotalEmpleados == 0)
                    {
                        MessageBox.Show("Planilla no tiene aun empleados registrados", "Planilla de " + Empresa);
                        return;
                    }
                    Estado = 3;
                    MessageBox.Show("Planilla cerrada con " + TotalEmpleados + "empleados", "Planilla de " + Empresa);

                    MessageBox.Show("Planilla abierta el " + FechaPlanilla.ToString() + " se muestra ahora!!", "Planilla de " + Empresa);
                    break;
            }
            //Finaliza planilla activa y la genera en un datagrid
            cuadro.Rows.Clear();
            cuadro.Columns.Clear();
            cuadro.Columns.Add("id", "num");
            cuadro.Columns.Add("nom", "nombre completo");
            cuadro.Columns.Add("sb", "sueldo base");
            cuadro.Columns.Add("sf", "sueldo neto final");
            //Alternar colores de datagridview
            cuadro.RowsDefaultCellStyle.BackColor = System.Drawing.Color.Bisque;
            cuadro.AlternatingRowsDefaultCellStyle.BackColor = System.Drawing.Color.Beige;
            //comienza a llenar filas del grid con los datos de c/empleado registrado en  planilla
            foreach (var result in Listaempleados)
            {
                cuadro.Rows.Add();
                cuadro.Rows[i - 1].Cells[0].Value = result.Key;
                cuadro.Rows[i - 1].Cells[1].Value = result.Value.nombrecompleto;
                result.Value.VerSueldos(ref sb, ref sn);
                cuadro.Rows[i - 1].Cells[2].Value = sb;
                cuadro.Rows[i - 1].Cells[3].Value = sn;
                i++;
            }
            MessageBox.Show("Planilla de pago final completa generada en pantalla!!");
        }
        //PROPIEDAD(procedimientos de propiedad)
        public string TotaldeEmpleado
        {
            get
            {
                return TotalEmpleados.ToString();
            }
        }
    }
}
