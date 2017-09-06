using System.Linq;

namespace Domain.Specifications
{
    public class BovineSpecification : ISpecification
    {
        private const char LETTER='b';
        public bool SatisfiedBy(string textLine)
        {
            return textLine.ToLower().Contains(LETTER);
        }
    }
}
