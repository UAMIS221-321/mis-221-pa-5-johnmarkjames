namespace mis_221_pa_5_johnmarkjames
{
    public class Trainer
    {
        private int trainerId;
        private string trainerName;
        private string mailingAddress;
        private string emailAddress;
        static public int count;

        //constructor
        public Trainer(int trainerId, string trainerName, string mailingAddress, string emailAddress) {
            this.trainerId = trainerId;
            this.trainerName = trainerName;
            this.mailingAddress = mailingAddress;
            this.emailAddress = emailAddress;
        }

        public Trainer()
        {
        }

        //getters
        public int GetTrainerId() {
            return trainerId;
        }
        public string GetTrainerName() {
            return trainerName;
        }
        public string GetMailingAddress() {
            return mailingAddress;
        }
        public string GetEmailAddress() {
            return emailAddress;
        }
        static public int GetCount() {
            return count;
        }

        //setters
        public void SetTrainerId(int trainerId) {
            this.trainerId = trainerId;
        }
        public void SetTrainerName(string trainerName) {
            this.trainerName = trainerName;
        }
        public void SetMailingAddress(string mailingAddress) {
            this.mailingAddress = mailingAddress;
        }
        public void SetEmailAddress(string emailAddress) {
            this.emailAddress = emailAddress;
        }
        static public void SetCount(int count) {
            Trainer.count = count;
        }
        
        
        //other
        public override string ToString() {
            return $"ID: {trainerId}, Name: {trainerName}, Address: {mailingAddress}, Email: {emailAddress}";
        }

        public string ToFile() {
            return $"{trainerId}#{trainerName}#{mailingAddress}#{emailAddress}";
        }
        public int CompareTo(int i){
            if(i == trainerId) return 0;
            if(i < trainerId) return -1;
            return 1;
        }
        public static void IncCount() {
            Trainer.count++;
        }

    }
}

