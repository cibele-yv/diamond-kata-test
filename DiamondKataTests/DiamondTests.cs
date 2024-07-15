using DiamondKata;
using System;
using Xunit;

namespace DiamondKataTests
{
    public class DiamondTests
    {   
        [Fact]
        public void Diamond_GivenInvalidInput_ThrowsArgumentException()
        {
            Assert.Throws<ArgumentException>(() => Diamond.Create('1'));
        }

        [Theory]
        [InlineData('A', "A\n")]
        [InlineData('B', " A \nB B\n A \n")]
        [InlineData('C', "  A  \n B B \nC   C\n B B \n  A  \n")]
        [InlineData('D', "   A   \n  B B  \n C   C \nD     D\n C   C \n  B B  \n   A   \n")]
        public void CreateDiamond_ShouldReturnDiamondAccordingToTheInputLetter(char input, string expectedDiamond)
        {
            var actualDiamond = Diamond.Create(input);

            Assert.Equal(expectedDiamond, actualDiamond);

        }

    }
}