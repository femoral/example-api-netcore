using System.Collections.Generic;
using System.Linq;

namespace WebApplication.Common
{
    public abstract class AbstractMapper<TInput,TOutput>
    {
        public abstract TOutput Map(TInput value);

        public IEnumerable<TOutput> MapList(IEnumerable<TInput> values)
        {
            return values.Select(Map);
        }
    }
}