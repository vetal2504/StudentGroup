﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;

namespace WebService
{
    // ПРИМЕЧАНИЕ. Команду "Переименовать" в меню "Рефакторинг" можно использовать для одновременного изменения имени интерфейса "IServiceBD" в коде и файле конфигурации.
    [ServiceContract]
    public interface IServiceBD
    {
        [OperationContract]
        void AddStudent(string name, DateTime date);

        [OperationContract]
        List<Student> GetStudent();

        //ToDo Id is all you need for delete
        [OperationContract]
        void RemoveStudent(int id, string name, DateTime date);

        //ToDo Id must be autogenerated in db
        [OperationContract]
        void AddOtherData(int id, string gender, string street, string telephone, string ticket, float middle);

        [OperationContract]
        void UpdateOtherInfo(int studentID, string gender, string street, string telephone, string ticket, float middle);

        [OperationContract]
        List<AllDataStudent> GetOtherInfo();
    }
}
