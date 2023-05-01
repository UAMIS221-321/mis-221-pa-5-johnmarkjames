namespace mis_221_pa_5_johnmarkjames
{
    public class Booking
    {
        private object trainerUtility;

        public void BookSession(){
            Transaction newTransaction = new Transaction();
            System.Console.WriteLine();
            System.Console.WriteLine();
            System.Console.WriteLine("Enter your session's identification number");
            int userInput = int.Parse(Console.ReadLine());
            newTransaction.SetSession(userInput);
            System.Console.WriteLine("Enter name");
            newTransaction.SetCustomerName(Console.ReadLine());
            System.Console.WriteLine("Enter email");
            newTransaction.SetCustomerEmail(Console.ReadLine());

            Listing listingBooking = ListingUtility.listing[ListingUtility.Find(userInput)];
            newTransaction.SetTrainerDate(listingBooking.GetSesDate());
            newTransaction.SetTrainerName(listingBooking.GetTrainerName());

            string trainerName = listingBooking.GetTrainerName();

            Trainer trainerBooking = TrainerUtility.trainer[trainerUtility.Find(trainerName)];
            newTransaction.SetTrainerId(trainerBooking.GetTrainerId());
            newTransaction.SetStatus("booked");

            transactions[Transaction.GetCount()];
            Transaction.IncCount();

            Save();
        }
        private void Save(){
            StreamWriter outFile = new StreamWriter("transaction.txt");

            for(int i = 0; i < Transaction.GetCount(); i++){
                outFile.WriteLine(transactions[i].ToFile());
            }

            outFile.Close();
        }
    }
}