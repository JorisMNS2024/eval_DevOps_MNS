using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EvaluationSampleCode.UnitTests
{
    [TestClass]
    public class PhoneNumberTests
    {
        private PhoneNumber _phoneNumber;

        [TestInitialize]
        public void Init()
        {
            _phoneNumber = PhoneNumber.Parse("0123456789");

        }

        [TestMethod]
        public void Parse_ValidPhoneNumber_ReturnsPhoneNumberInstance()
        {
          
            string phoneNumberString = "0123456789";

            PhoneNumber _phoneNumber = PhoneNumber.Parse(phoneNumberString);
         
            Assert.IsNotNull(_phoneNumber);
            Assert.AreEqual("012", _phoneNumber.Area);
            Assert.AreEqual("345", _phoneNumber.Major);
            Assert.AreEqual("6789", _phoneNumber.Minor);
        }

        [TestMethod]
        [DataRow("")] //aucun caractère (= null)
        [DataRow(" ")] //espace blanc
        [DataRow("12345")] //moins de 10
        [DataRow("012345678910")] //plus de 10
        public void Parse_InvalidPhoneNumber_ThrowsArgumentException(string phoneNumberString)
        {
     
            Assert.ThrowsException<ArgumentException>(() => PhoneNumber.Parse(phoneNumberString));
        }

        [TestMethod]
        public void ToString_ValidPhoneNumber_ReturnsFormattedString()
        {
           
            PhoneNumber _phoneNumber = PhoneNumber.Parse("0123456789");
       
            var result = _phoneNumber.ToString();

            Assert.AreEqual("(012)345-6789", result); //(area) - major - minor du fichier PhoneNumber
        }

    }
}
