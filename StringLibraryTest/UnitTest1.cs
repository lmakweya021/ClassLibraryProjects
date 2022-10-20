using System.Reflection;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using UtilityLibraries;

namespace StringLibraryTest
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestStartsWithUpper()
        {
            // Tests that we expect to return true(starts with an uppercase string)
            string[] words = {"Alphabet", "Zebra", "ABC", "Αθήνα", "Москва"};
            foreach (var word in words)
            {
                bool result = word.StartsWithUpper();
                Assert.IsTrue(result,
                        string.Format("Expected for '{0}': false; Actual: {1}",
                                    word, result));
            }
        }

        [TestMethod]

        public void TestDoeaNotStartWithUpper()
        {
            // Tests that we expect to return false(does not start with an uppercase string)
            string[] words = {"alphabet", "zebra", "abc", "αυτοκινητοβιομηχανία", "государство",
                                    "1234", ".", ";", " "};
            foreach (var word in words)
            {
                bool result = word.StartsWithUpper();
                Assert.IsFalse(result,
                        string.Format("Expected for '{0}': false; Actual: {1}",
                                    word, result));
            }
        }

        [TestMethod]

        public void DirectCallWithNullorEmpty()
        {
            // Tests that we expect to return false(either empty or null)
            string[] words = {string.Empty, null};
            foreach (var word in words)
            {
                bool result = StringLibrary.StartsWithUpper(word);
                Assert.IsFalse(result,
                        string.Format("Expected for '{0}': false; Actual: {0}",
                                    word == null ? "<null>" : word, result));
            }
        }

    }
}