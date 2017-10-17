using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;
using ImageIO;
using Xamarin.Forms;
using formulario_SQLite.iOS;

using Foundation;
using UIKit;


[assembly: Dependency(typeof(SQLite_IOS))]

namespace formulario_SQLite.iOS
{
   public class SQLite_IOS: ISQLite
    {
        public string GetLocalFilePath(string filename)

        {
            string docFolder = Environment.GetFolderPath(Environment.SpecialFolder.Personal);
            string libFolder = Path.Combine(docFolder, "..", "Library", "Databases");


            if (!Directory.Exists(libFolder))

            {
                Directory.CreateDirectory(libFolder);
            }


            return Path.Combine(libFolder, filename);

        }


    }


}
