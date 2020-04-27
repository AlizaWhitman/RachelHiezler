using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Text;

namespace BL
{
    public class CallSessionBL: ICallSessionBL
    {
        private ILogger<CallSessionBL> _logger;
        public CallSessionBL(ILogger<CallSessionBL> logger)
        {
            _logger = logger;
        }
        public void A()
        {
            _logger.LogInformation("WOW");
        }
    }

}
