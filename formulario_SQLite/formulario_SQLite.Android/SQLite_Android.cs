using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;
using Xamarin.Forms;
using formulario_SQLite.Droid;


using Android.App;
using Android.Content;
using Android.OS;
using Android.Runtime;
using Android.Views;
using Android.Widget;


[assembly: Dependency(typeof(SQLite_Android))]
namespace formulario_SQLite.Droid
{
   public class SQLite_Android: ISQLite
    {
        public string GetLocalFilePath(string filename)

        {
            string path = System.Environment.GetFolderPath(System.Environment.SpecialFolder.Personal);
            return Path.Combine(path,filename);
            
            

        }


    }
}