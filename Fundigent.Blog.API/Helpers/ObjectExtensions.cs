using System.Collections.Generic;
using System.Dynamic;

namespace Fundigent.Blog.API.Helpers
{
    public static class ObjectExtensions
    {
        public static ExpandoObject Expand<TSource>(this TSource source)
        {
            var propertyInfoList = typeof(TSource).GetProperties(System.Reflection.BindingFlags.Public | System.Reflection.BindingFlags.Instance);

            var expando = new ExpandoObject();
            foreach (var propertyInfo in propertyInfoList)
            {
                var propertyValue = propertyInfo.GetValue(source);
                ((IDictionary<string, object>)expando).Add(propertyInfo.Name, propertyValue);
            }

            return expando;
        }
    }
}
