using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;

namespace WcfServiceLibrary1
{
    public class Service1 : ICalculator
    {

        public string AddString(string str)
        {
            Console.WriteLine(str);

            Console.WriteLine(OperationContext.Current.RequestContext.RequestMessage.ToString());

            return string.Format(str);
        }

        public string Add(int a)
        {
            return "" + a;
        }
    }
}
