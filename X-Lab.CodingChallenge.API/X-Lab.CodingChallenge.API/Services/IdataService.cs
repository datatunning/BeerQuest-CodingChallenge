// <copyright file="IdataService.cs" company="Bruno DUVAL">
// Copyright (c) Bruno DUVAL.</copyright>

using System.Threading;
using System.Threading.Tasks;
using XLab.CodingChallenge.API.Models;

namespace XLab.CodingChallenge.API.Services
{
    public interface IDataService
    {
        Task<Venue[]> GetAsync(CancellationToken cancellationToken);
    }
}