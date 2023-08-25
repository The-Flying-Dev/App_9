using System;
using System.IO; 

namespace WordUnscrambler.Workers
{
    class FileReader
    {
        public string[] Read(string filename)
        {
            string[] fileContent;
            try
            {              // .IO directive above allows static methods to be called
                fileContent = File.ReadAllLines(filename);
            }
            catch (Exception ex)
            {

                throw new Exception(ex.Message); //wraps existing exception into this new exception, otherwise it eraises the entire call stack
                // throw ex; DON'T DO THIS, ERAISES CALL STACK
            }
            return fileContent;
        }
    }
}
