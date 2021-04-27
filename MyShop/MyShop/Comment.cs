using System;
using System.Collections.Generic;

#nullable disable

namespace MyShop
{
    public partial class Comment
    {
        public int CommentId { get; set; }
        public string Text { get; set; }
        public int ProductId { get; set; }

        public virtual Product Product { get; set; }
    }
}
