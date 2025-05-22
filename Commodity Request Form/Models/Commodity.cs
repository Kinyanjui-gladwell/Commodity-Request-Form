using Commodity_Request_Form.Enums;
using System.ComponentModel.DataAnnotations;

namespace Commodity_Request_Form.Models
{
    public class Commodity
    {
        [Key]
        public int ID { get; set; }
        public string Name { get; set; }

        [Required]
        [Range(1, 99, ErrorMessage = "Quantity must be between 1 and 99.")]
        public int Quantity { get; set; }
        public DateTime DateRequested { get; set; } = DateTime.Now;
        public RequestStatus Status { get; set; } = RequestStatus.Pending;
        public int CHW_ID { get; set; }
        public CHW CHW { get; set; }
        public int CHA_ID { get; set; }
        public CHA CHA { get; set; }

    }
}
