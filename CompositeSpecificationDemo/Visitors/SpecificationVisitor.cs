using CompositeSpecificationDemo.Composites;
using CompositeSpecificationDemo.Leafs;

namespace CompositeSpecificationDemo.Visitors
{
    public class SpecificationVisitor : ISpecificationVisitor
    {
        public virtual void Visit(EvenNumbers evenNumbers)
        {
        }

        public virtual void Visit(PositiveNumbers positiveNumbers)
        {
        }

        public virtual void Visit(IsZeroSpecification isZeroSpecification)
        {
        }

        public virtual void Visit<T>(AndSpecification<T> andSpecification)
        {
        }

        public virtual void Visit<T>(OrSpecification<T> orSpecification)
        {
        }

        public virtual void Visit<T>(NotSpecification<T> notSpecification)
        {
        }
    }
}
