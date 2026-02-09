namespace Architecture.src.OOPPrinciples.OOPRelationShip.Aggregation
{
    public class Aggregation
    {
        class Employee
        {
            public string Name { get; set; }
        }
        class Company
        {
            public List<Employee> Employees { get; set; } // Aggregation
        }
    }

}
