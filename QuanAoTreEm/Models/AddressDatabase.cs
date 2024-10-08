﻿using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Data.SqlTypes;
using System.Linq;
using System.Web;

namespace QuanAoTreEm.Models
{
    public class AddressDatabase
    {
        SqlConnection conn;
        public AddressDatabase()
        {
            conn = new SqlConnection("Data Source=MSI-GF63-THIN11\\SQLEXPRESS;Initial Catalog=QL_BanQuanAoTreEm;Integrated Security=True");
        }
        public DataTable getProvinces()
        {
            string sql = "Select code, name from provinces";
            DataTable dataTable = new DataTable();

            using (SqlCommand cmd = new SqlCommand(sql, conn))
            {
                using (SqlDataAdapter adapter = new SqlDataAdapter(cmd))
                {
                    conn.Open();
                    adapter.Fill(dataTable);
                }
            }
            conn.Close();
            return dataTable;
        }
    }
}