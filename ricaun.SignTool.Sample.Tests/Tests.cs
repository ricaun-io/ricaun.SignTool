using NUnit.Framework;
using ricaun.Security.WinTrust;
using System;

namespace ricaun.SignTool.Sample.Tests
{
    public class Tests
    {
        string FilePath => typeof(Class).Assembly.Location;

        [Test]
        public void IsSignedFile()
        {
            var result = Certificate.IsSignedFile(FilePath);
            Assert.IsTrue(result);
        }

        [TestCase("cn")]
        public void SignedFileIssuer(string code)
        {
            var result = Certificate.GetSignedFileIssuer(FilePath, code);
            Console.WriteLine(result);
            var isValid = !string.IsNullOrEmpty(result);
            Assert.IsTrue(isValid);
        }
    }
}