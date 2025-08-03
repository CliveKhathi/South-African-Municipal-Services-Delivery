using System.ComponentModel.DataAnnotations;

namespace South_African_Municipal_Services_Delivery.Models.Entities
{
    public class ReportIssues
    {
      
            [Required]
            public string Location { get; set; }
            [Required]
            public string Category { get; set; }
            [Required]
            public string Description { get; set; }
            [Required]
            public IFormFile File { get; set; }
        
    }
}
