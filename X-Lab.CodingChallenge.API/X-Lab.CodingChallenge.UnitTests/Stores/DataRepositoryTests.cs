// <copyright file="DataRepositoryUnitTests.cs" company="Bruno DUVAL">
// Copyright (c) Bruno DUVAL.</copyright>

using System.Net;
using System.Net.Http;
using System.Threading;
using System.Threading.Tasks;
using FluentAssertions;
using Microsoft.Extensions.Logging;
using Moq;
using Moq.Protected;
using XLab.CodingChallenge.API.Stores;
using Xunit;

namespace XLab.CodingChallenge.UnitTests.Stores
{
    public class DataRepositoryTests
    {
       
        [Fact]
        public async void ShouldReturnAllDataWhenRequestWithoutFilter()
        {
            // Arrange
            var loggerMock = Mock.Of<ILogger<IDataRepository>>();
            var dataRepo = new DataRepository(loggerMock);

            // Act
            var data = await dataRepo.GetAsync();

            // Assert
            data.Length.Should().Be(MockData.Venues.Length);
            data.Should().BeEquivalentTo(MockData.Venues);
        }
    }
}