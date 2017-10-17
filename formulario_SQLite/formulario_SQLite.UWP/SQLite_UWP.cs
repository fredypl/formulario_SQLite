using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using Xamarin.Forms;
using formulario_SQLite.UWP;
using Windows.Storage;

[assembly: Dependency(typeof(SQLite_UWP))]
namespace formulario_SQLite.UWP
{
   public class SQLite_UWP : ISQLite
    {
        public string GetLocalFilePath(string filename)
        {

            return Path.Combine(ApplicationData.Current.LocalCacheFolder.Path, filename);

        }
    }
}
