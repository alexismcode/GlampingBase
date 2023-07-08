using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GlampingContent.Logica
{
    public class Reservation : Client
    {
        private decimal _reservationDays;
        public decimal ReservationDays
        {
            get => _reservationDays; 
            set => _reservationDays = ValidateReservationDays(value);
        }
        public override decimal TotalPayment()
        {
            return ReservationDays * 50.00m;
        }
        public override string ToString()
        {
            return $"{base.ToString()}\n\t" +
                   $"Reservation Days...........{ReservationDays}\n\t" +
                   $"Total Payment..............{TotalPayment():C2}";
        }

        private decimal ValidateReservationDays(decimal value)
        {
            if (value > 4)
            {
                throw new ArgumentException("Los dias de reservan excedieron los 4 dias");
            }
            return value;
        }
    }

}
