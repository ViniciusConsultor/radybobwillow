using System;
namespace Com.ChangeSoft.ERP.Entity.Dao
{
    public interface ITest2Dao
    {
        int Count();
        Com.ChangeSoft.ERP.Entity.Test2[] GetAll(int uid);
    }
}
