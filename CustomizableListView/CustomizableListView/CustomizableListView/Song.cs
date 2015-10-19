using Telerik.XamarinForms.Common;

namespace CustomizableListView
{
    public class Song : NotifyPropertyChangedBase
    {
        private bool isFavourite;
 
        public string Title { get; set; }

        public string Author { get; set; }

        public string Album { get; set; }

        public string AlbumArt { get; set; }

        public bool IsFavourite
        {
            get
            {
                return this.isFavourite;
            }
            set
            {
                if (this.isFavourite != value)
                {
                    this.isFavourite = value;
                    this.RaisePropertyCanged();
                }
            }
        }
    }
}