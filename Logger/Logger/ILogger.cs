using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;

namespace Logger
{
    [ServiceContract]
    public interface ILogger
    {
        [OperationContract]
        void Info(string message);
        [OperationContract]
        void Warn(string message);
        [OperationContract]
        void Error(string message);
        [OperationContract]
        void Debug(string message);
        [OperationContract]
        void Fatal(string message);
    }
}
