using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DependencyInjection_property
{
    public class Client
    {
        private IService _service;

        public IService Service
        {
            set
            {
                this._service = value;
            }
        }

        public void ServeMethod()
        {
            this._service.Serve();
        }
    }
}
