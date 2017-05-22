using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Database
{

    class Program
    {
        static void Main(string[] args)
        {
            try
            {
            var command = new DBCommand(new SqlConnection("to sql server"), "select * from user where pass like 'abcd'");
            var command2 = new DBCommand(new OracleConnection("to oracle"), "select * from user where pass like 'abcd'");
            command.Execute();
            command2.Execute();
            }
            catch (System.Exception e)
            {
                System.Console.WriteLine(e.Message);
            }
        }
    }
}
