// <copyright file="DataRepository.cs" company="Bruno DUVAL">
// Copyright (c) Bruno DUVAL.</copyright>

using System;
using System.IO;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Threading;
using System.Threading.Tasks;
using FileHelpers;
using Microsoft.Extensions.Caching.Memory;
using Microsoft.Extensions.Logging;
using XLab.CodingChallenge.API.Models;

namespace XLab.CodingChallenge.API.Stores
{
    public class DataRepository : IDataRepository
    {
        private const string VenueUrl = "https://drive.google.com/file/d/1o5JTtFUHcBAjH47z4i_eZrFdyXvSzY_S/view";
        private readonly ILogger<IDataRepository> _logger;
        private readonly IHttpClientFactory _httpClientFactory;
        private Venue[] _venues = {};

        public DataRepository(ILogger<IDataRepository> logger, IHttpClientFactory httpClientFactory)
        {
            logger.LogInformation("Initializing DataRepository");
            _logger = logger;
            _httpClientFactory = httpClientFactory;
        }

        public async Task<Venue[]> GetAsync(CancellationToken cancellationToken = default)
        {
            try
            {
                _logger.LogInformation("Retrieving venues");
                var httpClient = _httpClientFactory.CreateClient();
                await using var rawStream = await httpClient.GetStreamAsync(VenueUrl, cancellationToken);
                using var rawReader = new StreamReader(rawStream);

                _logger.LogInformation("Caching venues");
                using var engine = new FileHelperAsyncEngine<Venue>();
                using var recordReader = engine.BeginReadStream(rawReader);

                this._venues = engine.ToArray();

                return _venues;
            }
            catch (HttpRequestException httpEx)
            {
                if (httpEx.StatusCode == HttpStatusCode.NoContent)
                {
                    _logger.LogWarning("Request did not returned any venues.");
                    return new Venue[]{};
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