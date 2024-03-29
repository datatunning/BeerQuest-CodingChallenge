﻿// <copyright file="HealthCheckTests.cs" company="Bruno DUVAL">
// Copyright (c) Bruno DUVAL.</copyright>

using System.Net.Http;
using System.Threading.Tasks;
using FluentAssertions;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.TestHost;
using XLab.CodingChallenge.API;
using Xunit;

namespace XLab.CodingChallenge.UnitTests.Endpoints
{
    public class HealthCheckTests
    {
        private readonly HttpClient _client;

        public HealthCheckTests()
        {
            var builder = new WebHostBuilder().UseStartup<Startup>();
            var testServer = new TestServer(builder);
            _client = testServer.CreateClient();
        }

        [Fact]
        public async Task Health_OnInvoke_ReturnsHealthy()
        {
            var response = await _client.GetAsync("/health");
            var responseString = await response.Content.ReadAsStringAsync();

            response.StatusCode.Should().Be(StatusCodes.Status200OK);
            responseString.Should().Be("Healthy");
        }
    }
}