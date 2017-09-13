using FastMember;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DatabaseDataModelGenerator
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void btnLoadDatabaseSchema_Click(object sender, EventArgs e)
        {
            var tables = LoadCollection<TableModel>("SELECT * FROM INFORMATION_SCHEMA.TABLES WHERE TABLE_TYPE = 'BASE TABLE'", new[] { "TABLE_CATALOG", "TABLE_SCHEMA", "TABLE_NAME", "TABLE_TYPE" });
            var views = LoadCollection<TableModel>("SELECT * FROM INFORMATION_SCHEMA.TABLES WHERE TABLE_TYPE = 'VIEW'", new[] { "TABLE_CATALOG", "TABLE_SCHEMA", "TABLE_NAME", "TABLE_TYPE" });
            var procedures = LoadCollection<TableModel>("SELECT* from INFORMATION_SCHEMA.ROUTINES where ROUTINE_TYPE = 'PROCEDURE'", new[] { "TABLE_CATALOG", "TABLE_SCHEMA", "TABLE_NAME", "TABLE_TYPE" });
            var parameters = LoadCollection<TableModel>("SELECT * from information_schema.PARAMETERS", new[] { "TABLE_CATALOG", "TABLE_SCHEMA", "TABLE_NAME", "TABLE_TYPE" });

            foreach (var table in tables)
            {
                cbTable.Items.Add(table.TABLE_NAME, false);
            }
        }

        public List<T> LoadCollection<T>(string query, string[] columns) where T : new()
        {
            List<T> collection = new List<T>();
            DataTable table = new DataTable();
            using (SqlConnection connection = new SqlConnection(txtConnectionString.Text))
            {
                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    connection.Open();
                    table.Load(command.ExecuteReader());
                }
            }

            foreach (DataRow item in table.Rows)
            {
                object obj = new T();

                foreach (var column in columns)
                {
                    var value = item[column];

                    PropertyInfo propertyInfo = obj.GetType().GetProperty(column);
                    propertyInfo.SetValue(obj, Convert.ChangeType(value, propertyInfo.PropertyType), null);
                }

                collection.Add((T)obj);
            }

            return collection;
        }

        public class TableModel
        {
            public string TABLE_CATALOG { get; set; }
            public string TABLE_SCHEMA { get; set; }
            public string TABLE_NAME { get; set; }
            public string TABLE_TYPE { get; set; }
        }
    }
}
