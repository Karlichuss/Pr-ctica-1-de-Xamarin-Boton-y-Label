using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace PruebaXamarin1.Vistas
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class MainView : ContentPage
    {
        // Variable contador, se inicializa a 1
        int count = 1;

        public MainView()
        {
            InitializeComponent();

            MyButton.Clicked += (sender, args) =>
            {
                MyLabel.Text = String.Format("Se han hecho {0} clicks!", count++);
            };
        }
    }
}