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

        [OperationContract]
        void RemoveStudent(int id, string name, DateTime date);

    }
}
