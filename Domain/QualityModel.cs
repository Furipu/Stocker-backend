using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace Domain
{
    public class QualityModel
    {
        public int Id { get; set; }
        [Required(ErrorMessage = "QualityName is required")]
        public string QualityName { get; set; }

    }
}
