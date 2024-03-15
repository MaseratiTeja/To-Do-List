using Microsoft.EntityFrameworkCore;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace To_Do_List.Models
{
    public class Todo
    {
        [Key]
        public int? Id { get; set; }
        public string? Subject { get; set; }
        public string? Description { get; set; }
        public string? ActivitiesNo { get; set; }
        public string? Stats { get; set; }
        public DateTime? CreatedDate { get; set; }
        public DateTime? UpdatedDate { get; set; }
        public CustomUser? CustomUser { get; set; }
        [ForeignKey("CustomUserId")]
        public string? CustomUserId { get; set; }
    }
}
