namespace EmployeeMenuSortFind
{
    public class EmpIdComparer : IComparer<Employee>
    {
        public int Compare(Employee employee1, Employee employee2)
        {

            if (employee1.ID < employee2.ID)
                return -1;
            else if (employee1.ID > employee2.ID)
                return 1;
            else
                return 0;

        }
    }
}
