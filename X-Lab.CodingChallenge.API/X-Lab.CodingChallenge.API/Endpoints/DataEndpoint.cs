// <copyright file="DataEndpoint.cs" company="Bruno DUVAL">
// Copyright (c) Bruno DUVAL.</copyright>

using System;
using System.Net;
using System.Net.Mime;
using System.Text.Json;
using System.Threading;
using System.Threading.Tasks;
using Ardalis.ApiEndpoints;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using Swashbuckle.AspNetCore.Annotations;
using XLab.CodingChallenge.API.Models;
using XLab.CodingChallenge.API.Services;

namespace XLab.CodingChallenge.API.Endpoints
{
    public class VenueListEndpoint : BaseAsyncEndpoint.WithoutRequest.WithResponse<Venue[]>
    {
        private readonly ILogger<VenueListEndpoint> _logger;
        private readonly IDataService _dataService;

        public VenueListEndpoint(ILogger<VenueListEndpoint> logger, IDataService dataService)
        {
            _logger = logger;
            _dataService = dataService;
        }

        [HttpGet("/list")]
        [SwaggerOperation(
            Summary = "List all the venues",
            Description = "List all the venues. TODO: Add paging",
            OperationId = "Venues.List",
            Tags = new[] { nameof(VenueListEndpoint) })
        ]
        [Produces(MediaTypeNames.Application.Json)]
        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        [ProducesResponseType(StatusCodes.Status500InternalServerError)]
        public override async Task<ActionResult<Venue[]>> HandleAsync(CancellationToken cancellationToken = default)
        {
            _logger.LogInformation($"Received request to retrieve all Venues ");
            try
            {
                return Ok(JsonSerializer.Serialize(await this._dataService.GetAsync(cancellationToken)));
            }
            catch (Exception ex)
            {
                return Problem(ex.Message, null, (int)HttpStatusCode.InternalServerError, "API error");
            }
        }
    }
}