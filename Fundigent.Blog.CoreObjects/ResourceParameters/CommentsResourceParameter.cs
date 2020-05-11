namespace Fundigent.Blog.CoreObjects.ResourceParameters
{
    public class CommentsResourceParameter
    {
        const int maxPageSize = 20;
        private int pageSize = 5;
        public int PageNumber { get; set; } = 1;
        public int PageSize
        {
            get { return pageSize; }
            set { pageSize = (value > maxPageSize) ? maxPageSize : value; }
        }
    }
}
