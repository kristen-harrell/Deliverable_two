namespace KeiraTheCaticorn.Models
{
    public partial class TagCommentRelation
    {
        public string CommentId { get; set; }
        public string TagId { get; set; }

        public virtual Comment Comment { get; set; }
        public virtual Tag Tag { get; set; }
    }
}
