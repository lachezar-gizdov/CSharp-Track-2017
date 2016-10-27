using System;

class CompanyInfo
{
    static void Main()
    {
        string companyName = Console.ReadLine();
        string companyAddress = Console.ReadLine();
        string companyPhone = Console.ReadLine();
        string faxNum = Console.ReadLine();
        string companyWebSite = Console.ReadLine();
        string managerFirstName = Console.ReadLine();
        string managerLastName = Console.ReadLine();
        sbyte managerAge = sbyte.Parse(Console.ReadLine());
        string managerPhone = Console.ReadLine();
        string managerFullname = managerFirstName + " " + managerLastName;

        if (faxNum == "")
        {
            faxNum = "(no fax)";
        }

        Console.WriteLine(companyName);
        Console.WriteLine("Address: {0}", companyAddress);
        Console.WriteLine("Tel. {0}", companyPhone);
        Console.WriteLine("Fax: {0}", faxNum);
        Console.WriteLine("Web site: {0}", companyWebSite);
        Console.WriteLine("Manager: {0} (age: {1}, tel. {2})", managerFullname, managerAge, managerPhone);
    }
}