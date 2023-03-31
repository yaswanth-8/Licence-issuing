class Program
{
    static int LicenseIssue(string myself, int agents, string customers)
    {
        int iteration = 0;
        string[] names = customers.Split(' ');
        string[] listOfNames = new string[names.Length+1];
        for(iteration = 0; iteration < names.Length; iteration++)
        {
            listOfNames[iteration] = names[iteration];
        }
        listOfNames[iteration] = myself;
        Array.Sort(listOfNames);
        int myIndex = Array.IndexOf(listOfNames, myself);

        int minutes = (myIndex / agents ) * 20;
        minutes += 20;
        return minutes;
    }

    static void Main(string[] args)
    {
        Console.WriteLine(LicenseIssue("Eric", 2, "Adam Caroline Rebecca Frank")); 
        Console.WriteLine(LicenseIssue("Zebediah", 1, "Bob Jim Becky Pat")); 
        Console.WriteLine(LicenseIssue("Aaron", 3, "Jane Max Olivia Sam")); 
    }
}