﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace projsqllite
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class PageDSloaihoa : ContentPage
    {
        database db;
        List<Loaihoa> dsl;
        
        public PageDSloaihoa()
        {
            InitializeComponent();
            db = new database();
            dsl = db.selectLoaihoa();
            
            lstdsloai.ItemsSource = dsl;
           
        }

        private void ImageButton_Clicked(object sender, EventArgs e)
        {
            Navigation.PushAsync(new PageDShoaloai());

        }

        
    }
}