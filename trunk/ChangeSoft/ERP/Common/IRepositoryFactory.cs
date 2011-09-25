using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Com.GainWinSoft.Common
{
    public interface IRepositoryFactory
    {
        IBaseContent Create(string id);
        void Release(IBaseContent content);
    }
}
