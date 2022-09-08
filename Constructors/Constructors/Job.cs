using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Constructors
{
    public class Job
    {
        public string JobTitle;
        public int Salary;


        // Chain constructors
        public Job(string JobTitle) : this(JobTitle, 60000)
        {

        }

        public Job(String JobTitle, int Salary)
        {

        }
        

    }
}
