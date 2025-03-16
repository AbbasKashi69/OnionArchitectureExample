

namespace Shop.Application.Dto.Category
{
    public class CategoryListDto
    {
        public string Name { get; set; }
        public int? ParentId { get; set; }
        public int ChildrenCount { get; set; }
        public bool HasChild => ChildrenCount > 0;
    }
}
