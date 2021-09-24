using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PMS.APIFramework.Services
{
    public interface IApiTestService
    {
        Task<string> ApiTestInfo();
    }
}
