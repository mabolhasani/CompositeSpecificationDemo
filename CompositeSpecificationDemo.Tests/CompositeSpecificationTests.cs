using CompositeSpecificationDemo.Leafs;
using CompositeSpecificationDemo.Visitors;
using FluentAssertions;
using Xunit;

namespace CompositeSpecificationDemo.Tests
{
    public class CompositeSpecificationTests
    {
        [Fact]
        public void AcceptMethod_WithSpecificRules_ShouldCreateProperSentence()
        {
            //Arrange
            var rule = GetRules();
            var visitor = new MakeSentenceFromSpecificationVisitor();
            //Act
            rule.Accept(visitor);

            //Assert
            visitor.Sentence
                .Should()
                .Be("آیا عدد انتخابی زوج است؟ (و) آیا عدد انتخابی مثبت است؟ (یا) آیا عدد انتخابی صفر است؟");
        }

        [Theory]
        [InlineData(10, true)]
        [InlineData(0, true)]
        [InlineData(-1, false)]
        public void IsSatisfiedByMethod_WithSpecificRules_ShouldCreateProperBoolResult(int input, bool output)
        {
            //Arrange
            var rule = GetRules();
            //Act
            var result = rule.IsSatisfiedBy(input);

            //Assert
            result.Should().Be(output);
        }

        private static ISpecification<long> GetRules()
        {
            return new EvenNumbers().And(new PositiveNumbers()).Or(new IsZeroSpecification());
        }
    }
}
