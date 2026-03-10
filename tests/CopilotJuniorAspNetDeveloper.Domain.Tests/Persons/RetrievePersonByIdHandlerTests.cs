using CopilotJuniorAspNetDeveloper.Application.Persons;
using CopilotJuniorAspNetDeveloper.Domain.Persons;
using Moq;

namespace CopilotJuniorAspNetDeveloper.Domain.Tests.Persons
{
    [TestClass]
    public class RetrievePersonByIdHandlerTests
    {
        [TestMethod]
        public async Task GetPersonByIdAsync_WhenPersonDoesNotExist_ReturnsNull()
        {
            // Arrange
            var mockRepository = new Mock<IPersonsRepository>();
            mockRepository
                .Setup(r => r.GetByIdAsync(It.IsAny<int>()))
                .ReturnsAsync((Person?)null);

            var handler = new RetrievePersonByIdHandler(mockRepository.Object);

            // Act
            var result = await handler.GetPersonByIdAsync(999);

            // Assert
            Assert.IsNull(result);
        }

        [TestMethod]
        public async Task GetPersonByIdAsync_WhenPersonExists_ReturnsPersonDto()
        {
            // Arrange
            var person = new Person { Id = 1, Name = "Rolando", LastName = "Mesa" };

            var mockRepository = new Mock<IPersonsRepository>();
            mockRepository
                .Setup(r => r.GetByIdAsync(1))
                .ReturnsAsync(person);

            var handler = new RetrievePersonByIdHandler(mockRepository.Object);

            // Act
            var result = await handler.GetPersonByIdAsync(1);

            // Assert
            Assert.IsNotNull(result);
            Assert.AreEqual(person.Id, result.Id);
            Assert.AreEqual(person.Name, result.Name);
            Assert.AreEqual(person.LastName, result.LastName);
        }
    }
}
