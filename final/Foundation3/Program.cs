using System;

class Program
{
    static void Main(string[] args)
    {
        Lectures lecture = new Lectures("Why Having Fun Is the Secret to a Healthier Life", "A lectures about how to have a healthier life and how to have fun in everything that we do everyday.", "March 31, 2023", "9:00 PM", "Madison Square Garden", "Catherine Price", "3,000" );
        Console.WriteLine("Event:");
        lecture.getLectureShort();
        Console.WriteLine();
        Console.WriteLine("Details:");
        lecture.getStandardDetails();
        Console.WriteLine();
        Console.WriteLine("Full Details of the event:");
        lecture.getStandardDetails();
        lecture.getLectureDetails();
        Console.WriteLine();
        Console.WriteLine("----------------");
        Console.WriteLine();

        Reception reception = new Reception("Isaac x Rebekah Wedding Reception", "A celebration of love between two lovers together with their loved ones and friends.", "May 21, 2023", "6:00 PM", "Marco Polo Hotel", "jacobandrebekah@mymail.com");
        Console.WriteLine("Event:");
        reception.getReceptionShort();
        Console.WriteLine();
        Console.WriteLine("Details:");
        reception.getStandardDetails();
        Console.WriteLine();
        Console.WriteLine("Full Details of the event:");
        reception.getStandardDetails();
        Console.WriteLine();
        reception.getReceptionDetails();
        Console.WriteLine();
        Console.WriteLine("----------------");
        Console.WriteLine();

        Outdoor outdoor = new Outdoor("Find the Easter Egg!", "Come, join us as we have fun finding the easter egg this easter afternoon!", "April 09, 2023", "12:00 PM", "Easton Amusement Park", "Sunny afternoon");
        Console.WriteLine("Event:");
        outdoor.getOutdoorShort();
        Console.WriteLine();
        Console.WriteLine("Details:");
        outdoor.getStandardDetails();
        Console.WriteLine();
        Console.WriteLine("Full Details of the event:");
        outdoor.getStandardDetails();
        outdoor.getOutdoorDetails();
    }
}