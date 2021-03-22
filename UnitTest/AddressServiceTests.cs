using APIDemo.Services;
using DataLayer.Entity;
using DataLayer.Repository;
using Moq;
using NUnit.Framework;
using System.Collections.Generic;

namespace UnitTest
{
    [TestFixture]
    public class AddressServiceTests
    {

        Mock<IAddressRepository> _mockRepo;

        [SetUp]
        public void Setup()
        {
            _mockRepo = new Mock<IAddressRepository>();
        }

        [Test]
        public void LoadAll_LoadSuccess_ReturnsList()
        {
            Assert.Fail();
        }
        [Test]
        public void LoadAll_LoadFailure_ReturnsNullAndThrows()
        {
            Assert.Fail();
        }
        [Test]
        public void AddAddress_AddSuccess_ReturnsTrue()
        {
            _mockRepo.Setup(repo => repo.AddAddress(It.IsAny<Address>())).Returns(true);
            AddressService service = new AddressService(_mockRepo.Object);
            var result = service.AddAddress(new Address());

            Assert.True(result);
            _mockRepo.Verify(repo => repo.AddAddress(It.IsAny<Address>()), Times.Once);
        }

        [Test]
        public void AddAddress_AddFailure_ReturnsFalseAndThrows()
        {
            Assert.Fail();
        }

        [Test]
        public void GetAddressById_GetSuccess_ReturnsAddress()
        {
            Assert.Fail();
        }

        [Test]
        public void GetAddressById_GetFailure_ReturnsNullAndThrows()
        {
            Assert.Fail();
        }

        [Test]
        public void UpateAddress_UpdateSuccess_ReturnsTrue()
        {
            Assert.Fail();
        }

        [Test]
        public void UpdateAddress_UpdateFailure_ReturnsFalseAndThrows()
        {
            Assert.Fail();
        }

        [Test]
        public void DeleteAddress_DeleteSuccess_ReturnsTrue()
        {
            Assert.Fail();
        }

        [Test]
        public void DeleteAddress_DeleteFailure_ReturnsFalseAndThrows()
        {
            Assert.Fail();
        }

    }
}
