using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using TruePlayer.Models;

namespace TruePlayer.Data
{
    public class MusicData
    {
        public async Task<List<MusicModel>> ListMusic()
        {
            var musicList = new List<MusicModel>() { 
                new MusicModel
                {
                    Song_Name = "Take My Hand",
                    Autor = "Aldebaran",
                    Album = "Slaves of Time",
                    Cover = "Slaves_of_Time.jpg",
                    Url = "https://firebasestorage.googleapis.com/v0/b/trueplayerapp.appspot.com/o/Take%20my%20Hand.mp3?alt=media&token=eff46e5e-3c92-4357-b5c3-a04aa58a5f48"
                },
                new MusicModel
                {
                    Song_Name = "Vengeance",
                    Autor = "Yngwie J. Malmstein",
                    Album = "Magnum Opus",
                    Cover = "Magnum_Opusc.jpg",
                    Url = "https://firebasestorage.googleapis.com/v0/b/trueplayerapp.appspot.com/o/Vengeance.mp3?alt=media&token=c0b2340e-5642-43cd-9778-5114f66b553b"
                },
                new MusicModel
                {
                    Song_Name = "I'll See the Light Tonight",
                    Autor = "Yngwie J. Malmstein",
                    Album = "Marching Out",
                    Cover = "Marching_Outc.jpg",
                    Url = "https://firebasestorage.googleapis.com/v0/b/trueplayerapp.appspot.com/o/I'll%20See%20the%20Light%2C%20Tonight.mp3?alt=media&token=1000ea3b-9337-4fc9-b7c8-00beef95d28c"
                },
            };

            return musicList;
        }
    }
}
