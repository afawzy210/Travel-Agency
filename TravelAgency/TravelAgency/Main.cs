using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TravelAgency
{
    class Main
    { 

        SqlConnection con = new SqlConnection(@"Data Source=  DESKTOP-3UCT87L\SQLEXPRESS ;Initial Catalog=  GeorgeGreat3  ;Integrated Security=True;");
        public string TableName;
        public Main(string TableName)
        {
            this.TableName = TableName;
        }
        /// <summary>
        /// Inserting Values in the table
        /// Data Must be formated well
        /// </summary>
        /// <param name="Data">
        /// Data Must be formated well
        /// Value1, Value2, ......
        /// if string then 'Value1' 
        /// </param>
        public void Insert(string Data)
        {
            con.Open();
            SqlCommand cmd = new SqlCommand("Insert Into " + TableName + " Values(" + Data + ")");
            cmd.Connection = con;
            cmd.ExecuteNonQuery();
            con.Close();
        }
        /// <summary>
        /// Gets the Data from the Table
        /// </summary>
        /// <param name="Condition">
        /// Condition Must be Fromated well
        ///      ColumnName Compare Value
        /// Like EmployeeName = 'Amel'
        /// </param>
        /// <returns>Returns the Data in List of Lists </returns>
        public List<List<string>> Read(string Condition = "")
        {
            con.Open();
            SqlCommand cmd = new SqlCommand("Select * From " + TableName + ((Condition != "") ? " Where " + Condition : ""));
            cmd.Connection = con;
            SqlDataReader rdr = cmd.ExecuteReader();
            List<List<string>> Data = new List<List<string>>();
            while (rdr.Read())
            {
                List<string> DataList = new List<string>();
                for (int i = 0; i < rdr.FieldCount; i++)
                {
                    DataList.Add(rdr[i].ToString());
                }
                Data.Add(DataList);
            }
            con.Close();
            return Data;
        }
        /// <summary>
        /// Make DataTable for Printing From the information
        /// </summary>
        /// <param name="Headers">The Header of the Table</param>
        /// <param name="Data">the Info of the Table</param>
        /// <returns>The DataTable for Printing</returns>
        public DataTable GetTable(List<string> Headers, List<List<string>> Data)
        {
            DataTable Table = new DataTable();
            foreach (string item in Headers)
            {
                Table.Columns.Add(item);
            }
            for (int i = 0; i < Data.Count; i++)
            {
                Table.Rows.Add(Data[i].ToArray());
            }
            return Table;
        }
        /// <summary>
        /// Delete From the Table
        /// </summary>
        /// <param name="Condition">
        /// Condition Must be Fromated well
        /// ColumnName Compare Value
        /// Like EmployeeName = 'George'</param>
        public void Delete(string Condition)
        {
            con.Open();
            SqlCommand cmd = new SqlCommand("Delete " + TableName + " Where " + Condition);
            cmd.Connection = con;
            cmd.ExecuteNonQuery();
            con.Close();
        }
        /// <summary>
        /// Update thet Table 
        /// </summary>
        /// <param name="Condition">
        /// Condition Must be Fromated well
        /// ColumnName Compare Value
        /// Like EmployeeName = 'George'</param>
        /// <param name="Set">
        /// Set Must Be Formated Well
        /// ColumnName = Value, ColumnName = Value
        /// Like EmployeeName = 'George', Salary = 3000
        /// </param>
        public void Update(string Condition, string Set)
        {
            con.Open();
            SqlCommand cmd = new SqlCommand("Update " + TableName + " Set " + Set + " Where " + Condition);
            cmd.Connection = con;
            cmd.ExecuteNonQuery();
            con.Close();
        }

    }
}

