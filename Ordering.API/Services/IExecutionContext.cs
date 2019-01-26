using Microsoft.Azure.WebJobs;
using System;
using System.Collections.Generic;
using System.Text;

namespace Ordering.API.Services
{
    /// <summary>
    /// Helper interface to expose Execution Context outside of an Azure Function 
    /// </summary>
    public interface IExecutionContext
    {
        Guid InvocationId { get; set; }
        string FunctionName { get; set; }
        string FunctionDirectory { get; set; }
        string FunctionAppDirectory { get; set; }
    }

    public class FuncExecutionContext : 
        ExecutionContext, IExecutionContext { }
}
