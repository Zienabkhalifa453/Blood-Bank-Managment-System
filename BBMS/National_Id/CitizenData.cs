namespace National_ID
{
    struct CitizenData
    {
        public int Age { get; }
        public int YearOfBirth { get; }
        public byte MonthOfBirth { get; }
        public byte DayOfBirth { get; }
        public string Governorate { get; }
        public string Gender { get; }


        public CitizenData(int age, int yearOfBirth, byte monthOfBirth, byte dayOfBirth, string governorate, string gender)
        {
            Age = age;
            YearOfBirth = yearOfBirth;
            MonthOfBirth = monthOfBirth;
            DayOfBirth = dayOfBirth;
            Governorate = governorate;
            Gender = gender;
        }
    }
}