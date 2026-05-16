using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello World! This is the Resumes Project.");
    


        // Create first job
        Job job1 = new Job();
        job1._jobTitle = "Project Manager";
        job1._company = "Diamond Creationa";
        job1._startYear = 2012;
        job1._endYear = 2016;

        // Create second job
        Job job2 = new Job();
        job2._jobTitle = "Managing Director";
        job2._company = "Diamond Creations";
        job2._startYear = 2016;
        job2._endYear = 2026;

        // Create resume
        Resume myResume = new Resume();


        myResume._name = "Olusola Onoja";

        // Add jobs to resume
        myResume._jobs.Add(job1);
        myResume._jobs.Add(job2);

        // Display resume
        myResume.Display();
    }
}