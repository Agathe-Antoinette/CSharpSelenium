namespace RestAPITests
{
    using System.Data.OleDb;
    using System.Linq;
    using Dapper;
    using System.Configuration;

    public class DataReader<T> where T : class
    {
        private const string CONNECTION_STRING = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source={0};Extended Properties=\"Excel 12.0 Xml;HDR=Yes;IMEX=1;\"";
        private const string DATA_PATH_KEY = "RestApiDataSource";
        private const string QUERY_TEMPLATE = @"select * from [{0}$] where TestName = '{1}'";

        public T GetData(string test)
        {
            var dataSource = ConfigurationManager.AppSettings[DATA_PATH_KEY];
            using (var connection = new OleDbConnection(string.Format(CONNECTION_STRING, dataSource)))
            {
                return connection.Query<T>(string.Format(QUERY_TEMPLATE, typeof(T).Name, test)).FirstOrDefault(); //typeof(T).Name is the name name of the Sheet.
            }
        }
    }
}