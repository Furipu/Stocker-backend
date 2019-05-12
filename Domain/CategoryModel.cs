using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace Domain
{
    public class CategoryModel
    {
        public int Id { get; set; }
        [Required(ErrorMessage = "Name is required")]
        public string CategoryName { get; set; }
        public int? ParentId { get; set; }
        public List<CategoryModel> Children { get; set; }

    }
}
