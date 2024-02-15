namespace NUnitDemonstration
{
    public static class Triangle
    {
        public static string ValidTriangle(int firstAngle, int secondAngle, int
        thirdAngle)
        {
            string result; // Gagandeep Singh id: 8990191
            if ((firstAngle + secondAngle + secondAngle) == 180) // source code after deleting mutant 
            {
                result = "The triangle is valid.";
            }
            else
            {
                result = "The triangle is NOT valid.";
            }
            return result;
        }
    }
}