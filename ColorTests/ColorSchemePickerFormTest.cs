using ColorSchemePicker;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Drawing;

namespace TestUnit
{


    /// <summary>
    ///This is a test class for ColorSchemePickerFormTest and is intended
    ///to contain all ColorSchemePickerFormTest Unit Tests
    ///</summary>
    [TestClass()]
    public class ColorSchemePickerFormTest
    {


        private TestContext testContextInstance;

        /// <summary>
        ///Gets or sets the test context which provides
        ///information about and functionality for the current test run.
        ///</summary>
        public TestContext TestContext
        {
            get
            {
                return testContextInstance;
            }
            set
            {
                testContextInstance = value;
            }
        }

        #region Additional test attributes
        // 
        //You can use the following additional attributes as you write your tests:
        //
        //Use ClassInitialize to run code before running the first test in the class
        //[ClassInitialize()]
        //public static void MyClassInitialize(TestContext testContext)
        //{
        //}
        //
        //Use ClassCleanup to run code after all tests in a class have run
        //[ClassCleanup()]
        //public static void MyClassCleanup()
        //{
        //}
        //
        //Use TestInitialize to run code before running each test
        //[TestInitialize()]
        //public void MyTestInitialize()
        //{
        //}
        //
        //Use TestCleanup to run code after each test has run
        //[TestCleanup()]
        //public void MyTestCleanup()
        //{
        //}
        //
        #endregion


        /// <summary>
        ///A test for ColorToHSV
        ///</summary>
        [TestMethod()]
        [DeploymentItem("ColorSchemePicker.exe")]
        public void ColorToHSVTest()
        {
            ColorSchemePickerForm_Accessor target = new ColorSchemePickerForm_Accessor();
            double
                hue, sat, val,
                hueExpected = 1.3806451612903228,
                satExpected = 0.55029585798816572,
                valExpected = 0.66274509803921566;
            Color color = Color.FromArgb(76, 169, 104);

            target.ColorToHSV(color, out hue, out sat, out val);

            Assert.AreEqual(hueExpected, hue);
            Assert.AreEqual(satExpected, sat);
            Assert.AreEqual(valExpected, val);
        }

        /// <summary>
        ///A test for HSVToColor
        ///</summary>
        [TestMethod()]
        [DeploymentItem("ColorSchemePicker.exe")]
        public void HSVToColorTest()
        {
            ColorSchemePickerForm_Accessor target = new ColorSchemePickerForm_Accessor();
            double
                hue = 1.3806451612903228,
                sat = 0.55029585798816572,
                val = 0.66274509803921566;
            Color expected = Color.FromArgb(76, 169, 104), actual;

            actual = target.HSVToColor(hue, sat, val);

            Assert.AreEqual(expected, actual);
        }
    }
}
