﻿using Music.Market.Core;
using Music.Market.Core.Models;
using Music.Market.Core.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Music.Market.Services
{
    public class ArtistService : IArtistService
    {
        private readonly IUnitOfWork unitOfWork;

        public ArtistService(IUnitOfWork _unitOfWork) 
        {
            this.unitOfWork = _unitOfWork;
        }

        public async Task<Artist> CreateArtist(Artist newArtist)
        {
            await unitOfWork.Artists.AddAsync(newArtist);
            await unitOfWork.CommitAsync();
            return newArtist;
        }

        public async Task DeleteArtist(Artist artist)
        {
            unitOfWork.Artists.RemoveAsync(artist);
            await unitOfWork.CommitAsync();
        }

        public async Task<IEnumerable<Artist>> GetAllArtists()
        {
            return await unitOfWork.Artists.GetAllAsync();
        }

        public async Task<Artist> GetArtistById(int id)
        {
            return await unitOfWork.Artists.GetByIdAsync(id);
        }

        public async Task UpdateArtist(Artist artistToBeUpdated, Artist artist)
        {
            artistToBeUpdated.Name = artist.Name;
            await unitOfWork.CommitAsync();
        }
    }
}
