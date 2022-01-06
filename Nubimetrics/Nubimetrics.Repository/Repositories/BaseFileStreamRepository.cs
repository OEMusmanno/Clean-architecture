using CsvHelper;
using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Text;

namespace Nubimetrics.Dal.Repositories
{
    public abstract class BaseFileStreamRepository 
    {
        public virtual void SaveFile(string path, string fileName, string extension, List<string> content )
        {
            var _path = Path.GetPathRoot(path);
            string @strFilePath =  _path + fileName + @extension;
            StringBuilder sbOutput = new StringBuilder();
            foreach (var item in content)
            {
                sbOutput.AppendLine(string.Join(",", item));
            }
            File.WriteAllText(strFilePath, sbOutput.ToString());


        }
    }
}
