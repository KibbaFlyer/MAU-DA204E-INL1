namespace Assignment_1
{
    public class Program
    {
        static async Task Main()
        {
            /*
            // Creating a new Pet instance and calling its Start method
            Pet pet = new Pet();
            pet.Start();

            // Waiting for the user to start the next part
            NextPart();

            // Creating a new TicketSeller instance and calling its Start method
            TicketSeller tSeller = new TicketSeller();
            tSeller.Start();

            // Waiting for the user to start the next part
            NextPart();

            // Creating a new Album instance and calling its Start method
            Album album = new Album();
            album.Start();
            */
            Weather weather = new Weather();
            await weather.Start();
        }
        private static void NextPart()
        {
            Console.WriteLine("\nPress Enter for the next part");
            Console.ReadLine();
        }

    }
}
