using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Leetcoe__Google_NumUniqueEmails
{
    public class EmailUniqueness
    {
        public int NumUniqueEmails(string[] emails)
        {
            int count = 0;

            var hashSet = new HashSet<string>();

            foreach (string email in emails)
            {
                string[] emailSplit = email.Split('@');

                if (emailSplit.Length == 2)
                {
                    string localName = emailSplit[0];

                    int plusIndex = localName.IndexOf('+');

                    if (plusIndex != -1)
                        localName = localName.Substring(0, plusIndex);

                    var sb = new StringBuilder();

                    foreach (char ch in localName)
                    {
                        if (ch != '.')
                        {
                            sb.Append(ch);
                        }
                    }

                    localName = sb.ToString();

                    string emailModified = localName + '@' + emailSplit[1];
                    hashSet.Add(emailModified);
                }
                else
                {
                    continue;
                }
            }

            int emailDistinctCount = hashSet.Distinct().Count();
            return emailDistinctCount;
        }
    }

    /*public int NumUniqueEmailsModified(string[] emails)
    {
        HashSet<string> hashSet = new HashSet<string>();

        foreach (var email in emails)
        {
            string[] emailFraction = email.Split('@');
            string localName = emailFraction[0];

            if (localName.Contains("."))
            {
                localName = localName.Replace(".", "");
            }

            if (localName.Contains("+"))
            {
                localName = localName.Remove(localName.IndexOf("+"));
            }

            hashSet.Add(localName + "@" + emailFraction[1]);
        }

        return hashSet.Distinct<string>().Count();
    }*/

}

    class Program
    {
        
        static void Main(string[] args)
        {
            string[] emails =
            {
                "test.email+alex@leetcode.com",
                "test.e.mail+bob.cathy@leetcode.com",
                "testemail+david@lee.tcode.com"
            };

            //var eunique = new EmailUniqueness();
            //eunique.NumUniqueEmails(emails);

        }
    }
//}
