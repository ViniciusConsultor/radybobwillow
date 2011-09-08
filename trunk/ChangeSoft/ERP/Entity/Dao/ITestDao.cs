using System;
using Castle.ActiveRecord;
namespace Com.GainWinSoft.ERP.Entity.Dao

{
    public interface ITestDao
    {
        int Count();
        Test[] GetAll(int uid);
    }
}
