using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmsMessageInjector
{
    internal interface IEnvironments : IEnumerable
    {
        void GatherEnvironments(string environment);

        void GetAvailableQueues(string environment);
    }
}
