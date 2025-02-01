using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace P33_CShapr
{
    public interface IWorker
    {
        void Work();
        int Salary {  get; set; }
    }
}
