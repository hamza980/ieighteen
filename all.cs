using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace loginapp.Models
{
    public class Comment
    {
        [Key]
        public int Comment_Id { get; set; }
        public string Description { get; set; }
       
        //[ForeignKey("User")]
        public int User_Id { get; set; }
        public virtual User User { get; set; }

        public int post_Id { get; set; }
        public virtual Post post { get; set; }

    }


gvgcghchggggggggggggggggggggggggnchgcccg

}