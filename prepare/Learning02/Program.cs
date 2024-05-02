using System;

class Program
{
    static void Main()
    {
        // Create jobs
        Job job1 = new Job("Microsoft", "Software Engineer", 2019, 2022);
        Job job2 = new Job("Apple", "Manager", 2022, 2023);

        // Display company of each job
        job1.Display();
        job2.Display();
        
        // Create a resume
        Resume myResume = new Resume("Murillo de Jesus");
        
        // Add jobs to the resume
        myResume.AddJob(job1);
        myResume.AddJob(job2);

        // Display resume
        myResume.Display();
    }
}