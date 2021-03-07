// <copyright file="DataServiceUnitTests.cs" company="Bruno DUVAL">
// Copyright (c) Bruno DUVAL.</copyright>

using System;
using System.Threading;
using FluentAssertions;
using Microsoft.Extensions.Logging;
using Moq;
using XLab.CodingChallenge.API.Models;
using XLab.CodingChallenge.API.Services;
using XLab.CodingChallenge.API.Stores;
using Xunit;

namespace XLab.CodingChallenge.UnitTests.Services
{
    public class DataServiceTests
    {
        [Fact]
        public async void ShouldReturnAllDataWhenRequestWithoutFilter()
        {
            // Arrange
            var repoMock = new Mock<IDataRepository>();
            repoMock.Setup(repo => repo.GetAsync(CancellationToken.None).Result).Returns(MockData.Venues);

            var logger = new Mock<ILogger<IDataService>>();
            var dataService = new DataService(logger.Object, repoMock.Object);

            // Act
            var data = await dataService.GetAsync();

            // Assert
            data.Should().BeEquivalentTo(MockData.Venues);
        }
    }
}