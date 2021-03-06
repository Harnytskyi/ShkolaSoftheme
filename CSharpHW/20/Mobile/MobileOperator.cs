﻿using System;
using System.Collections.Generic;
using System.Linq;
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
        
        

        public MobileAccount CreateAccount(int number, string firstName, string lastName, DateTime birtday, string email )
        {
            var acc = new MobileAccount(number, firstName, lastName, birtday, email, this);
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

        public void Get5MostCallingNumbers()
        {
            var groupsCall = _callToAccounts.GroupBy(call => call);

            var groupsSMS = _smsToAccounts.GroupBy(sms => sms);


            var leftoutrtjoin = (from sms in groupsSMS

                                 join call in groupsCall on sms.Key equals call.Key into SC

                                 from newSC in SC.DefaultIfEmpty()

                                 select new
                                 {
                                     account = sms.Key,
                                     activity = newSC?.Count() + (double)sms.Count() / 2 ?? (double)sms.Count() / 2
                                 }).ToList();

            var rightouterjoin = (from call in groupsCall

                                  join sms in groupsSMS on call.Key equals sms.Key into CS

                                  from newCS in CS.DefaultIfEmpty()

                                  select new
                                  {
                                      account = call.Key,
                                      activity = newCS == null ? call.Count() : (double)newCS.Count() / 2 + call.Count()
                                  }).ToList();


            var fullouterjoin = leftoutrtjoin.Union(rightouterjoin);

            var result = (from account in fullouterjoin
                          orderby account.activity descending
                          select account.account).Take(5);


            Console.WriteLine("5 Most Calling Numbers: ");
            foreach (var item in result)
            {
                Console.WriteLine(item);
            }
        }

        public void Get5MostActiveNumbers()
        {
            var groupsCall = _callFromAccounts.GroupBy(call => call);

            var groupsSMS = _smsFromAccounts.GroupBy(sms => sms);


            var leftoutrtjoin = (from sms in groupsSMS

                                 join call in groupsCall on sms.Key equals call.Key into SC

                                 from newSC in SC.DefaultIfEmpty()

                                 select new
                                 {
                                     account = sms.Key,
                                     activity = newSC?.Count() + (double)sms.Count() / 2 ?? (double)sms.Count() / 2
                                 }).ToList();

            var rightouterjoin = (from call in groupsCall

                                  join sms in groupsSMS on call.Key equals sms.Key into CS

                                  from newCS in CS.DefaultIfEmpty()

                                  select new
                                  {
                                      account = call.Key,
                                      activity = newCS == null ? call.Count() : (double)newCS.Count() / 2 + call.Count()
                                  }).ToList();


            var fullouterjoin = leftoutrtjoin.Union(rightouterjoin);

            var result = (from account in fullouterjoin
                          orderby account.activity descending
                          select account.account).Take(5);


            Console.WriteLine("5 Most Active Numbers: ");
            foreach (var item in result)
            {
                Console.WriteLine(item);
            }
        }
    }
}
