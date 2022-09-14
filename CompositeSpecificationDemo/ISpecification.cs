using CompositeSpecificationDemo.Visitors;

namespace CompositeSpecificationDemo
{
    public interface ISpecification<in T>
    {
        public bool IsSatisfiedBy(T entity);

        public void Accept(ISpecificationVisitor visitor);
    }
}
