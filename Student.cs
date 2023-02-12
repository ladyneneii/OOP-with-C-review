// Class Methods

namespace Tutorial
{
    class Student 
    {
        public string name;
        public string major;
        public double gpa;

        public Student(string _name, string _major, double _gpa)
        {
            name = _name;
            major = _major;
            gpa = _gpa;
        }

        public bool HasHonours()
        {
            if (gpa > 3.5)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}