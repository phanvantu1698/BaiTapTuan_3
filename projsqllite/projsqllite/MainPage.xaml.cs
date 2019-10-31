using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace projsqllite
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
        }

        private void Cmdthemloaihoa_Clicked(object sender, EventArgs e)
        {
            Navigation.PushAsync(new PagThemLoaiHoa());

        }

        private void Cmddsloaihoa_Clicked(object sender, EventArgs e)
        {
            Navigation.PushAsync(new PageDSloaihoa());

        }
        private void Cmdthemhoa_Clicked(object sender, EventArgs e)
        {
            Navigation.PushAsync(new PageThemHoa());

        }
        
            private void Cmddshoa_Clicked(object sender, EventArgs e)
        {
            Navigation.PushAsync(new PageDShoa());

        }
    }
}
