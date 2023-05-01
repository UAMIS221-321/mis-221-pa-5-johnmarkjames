namespace mis_221_pa_5_johnmarkjames;
Menu();

static void Menu(){
    Console.Clear();
    System.Console.WriteLine("╔╗╔╗╔╗    ╔╗                      ╔╗         ╔════╗╔╗   ╔═══╗╔═══╗╔╗");
    System.Console.WriteLine("║║║║║║    ║║                     ╔╝╚╗        ║╔╗╔╗║║║   ║╔═╗║║╔═╗║║║");
    System.Console.WriteLine("║║║║║║╔══╗║║ ╔══╗╔══╗╔╗╔╗╔══╗    ╚╗╔╝╔══╗    ╚╝║║╚╝║║   ║║ ║║║║ ╚╝║║");
    System.Console.WriteLine("║╚╝╚╝║║╔╗║║║ ║╔═╝║╔╗║║╚╝║║╔╗║     ║║ ║╔╗║      ║║  ║║ ╔╗║╚═╝║║║ ╔╗╚╝");
    System.Console.WriteLine("╚╗╔╗╔╝║║═╣║╚╗║╚═╗║╚╝║║║║║║║═╣     ║╚╗║╚╝║     ╔╝╚╗ ║╚═╝║║╔═╗║║╚═╝║╔╗");
    System.Console.WriteLine(" ╚╝╚╝ ╚══╝╚═╝╚══╝╚══╝╚╩╩╝╚══╝     ╚═╝╚══╝     ╚══╝ ╚═══╝╚╝ ╚╝╚═══╝╚╝");
    System.Console.WriteLine("\n"); 
    System.Console.WriteLine("1. Manage Trainer Data"); 
    System.Console.WriteLine("2. Manage Listing Data");     
    System.Console.WriteLine("3. Manage Customer Booking Data");          
    System.Console.WriteLine("4. Run Reports");     
    System.Console.WriteLine("5. Exit Application");   
    string userInput = Console.ReadLine();
    switch(userInput) {
        case "1":
            TrainerData();
            break;
        case "2":
            ListingData();
            break;
        case "3":
            BookingData();
            break;
        case "4":
            RunReports();
            break;
        case "5":
            return;
        default:
            System.Console.WriteLine("Invalid Menu Choice");
            PauseAction();
            break;
    }                                       
}

static void TrainerData() {
    Console.Clear();
    Trainer[] trainer = new Trainer[100];
    TrainersUtility trainersUtility = new TrainersUtility(trainer);
    TrainerReport trainerReport = new TrainerReport(trainer);
    trainersUtility.GetAllTrainersFromFile();
    System.Console.WriteLine("1. Add Trainer");
    System.Console.WriteLine("2. Edit Trainer");
    System.Console.WriteLine("3. Delete Trainer");
    System.Console.WriteLine("4. Exit");
    string userInput = Console.ReadLine();
    Console.Clear();
    trainerReport.PrintAllTrainers();
    switch(userInput){
        case "1":
            trainersUtility.AddTrainer();
            break;
        case "2":
            trainersUtility.EditTrainer();
            break;
        case "3":
            trainersUtility.DeleteTrainer();
            break;
        case "4":
            Menu();
            break;
        default:
            System.Console.WriteLine("Invalid Menu Choice");
            PauseAction();
            break;

    }
}

static void ListingData() {
    Console.Clear();
    Listing[] listing = new Listing [100];
    ListingUtility listingUtility = new ListingUtility(listing);
    ListingReport listingReport = new ListingReport(listing);
    listingUtility.GetAllListFromFile();
    System.Console.WriteLine("1. Add Listing");
    System.Console.WriteLine("2. Edit Listing");
    System.Console.WriteLine("3. Delete Listing");
    System.Console.WriteLine("4. Exit");
    string userInput = Console.ReadLine();
    Console.Clear();
    listingReport.PrintAllListings();
    switch(userInput) {
        case "1":
            listingUtility.AddListing();
            Console.Clear();
            listingReport.PrintAllListings();
            System.Console.WriteLine("\nSuccess!\n");
            PauseAction();
            break;
        case "2":
            listingUtility.EditListing();
            Console.Clear();
            listingReport.PrintAllListings();
            System.Console.WriteLine("\nSuccess!\n");
            PauseAction();
            break;
        case "3":
            listingUtility.DeleteListing();
            Console.Clear();
            listingReport.PrintAllListings();
            System.Console.WriteLine("\nSuccess!\n");
            PauseAction();
            break;
        case "4":
            Menu();
            break;
        default:
            System.Console.WriteLine("Invalid Menu Choice");
            PauseAction();
            break;
    }

}

static void BookingData() {

}

static void RunReports() {

}

static void PauseAction(){
    System.Console.WriteLine("Press any key to continue..."); //pauses from going straght to menu
    Console.ReadKey();
}