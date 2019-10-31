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
    public partial class PageThemHoa : ContentPage
    {
        
       database db;
        List<Loaihoa> dsl;

        public PageThemHoa()
        {
            InitializeComponent();
            db = new database();
            dsl = db.selectLoaihoa();

            txtmaloai.ItemsSource = dsl;

        }
        private void Cmdthemhoa_Clicked(object sender, EventArgs e)
        {
            database db = new database();
            Hoa l = new Hoa { Maloai=txtmaloai.AutomationId,Mahoa=txttenhoa.Text , Tenhoa = txttenhoa.Text, Hinh=txthinh.Text, Gia=txtgiaban.Text , Mota=txtmota.Text };
            if (db.InsertHoa(l) == true)
            {
                DisplayAlert("Thông Báo", "Thêm hoa thành công", "OK");
            }
            else
                DisplayAlert("Thông Báo", "Thêm hoa Lỗi", "OK");

        }
        private void Cmdxoahoa_Clicked(object sender, EventArgs e)
        {
            database db = new database();
            Hoa l = new Hoa { Maloai = txtmaloai.AutomationId, Mahoa = txttenhoa.Text, Tenhoa = txttenhoa.Text, Hinh = txthinh.Text, Gia = txtgiaban.Text, Mota = txtmota.Text };
            if (db.DELETE(l) == true)
            {
                DisplayAlert("Thông Báo", "Xóa hoa thành công", "OK");
            }
            else
                DisplayAlert("Thông Báo", "Xóa hoa Lỗi", "OK");

        }

    }
}