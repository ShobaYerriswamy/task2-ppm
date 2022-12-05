using System;
using ProlificsProjectManager.PPM.MAIN.PPM.MODEL;

namespace ProlificsProjectManager.PPM.MAIN.PPM.DOMAIN
{
    public class ProjectManager
    {
        List<Project> Projects = new List<Project>();
        public void AddProject(Project project)
        {
            Projects.Add(project);
        }
        public void displayAllProjects(Project project)
        {
            Console.WriteLine("[" + project.ProjectName + "]");
        }
        public void ViewProject()
        {
            foreach (var i in Projects)
            {
                displayAllProjects(i);
            }
        }
    }

    public class EmployeeManager
    {
        List<Employee> Employees = new List<Employee>();
        public void AddEmployee(Employee employee)
        {
            Employees.Add(employee);
        }
        public void displayAllEmployees(Employee employee)
        {
            Console.WriteLine("[" + employee.EmployeeName + "]");
        }
    
        public void ViewEmployee()
        {
            foreach (var i in Employees)
            {
                displayAllEmployees(i);
            }
        }
    }

    public class RoleManager
    {
        List<Role> Roles = new List<Role>();
    
        public void AddRole(Role role)
        {
            Roles.Add(role);
        }
    
        public void displayAllRoles(Role role)
        {
            Console.WriteLine("[" + role.RoleName + "]");
        }
    
        public void ViewRole()
        {
            foreach (var i in Roles)
            {
                displayAllRoles(i);
            }
        }
    }
}
