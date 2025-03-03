﻿using Music.Market.Core.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Music.Market.Core.Services
{
    public interface IArtistService
    {
        Task<IEnumerable<Artist>> GetAllArtists();
        Task<Artist> GetArtistById(int id);
        Task<Artist> CreateArtist(Artist newArtist);
        Task UpdateArtist(Artist artistToBeUpdated, Artist artist);
        //Task UpdateArtist(int artistId, Artist artist);
        //Task DeleteArtist(int id);
        Task DeleteArtist(Artist artist);

        //Task DeleteAllArtists();
        //Task DeleteArtists(IEnumerable<Artist> entities);

    }
}
