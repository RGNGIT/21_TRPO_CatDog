namespace _21_TRPO_CatDog
{
    [Serializable]
    public static class PlainDatabase
    {
        [Serializable]
        public class Pet
        {

            public Pet(string Name, string DOB, string Kind, string Sex, string Breed, string OwnerFIO, DateTime DateCall, string ReasonCall)
            {
                this.Name = Name;
                this.DOB = DOB;
                this.Kind = Kind;
                this.Sex = Sex;
                this.Breed = Breed;
                this.OwnerFIO = OwnerFIO;
                this.DateCall = DateCall;
                this.ReasonCall = ReasonCall;
            }

            public void Updater(string Name, string DOB, string Kind, string Sex, string Breed, string OwnerFIO, DateTime DateCall, string ReasonCall)
            {
                this.Name = Name;
                this.DOB = DOB;
                this.Kind = Kind;
                this.Sex = Sex;
                this.Breed = Breed;
                this.OwnerFIO = OwnerFIO;
                this.DateCall = DateCall;
                this.ReasonCall = ReasonCall;
            }

            public string? Name { get; set; }
            public string? DOB { get; set; }
            public string? Kind { get; set; }
            public string? Sex { get; set; }
            public string? Breed { get; set; }
            public string? OwnerFIO { get; set; }
            public DateTime? DateCall { get; set; }
            public string? ReasonCall { get; set; }
        }

        public static List<string> AnimalKind = new List<string>();
        public static List<string> BreedKind = new List<string>();
        public static List<Pet> Pets = new List<Pet>();
    }
}
