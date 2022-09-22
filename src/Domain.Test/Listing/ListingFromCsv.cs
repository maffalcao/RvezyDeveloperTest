using Domain.Interfaces;
using Domain.Entities;

using Moq;
using Domain.Services;

namespace Domain.Test.Listing
{
    public class ListingFromCsv
    {
        [Fact]
        public void GetById_Return_Register_If_Id_Is_Found()
        {
            var data = GetData();
            var serviceMock = new Mock<IListingFromCsv>();
            serviceMock.Setup(m =>
                m.GetById(It.IsAny<int>()))
                    .Returns(data.First());

            var service = new ListingFromCsvService(serviceMock.Object);

            var result = service.GetById(It.IsAny<int>());

            Assert.NotNull(result);

        }

        [Fact]
        public void GetById_Return_Register_If_Id_Is_Not_Found()
        {
            var data = GetData();
            var serviceMock = new Mock<IListingFromCsv>();
            serviceMock.Setup(m =>
                m.GetById(It.IsAny<int>()))
                    .Returns(data.FirstOrDefault(_ => _.Id == 1));

            var service = new ListingFromCsvService(serviceMock.Object);

            var result = service.GetById(It.IsAny<int>());

            Assert.Null(result);

        }

        [Fact]
        public void GetPaged_Return_Registers_If_When_Page_Is_1()
        {
            var data = GetData();
            var serviceMock = new Mock<IListingFromCsv>();
            serviceMock.Setup(m =>
                m.GetPaged(null, 1))
                    .Returns(data);

            var service = new ListingFromCsvService(serviceMock.Object);

            var result = service.GetPaged(null, 1);

            Assert.NotEmpty(result);

        }

        public List<Domain.Entities.Listing> GetData()
        {

            return new List<Domain.Entities.Listing>() {

                new Domain.Entities.Listing(
                        It.IsAny<int>(),
                        It.IsAny<string>(),
                        It.IsAny<string>(),
                        It.IsAny<string>(),
                        It.IsAny<string>()),

                new Domain.Entities.Listing(
                        It.IsAny<int>(),
                        It.IsAny<string>(),
                        It.IsAny<string>(),
                        It.IsAny<string>(),
                        It.IsAny<string>()),

                new Domain.Entities.Listing(
                        It.IsAny<int>(),
                        It.IsAny<string>(),
                        It.IsAny<string>(),
                        It.IsAny<string>(),
                        It.IsAny<string>()),

                new Domain.Entities.Listing(
                        It.IsAny<int>(),
                        It.IsAny<string>(),
                        It.IsAny<string>(),
                        It.IsAny<string>(),
                        It.IsAny<string>()),

            };

        }

    }
}