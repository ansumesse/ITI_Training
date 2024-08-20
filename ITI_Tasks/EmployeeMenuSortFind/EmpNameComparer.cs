namespace EmployeeMenuSortFind
{
    public class EmpNameComparer : IComparer<Employee>
    {
        public int Compare(Employee employee1, Employee employee2)
        {

            return string.Compare(employee1.Name, employee2.Name);
        }
    }
}
