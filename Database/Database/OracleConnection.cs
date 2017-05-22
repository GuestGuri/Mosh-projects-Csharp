using System;

namespace Database
{
    public class OracleConnection : DBConnection
    {
        public OracleConnection(string connection) : base(connection)
        {
        }

        public override void Close()
        {
            Console.WriteLine("close oracle connection");
        }

        public override void Open()
        {
            Console.WriteLine("open oracle connection");
        }
    }
}
