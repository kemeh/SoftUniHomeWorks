using System;

class Program
{
    static void Main()
    {
        try
        {
            var studentTokens = Console.ReadLine().Split();
            var workerTokens = Console.ReadLine().Split();
            Student student = new Student(studentTokens[0], studentTokens[1], studentTokens[2]);           
            Worker worker = new Worker(workerTokens[0], workerTokens[1], decimal.Parse(workerTokens[2]),
                double.Parse(workerTokens[3]));

            Console.WriteLine(student.ToString());
            Console.WriteLine();
            Console.WriteLine(worker.ToString());
        }
        catch (ArgumentException ex)
        {
            Console.WriteLine(ex.Message);
        }
    }
}