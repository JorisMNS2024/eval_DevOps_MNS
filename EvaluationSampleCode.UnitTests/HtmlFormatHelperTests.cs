using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EvaluationSampleCode.UnitTests
{
    [TestClass]
    public class HtmlFormatHelperTests
    {
        private HtmlFormatHelper _htmlFormatHelper;

        [TestInitialize]
        public void Init()
        {
            _htmlFormatHelper = new HtmlFormatHelper();
        }
        [TestMethod]
        public void GetStrongFormat_ValidContent_ReturnsStrongFormattedString()
        {
           
            string content = "Texte en gras";

            var result = _htmlFormatHelper.GetStrongFormat(content);

            Assert.AreEqual("<strong>Texte en gras</strong>", result);
        }

        [TestMethod]
        public void GetItalicFormat_ValidContent_ReturnsItalicFormattedString()
        {
            string content = "Texte en italique";
            
            var result = _htmlFormatHelper.GetItalicFormat(content);

            Assert.AreEqual("<i>Texte en italique</i>", result);
        }

        [TestMethod]
        public void GetFormattedListElements_ValidList_ReturnsFormattedListString()
        {

            List<string> contents = new List<string> { "Item 1", "Item 2", "Item 3" };

            var result = _htmlFormatHelper.GetFormattedListElements(contents);

            Assert.AreEqual("<ul><li>Item 1</li><li>Item 2</li><li>Item 3</li></ul>", result);
        }

    }
}
