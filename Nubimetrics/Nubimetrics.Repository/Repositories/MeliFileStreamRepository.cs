using Nubimetrics.DalContracts.Meli;
using System;
using System.Collections.Generic;
using System.Text;

namespace Nubimetrics.Dal.Repositories
{
    public class MeliFileStreamRepository : BaseFileStreamRepository, IMeliFileStreamRepository
    {
        public void SaveFileCsv(string path, string fileName, string extension, List<string> ratios)
        {
            SaveFile(path, fileName, extension, ratios);
        }
    }
}
