namespace _08.AnimalShelter
{
    public class Pet
    {
        public int PetId;
        public string Name;
        public string Color;
        public string Gender;
        public string Description;
        
        // 생성자 만들기
        public Pet(int petId, string name, string color, string gender)
        {
            this.PetId = petId;
            this.Name = name;
            this.Color = color;
            this.Gender = gender;
        }


        // 메서드 (Method)(함수)
        public virtual string MakeSound()
        {
            return "";
        }
    }
}