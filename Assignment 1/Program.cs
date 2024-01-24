namespace Assignment_1
{
    public class Program
    {
        static async Task Main()
        {
            await CallingService();
        }
        // This Method is used to write to the user to press enter to start the next part
        private static async void NextPart()
        {
            Console.WriteLine("\nPress Enter for the next part");
            Console.ReadLine();
            await CallingService();
        }
        private static async Task CallingService()
        {
            // We set a name for the console
            Console.Title = "Startup";
            // Here we define all classes the user can use. I have tried doing this variable (according to all defined clases)
            // but have chosen to leave it hard-coded for now
            List<string> allClassesNames = new List<string> { "Pet", "TicketSeller", "Album", "Weather" };
            // We write out a welcome message with instructions
            Console.WriteLine("Welcome to the Kristoffer Console App!\n\n" +
                "Here you are able to choose any of all the available apps in use to run.\n" +
                "The currently accessible apps are:\n" +
                $"{string.Join(", ", allClassesNames)}\n" +
                $"Please write down the name of the class you want to try");
            // Read the user input
            string chosenClassName = Console.ReadLine();
            // Here, a switch calls each class depending on the user choice
            switch (chosenClassName)
            {
                case "Pet":
                    // Creating a new Pet instance and calling its Start method
                    Pet pet = new Pet();
                    pet.Start();
                    break;
                case "TicketSeller":
                    // Creating a new TicketSeller instance and calling its Start method
                    TicketSeller tSeller = new TicketSeller();
                    tSeller.Start();
                    break;
                case "Album":
                    // Creating a new Album instance and calling its Start method
                    Album album = new Album();
                    album.Start();
                    break;
                case "Weather":
                    // Creating a new Weather object and calling its Start method
                    Weather weather = new Weather();
                    await weather.Start();
                    break;
                default: 
                    Console.WriteLine("The Class doesn't exist");
                    break;
            }
            // After Switch is done, we call the next part, which will reset the application to the start
            NextPart();
        }

    }
}
