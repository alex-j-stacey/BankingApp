namespace AJS.Banking.BL
{
    public class Person
    {
        public string SSN { get; set; } = "";
        public string FirstName { get; set; } = "";
        public string LastName { get; set; } = "";
        public string FullName { get { return ToString(); } }
        public int Age { get { return DateTime.Now.Year - BirthDate.Year; } }
        public DateTime BirthDate { get; set; } 

        // allows full name to be displayed in listbox on form
        public override string ToString() { return FirstName + " " + LastName; }
    }
}