using System;

class Program
{
    static void Main(string[] args)
    {

        Job job1 = new Job ();

        job1._company =  "Apple";
        job1._jobTitle = "IOS Developer";
        job1._endYear = "2017";
        job1._starYear = "2014";

        Job job2 = new Job ();
        job2._company = "Google";
        job2._jobTitle = "Software Engineer";
        job2._starYear = "2017";
        job2._endYear = "2020";

        job1.DisplayJobDetails();
        job2.DisplayJobDetails();

    }
}