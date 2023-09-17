﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BaseMusaBlog.EntityLayer.Concrete
{
    public class Comment
    {
        [Key]
        public int CommentID { get; set; }
        [StringLength(20)]
        public string UserName { get; set; }
        [StringLength(50)]
        public string Mail { get; set; }      
        public string CommentText { get; set; }
        public DateTime CommentDate { get; set; }
        public bool CommentStatus { get; set; }
        public int BlogRaiting { get; set; }
        public int BlogID { get; set; }
        public virtual Blog Blog { get; set; }
    }
}
