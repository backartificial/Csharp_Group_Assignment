﻿using System;
using System.Collections.Generic;
using System.Runtime.Serialization;
using System.ServiceModel;

namespace DatabaseService {
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the interface name "IDatabase" in both code and config file together.
    [ServiceContract]
    public interface IDatabase {
        [OperationContract]
        bool checkUniqueCourse(string courseCode);

        [OperationContract]
        bool checkUniqueProgram(string programName);

        [OperationContract]
        Data PullData(string table);

        [OperationContract]
        bool PushData(string query, List<Tuple<string, string>> values);
    }

    [DataContract]
    public class Data {
        [DataMember]
        public List<Dictionary<string, string>> Value { get; set; }
    }
}