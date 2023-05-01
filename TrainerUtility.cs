namespace mis_221_pa_5_johnmarkjames
{
    public class TrainerUtility
    {
        private Trainer[] myTrainers;

        public TrainersUtility(Trainer[] myTrainers) {
            this.myTrainers = myTrainers;
        }

        public void AddTrainer() {
            Trainer.SetCount(0);
            System.Console.WriteLine("Please enter trainer name, STOP to stop.");
            string userInput = Console.ReadLine();
            while(userInput.ToUpper() != "STOP") {
                myTrainers[Trainer.GetCount()] = new Trainer();
                myTrainers[Trainer.GetCount()].SetTrainerName(userInput);
                System.Console.WriteLine("Please enter the trainer ID:");
                myTrainers[Trainer.GetCount()].SetTrainerId(int.Parse(Console.ReadLine()));
                System.Console.WriteLine("Please enter trainer mailing address:");
                myTrainers[Trainer.GetCount()].SetMailingAddress(Console.ReadLine()); //might be a problem
                System.Console.WriteLine("Please enter trainer email address: ");
                myTrainers[Trainer.GetCount()].SetEmailAddress(Console.ReadLine());
                Trainer.SetCount(Trainer.GetCount()+1);
                System.Console.WriteLine("Please enter trainer name, STOP to stop."); //update read
                userInput = Console.ReadLine();
            }
            Save();
        }
        public void EditTrainer() {
            Trainer.SetCount(0);
            System.Console.WriteLine("Please enter trainer name, STOP to stop.");
            string userInput = Console.ReadLine();
            while(userInput.ToUpper() != "STOP") {
                myTrainers[Trainer.GetCount()] = new Trainer(); // how do i Reference what i want to edit?
                myTrainers[Trainer.GetCount()].SetTrainerName(userInput);
                System.Console.WriteLine("Please enter the trainer ID:");
                myTrainers[Trainer.GetCount()].SetTrainerId(int.Parse(Console.ReadLine()));
                System.Console.WriteLine("Please enter trainer mailing address:");
                myTrainers[Trainer.GetCount()].SetMailingAddress(Console.ReadLine()); //might be a problem
                System.Console.WriteLine("Please enter trainer email address: ");
                myTrainers[Trainer.GetCount()].SetEmailAddress(Console.ReadLine());
                Trainer.SetCount(Trainer.GetCount()+1);
                System.Console.WriteLine("Please enter trainer name, STOP to stop."); //update read
                userInput = Console.ReadLine();
            }
            Save();
        }

        public void DeleteTrainer(){

        }


      private void Save() {
        StreamWriter outFile = new StreamWriter("trainers.txt");

        for(int i = 0; i < Trainer.GetCount(); i++) {
            outFile.WriteLine(myTrainers[i].ToFile()); //maybe wrong variable
        }
        outFile.Close();
      } 

      public int Find(int searchVal){
        for(int i = 0; i < Trainer.GetCount(); i++){
            if(myTrainers[i].GetTrainerId()== searchVal){
                return i;
            }
        }
        return -1;
      }
        public void GetAllTrainersFromFile() {
            StreamReader inFile = new StreamReader("trainers.txt");

            Trainer.SetCount(0);
            string line = inFile.ReadLine();
            while(line != null) {
                string [] temp = line.Split('#');
                myTrainers[Trainer.GetCount()] = new Trainer(int.Parse(temp[0]), temp[1], temp[2], temp[3]);
                Trainer.IncCount();
                line = inFile.ReadLine();
            }

            inFile.Close();
        }
    }
}
