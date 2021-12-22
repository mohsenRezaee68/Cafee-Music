﻿using _0_Framework.Infrastructure;
using Microsoft.EntityFrameworkCore;
using musicManagement.Application.Contracts.MusicTrack;
using MusicManagement.Application.Contracts.MusicTrack;
using MusicManagement.Domain.MusicTrackAgg;
using System.Collections.Generic;
using System.Linq;

namespace MusicManagement.Infrastructure.EFCore.Repository
{
    public class MusicTrackRepository : RepositoryBase<long, MusicTrack>,IMusicTrackRepository
    {
        private readonly MusicContext _context;

        public MusicTrackRepository(MusicContext context) : base(context)
        {
            _context = context;
        }

        public EditMusicTrack GetDetails(long id)
        {
            return _context.MusicTracks
                .Include(x => x.Music)
           .Select(x => new EditMusicTrack
           {
               Id = x.Id,
               TrackId = x.Music.Id,
              TrackName = x.TrackName
           }).FirstOrDefault(x => x.Id == id);
        }

        public MusicTrack GetWithMusicAndCategory(long id)
        {
            return _context.MusicTracks
                 .Include(x => x.Music)
                 .ThenInclude(x => x.Category)
                 .FirstOrDefault(x => x.Id == id);
        }

        public List<MusicTrackViewModel> Search(MusicTrackSearchModel searchModel)
        {
            var query = _context.MusicTracks
               .Include(x => x.Music)
               .Include(x => x.Category)
              
               .Select(x => new MusicTrackViewModel
               {
                   Id = x.Id,
                   Name = x.Music.Name,
                   CreationDate = x.CreationDate.ToString(),
                   Track = x.Track,
                   TrackId = x.Music.Id,
                   IsRemoved = x.IsRemoved,
                   Singer = x.Music.Singer,
                   TrackName = x.TrackName,
                   Category = x.Music.Category.Name
               });

            if (searchModel.TrackId != 0)
                query = query.Where(x => x.TrackId == searchModel.TrackId);

           
            query.OrderByDescending(x => x.Id).ToList();
            return query.ToList();
        }
    }
}
