using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;
using Subsystem_Employed.Mysql;
using System.Windows.Forms;


namespace Subsystem_Employed.mysql
{
    class funciones
    {
        public static int agregar(constructor_registro add)
        {
            int retorno;
            MySqlCommand comando = new MySqlCommand(string.Format("INSERT INTO empleado(id_empleado,nombre,ap_paterno,ap_materno,correo,num_cel,num_cuenta,nombre_usuario,psw,ocupacion,edad)VALUES('{0}','{1}','{2}','{3}','{4}','{5}','{6}','{7}','{8}','{9}','{10}')",add.id_empleado, add.nombre, add.ap_paterno, add.ap_materno, add.correo, add.num_cel, add.num_cuenta, add.nombre_usuario, add.psw, add.ocu,add.edad), conexion.com());
            retorno = comando.ExecuteNonQuery();
            try
            {
                return retorno;
            }catch(Exception ex)
            {
                MessageBox.Show("Ha ocurrido un error inesperado favor de revisar los datos."+ex,"Error",MessageBoxButtons.OK,MessageBoxIcon.Error);
                return retorno;
            }
        }
        
        
    }
}
