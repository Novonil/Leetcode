using System;
using System.Collections.Generic;
using System.Text;

namespace Leetcode.Stacks
{
	class CrawlerLogFolder
	{
        public int MinOperations(string[] logs)
        {
            int count = 0;

            foreach (string log in logs)
            {
                if (log.Equals("../"))
                {
                    if (count > 0)
                        count--;

                }
                else if (log.Equals("./"))
                {
                    continue;
                }
                else
                {
                    count++;
                }
            }
            return count;
        }

        public int minOps(string[] logs)
		{
			Stack<string> stack = new Stack<string>();
			CrawlerLogFolder ob = new CrawlerLogFolder();

			foreach (string log in logs)
			{
				if (log.Equals("./"))
				{
					continue;
				}
				else if (log.Equals("../"))
				{
					moveDown(stack);
				}
				else
				{
					moveUp(stack, log);
				}
			}

			return stack.Count;
		}

		public void moveDown(Stack<string> stack)
		{
			if (stack.Count > 0)
				stack.Pop();
		}


		public void moveUp(Stack<string> stack, string log)
		{
			stack.Push(log);
		}

	}
}
