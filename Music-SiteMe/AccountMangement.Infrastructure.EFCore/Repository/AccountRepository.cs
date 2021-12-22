using _0_Framework.Application;
using _0_Framework.Infrastructure;
using AccountManagement.Application.Contracts.Account;
using AccountManagement.Domain.AccountAgg;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;

namespace AccountMangement.Infrastructure.EFCore.Repository
{
    public class AccountRepository : RepositoryBase<long, Account>, IAccountRepository
    {
        private readonly AccountContext _context;

        public AccountRepository(AccountContext context) : base(context)
        {
            _context = context;
        }

        public Account GetBy(string username)
        {
            return _context.Accounts.FirstOrDefault(x => x.Username == username);
        }

        public EditAccount GetDetails(long id)
        {
            return _context.Accounts.Select(x => new EditAccount
            {
                Id = x.Id,
                Fullname = x.Fullname,
                Mobile = x.Mobile,
                RoleId = x.RoleId,
                Username = x.Username,
                Email = x.Email
            }).FirstOrDefault(x => x.Id == id);
        }

        public List<AccountViewModel> GetAccounts()
        {
            return _context.Accounts.Select(x => new AccountViewModel
            {
                Id = x.Id,
                Fullname = x.Fullname
            }).OrderByDescending(x => x.Id).ToList();
        }

        public List<AccountViewModel> Search(AccountSearchModel searchModel)
        {
            var query = _context.Accounts.Include(x => x.Role).Select(x => new AccountViewModel
            {
                Id = x.Id,
                Fullname = x.Fullname,
                Mobile = x.Mobile,
                ProfilePhoto = x.ProfilePhoto,
                Role = x.Role.Name,
                RoleId = x.RoleId,
                Username = x.Username,
                Email = x.Email,
                IsCanceled = x.IsCanceled,
                IsConfirmed = x.IsConfirmed,
                CreationDate = x.CreationDate.ToFarsi()
            });

            if (!string.IsNullOrWhiteSpace(searchModel.Fullname))
                query = query.Where(x => x.Fullname.Contains(searchModel.Fullname));

            if (!string.IsNullOrWhiteSpace(searchModel.Username))
                query = query.Where(x => x.Username.Contains(searchModel.Username));

            if (!string.IsNullOrWhiteSpace(searchModel.Mobile))
                query = query.Where(x => x.Mobile.Contains(searchModel.Mobile));

            if (!string.IsNullOrWhiteSpace(searchModel.Email))
                query = query.Where(x => x.Email.Contains(searchModel.Email));

            if (searchModel.RoleId > 0)
                query = query.Where(x => x.RoleId == searchModel.RoleId);

            query.OrderByDescending(x => x.Id).ToList();
            return query.ToList();
        }

        public string GetSlugById(long accountId)
        {
            return _context.Accounts.Select(x => new { x.Id, x.Username }).FirstOrDefault(x => x.Id == accountId).Username;
        }
    }
}