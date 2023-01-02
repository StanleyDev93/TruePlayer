using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TruePlayer.ViewModels;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace TruePlayer.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class MusicList : ContentPage
    {
        public MusicList()
        {
            InitializeComponent();
            BindingContext = new MusicViewModel(Navigation);
        }
    }
}