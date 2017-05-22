using System;

namespace Database
{
    public class DBCommand
    {

        private DBConnection _connection;
        private string _instruction;

        public DBCommand(DBConnection connection, string instruction)
        {
            if(connection == null || string.IsNullOrWhiteSpace(instruction))
            {
                throw new ArgumentNullException("connection statement is empty");
            }
            else
            {
                this._connection = connection;
                this._instruction = instruction;
            }
        }

        public void Execute()
        {
            this._connection.Open();
            Console.WriteLine(this._instruction);
            this._connection.Close();
        }


    }
}
