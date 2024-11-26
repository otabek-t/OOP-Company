using oopTasks.Model;

namespace oopTasks.userService
{
    
    public class CompanyService
    {
        private List<Company> companies;
        public CompanyService()
        {
            companies = new List<Company>();
        }
        public Company GetById(Guid id)
        {
            foreach (var comp in companies)
            {
                if (comp.Id == id)
                {
                    return comp;
                }

            }
            return null;

        }
        public Company AddDepartment(Company department)
        {
            department.Id = Guid.NewGuid();
            companies.Add(department);
            return department;
        }
        public bool UpdateDepartment(Company department) 
        {
            var updepartment = GetById(department.Id);
            if (updepartment is null)
            {
                return false;
            }
            return true;

        }

        public bool DeleteDepartment(Guid Id)
        {
            var deleteDepartment = GetById(Id);
            if (deleteDepartment is null)
            {
               return false;
            }
            companies.Remove(deleteDepartment);
            return true;
        }

        public List<Company> GetAll() 
        {
            return companies;
        }

    }
}
