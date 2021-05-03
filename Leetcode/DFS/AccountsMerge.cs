using System;
using System.Collections.Generic;
using System.Text;

namespace Leetcode.DFS
{
	class AccountsMerge
	{
        public static IList<IList<string>> AccountsMerges(IList<IList<string>> accounts)
        {
            Dictionary<string, List<string>> emailMap = new Dictionary<string, List<string>>();
            Dictionary<string, string> nameMap = new Dictionary<string, string>();

            createEdges(accounts, emailMap, nameMap);
            return dfs(emailMap, nameMap);
        }

        public static void createEdges(IList<IList<string>> accounts, Dictionary<string, List<string>> emailMap, Dictionary<string, string> nameMap)
        {
            foreach (List<string> account in accounts)
            {
                string name = account[0];
                string firstAccount = account[1];

                if (!nameMap.ContainsKey(firstAccount))
                    nameMap.Add(firstAccount, name);

                if (!emailMap.ContainsKey(firstAccount))
                {
                    List<string> edge = new List<string>();
                    edge.Add(firstAccount);
                    emailMap.Add(firstAccount, edge);
                }

                for (int i = 2; i < account.Count; i++)
                {
                    string email = account[i];

                    if (!nameMap.ContainsKey(email))
                        nameMap.Add(email, name);

                    if (!emailMap.ContainsKey(account[i]))
                    {
                        emailMap.Add(email, new List<string>());
                    }
                    emailMap[firstAccount].Add(email);
                    emailMap[email].Add(firstAccount);
                }
            }
        }

        public static IList<IList<string>> dfs(Dictionary<string, List<string>> emailMap, Dictionary<string, string> nameMap)
        {
            HashSet<string> visited = new HashSet<string>();
            
            IList<IList<string>> result = new List<IList<string>>();
            foreach (KeyValuePair<string, List<string>> email in emailMap)
            {
                List<string> individuals = new List<string>();
                
                if (!visited.Contains(email.Key))
                {
                    
                    dfs(emailMap, email.Key, visited, individuals);
                    individuals.Sort(String.CompareOrdinal);
                    individuals.Insert(0, nameMap[email.Key]);
                    result.Add(individuals);
                }
            }
            return result;
        }

        public static void dfs(Dictionary<string, List<string>> emailMap, string currentEmail, HashSet<string> visited, List<string> individuals)
        {
            if (visited.Contains(currentEmail) || !emailMap.ContainsKey(currentEmail))
                return;

            visited.Add(currentEmail);
            individuals.Add(currentEmail);
            foreach (string email in emailMap[currentEmail])
            {
                dfs(emailMap, email, visited, individuals);
            }
        }
    }
}
