using System;
using System.Collections.Generic;
using System.Text;

namespace Nubimetrics.DalContracts.Meli
{
    public interface IMeliFileStreamRepository
    {
        void SaveFileCsv(string path, string fileName, string extension, List<string> ratios);

    }
}
