using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;
using System.Runtime.CompilerServices;
using System.ComponentModel;
using System.Windows.Input;
using TruePlayer.Data;
using TruePlayer.Models;

namespace TruePlayer.ViewModels
{
    public class MusicViewModel: BaseViewModel
    {
        #region VARIABLES
        List<MusicModel> list_music;
        #endregion
        #region CONSTRUCTOR
        public MusicViewModel(INavigation navigation)
        {
            Navigation = navigation;
            ShowMusicList();
        }
        #endregion
        #region OBJETOS
        public List<MusicModel> ListMusic
        {
            get { return list_music; }
            set { SetValue(ref list_music, value); }
        }
        #endregion
        #region PROCESOS
        public async Task ShowMusicList()
        {
            var function = new MusicData();
            ListMusic = await function.ListMusic();
        }
        public void ProcesoSimple()
        {

        }
        #endregion
        #region COMANDOS
        //public ICommand ProcesoAsyncommand => new Command(async () => await ProcesoAsyncrono());
        public ICommand ProcesoSimpcommand => new Command(ProcesoSimple);
        #endregion

    }
}
