﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;



namespace Subsystem_Employed.Mysql
{
    class conexion
    {
        public static MySqlConnection com()
        {
            MySqlConnection con = new MySqlConnection("server=127.0.0.1;database=hospital_al;user=root;pwd=;");
            con.Open();
            return con;
        }
    }
}
