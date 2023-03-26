using System;
using System.Collections.Generic;
using Models;
namespace Repositories.Contract
{
    public interface IHomepage
    {
        List<BasicData> GetData();
        List<BasicData> InsertData();
        int DeleteData();
        int UpdataData();
    }
}
