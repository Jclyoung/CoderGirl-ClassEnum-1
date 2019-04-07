using System;

namespace ClassEnum
{
    public enum CourseType
    {
        Algebra,
        WorldHistory,
        Geography,
        Art,
        English,
        Latin,
        Band,
        Biology,
        Physics,
    }

    class GetCourseSubjectName
    {
        public CourseType Subject { get; set; }
    }

    public static class Program
    {
        public static void Main()
        {            
            Console.ReadLine();
        }

        public static void CourseType(CourseType Subject)
        {
             Console.WriteLine(nameof(CourseType));
        }


        //return the enum subject as a string. IOW, if you pass in CourseSubject.Math, 
        //the method should return "Math".




    }

    //Create an enum named CourseSubject. 
    //It should contain at least 8 subjects, two of which must be Geography and WorldHistory
}
