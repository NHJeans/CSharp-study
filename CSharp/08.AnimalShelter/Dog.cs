namespace _08.AnimalShelter
{
    // 열거형 데이터 타입
    public enum DogBreed{Mixed, Bulldong, Jindo, Yorkshire}
    
    public class Dog
    {
        public int PetId;
        public string Name;
        public string Color;
        public string Gender;
        public string Description;
        public DogBreed Breed;

        // 생성자 만들기
        public Dog(int petId, string name, string color, string gender, DogBreed breed)
        {
            this.PetId = petId;
            this.Name = name;
            this.Color = color;
            this.Gender = gender;
        }


        // 메서드 (Method)(함수)
        public string MakeSound()
        {
            return "멍멍!";
        }

        public string Bite()
        {
            return "물어뜯기";
        }
    }
}