using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace cleanBudget_BL.interfaces
{
    public interface iAPIConnection<T, U> where T : class where U : class
    {
        public Task<T> SendGetRequestAsync(string APILink, Dictionary<string, object> requestObj);
        public Task<T> SendPostRequestAsync(string APILink,U requestObj);
    }
}
