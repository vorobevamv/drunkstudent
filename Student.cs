namespace drunkstudent
{
    public class Student
    {
        public string Name { get; set; }
        public int Age { get; set; }
        public Bag StudentBag { get; set; }

        public string CountDrunk(Student student)
        {
            if ((student.Age < 20 && student.StudentBag.BeerBottles > 5) || (student.Age >= 20 && student.StudentBag.BeerBottles > 10))
            {
                return "is drunk";
            }
            else if ((student.Age < 20 && student.StudentBag.BeerBottles < 3) || (student.Age >= 20 && student.StudentBag.BeerBottles < 5))
            {
                return "not enought beer";
            }
            else
            {
                return "it's OK with beer";
            }
        }

        public string CountSatiety (Student student)
        {
            if ((student.Age < 20 && student.StudentBag.PizzaPieces > 15) || (student.Age >= 20 && student.StudentBag.PizzaPieces > 10))
            {
                return "too much pizza";
            }
            else if ((student.Age < 20 && student.StudentBag.PizzaPieces < 5) || (student.Age >= 20 && student.StudentBag.PizzaPieces < 4))
            {
                return "is hungry";
            }
            else
            {
                return "it's OK with pizza";
            }
        }
    }
}
