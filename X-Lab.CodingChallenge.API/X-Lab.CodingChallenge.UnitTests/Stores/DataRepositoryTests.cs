// <copyright file="DataRepositoryUnitTests.cs" company="Bruno DUVAL">
// Copyright (c) Bruno DUVAL.</copyright>

using System.Net;
using System.Net.Http;
using System.Threading;
using System.Threading.Tasks;
using FluentAssertions;
using Microsoft.Extensions.Caching.Memory;
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
            var handlerMock = new Mock<HttpMessageHandler>();
            var response = new HttpResponseMessage
            {
                StatusCode = HttpStatusCode.OK,
                Content = new StringContent(MockData.CsvVenues),
            };

            handlerMock
                .Protected()
                .Setup<Task<HttpResponseMessage>>(
                    "SendAsync",
                    ItExpr.IsAny<HttpRequestMessage>(),
                    ItExpr.IsAny<CancellationToken>())
                .ReturnsAsync(response);
            var httpClientMock = new HttpClient(handlerMock.Object);

            var httpClientFactoryMock = new Mock<IHttpClientFactory>();
            httpClientFactoryMock.Setup(_ => _.CreateClient(It.IsAny<string>())).Returns(httpClientMock);

            var loggerMock = Mock.Of<ILogger<IDataRepository>>();
            var dataRepo = new DataRepository(loggerMock, httpClientFactoryMock.Object);

            // Act
            var data = await dataRepo.GetAsync();

            // Assert
            data.Should().BeEquivalentTo(MockData.Venues);
        }
    }
}