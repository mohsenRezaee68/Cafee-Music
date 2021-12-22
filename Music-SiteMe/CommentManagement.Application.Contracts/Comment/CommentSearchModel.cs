namespace CommentManagement.Application.Contracts.Comment
{
    public class CommentSearchModel
    {
        public long Id { get; set; }
        public string Name { get; set; }
        public string Email { get; set; }
        public string OwnerRecordSinger { get; set; }
        public string OwnerRecordName { get; set; }
        public string OwnerRecordCatgory { get; set; }
    }
}
