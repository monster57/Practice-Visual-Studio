namespace PartialClassSpike
{
    partial class Employee
    {
        public override string ToString()
        {
            return "{" + employeeId + " , " + name + " , " + Salary + "}";
        }
    }
}