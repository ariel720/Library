
using System.ComponentModel.DataAnnotations;

namespace Library.Models
{
    public class Book : LibraryAsset
    {
        [Key]
        public int Id { get; set; }
        public string ISBN { get; set; }
        public string Author { get; set; }
        public string DeweyIndex { get; set; }
    }
}
