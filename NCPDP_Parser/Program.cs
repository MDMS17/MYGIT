using System;
using System.IO;
using System.Configuration;

namespace NCPDP_Parser
{
    class Program
    {
        static void Main(string[] args)
        {
            DataAccess.emptyTables();
            string inputPath = ConfigurationManager.AppSettings["FilePath"].ToString();
            DirectoryInfo di = new DirectoryInfo(inputPath);
            foreach (FileInfo fi in di.GetFiles())
            {
                Post_NCPDPParser parser = new Post_NCPDPParser(fi.FullName);
                parser.ParseDetail();
            }

        }
    }
}
