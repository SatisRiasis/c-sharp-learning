namespace _03_StringBasics
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Initialization
            Console.WriteLine("===INITIALIZATION AND VARIABLES OUTPUT===");
            string needsBarber = "    hairHeadiarh  ";
            string pets = "cat, Parrot, cat, Dog, cat, bRuh";
            string dummy = "";

            Console.WriteLine($"string needsBarber = {needsBarber}.");
            Console.WriteLine($"string pets = {pets}");
            Console.WriteLine($"string dummy = {dummy}\n");

            //Upper and lower cases
            Console.WriteLine("===CASE CONVERSION===");
            Console.WriteLine($"pets in uppercase: {pets.ToUpper()}");
            Console.WriteLine($"pets in lowercase: {pets.ToLower()}\n");

            //Length and index
            Console.WriteLine("===STRING LENGTH AND CHARACTER INDEXES===");
            Console.WriteLine($"Length of pets = {pets.Length}");
            Console.WriteLine($"Index of the first cat in pets = {pets.IndexOf("cat")}");
            Console.WriteLine($"Index of the second cat in pets = {pets.IndexOf("cat", pets.IndexOf("cat") + 1)}");
            Console.WriteLine($"Index of the last cat in pets = {pets.LastIndexOf("cat")}");
            Console.WriteLine($"Index of the first cat in needsBarber = {needsBarber.IndexOf("cat")}\n");

            //Is null or not
            Console.WriteLine("===EMPTY CHECK===");
            Console.WriteLine($"Is needsBarber null or white space: {string.IsNullOrWhiteSpace(needsBarber)}");
            Console.WriteLine($"Is dummy null or white space: {string.IsNullOrWhiteSpace(dummy)}\n");

            //Trim
            Console.WriteLine("===TRIM METHODS===");
            Console.WriteLine($"Trimmed needsBarber = {needsBarber.Trim()}.");
            Console.WriteLine($"Fully trimmed needsBarber = {needsBarber.Trim().Trim('h', 'a', 'i', 'r')}.");
            Console.WriteLine($"Left-trimmed of needsBarber = {needsBarber.TrimStart()}.");
            Console.WriteLine($"Right-trimmed of needsBarber = {needsBarber.TrimEnd()}.\n");

            //Searching
            Console.WriteLine("===STRING SEARCHING===");
            Console.WriteLine($"Does pets start with ca: {pets.StartsWith("ca")}");
            Console.WriteLine($"Does dummy end with ca: {dummy.EndsWith("ca")}");
            Console.WriteLine($"Does needsBarber contain ad: {needsBarber.Contains("ad")}\n");

            //Replacing and substring extraction
            Console.WriteLine("===REPLACE AND SUBSTRING METHODS===");
            Console.WriteLine($"Replacing cat with lion in pets: {pets.Replace("cat", "lion")}");
            Console.WriteLine($"Extracting substring from index 18 in pets: {pets.Substring(18)}");
            Console.WriteLine($"\"Beheading\" of needsBarber: {needsBarber.Substring(8, 4)}\n");

            //Split and join
            Console.WriteLine("===SPLITTING AND JOINING===");

            string[] animals = pets.Split(", ");

            Console.WriteLine($"Splitting pets by \", \" and rearranging its parts: {animals[3]}, {animals[4]}, {animals[1]}, {animals[2]}, {animals[0]}, {animals[5]}");

            pets = string.Join(" | ", animals);

            Console.WriteLine($"Joining the parts back into a string: {pets}\n");

            //User card parser
            string rawUserData = "   Alex Johnson;22;alex.johnson@gmail.com;C#,SQL,ASP.NET Core   ";
            string[] splitUserData = rawUserData.Trim().Split(";");
            string[] skills = splitUserData[3].Split(",");

            Console.WriteLine("===USER CARD===");
            Console.WriteLine($"Raw user data: {rawUserData}.\n");
            Console.WriteLine($"Full name: {splitUserData[0]}");
            Console.WriteLine($"Age: {splitUserData[1]}");
            Console.WriteLine($"Email: {splitUserData[2]}");
            Console.WriteLine($"Skills:\n  -{skills[0]}\n  -{skills[1]}\n  -{skills[2]}");
        }
    }
}
