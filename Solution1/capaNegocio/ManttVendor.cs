using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CapaDatos;
namespace capaNegocio
{
    public class ManttVendor
    {
        bdConex test= new bdConex();
        private String codVendor, nombreVendor;

        public String NombreVendor
        {
            get { return nombreVendor; }
            set { nombreVendor = value; }
        }

        public String CodVendor
        {
            get { return codVendor; }
            set { codVendor = value; }
        }


        public void insertVendor()
        {
            try
            {
                String insert="INSERT INTO VENDEDOR(VENDEDOR,NOMBRE) VALUES('"+ codVendor+"','"+nombreVendor+"')";
                test.Conectar();
                test.ConsultaSQL(insert);
                test.Desconectar();
            }
            catch
            {

            }
        }


        public void updateVendor()
        {
            try
            {
                String update = "update VENDEDOR set NOMBRE='" + nombreVendor + "' where vendedor='"+codVendor+"'";
                test.Conectar();
                test.ConsultaSQL(update);
                test.Desconectar();
            }
            catch
            {

            }
        }

        public void deleteVendor()
        {
            try
            {
                String delete = "delete from VENDEDOR where vendedor='" + codVendor + "'";
                test.Conectar();
                test.ConsultaSQL(delete);
                test.Desconectar();
            }
            catch
            {

            }
        }



        public String prueba()
        {
            String mensaje;
            if (test.Conectar() == true)
            {
                test.Desconectar();
                mensaje = "Conexion realizada";
            }
            else {
                test.Desconectar();
                mensaje = "Conexion no realizada";
            }
            return mensaje;

        }
    }
}
