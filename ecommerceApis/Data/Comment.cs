using System;
using System.Collections.Generic;

namespace ecommerceApis.Data;

public partial class Comment
{
    public int CommentId { get; set; }

    public int? ProductId { get; set; }

    public int? UserId { get; set; }

    public int? Rating { get; set; }

    public string? Image { get; set; }

    public string? CommentText { get; set; }

    public virtual Product? Product { get; set; }

    public virtual User? User { get; set; }
}
