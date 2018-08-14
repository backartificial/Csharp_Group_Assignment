using Csharp_Group_Assignment;
using System.ServiceModel;

namespace DatabaseService {
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the interface name "IDatabase" in both code and config file together.
    [ServiceContract]
    public interface IDatabase {
        [OperationContract]
        Course checkUnique(string courseCode);
    }
}
