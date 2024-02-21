using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace EvaluationSampleCode.UnitTests
{
    [TestClass]
    public class BaptizmTests
    {
        private Baptizm _baptizm;
        private ClergyMember _clergyMember;

        [TestInitialize]
        public void Initialize()
        {
            ClergyMember _clergyMember = new ClergyMember();
            _baptizm = new Baptizm(_clergyMember);
        }

        [TestMethod]
        public void CanBeBaptizedBy_Priest_ReturnsTrue()
        {
            ClergyMember priest = new ClergyMember { IsPriest = true };

            var result = _baptizm.CanBeBaptizedBy(priest);

            Assert.IsTrue(result);
        }

        [TestMethod]
        public void CanBeBaptizedBy_Pope_ReturnsTrue()
        {
            ClergyMember pope = new ClergyMember { IsPope = true };

            var result = _baptizm.CanBeBaptizedBy(pope);

            Assert.IsTrue(result);
        }

        [TestMethod]
        public void CanBeBaptizedBy_NonPriestNonPope_ReturnsFalse()
        {
            ClergyMember nonPriestNonPope = new ClergyMember();

            var result = _baptizm.CanBeBaptizedBy(nonPriestNonPope);

            Assert.IsFalse(result);
        }

        [TestMethod]
        public void CanBeTeachedBy_SameClergyMember_ReturnsTrue()
        {
            var result = _baptizm.CanBeTeachedBy(_clergyMember);

            Assert.IsTrue(result);
        }

    }
}
