using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SQLite;

namespace formulario_SQLite
{
   public interface ISQLite
    {

        string GetLocalFilePath(string filename);
    }
}
