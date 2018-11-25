using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ServiceModel;

namespace Service
{
    [ServiceContract]
    public interface IServiceGeneric<T>
    {
        //CRUD 
        [OperationContract]
        void Create(T entity);

        [OperationContract]
        T[] ReadAll();

        [OperationContract]
        T ReadById(int id);

        [OperationContract]
        void Update(T entity);

        [OperationContract]
        void Delete(T entity);
    }
}
