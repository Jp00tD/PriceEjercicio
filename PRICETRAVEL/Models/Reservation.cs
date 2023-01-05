using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace PRICETRAVEL.Models
{
    public class Reservation
    {
        public int reservationId { get; set; }
        public DateTime dtCreated { get; set; }

        [Column(TypeName = "decimal(18,2)")]
        //[RegularExpression(@"^(0|-?\d{0,16}(\.\d{0,2})?)$")]
        public decimal amount { get; set; }
        public string? currency { get; set; }
        public int userIdCreatedBy { get; set; }    
        public int csaid { get; set; }
    }
}
