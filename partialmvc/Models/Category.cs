using System.ComponentModel.DataAnnotations;

namespace partialmvc.Models
{
    public class Category:BaseEntity
    {
        public string Name { get; set; }
        [MaxLength(500)]
        public string Description { set; get; }
        public int? ParentID { set; get; }
    }
}