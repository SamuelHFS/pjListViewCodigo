using ListViewCodigo.model;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace ListViewCodigo
{
    // Learn more about making custom code visible in the Xamarin.Forms previewer
    // by visiting https://aka.ms/xamarinforms-previewer
    [DesignTimeVisible(false)]
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();

            ListView lstview = new ListView();
            lstview.ItemsSource = new List<Times>
            { 
            
                new Times{
                nome = "Galudo",
                imagem = "galudo.png",
                descricao = "Maior de minas, CONFIA",
                tecnico = "Cuca cabelo de boneca",
                jogadores = new string[] {"Everson","Arana","Nathan S", "Alonso", "Mariano", "Allan", "Jair", "Nacho", "Savarino", "Hulk", "Keno"}
                },

                new Times{
                nome = "Palmares",
                imagem = "palmeiras.png",
                descricao = "Não tem copinha e não tem mundial",
                tecnico = "Abelaum",
                jogadores = new string[] {"Weverton", "Gustavo Gomez", "Luan", "Piquerez", "Marcos Rocha", "Danilo", "Zé Rafael", "Scarpa", "Wesley", "Luiz Adriano", "Rony Rústico" }
                },

                new Times{
                nome = "Flamilicia",
                imagem = "flamengo.png",
                descricao = "Sem meu José Alberto Wright eu não consigo",
                tecnico = "Renight",
                jogadores = new string[] {"Diego", "Leo Pereira", "Rodrigo Caio", "Isla", "Filipe Luís", "Arão", "Andreas Pereira", "Everton Ribeiro", "Arrascaxeira", "Belo Horizonte", "Gabigordo" }
                },

                new Times{
                nome = "Lion do Pici",
                imagem = "fortaleza.png",
                descricao = "Quem não tem história conta a dos outros",
                tecnico = "Vojfoda",
                jogadores = new string[] {"Filipe Alves", "Tinga", "Benevenuto", "Titi", "Bruno Melo", "Ederson", "Felipe", "Lucas Lesma", "Yago Pikachu", "W.Paulista", "David" }
                }



            };
            lstview.ItemTemplate = new DataTemplate(typeof(ImageCell));
            lstview.ItemTemplate.SetBinding(ImageCell.ImageSourceProperty, "imagem");
            lstview.ItemTemplate.SetBinding(ImageCell.TextProperty, "nome");
            lstview.ItemTemplate.SetBinding(ImageCell.DetailProperty, "tecnico");
            
           

            lstview.ItemSelected += Lstview_ItemSelected;
            lstview.ItemTapped += Lstview_ItemTapped;

            Content = lstview;
        }

        private void Lstview_ItemTapped(object sender, ItemTappedEventArgs e)
        {
           
        }

        private void Lstview_ItemSelected(object sender, SelectedItemChangedEventArgs e)
        {
            var time = e.SelectedItem as Times;
            Navigation.PushAsync(new Apresentacao(time));
        }
    }
}
