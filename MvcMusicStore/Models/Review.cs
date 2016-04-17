using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MvcMusicStore.Models
{
    public class Review
    {
        public int ReviewID { get; set; }

        //isn't really needed, but makes life easier
        public int AlbumID { get; set; }

        //enables lazy loading
        public virtual Album Album { get; set; }

        public string Contents { get; set; }

        [Required()]
        [Display(Name ="Email Address")]
        [DataType(DataType.EmailAddress)]
        public string ReviewerEmail { get; set; }
    }
}
