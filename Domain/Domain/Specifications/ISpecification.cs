
namespace Domain.Specifications
{
   public interface ISpecification
    {
        bool SatisfiedBy(string textLine);
    }
}
