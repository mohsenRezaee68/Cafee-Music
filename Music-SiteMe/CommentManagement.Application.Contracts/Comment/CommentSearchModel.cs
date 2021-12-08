namespace CommentManagement.Application.Contracts.Comment
{
    public class CommentSearchModel
    {
        public long Id { get; set; }
        public string Name { get; set; }
        public string Email { get; set; }
        public long OwnerRecordId { get; set; }
    }
}
