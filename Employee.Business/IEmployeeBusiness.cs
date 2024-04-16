using Employee.Model;

namespace Employee.Business.Business
{
    public interface IEmployeeBusiness
    {
        IEnumerable<EmployeeMaster> GetEmployeebyid(int id);
        IEnumerable<EmployeeMaster> GetEmployeebyid();
        IEnumerable<object> GetList();
        IEnumerable<object> GetTotalSalary(int empID, DateTime dateTimeFrom, DateTime dateTimeTo);
    }
}