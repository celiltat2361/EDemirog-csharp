
//IPersonManager customerManager1 = new CustomerManager();
//IPersonManager employeeManager1 = new EmployeeManager();

//employeeManager1.Add();
//employeeManager1.Update();

ProjectManager projectManager = new ProjectManager();
//projectManager.Add(new CustomerManager());
projectManager.Add(new InternManager());

class Person
{
    //interfaceler newlenemz
    //IPersonManager personmanager = new IPersonManager();

}

class Customer : Person
{

}

interface IPersonManager
{
    //implemented operation -- ici dolu operasyon
    void Add();
    void Remove();
    void Update();
}
//inherits - class -------------------- implement - interface
class CustomerManager : IPersonManager
{
    public void Add()
    {
        Console.WriteLine("Customer added..");
    }

    public void Remove()
    {
        Console.WriteLine("Customer removed..");
    }

    public void Update()
    {
        Console.WriteLine("Customer updated..");
    }
}

class EmployeeManager : IPersonManager
{
    public void Add()
    {
        Console.WriteLine("Employee added..");
    }

    public void Remove()
    {
        Console.WriteLine("Employee removed..");
    }

    public void Update()
    {
        Console.WriteLine("Employee updated..");
    }
}

class ProjectManager
{
    public void Add(IPersonManager personManager)
    {
        personManager.Add();
    }
}

class InternManager : IPersonManager
{
    public void Add()
    {
        Console.WriteLine("Added intern..");
    }

    public void Remove()
    {
        Console.WriteLine("Removed intern..");
    }

    public void Update()
    {
        Console.WriteLine("Updated intern...");
    }
}