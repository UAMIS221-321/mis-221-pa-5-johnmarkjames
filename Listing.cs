namespace mis_221_pa_5_johnmarkjames
{
    public class Listing
    {
        private int listingId;
        private string trainerName;
        private double sesDate;
        private double sesTime;
        private double sesCost;
        static public int count;

         //constructor
        public Listing(int listingId, string trainerName, double sesDate, double sesTime, double sesCost) {
            this.listingId = listingId;
            this.trainerName = trainerName;
            this.sesDate = sesDate;
            this.sesTime = sesTime;
            this.sesCost= sesCost;
        }

        public Listing() { // no arg constructor
        }

        //getters
        public int GetListingId() {
            return listingId;
        }
        public string GetTrainerName() {
            return trainerName;
        }
        public double GetSesDate() {
            return sesDate;
        }
        public double GetSesTime() {
            return sesTime;
        }
        public double GetSesCost(){
            return sesCost;
        }
        static public int GetCount() {
            return count;
        }

        //setters
        public void SetListingId(int listingId) {
            this.listingId = listingId;
        }
        public void SetTrainerName(string trainerName) {
            this.trainerName = trainerName;
        }
        public void SetSesDate(double sesDate) {
            this.sesDate = sesDate;
        }
        public void SetSesTime(double sesTime) {
            this.sesTime = sesTime;
        }
        public void SetSesCost(double sesCost) {
            this.sesCost = sesCost;
        }
        static public void SetCount(int count) {
            Trainer.count = count;
        }
        
        //other
        public override string ToString() {
            return $"ID: {listingId}, Name: {trainerName}, Date: {sesDate}, Time: {sesTime}, Costs: {sesCost}";
        }

        public string ToFile() {
            return $"{listingId}#{trainerName}#{sesDate}#{sesTime}#{sesCost}";
        }
        public int CompareTo(int i){
            if(i == listingId) return 0;
            if(i < listingId) return -1;
            return 1;
        }
        public static void IncCount() {
            Listing.count++;
        }

    }
}
