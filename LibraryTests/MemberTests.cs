using Library;

namespace LibraryTests
{
    [TestClass]
    public class MemberTests
    {
        [TestMethod]
        public void MemberConstructor_ShouldInitialisedProperties()
        {

            // Arrange

            int memberId = 1;
            string name = "Sam Watson";
            string address = "12345 Road";
            int phone = 1234567890;

            // Act

            Member member = new Library.Member (memberId, phone, name, address);

            // Assert

            Assert.AreEqual(memberId, member.MemberID);
            Assert.AreEqual(name, member.Name); 
            Assert.AreEqual(address, member.Address);
            Assert.AreEqual(phone, member.PhoneNumber);

        }

        [TestMethod]
        public void NameProperty_ShouldGetAndSet()
        {

            // Arrange

            Member member = new Member(1, 1234567890, "Johnathan", "14a Madeup Street");
            string newName = "Fred";

            // Act

            member.Name = newName;

            // Assert

            Assert.AreEqual(newName, member.Name);

        }

        [TestMethod]
        public void AddressProperty_ShouldGetAndSet()
        {

            // Arrange

            Member member = new Member(1, 1234567890, "Simon", "Street Street");
            string newAddress = "New Street";

            // Act

            member.Address = newAddress;

            // Assert

            Assert.AreEqual(newAddress, member.Address);

        }

        [TestMethod]
        public void PhoneProperty_ShouldGetAndSet()
        {

            // Arrange

            Member member = new Member(1, 01234, "Hamish", "Highway Street");
            int newPhone = 56789;

            // Act

            member.PhoneNumber = newPhone;

            // Assert

            Assert.AreEqual(newPhone, member.PhoneNumber);

        }
    }
}
