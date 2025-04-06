using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArtGalleryManagementSystem.ViewModels
{
    public class ArtViewModelcs
    {
        public int ArtId { get; set; }

        public string ArtCode { get; set; }

        public string ArtTitle { get; set; }

        public int GenreId { get; set; }

        public string GenreTitle { get; set; }

        public string ArtistFName { get; set; }

        public string ArtistLName { get; set; }

        public string Gender { get; set; }

        public DateTime CreationDate { get; set; }

        public int Price { get; set; }

        public bool IsAvailable { get; set; }

        public string ImagePath { get; set; }

        //public string ExhibitionTitle { get; set; }

        public int ExhibitionDuration { get; set; }
    }
}
