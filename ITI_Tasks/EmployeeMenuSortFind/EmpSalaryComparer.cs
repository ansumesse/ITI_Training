namespace EmployeeMenuSortFind
{
    public class EmpSalaryComparer : IComparer<Employee>
    {
        public int Compare(Employee employee1, Employee employee2)
        {

            if (employee1.Salary < employee2.Salary)
                return -1;
            else if (employee1.Salary > employee2.Salary)
                return 1;
            else
                return 0;

        }
    }
}
