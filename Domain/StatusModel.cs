using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace Domain
{
    public class StatusModel
    {
        public int Id { get; set; }
        [Required(ErrorMessage = "Name is required")]
        public string StatusName { get; set; }

    }
}
