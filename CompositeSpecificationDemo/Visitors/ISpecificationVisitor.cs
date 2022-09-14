using CompositeSpecificationDemo.Composites;
using CompositeSpecificationDemo.Leafs;

namespace CompositeSpecificationDemo.Visitors
{
    public interface ISpecificationVisitor
    {
        public void Visit(EvenNumbers evenNumbers);
        public void Visit(PositiveNumbers positiveNumbers);
        public void Visit(IsZeroSpecification isZeroSpecification);
        public void Visit<T>(AndSpecification<T> andSpecification);
        public void Visit<T>(OrSpecification<T> orSpecification);
        public void Visit<T>(NotSpecification<T> notSpecification);
    }
}