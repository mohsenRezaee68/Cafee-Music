


using _0_Framework.Domain;

namespace CommentManagement.Domain.CommentAgg
{
    public class Comment : EntityBase
    {
        public string Name { get; private set; }
        public string Email { get; private set; }
        public string Website { get; private set; }
        public string Message { get; private set; }
        public bool IsConfirmed { get; private set; }
        public bool IsCanceled { get; private set; }
        public string OwnerRecordName { get; private set; }
        public string OwnerRecordId { get; private set; }
        public string OwnerRecordSinger { get; private set; }
        public string OwnerRecordCatgory { get; private set; }
        public int Type { get; private set; }
        public long ParentId { get; private set; }
      
        public Comment Parent { get; private set; }

        public Comment(string name, string email, string website, string message,
             string ownerRecordName, string ownerRecordSinger,
            string ownerRecordCatgory, int type, long parentId, string ownerRecordId)
        {
            Name = name;
            Email = email;
            Website = website;
            Message = message;
           
            OwnerRecordName = ownerRecordName;
            OwnerRecordSinger = ownerRecordSinger;
            OwnerRecordCatgory = ownerRecordCatgory;
            Type = type;
            ParentId = parentId;
            OwnerRecordId = ownerRecordId;
        }

        public void Confirm()
        {
            IsConfirmed = true;
        }

        public void Cancel()
        {
            IsCanceled = true;
        }
    }
}
