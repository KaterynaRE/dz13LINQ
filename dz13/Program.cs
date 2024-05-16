using cl2;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace dz13
{
	internal class Program
	{
		static void Main(string[] args)
		{

			//			Завдання 1:
			//Реалізуйте користувацький тип «Фірма». В ньому має бути
			//інформація про назву фірми, дату заснування, профіль бізнесу
			//(маркетинг, IT, і т. д.), ПІБ директора, кількість працівників, адреса.
			//Для масиву фірм реалізуйте такі запити:
			//+ Отримати інформацію про всі фірми.
			//+ Отримати фірми, які мають у назві слово «Food».
			//+ Отримати фірми, які працюють у галузі маркетингу.
			//+ Отримати фірми, які працюють у галузі маркетингу або IT.
			//+ Отримати фірми з кількістю працівників більшою, ніж 100.
			//+ Отримати фірми з кількістю працівників у діапазоні від 100 до 300.
			//+ Отримати фірми, які знаходяться в Лондоні.
			//+ Отримати фірми, в яких прізвище директора White.
			//+ Отримати фірми, які засновані більше двох років тому.
			//+ Отримати фірми з дня заснування яких минуло 123 дні.
			//+ Отримати фірми, в яких прізвище директора Black і мають у назві фірми слово «White».

			//List<Firm> firms = new List<Firm>()
			//{
			//  new Firm("Royal", new DateTime(2023,01,01), "marketing","Skill", "Skil", 123, "Zp"),
			//  new Firm("Check", new DateTime(2021,10,03), "IT","Ivan", "Ivanov", 12, "Poznan"),
			//  new Firm("FoodMarket", new DateTime(2024,01,03), "IT","Den", "Denov", 200, "Zp"),
			//  new Firm("Food", new DateTime(2023,09,03), "marketing","Iande", "Devbn", 210, "Poznan"),
			//  new Firm("Fooding", new DateTime(2024,09,03), "marketing","Ian", "Den", 410, "Poznan")
			//};


			Firm firms11 = new Firm("Royal", new DateTime(2023, 01, 01), "marketing", "Skill", "Skil", 123, "Zp");
			Firm firms12 = new Firm("Check", new DateTime(2021, 10, 03), "IT", "Ivan", "Ivanov", 12, "Poznan");
			Firm firms13 = new Firm("CheckNew", new DateTime(2021, 10, 03), "IT", "Ivan", "Ivanov", 12, "Poznan");
			Firm firms14 = new Firm("FoodMarket", new DateTime(2024, 01, 03), "IT", "Den", "Denov", 200, "Zp");
			Firm firms15 = new Firm("Food", new DateTime(2023, 09, 03), "marketing", "Iande", "Devbn", 210, "Poznan");
			Firm firms16 = new Firm("Fooding", new DateTime(2024, 09, 03), "marketing", "Ian", "Den", 410, "Poznan");


			List<Firm> firms = new List<Firm>() { firms11, firms12, firms13, firms14, firms15, firms16 };

			//List<Firm> firms1 = (from f in firms select f).ToList();
			//Console.WriteLine("All firms info: \n");
			//foreach (var item in firms1)
			//{
			//	Console.WriteLine(item);
			//}

			//List<Firm> firms2 = firms.Where(f => f.NameFirm.StartsWith("Food")).ToList();
			//Console.WriteLine("Firms name with Food: \n");
			//foreach (var item in firms2)
			//{
			//	Console.WriteLine(item);
			//}


			//List<Firm> firms3 = firms.Where(f => f.BusinessProfile == "marketing").ToList();
			//Console.WriteLine("Firms with business profile marketing: \n");
			//foreach (var item in firms3)
			//{
			//	Console.WriteLine(item);
			//}


			//List<Firm> firms4 = firms.Where(f => f.BusinessProfile.ToLower() == "marketing" || f.BusinessProfile.ToLower() == "it").OrderByDescending(n => n.BusinessProfile).ToList();
			//Console.WriteLine("Firms with business profile Marketing or IT: \n");
			//foreach (var item in firms4)
			//{
			//	Console.WriteLine(item);
			//}


			//List<Firm> firms5 = firms.Where(f => f.Employee > 100).OrderByDescending(n => n.Employee).ToList();
			//Console.WriteLine("Firms with employee more 100: \n");
			//foreach (var item in firms5)
			//{
			//	Console.WriteLine(item);
			//}


			//List<Firm> firms6 = firms.Where(f => f.Employee > 100 && f.Employee < 300 ).OrderByDescending(n => n.Employee).ToList();
			//Console.WriteLine("Firms with employee 100 - 300: \n");
			//foreach (var item in firms6)
			//{
			//	Console.WriteLine(item);
			//}

			//List<Firm> firms7 = firms.Where(f => f.AdressFirm == "Zp").ToList();
			//Console.WriteLine("Firms with firm in 'Zp': \n");
			//foreach (var item in firms7)
			//{
			//	Console.WriteLine(item);
			//}

			//List<Firm> firms8 = firms.Where(f => f.LastNameDirector.StartsWith("Skil")).TakeWhile(l => l.LastNameDirector.StartsWith("Skil")).ToList();
			//Console.WriteLine("Firms with last name director 'Skil': \n");
			//foreach (var item in firms8)
			//{
			//	Console.WriteLine(item);
			//}


			//DateTime twoYearsAgo = DateTime.Now.AddYears(-2);

			//List<Firm> firms9 = firms.Where(f => f.DateOfEstablishment <= twoYearsAgo).ToList();
			//Console.WriteLine("Firms \r\nfounded more than two years ago: \n");
			//foreach (var item in firms9)
			//{
			//	Console.WriteLine(item);
			//}


			//DateTime daysAgo = DateTime.Now.AddDays(-123);

			//List<Firm> firms10 = firms.Where(f => f.DateOfEstablishment <= daysAgo).ToList();
			//Console.WriteLine("Firms \r\nfounded more than 123 days ago: \n");
			//foreach (var item in firms10)
			//{
			//	Console.WriteLine(item);
			//}


			//List<Firm> firms111 = firms.Where(f => f.LastNameDirector.StartsWith("Skil"))
			//	.TakeWhile(l => l.LastNameDirector.StartsWith("Skil"))
			//	.Where(nF => nF.NameFirm == "Royal").ToList();
			//Console.WriteLine("Firms with last name director 'Skil' and name firm 'Royal': \n");
			//foreach (var item in firms111)
			//{
			//	Console.WriteLine(item);
			//}


			//			Завдання 3:
			//Додайте до першого завдання клас, який містить інформацію про
			//працівників.Потрібно зберігати такі дані:
			//+ ПІБ співробітника
			//+ Посада
			//+ Контактний телефон
			//+ Email
			//+ Заробітна плата
			//Помістіть інформацію про працівників всередину фірми. 
			//Для масиву співробітників фірми реалізуйте наступні запити:
			//+ Отримати список усіх працівників певної фірми.
			//+ Отримати список усіх працівників певної фірми, в яких заробітна плата більша заданої.
			//+ Отримати список працівників усіх фірм, в яких є посада  «Менеджер».
			//+ Отримати список працівників, в яких телефон починається з «23».
			//+ Отримати список працівників, в яких Email починається з «di».
			//+ Отримати список працівників з ім'ям Lionel

			Employee emp1 = new Employee( "John", "Doe", "Developer", "123-456-7890", "john.doe@example.com", 50000);
			Employee emp2 = new Employee( "Jane", "Smith", "Designer", "234-567-8901", "jane.smith@example.com", 60000);
			Employee emp3 = new Employee( "Mike", "Johnson", "Manager", "345-678-9012", "mike.johnson@example.com", 70000);
			Employee emp4 = new Employee( "Jane", "Brown", "Marketing Specialist", "456-789-0123", "emily.brown@example.com", 55000);
			Employee emp5 = new Employee( "Chris", "Wilson", "Accountant", "567-890-1234", "chris.wilson@example.com", 65000);

			List<Employee> employees = new List<Employee>() { emp1, emp2, emp3, emp4, emp5 };

			firms11.AddEmp(emp1);
			firms11.AddEmp(emp2);

			firms13.AddEmp(emp3);
			firms13.AddEmp(emp4);
			firms13.AddEmp(emp5);

			//List<Firm> firmsNew = firms.Where(f => f.NameFirm.StartsWith("Royal")).ToList();
			//Console.WriteLine("Firms name with Royal: \n");
			//foreach (var item in firmsNew)
			//{
			//	Console.WriteLine(item);
			//}
			//Console.WriteLine();


			//Decimal zp = 55000;
			//List<Firm> firmsNew2 = firms.Where(f => f.NameFirm.StartsWith("CheckNew")).ToList();
			//Console.WriteLine($"Firms name with CheckNew and zp > {zp}: \n");
			//foreach (var firm in firmsNew2)
			//{
			//	var employees2 = firm.employeesList.Where(em => em.SalaryEmployee > zp).ToList();
			//             foreach (var item1 in employees2)
			//             {
			//		Console.WriteLine(item1);
			//             }
			//         }


			//List<Firm> firmsNew3 = firms.ToList();
			//Console.WriteLine("\nAll employee all firms where position is Designer:\n");
			//         foreach (var em in firmsNew3)
			//         {
			//	Console.Write(em.NameFirm);
			//	var empMan = em.employeesList.Where(emp => emp.PositionEmployee == "Designer").ToList();
			//             foreach (var item in empMan)
			//             {
			//		Console.WriteLine(item);
			//             }

			//         }


			//List<Firm> firmsNew4 = firms.ToList();
			//Console.WriteLine("\nEmployee with phone begin '34':\n");
			//foreach (var em in firmsNew4)
			//{
			//	var empMan = em.employeesList.Where(emp => emp.MobileEmployee.StartsWith("34")).ToList();
			//	foreach (var item in empMan)
			//	{
			//		Console.WriteLine($"Name firm: {em.NameFirm}:{item}");
			//	}

			//}


			//List<Firm> firmsNew5 = firms.ToList();
			//Console.WriteLine("\nEmployee with email begin 'ch':\n");
			//foreach (var em in firmsNew5)
			//{
			//	var empMan = em.employeesList.Where(emp => emp.EmailEmployee.StartsWith("ch")).ToList();
			//	foreach (var item in empMan)
			//	{
			//		Console.WriteLine($"Name firm: {em.NameFirm}:{item}");
			//	}

			//}


			List<Firm> firmsNew6 = firms.ToList();
			Console.WriteLine("\nEmployee with name Jane:\n");
			foreach (var em in firmsNew6)
			{
				var empMan = em.employeesList.Where(emp => emp.FirstNameEmployee.StartsWith("Jane"))
					.TakeWhile(m => m.FirstNameEmployee.StartsWith("Jane")).ToList();
				foreach (var item in empMan)
				{
					Console.WriteLine($"\nName firm: {em.NameFirm}:{item}");
				}

			}



		}
	}
}
