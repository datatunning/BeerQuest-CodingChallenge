// <copyright file="IDataRepository.cs" company="Bruno DUVAL">
// Copyright (c) Bruno DUVAL.</copyright>

using System.Threading;
using System.Threading.Tasks;
using XLab.CodingChallenge.API.Models;

namespace XLab.CodingChallenge.API.Stores
{
    public interface IDataRepository
    {
        Task<Venue[]> GetAsync(CancellationToken cancellationToken);
    }
}