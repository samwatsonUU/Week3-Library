
namespace Library
{
    public class Member
    {

        private string name;
        private string address;
        private int phoneNumber;
        private int memberID;

        public int MemberID
        {
            get { return memberID; }
            private set { memberID = value; }
        }

        public int PhoneNumber
        {
            get {  return phoneNumber; }
            set { phoneNumber = value; }
        }

        public string Name
        {
            get { return name; }
            set { name = value; }

        }

        public string Address
        {
            get { return address; }
            set { address = value; }
        }

        public Member(int memberID, int phoneNumber, string name, string address)
        {

            this.memberID = memberID;
            this.phoneNumber = phoneNumber; 
            this.name = name;
            this.address = address;

        }

        public void DisplayMemberInfo()
        {

            Console.WriteLine($"Member name: {name}");
            Console.WriteLine($"Member address: {address}");
            Console.WriteLine($"Member phone number: {phoneNumber}");
            Console.WriteLine($"Member ID: {memberID}");
            Console.WriteLine("");

        }

    }
}
