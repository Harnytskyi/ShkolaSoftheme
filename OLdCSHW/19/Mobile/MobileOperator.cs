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
        private Dictionary<int, ActivationActivityInfo> _accountsActivityInfos;
        readonly List<int> _callToAccounts = new List<int>();
        private readonly List<int> _callFromAccounts = new List<int>();
        List<int> _smsToAccounts = new List<int>();
        List<int> _smsFromAccounts = new List<int>();

        public Dictionary<int, MobileAccount> _accounts = new Dictionary<int, MobileAccount>();

        public MobileOperator()
        {
            _accountsActivityInfos = new Dictionary<int, ActivationActivityInfo>();
        }
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
                //_accountsActivityInfos[numberFrom].MadeSmsCount++;
                _accountsActivityInfos[numberTo].RecievedSmsCount++;

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
                _accountsActivityInfos[numberFrom].MadeCallsCount++;
                _accountsActivityInfos[numberTo].RecievedCallsCount++;

                acc.ReceiveCall(numberFrom);
                _callToAccounts.Add(numberTo);
                _callFromAccounts.Add(numberFrom);
            }

            //TODO: Implement else logic
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
            return _accountsActivityInfos.OrderBy(x => x.Value.MadeCallsCount + x.Value.RecievedSmsCount*0.5).Take(5).Select(x=>x.Key).ToList();
        }
        public class ActivationActivityInfo
        {
            public uint MadeCallsCount { get; set; }

            public uint RecievedCallsCount { get; set; }

            public uint MadeSmsCount { get; set; }

            public uint RecievedSmsCount { get; set; }
        }
        
    }
}
