using System.ComponentModel.DataAnnotations;

namespace CoreProjeApi.DAL.Entity
{
    public class Category
    {
        [Key]
        public int CategoryId { get; set; }
        public string CategoryName { get; set; }
    }
}
