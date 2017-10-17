using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;
using System.Collections.ObjectModel;
using SQLite;

namespace formulario_SQLite
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
            SQLiteAsyncConnection database;
            string db;
            db = DependencyService.Get<ISQLite>().GetLocalFilePath("DATOBD.db");
            database = new SQLiteAsyncConnection(db);
            database.CreateTableAsync<Datos>().Wait();
            var elemento = new Datos
            {
                Id = 3,
                Dato1 = "Sofia",
                Dato2 = "Juarez",
                Dato3 = "Flores",
                Dato4 = "San Lorenzo",
                Dato5 = 555678906,
                Dato6 = "Ing.Sistemas Computacionales",
                Dato7 = "Tercero",
                Dato8 = 13090354,
                Dato9 = "sofi.534@hotmail.com",
                Dato10 ="sofyajf"
            
            };
            database.InsertAsync(elemento);
            Label label = new Label();
            database.Table<Datos>().ToListAsync();
            database.CloseAsync();
            ObservableCollection<Datos> Items = new ObservableCollection<Datos>
            {

            };
            BindingContext = this;
        }
    }
}
