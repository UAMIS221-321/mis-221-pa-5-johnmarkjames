namespace mis_221_pa_5_johnmarkjames
{
    public class TrainerReport
    {
        Trainer[] trainers;

        public TrainerReport(Trainer[] trainers) {
            this.trainers = trainers;
        }

        public void PrintAllTrainers() {
            for(int i = 0; i < Trainer.GetCount(); i++) {
                System.Console.WriteLine(trainers[i].ToString());
            }
        }
    }
}