using CompositeSpecificationDemo.Composites;
using CompositeSpecificationDemo.Leafs;

namespace CompositeSpecificationDemo.Visitors
{
    public class MakeSentenceFromSpecificationVisitor : SpecificationVisitor
    {
        public string Sentence { get; private set; }

        public override void Visit(EvenNumbers evenNumbers)
        {
            Sentence += "آیا عدد انتخابی زوج است؟";
        }

        public override void Visit(PositiveNumbers positiveNumbers)
        {
            Sentence += "آیا عدد انتخابی مثبت است؟";
        }

        public override void Visit(IsZeroSpecification isZeroSpecification)
        {
            Sentence += "آیا عدد انتخابی صفر است؟";
        }

        public override void Visit<T>(AndSpecification<T> andSpecification)
        {
            Visit(andSpecification.LeftSpec as dynamic);
            Sentence += " (و) ";
            Visit(andSpecification.RightSpec as dynamic);
        }

        public override void Visit<T>(OrSpecification<T> orSpecification)
        {
            Visit(orSpecification.LeftSpec as dynamic);
            Sentence += " (یا) ";
            Visit(orSpecification.RightSpec as dynamic);
        }

        public override void Visit<T>(NotSpecification<T> notSpecification)
        {
            Sentence += " (مخالف) ";
            Visit(notSpecification.TargetSpec as dynamic);
        }
    }
}
