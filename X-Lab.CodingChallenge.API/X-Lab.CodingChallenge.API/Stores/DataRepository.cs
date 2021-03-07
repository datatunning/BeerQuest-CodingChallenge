// <copyright file="DataRepository.cs" company="Bruno DUVAL">
// Copyright (c) Bruno DUVAL.</copyright>

using System;
using System.Collections.Generic;
using System.Net;
using System.Net.Http;
using System.Threading;
using System.Threading.Tasks;
using FileHelpers;
using Microsoft.Extensions.Logging;
using XLab.CodingChallenge.API.Models;

namespace XLab.CodingChallenge.API.Stores
{
    public class DataRepository : IDataRepository
    {
        private const string VenueUrl = "leedsbeerquest.csv";
        private readonly ILogger<IDataRepository> _logger;
        private readonly List<Venue> _venues = new();

        public DataRepository(ILogger<IDataRepository> logger)
        {
            logger.LogInformation("Initializing DataRepository");
            _logger = logger;
        }

        public Task<Venue[]> GetAsync(CancellationToken cancellationToken = default)
        {
            try
            {
                _logger.LogInformation("Getting CSV parser engine");
                using var engine = new FileHelperAsyncEngine<Venue>();

                _logger.LogInformation("Setting CSV engine error mode"); 
                // engine.ErrorManager.ErrorMode = ErrorMode.IgnoreAndContinue;
                
                _logger.LogInformation("Starting CSV reader"); 
                using var recordReader = engine.BeginReadFile($"{VenueUrl}");
                
                foreach (var record in engine)
                {
                    _logger.LogInformation($"Adding {record.name} to the venue list.");
                    this._venues.Add(record);
                }

                _logger.LogInformation($"Returning {_venues.Count} Venues.");
                return Task.FromResult(_venues.ToArray());
            }
            catch (HttpRequestException httpEx)
            {
                if (httpEx.StatusCode == HttpStatusCode.NoContent)
                {
                    _logger.LogWarning("Request did not returned any venues.");
                    return Task.FromResult(new Venue[]{});
                }

                _logger.LogError(
                    $"An error occurred while retrieving the venues. StatusCode: {httpEx.StatusCode}, Message: {httpEx.Message}");
                throw;
            }
            catch (Exception ex)
            {
                _logger.LogError($"An unhandled error occurred while retrieving the venues. {ex.Message}");
                throw;
            }
        }
    }
}