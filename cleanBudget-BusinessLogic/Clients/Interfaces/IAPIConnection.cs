using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace cleanBudget_BL.Clients.Interfaces {
    public interface IAPIConnection
    {
        public Task<T> SendGetRequestAsync<T>(string APILink, Dictionary<string, object> requestObj);
        public Task<T> SendPostRequestAsync<T,U>(string APILink,U requestObj);
    }
}
