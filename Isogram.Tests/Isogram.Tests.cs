using System;
using Xunit;
using isogram_csharp_problem_Varunn96;

namespace Isogram.Tests
{
    public class IsogramTest
    {
        [Fact]
        public void emptyString()
        {
            Assert.True(IsogramClass.isIsogram(""));
        }
        [Fact]
        public void lowerCaseIsogram()
        {
            Assert.True(IsogramClass.isIsogram("isogram"));
        }
        [Fact]
        public void lowerCaseEleven()
        {
            Assert.False(IsogramClass.isIsogram("eleven"));
        }
        [Fact]
        public void longEnglishWord()
        {
            Assert.True(IsogramClass.isIsogram("subdermatoglyphic"));
        }
        [Fact]
        public void mixedCaseDuplicated()
        {
            Assert.True(IsogramClass.isIsogram("Alphabet"));
        }
        [Fact]
        public void withHyphen()
        {
            Assert.True(IsogramClass.isIsogram("thumbscrew-japingly"));
        }
        [Fact]
        public void withDuplicatedHyphen()
        {
            Assert.True(IsogramClass.isIsogram("six-year-old"));
        }
        [Fact]
        public void nameWithSpaces()
        {
            Assert.True(IsogramClass.isIsogram("v a r u n"));
        }
    }
}
