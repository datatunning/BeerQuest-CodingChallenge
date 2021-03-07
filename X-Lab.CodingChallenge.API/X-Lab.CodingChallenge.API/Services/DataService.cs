// <copyright file="DataService.cs" company="Bruno DUVAL">
// Copyright (c) Bruno DUVAL.</copyright>

using System.Threading;
using System.Threading.Tasks;
using Microsoft.Extensions.Logging;
using XLab.CodingChallenge.API.Models;
using XLab.CodingChallenge.API.Stores;

namespace XLab.CodingChallenge.API.Services
{
    public class DataService : IDataService
    {
        private readonly ILogger<IDataService> _logger;
        private readonly IDataRepository _dataRepository;

        public DataService(ILogger<IDataService> logger, IDataRepository dataRepository)
        {
            logger.LogInformation("Initializing DataService");
            this._logger = logger;
            _dataRepository = dataRepository;
        }

        public Task<Venue[]> GetAsync(CancellationToken cancellationToken = default)
        {
            return _dataRepository.GetAsync(cancellationToken);
        }
    }
}