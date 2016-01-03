using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmsMessageInjector
{
    public abstract class EnvironmentsAbstract : IEnvironments
    {
        public abstract void GatherEnvironments(string environment);
        public abstract void GetAvailableQueues(string environment);
        public abstract IEnumerator GetEnumerator();
    }
}
