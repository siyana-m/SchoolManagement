using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

public class DBManipulator
{
    private readonly static string connectionString =
   "Server=DESKTOP-16922B7\\SQLEXPRESS;Database=ISDA;Integrated Security=true";
    private SqlConnection connection;
    private SqlCommand command;
    public DBManipulator()
    {
        try
        {
            this.connection = new SqlConnection(connectionString);
            this.command = new SqlCommand();
            this.command.Connection = this.connection;
        }
        catch (Exception e)
        {
            MessageBox.Show(e.ToString());
        }
    }
    public SqlConnection GetConnection()
    {
        return this.connection;
    }
    public SqlCommand GetCommand()
    {
        this.command.Parameters.Clear();
        return this.command;
    }
}

