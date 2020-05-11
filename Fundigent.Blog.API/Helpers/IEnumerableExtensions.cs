using System.Collections.Generic;
using System.Dynamic;

namespace Fundigent.Blog.API.Helpers
{
    /// <summary>
    ///
    /// </summary>
    public static class IEnumerableExtensions
    {
        public static IEnumerable<ExpandoObject> Expand<TSource>(this IEnumerable<TSource> source)
        {
            var expandoList = new List<ExpandoObject>();
            var propertyInfoList = typeof(TSource).GetProperties(System.Reflection.BindingFlags.Public | System.Reflection.BindingFlags.Instance);
            foreach (var item in source)
            {
                var expando = new ExpandoObject();
                foreach (var propertyInfo in propertyInfoList)
                {
                    var propertyValue = propertyInfo.GetValue(item);
                    ((IDictionary<string, object>)expando).Add(propertyInfo.Name, propertyValue);
                }
                expandoList.Add(expando);
            }

            return expandoList;
        }
    }
}
