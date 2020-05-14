using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Indexers
{
    public class IndexerDemo 
    {
        public int EmployeeId { get; set; }
        public string EmployeeName { get; set; }
    }

    public class Employee
    {
        List<IndexerDemo> indexerDemos = new List<IndexerDemo>();
        public Employee()
        {
            indexerDemos.Add(new IndexerDemo { EmployeeId = 1, EmployeeName = "Jack" });
            indexerDemos.Add(new IndexerDemo { EmployeeId = 2, EmployeeName = "Hugh" });
            indexerDemos.Add(new IndexerDemo { EmployeeId = 3, EmployeeName = "chris" });
            indexerDemos.Add(new IndexerDemo { EmployeeId = 4, EmployeeName = "Hemsworth" });
        }

        public string this[int EmployeeID]
        {
            get
            {
                return indexerDemos.FirstOrDefault(emp => emp.EmployeeId == EmployeeID).EmployeeName;
            }
            set
            {
                indexerDemos.FirstOrDefault(emp => emp.EmployeeId == EmployeeID).EmployeeName = value;
            }
        }            
    }
}
