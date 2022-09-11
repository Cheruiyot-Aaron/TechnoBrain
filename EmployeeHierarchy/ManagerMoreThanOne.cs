using System;
using System.Runtime.Serialization;

namespace EmployeeHierarchy
{
    [Serializable]
    internal class ManagerMoreThanOne : Exception
    {
        public ManagerMoreThanOne()
        {
        }

        public ManagerMoreThanOne(string message) : base(message)
        {
        }

        public ManagerMoreThanOne(string message, Exception innerException) : base(message, innerException)
        {
        }

        protected ManagerMoreThanOne(SerializationInfo info, StreamingContext context) : base(info, context)
        {
        }
    }
}