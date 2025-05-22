using System.ComponentModel.DataAnnotations;

namespace Commodity_Request_Form.Models
{
    public class CHA
    {
        [Key]
        public int CHA_ID { get; set; }
        public string F_Name { get; set; }
        public string L_Name { get; set; }
        public ICollection<CHW> CHWs { get; set; }
        public ICollection<Commodity> Commodities { get; set; }


    }
}
