using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GlampingContent.Logica
{
    public abstract class Client
    {
        public Date? ReservationDate { get; set; }
        public string? FullName { get; set; }
        public int Phone { get; set; }
        public string? Email { get; set; }

        public override string ToString()
        {
            return $"Fecha de reserva: {ReservationDate}\n\t" +
                   $"Cliente: {FullName}\n\t" +
                   $"Celular: +593 {Phone}\n\t" +
                   $"Cliente: {Email}";
        }
        public abstract decimal TotalPayment();
    }
}

