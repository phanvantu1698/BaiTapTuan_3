using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace projsqllite
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class PageDShoa : ContentPage
    {
        
        database db;
        List<Hoa> dsh;

        public PageDShoa()
        {
            InitializeComponent();
            db = new database();
            dsh = db.selecthoa();

            lstdshoa.ItemsSource = dsh;

        }

    }
}