internal class Program
{
    static void Main(string[] args)
    {
        var department = GetCurrentDepartment();


        string tmpStr = department.Company.Name;

        if (department?.Company?.Type == "Банк" && department?.City?.Name  == "Санкт-Петербург")
        {
            Console.WriteLine($"У банка {0} есть отделение в Санкт-Петербурге", department?.Company?.Name ?? "Неизвестная компания");
        }

    }

    static Department GetCurrentDepartment()
    {
        // logic

        Department d = new Department();
        return d;
    }
}

class Company
{
    public string Type;
    public string Name;
}

class Department
{
    public Company Company;
    public City City;
}

class City
{
    public string Name;
}