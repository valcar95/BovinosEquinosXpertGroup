
namespace Domain.Specifications
{
   public class NonSpecification: ISpecification
    {
        public bool SatisfiedBy(string textLine)
        {
            return false;
        }
    }
}
