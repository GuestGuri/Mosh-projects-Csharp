using System;

namespace Database
{
    public abstract class DBConnection
    {
        private string _connectionString;
        private TimeSpan _timeOut;

        public string ConnectionString { get { return _connectionString; } set { _connectionString = value; } }
        public TimeSpan TimeOut { get { return _timeOut; } set { _timeOut = value; } }

        public DBConnection(string connection)
        {
            if (string.IsNullOrWhiteSpace(connection))
            {
                throw new ArgumentNullException("Connection is empty");
            }
            else
            {
                this._connectionString = connection;
            }
        }

        public abstract void Open();

        public abstract void Close();
    }
}
