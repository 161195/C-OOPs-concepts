using System;

namespace Employee
{
    class Employee
    {
        public int EmpId;
        public string EmpName;
        public double GrossPay;
        double TaxDeduction = 0.1;
        double netSalary;

        public Employee(int Eid, string Ename, double Egrosspay)
        {
            this.EmpId = Eid;
            this.EmpName = Ename;
            this.GrossPay = Egrosspay;
        }
        void CalculateSalary()
        {
            if (GrossPay >= 30000)
            {
                netSalary = GrossPay - (TaxDeduction * GrossPay);
                Console.WriteLine("your salary is: {0}", netSalary);
            }
            else
            {
                Console.WriteLine("your salary is: {0}", GrossPay);
            }
        }
        public void ShowEmployeeDetails()
        {
            Console.WriteLine("Employee Id :{0}",this.EmpId);
            Console.WriteLine("Employee Name is :{0}",this.EmpName);
            this.CalculateSalary();
        }

    }
    class Program
    { 
        static void Main(string[] args)
        {
            Employee Mayuri = new Employee(161195, "Mayuri", 41000);
            Mayuri.ShowEmployeeDetails();
            Console.ReadLine();
        }
    }
}
