using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace ListViewCodigo
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class Apresentacao : ContentPage
    {
        public Apresentacao(Object t)
        {
            if(t == null)
            {
                
            }
            BindingContext = t;
            InitializeComponent();
        }

        private void btVoltar(object sender, EventArgs e)
        {
            Navigation.PopToRootAsync();
        }
    }
}