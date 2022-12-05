using System;
using ProlificsProjectManager.PPM.MAIN.PPM.MODEL;
using ProlificsProjectManager.PPM.MAIN.PPM.DOMAIN;


namespace ProlificsProjectManager.PPM.MAIN.PPM.UI
{
    public class viewing
    {
        public void view()
        {
            Console.WriteLine("Hello from the console PPM");
            Console.WriteLine("Enter 1 to Add Project");
            Console.WriteLine("Enter 2 to View Projects");
            Console.WriteLine("Enter 3 to Add Employee");
            Console.WriteLine("Enter 4 to View Employees");
            Console.WriteLine("Enter 5 to Add Role");
            Console.WriteLine("Enter 6 to View Roles");
            Console.WriteLine("Enter 'S' to QUIT the application");

            var userInput = Console.ReadLine();
            
            ProjectManager PM =  new ProjectManager();
            EmployeeManager EM = new EmployeeManager();
            RoleManager RM = new RoleManager();

            while (true)
            {
                switch (userInput)
                {
                    case "1":
                        Console.WriteLine("Enter the Project Name");
                        var add = Console.ReadLine();
                        var newProject = new Project(add);
                        PM.AddProject(newProject);
                        Console.WriteLine("Project Added Successfully");
                        break;
                
                    case "2":
                        PM.ViewProject();
                        break;

                    case "3":
                        Console.WriteLine("Enter the Employee Name");
                        var add1 = Console.ReadLine();
                        var newEmployee = new Employee(add1);
                        EM.AddEmployee(newEmployee);
                        Console.WriteLine("Employee Added Successfully");
                        break;
                
                    case "4":
                        EM.ViewEmployee();
                        break;

                    case "5":
                        Console.WriteLine("Enter the Role Name");
                        var add2 = Console.ReadLine();
                        var newRole = new Role(add2);
                        RM.AddRole(newRole);
                        Console.WriteLine("Role Added Successfully");;
                        break;
                  
                    case "6":
                        RM.ViewRole();
                        break;
                    
                    case "S":
                        return;

                    default:
                        Console.WriteLine("Select Valid Operation");
                        break;
                      
                }
                Console.WriteLine("Select Operation");
                userInput = Console.ReadLine();
            }
        
        }
    }
}