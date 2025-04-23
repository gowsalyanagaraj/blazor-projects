using Prototype.Web.Enums;
using Prototype.Web.Models;

namespace Prototype.Web.Components.Pages
{
	public partial class Home
	{
		Employee[] employees = new Employee[]{
						new Employee{ FirstName = "John", LastName = "Doe", Age = 30, Type = EmployeeType.Manager},
						new Employee{ FirstName = "Jane", LastName = "Smith", Age = 25, Type = EmployeeType.Employee},
						new Employee{ FirstName = "Sam", LastName = "Brown", Age = 28, Type = EmployeeType.Employee},
						new Employee{ FirstName = "Lisa", LastName = "White", Age = 35, Type = EmployeeType.Manager},
						new Employee{ FirstName = "Tom", LastName = "Green", Age = 40, Type = EmployeeType.Employee},
						new Employee{ FirstName = "Anna", LastName = "Black", Age = 22, Type = EmployeeType.Employee}
					};
	}
}
