using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace PDC03_MOD2
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class Activity5 : ContentPage
    {
        public Activity5()
        {
            InitializeComponent();
            lst.ItemsSource = new List<Contacts>()
            {
                new Contacts()
                {
                    Name = "Yoben Magalong", Num = "123123",

                },
                new Contacts()
                {
                    Name = "Yoben Magalong", Num = "123123",
                },
                new Contacts()
                {
                    Name = "Yoben Magalong", Num = "123123",
                },
            };
        }
    }
}