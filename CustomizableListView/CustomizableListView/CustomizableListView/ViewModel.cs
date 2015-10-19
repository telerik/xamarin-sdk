using System;
using System.Collections.ObjectModel;
using Telerik.XamarinForms.Common;

namespace CustomizableListView
{
    public class ViewModel : NotifyPropertyChangedBase
    {
        private ObservableCollection<Song> songs;

        public ViewModel()
        {
            this.Songs = this.GetData();
        }

        public ObservableCollection<Song> Songs
        {
            get
            {
                return this.songs;
            }
            set
            {
                if (this.songs != value)
                {
                    this.songs = value;
                    this.RaisePropertyCanged();
                }
            }
        }

        public void ReloadData()
        {
            this.Songs = this.GetData();
        }

        private ObservableCollection<Song> GetData()
        {
            var data = new ObservableCollection<Song>();

            data.Add(new Song
            {
                Title = "Morning Star",
                Author = "Philip Sayce Group",
                Album = "Philip Sayce Group",
                AlbumArt = "https://d3rt1990lpmkn.cloudfront.net/640/6eea3847379718b51bf7a3cc7532414079da814f",
                IsFavourite = true
            });

            data.Add(new Song
            {
                Title = "Highway Jones",
                Author = "Cry Of Love",
                Album = "Brother",
                AlbumArt = "https://d3rt1990lpmkn.cloudfront.net/640/d91a6ae79fa4cbe790afd02ca3b0eb2969fe2013",
                IsFavourite = true
            });

            data.Add(new Song
            {
                Title = "Point Of View",
                Author = "Henrik Freischlader",
                Album = "Night Train To Budapest",
                AlbumArt = "https://d3rt1990lpmkn.cloudfront.net/640/4441e61fa3c8bf84c5a2edff65711634bbd9297b",
                IsFavourite = false
            });

            data.Add(new Song
            {
                Title = "So Cold",
                Author = "Richie Kotzen",
                Album = "Get Up",
                AlbumArt = "https://d3rt1990lpmkn.cloudfront.net/640/c6d3e9a66565f876d4545997e7bb0b92a6ef4421",
                IsFavourite = false
            });

            data.Add(new Song
            {
                Title = "Sailin' Shoes",
                Author = "Philip Sayce",
                Album = "Influence",
                AlbumArt = "https://d3rt1990lpmkn.cloudfront.net/640/6487ea97fba3f13b265a90d1a666a0f3affe5cc9",
                IsFavourite = false
            });

            data.Add(new Song
            {
                Title = "World Boss",
                Author = "Gov't Mule",
                Album = "Shout!",
                AlbumArt = "https://d3rt1990lpmkn.cloudfront.net/640/c487c8c6dd99209749e4da178483cfc2ecdb0429",
                IsFavourite = false
            });

            data.Add(new Song
            {
                Title = "Who Do You Love?",
                Author = "Joanne Shaw Taylor",
                Album = "Diamonds In The Dirt",
                AlbumArt = "https://d3rt1990lpmkn.cloudfront.net/640/e430a29dcdfee292059c533d012b2671c4b57091",
                IsFavourite = false
            });
           
            return data;
        }
    }
}