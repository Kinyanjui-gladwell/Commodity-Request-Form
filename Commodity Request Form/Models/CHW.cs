using Microsoft.EntityFrameworkCore;
using System.ComponentModel.DataAnnotations;
namespace Commodity_Request_Form.Models
{
    public class CHW
    {
        [Key]
        public int CHW_ID { get; set; }
        public string F_Name { get; set; }
        public string L_Name { get; set; }
        public int CHA_ID { get; set; }
        public CHA CHA { get; set; }
        public ICollection<Commodity> Commodities { get; set; }

    }
}
