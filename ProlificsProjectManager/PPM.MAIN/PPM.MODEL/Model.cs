using System;

namespace ProlificsProjectManager.PPM.MAIN.PPM.MODEL
{
    public class Project
    {
        public string ProjectName { get; set; }

        public Project(string projectname)
        {
            ProjectName = projectname;
        } 
    }

    public class Employee
    {
        public string EmployeeName { get; set; }

        public Employee(string employeename)
        {
            EmployeeName = employeename;
        }
    }

    public class Role
    {
        public string RoleName { get; set; }

        public Role(string rolename)
        {
            RoleName = rolename;
        }
    }
}



