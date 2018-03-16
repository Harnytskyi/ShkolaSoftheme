using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Sockets;//
using System.Security.Cryptography;//
using System.Text;
using System.Threading.Tasks;

namespace Mobile
{
    class MobileOperator
    {
        List<int> _callToAccounts = new List<int>();
        List<int> _callFromAccounts = new List<int>();
        List<int> _smsToAccounts = new List<int>();
        List<int> _smsFromAccounts = new List<int>();

        private Dictionary<int, MobileAccount> _accounts = new Dictionary<int, MobileAccount>();
        
        public MobileAccount CreateAccount(int number)
        {
            var acc = new MobileAccount(number, this);
            _accounts.Add(number, acc);
            acc.OnMessagePost += RouteMessage;
            acc.OnCall += RouteCall;
            return acc;
        }

        private void RouteMessage(int numberTo, string message, int numberFrom)
        {
            MobileAccount acc;
            if (_accounts.TryGetValue(numberTo, out acc))
            {
                acc.ReceiveMessage(numberFrom, message);
                _smsToAccounts.Add(numberTo);
                _smsFromAccounts.Add(numberFrom);
            }
        }

        private void RouteCall(int numberTo, int numberFrom)
        {
            MobileAccount acc;
            if (_accounts.TryGetValue(numberTo, out acc))
            {
                acc.ReceiveCall(numberFrom);
                _callToAccounts.Add(numberTo);
                _callFromAccounts.Add(numberFrom);
            }
        }

        public List<int> Get5MostCallingNumbers()
        {
            return _callToAccounts
                .GroupBy(num => num)
                .OrderByDescending(num => num.Count())
                .Take(5)
                .Select(num => num.Key).ToList();
        }

        public List<int> Get5MostActiveNumbers()
        {
            return _callFromAccounts
                .GroupBy(num => num)
                .OrderByDescending(num => num.Count())
                .Take(5)
                .Select(num => num.Key).ToList();
        }
        
    }
}
