using Microsoft.AspNetCore.Mvc;
using PRICETRAVEL.Models;

namespace PRICETRAVEL.Controllers
{
    [ApiController]
    [Route("[[Reservations]]")]
    public class ReservationController : ControllerBase
    {
        [HttpGet]
        [Route("{Reservation}")]
        public dynamic ListReservation()
        {


            List<Reservation> Reservation1 = new List<Reservation>
            {
                new Reservation
                {
                    reservationId = 1,
                    dtCreated = DateTime.Now,
                    amount = 1500,
                    currency = "dolar",
                    userIdCreatedBy = 2

                }

            };
            return Reservation1;
        }

        [HttpPost]
        [Route("{Save-Reservation}")]
        public dynamic SaveReservation(Reservation reservation)
        {
            reservation.reservationId = 1;
            return new
            {
                success = true,
                message = "confirmed reservation ",
                result = reservation
            };
        }
        [HttpDelete]
        [Route("{Delete-Reservation}")]
        public dynamic DeleteReservation(Reservation reservation)
        {

           string token =  Request.Headers.Where(x => x.Key == "Authorization").FirstOrDefault().Value;

            if(token != "ACCES13")
            {
                return new
                {
                    success = false,
                    message = "Token incorrecto",
                    result = ""
                };
            }

            return new
            {
                success = true,
                message = " reservation deleted ",
                result = reservation
            };
        }

        [HttpPut]
        [Route("{Edit-Reservation}")]
        public dynamic EditReservation(Reservation reservation)
        {
            if(reservation.reservationId == 0 )
            {
                return new
                {
                    success = false,
                    message = "Reservacion no encontrada",
                    result = ""
                };
            }

            reservation.reservationId = 1;
            return new
            {
                success = true,
                message = "Modified Reservation",
                result = reservation
            };

        }


    }
}
