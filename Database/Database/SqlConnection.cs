using System;

namespace Database
{
    public class SqlConnection : DBConnection
    {
        public SqlConnection(string connection) : base(connection)
        {
        }

        public override void Close()
        {
            Console.WriteLine("close sql server connection");
        }

        public override void Open()
        {
            Console.WriteLine("open sql server connection");
        }
    }
}
