namespace PIT2022
{
    public class Student
    {
        private string _firstName;
        public string FirstName
        {
            get => _firstName;
            set
            {
                if (value == string.Empty)
                {
                    Console.WriteLine("incorrect value: firstname empty value");
                    return;
                }
                _firstName = value;
            }
        }

        public int Age;

        public Student(string firstName, DateTime birthday, string middleName)
        {
            FirstName = firstName;
            Birthday = birthday;
            MiddleName = middleName;
        }

        public DateTime Birthday
        {
            get => _birthday;
            set
            {
                if (value.Year < 1200)
                {
                    Console.WriteLine("incorrect value date " + value.Year);
                    return;
                }
                _birthday = value;
            }
        }

        private DateTime _birthday { get; set; }
        
        public string MiddleName { get; private set; }
        
    } 
}
