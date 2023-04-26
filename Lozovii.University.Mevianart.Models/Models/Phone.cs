using System.ComponentModel.DataAnnotations;

namespace Lozovii.University.Mevianart.Models
{
    public class Phone : DbItem
    {

        public string? FirstName { get; set; }

        public int? LastName { get; set; }

        public string? Email { get; set; }

        public string? Password { get; set; }
    }
    public class DbItem
    {
        public int Id { get; set; }
    }
}
