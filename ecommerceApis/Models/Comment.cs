using System.ComponentModel.DataAnnotations.Schema;

namespace ecommerceApis.Models
{
    public class Comment
    {
        public int CommentId { get; set; }
        [ForeignKey("Product")]
        public int ProductId { get; set; }
        [ForeignKey("User")]
        public int UserId { get; set; }
        public int Rating { get; set; }
        public string Image { get; set; }
        public string CommentText { get; set; }
    }
}
