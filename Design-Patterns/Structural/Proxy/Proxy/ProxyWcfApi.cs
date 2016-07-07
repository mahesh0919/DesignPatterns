using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proxy
{
    // This is a proxy class for Real WCF API
    public class ProxyWcfApi: IWCFApi
    {
        private RealWcfApi _realWcfApi;

        public void PerformAction()
        {
            if (_realWcfApi == null)
                _realWcfApi = new RealWcfApi();

            _realWcfApi.PerformAction();
        }
    }
}
