namespace CommentManagement.Application.Contracts.Comment
{
    public class AddComment
    {
        public string Name { get; set; }
        public string Email { get; set; }
        public string Message { get; set; }
        public string Website { get; set; }
        public long OwnerRecordId { get; set; }
        public int Type { get; set; }
        public long ParentId { get; set; }

        public string EtelaatCam { get;  set; }
        public string TamasCam { get;  set; }
        public string EmailCam { get;  set; }
        public string EnstaCom { get;  set; }
        public string TelegramCam { get;  set; }

    }
}
