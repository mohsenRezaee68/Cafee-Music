using _0_Framework.Application;
using _0_Framework.Infrastructure;
using CommentManagement.Application.Contracts.Comment;
using CommentManagement.Domain.CommentAgg;

using MusicManagement.Infrastructure.EFCore;
using System.Collections.Generic;
using System.Linq;

namespace CommnetManagement.Infrastructure.EFCore.Repository
{
    public class CommentRepository : RepositoryBase<long, Comment>, ICommentRepository
    {
        private readonly CommentContext _context;
       

        public CommentRepository(CommentContext context , MusicContext musicContext) : base(context)
        {
            _context = context;
        }

        public List<CommentViewModel> Search(CommentSearchModel searchModel)
        {
          
            var query = _context.Comments
               
                .Select(x => new CommentViewModel
                {
                    Id = x.Id,
                    Name = x.Name,
                    Email = x.Email,
                    Website = x.Website,
                    Message = x.Message,
                    OwnerRecordName = x.OwnerRecordName,
                    OwnerRecordSinger = x.OwnerRecordSinger,
                    OwnerRecordCatgory = x.OwnerRecordCatgory,
                    OwnerRecordId=x.OwnerRecordId,
                    Type = x.Type,
                    IsCanceled = x.IsCanceled,
                    IsConfirmed = x.IsConfirmed,
                    
                    CommentDate = x.CreationDate.ToFarsi()
                });

            if (!string.IsNullOrWhiteSpace(searchModel.Name))
                query = query.Where(x => x.Name.Contains(searchModel.Name));

            if (!string.IsNullOrWhiteSpace(searchModel.OwnerRecordSinger))
                query = query.Where(x => x.OwnerRecordSinger.Contains(searchModel.OwnerRecordSinger));
            if (!string.IsNullOrWhiteSpace(searchModel.OwnerRecordName))
                query = query.Where(x => x.OwnerRecordName.Contains(searchModel.OwnerRecordName));

            if (searchModel.Id != 0)
                query = query.Where(x => x.Id == searchModel.Id);

            query.OrderByDescending(x => x.Id).ToList();
            return query.ToList();
        }

      
    }
}
