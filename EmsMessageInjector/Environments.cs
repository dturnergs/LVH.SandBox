using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;

namespace EmsMessageInjector
{
    public class Environments : EnvironmentsAbstract
    {
        public Environments()
        {
            environments = new List<string>();
            queues = new List<string>();
        }

        public override void GatherEnvironments(string environment)
        {
            environments.Add(environment);
        }

        public override IEnumerator GetEnumerator()
        {
            return environments.GetEnumerator();
        }

        public override void GetAvailableQueues(string environment)
        {
            switch (environment)
            {
                case "QA":
                    MessageBox.Show("QA");
                    break;
                case "CERT":
                    MessageBox.Show("CERT");
                    break;
                case "DEV":
                    queues.Add("RMM");
                    queues.Add("PURCC");
                     MessageBox.Show("DEV");
                    break;
                case "PROD":
                    MessageBox.Show("PROD");
                    break;
                default:
                    MessageBox.Show("DEFAULT");
                    break;
            }
        }


        protected List<string> environments;
        protected List<string> queues;

    }
}
