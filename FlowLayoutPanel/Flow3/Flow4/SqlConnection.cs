//using Flow4.Properties;
namespace Flow4
{
    internal class SqlConnection
    {
        private string str;

        public SqlConnection(string str)
        {
            this.str = str;
        }

        internal void Open()
        {
            throw new NotImplementedException();
        }

        internal void Close()
        {
            throw new NotImplementedException();
        }
    }
}