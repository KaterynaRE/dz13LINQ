using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace cl2
{
	public class Employee
	{
		public string FirstNameEmployee {  get; set; }
		public string LastNameEmployee {  get; set; }
		public string PositionEmployee {  get; set; }
		public string MobileEmployee {  get; set; }
		public string EmailEmployee {  get; set; }
		public Decimal SalaryEmployee {  get; set; }

		public Employee(string FirstNameEmployee, string LastNameEmployee, string PositionEmployee, string MobileEmployee,
			string EmailEmployee, Decimal SalaryEmployee)
		{
			this.FirstNameEmployee = FirstNameEmployee;
			this.LastNameEmployee = LastNameEmployee;
			this.PositionEmployee = PositionEmployee;
			this.MobileEmployee = MobileEmployee;
			this.EmailEmployee = EmailEmployee;
			this.SalaryEmployee = SalaryEmployee;
		}

		public override string ToString()
		{
			return $"\n{FirstNameEmployee} {LastNameEmployee},\nPosition: {PositionEmployee},\n" +
				$"mob: {MobileEmployee}, email: {EmailEmployee}, salary: {SalaryEmployee} $";
		}


	}
}
