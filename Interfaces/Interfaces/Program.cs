using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interfaces
{
    class Program
    {
        static void Main(string[] args)
        {
            var migrator = new DBMigrator(new ConsoleLogger());
            migrator.Migrate();
            var file = new DBMigrator(new FileLogger(@"E:/report.txt"));
            file.Migrate();
        }
    }
}
