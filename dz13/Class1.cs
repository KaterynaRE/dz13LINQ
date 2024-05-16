using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using cl2;


namespace dz13
{
	public class Firm
	{
		public string NameFirm {  get; set; }
		public DateTime DateOfEstablishment { get; set; }
		public string BusinessProfile {  get; set; }
		public string FirstNameDirector {  get; set; }
		public string LastNameDirector {  get; set; }
		public int EmployeeInt { get; set; }
		public string AdressFirm {  get; set; }

		public List<Employee> employeesList;

		public Firm(string NameFirm, DateTime DateOfEstablishment, string BusinessProfile, string FirstNameDirector,
			string LastNameDirector, int EmployeeInt, string AdressFirm)
		{
			this.NameFirm = NameFirm;
			this.DateOfEstablishment = DateOfEstablishment;
			this.BusinessProfile = BusinessProfile;
			this.FirstNameDirector = FirstNameDirector;
			this.LastNameDirector = LastNameDirector;
			this.EmployeeInt = EmployeeInt;
			this.AdressFirm = AdressFirm;
			employeesList = new List<Employee>();
		}

		public void AddEmp(Employee employeeP)
		{
			employeesList.Add(employeeP);
		}
		public override string ToString()
		{
			StringBuilder sb = new StringBuilder();
			sb.AppendLine($"\nFirm:\n {NameFirm},\nDate Of Establishment: {DateOfEstablishment},\nBusiness Profile: {BusinessProfile},\n" +
				$"Name Full Director: {FirstNameDirector} {LastNameDirector},\nCount employee: {EmployeeInt},\nAdress: {AdressFirm} ");
            foreach (var item in employeesList)
            {
				sb.AppendLine($"Employee:\n{item.FirstNameEmployee} {item.LastNameEmployee},\nPosition: {item.PositionEmployee},\n" +
				$"mob: {item.MobileEmployee}, email: {item.EmailEmployee}, salary: {item.SalaryEmployee} $");
            }
            return sb.ToString();
		}

	}
}
