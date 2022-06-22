using SQL_Tutorial.Properties;
using System.Collections.Generic;
using System.Data.OleDb;

namespace SQL_Tutorial.DatabaseHelper
{
    public static class DatabaseReader
    {
        public static List<List<string>> Read(string sql)
        {
            try
            {
                if (sql.ToLower().Contains("delete") || sql.ToLower().Contains("drop") || sql.ToLower().Contains("alter") || sql.ToLower().Contains("insert"))
                {
                    return null;
                }
                string dbPath = Settings.Default.DB_Path;
                string strDSN = @"Provider=Microsoft.ACE.OLEDB.12.0;Data Source = " + dbPath;

                // create Objects of ADOConnection and ADOCommand    
                OleDbConnection myConn = new OleDbConnection(strDSN);
                OleDbCommand command = new OleDbCommand(sql, myConn);
                object[] meta = new object[20];
                //opens the connection
                myConn.Open();
                
                using (OleDbDataReader reader = command.ExecuteReader())
                {
                    //list for the output
                    List<List<string>> outputList = new List<List<string>>();

                    if (reader.Read())
                    {
                        // Get number of Columns
                        int numberOfColums = reader.GetValues(meta);
                        List<string> header = new List<string>();

                        //Write the name of the Columns
                        for (int a = 0; a < numberOfColums; a++)
                        {
                            header.Add(reader.GetName(a));
                        }

                        outputList.Add(header);

                        do
                        {
                            //reading all objects
                            numberOfColums = reader.GetValues(meta);
                            List<string> temp = new List<string>();

                            //Getting all Values
                            for (int i = 0; i < numberOfColums; i++)
                            {
                                temp.Add(meta[i].ToString());
                            }
                            outputList.Add(temp);

                        } while (reader.Read());
                    }
                    myConn.Close();
                    return outputList;
                }
            }
            catch
            {
                return null;
            }
        }
    }
}
