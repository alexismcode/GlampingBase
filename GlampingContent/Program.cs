using GlampingContent.Logica;

try
{
    var client1 = new Reservation()
    {
        ReservationDate = new Date(2023, 8, 5),
        FullName = "Alexis Moisés Sánchez Sánchez",
        Phone = 0987654321,
        Email = "alexismcode@gmail.com",
        ReservationDays = 4,
    };
    Console.WriteLine(client1);
    

}
catch(Exception ex)
{
    Console.WriteLine($"ERROR:....... [{ex.Message}]");
}
