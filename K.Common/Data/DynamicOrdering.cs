using System.Linq.Expressions;

namespace K.Common.Data
{
    internal class DynamicOrdering
    {
        public Expression Selector;
        public bool Ascending;
    }
}
