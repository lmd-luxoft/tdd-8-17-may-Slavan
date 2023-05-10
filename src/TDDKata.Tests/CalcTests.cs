using TDDKata.Lib;

namespace TDDKata.Tests
{
    public class CalcTests
    {
        [Fact]
        public void Add_EmtyInput_ReturnsZero()
        {
            var expr = "";
            var expected = 0D;

            var sut = new Calc();

            var res = sut.Add(expr);
            Assert.Equal(expected, res);
        }

        [Fact]
        public void Add_TextInExpr_Throws()
        {
            var expr = "dfhsdfh";
            var expected = -1;

            var sut = new Calc();

            var res = sut.Add(expr);
            Assert.Equal(expected, res);
        }

        [Fact]
        public void Add_OneOfArgumentIsNotValidInt_Throws()
        {
            var expr = "1 dfhsdfh";
            var expected = -1;

            var sut = new Calc();

            var res = sut.Add(expr);
            Assert.Equal(expected, res);
        }

        [Fact]
        public void Add_OneOfArgumentIsNotInIntRange_Throws()
        {
            var expr = "234623467245734572344634";
            var expected = -1;

            var sut = new Calc();

            var res = sut.Add(expr);
            Assert.Equal(expected, res);
        }

        [Fact]
        public void Add_ToMuchArgument_Throws()
        {
            var expr = "1 2 3";
            var expected = -1;

            var sut = new Calc();

            var res = sut.Add(expr);
            Assert.Equal(expected, res);
        }

        [Fact]
        public void Add_SingleInput_ReturnsInput()
        {
            var expr = "  234  ";
            var expected = 234;

            var sut = new Calc();

            var res = sut.Add(expr);
            Assert.Equal(expected, res);
        }

        [Fact]
        public void Add_ZeroInput_ReturnsInput()
        {
            var expr = "0";
            var expected = 0;

            var sut = new Calc();

            var res = sut.Add(expr);
            Assert.Equal(expected, res);
        }

        [Fact]
        public void Add_SingleInt_ReturnsResult()
        {
            var expr = "  234  ";
            var expected = 234;

            var sut = new Calc();

            var res = sut.Add(expr);
            Assert.Equal(expected, res);
        }

        [Fact]
        public void Add_TwoOneNegative_ReturnsResult()
        {
            var expr = "  234 -5  ";
            var expected = 229;

            var sut = new Calc();

            var res = sut.Add(expr);
            Assert.Equal(expected, res);
        }

        [Fact]
        public void Add_TwoSmallInputs_ReturnsSum()
        {
            var expr = "  1  2";
            var expected = 3;

            var sut = new Calc();

            var res = sut.Add(expr);
            Assert.Equal(expected, res);
        }

    }
}