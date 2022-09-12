using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise12
{
    public interface IStudent
    {
        void TakeTest(ITestPaper paper, string[] answers);
    }
}
