using System;
using System.Data;

namespace Test1
{
    class MyClass
    {
        public static void Main(string[] args)
        {
            DataTable employee = new DataTable();

            employee.Columns.Add("ID");
            employee.Columns.Add("Name");
            employee.Columns.Add("Salary");
            Console.WriteLine("Enter ID, Name and Salary seperated by commas: ");
            for (int i = 0; i < 5; i++)
            {
                DataRow row = employee.NewRow();
                string data = Console.ReadLine();
                string[] values = data.Split(",");
                row["ID"] = (values[0]);
                row["Name"] = (values[1]);
                row["Salary"] = (values[2]);
                employee.Rows.Add(row);
            }

            foreach (DataRow R in employee.Rows)
            {
                Console.WriteLine(R["ID"] + " " + R["Name"] + " " + R["Salary"]);
            }
        }
    }
}


