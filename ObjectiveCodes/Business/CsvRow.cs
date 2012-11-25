using System;
using System.Collections.Generic;
using System.IO;
using System.Text;

namespace ReadWriteCsv
{
    /// <summary>
    /// Class to store one CSV row
    /// </summary>
    /// <author>http://www.codeproject.com/Articles/415732/Reading-and-Writing-CSV-Files-in-Csharp</author>
    public class CsvRow : List<string>
    {
        public string LineText { get; set; }
    }

}