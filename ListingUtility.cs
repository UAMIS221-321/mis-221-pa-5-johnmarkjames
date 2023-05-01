namespace mis_221_pa_5_johnmarkjames
{
    public class ListingUtility
    {
        private Listing [] myListing;
        internal static object listing;

        public ListingUtility(Listing[] myListing) {
            this.myListing = myListing;
        }

        public void GetAllListings() {
            Listing.SetCount(0);
            System.Console.WriteLine("Please enter trainer name, STOP to stop.");
            string userInput = Console.ReadLine();
            while(userInput.ToUpper() != "STOP") {
                myListing[Listing.GetCount()] = new Listing();
                myListing[Listing.GetCount()].SetTrainerName(userInput);
                System.Console.WriteLine("Please enter the trainer id:");
                myListing[Trainer.GetCount()].SetListingId(int.Parse(Console.ReadLine()));
                System.Console.WriteLine("Please enter session date address:");
                myListing[Trainer.GetCount()].SetSesDate(double.Parse(Console.ReadLine())); //might be a problem
                System.Console.WriteLine("Please enter session time: ");
                myListing[Trainer.GetCount()].SetSesTime(double.Parse(Console.ReadLine()));
                System.Console.WriteLine("Please enter session cost: ");
                myListing[Trainer.GetCount()].SetSesTime(double.Parse(Console.ReadLine()));
                Trainer.SetCount(Trainer.GetCount()+1);
                System.Console.WriteLine("Please enter trainer name, STOP to stop."); //update read
                userInput = Console.ReadLine();
            }
        }

        public void AddListing(){

        }

        public void EditListing() {

        }

        public void DeleteListing() {
            
        }
        
        public void GetAllListFromFile() {
            StreamReader inFile = new StreamReader("listing.txt");

            Listing.SetCount(0);
            string line = inFile.ReadLine();
            while(line != null) {
                string [] temp = line.Split('#');
                myListing[Listing.GetCount()] = new Listing(int.Parse(temp[0]), temp[1], double.Parse(temp[2]), double.Parse(temp[3]), double.Parse(temp[4]));
                Listing.IncCount();
                line = inFile.ReadLine();
            }

            inFile.Close();
        }

        internal static int Find(int userInput)
        {
            throw new NotImplementedException();
        }
    }
}