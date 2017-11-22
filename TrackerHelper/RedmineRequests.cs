using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TrackerHelper
{
    public class RedmineRequests
    {
        public static void GetUserIssueList(string updatedOn, User user)
        {
            string url = string.Format("{0}issues.xml?utf8=%E2%9C%93&set_filter=1&f[]=status_id&op[status_id]==&v[status_id][]=4&v[status_id][]=23&v[status_id][]=18&f[]=assigned_to_id&op[assigned_to_id]==&v[assigned_to_id][]=me&f[]=updated_on&op[updated_on]=%3Ct-&v[updated_on][]={1}&f[]=&c[]=project&c[]=tracker&c[]=status&c[]=priority&c[]=author&c[]=subject&c[]=assigned_to&c[]=updated_on&c[]=category&group_by=&t[]=&limit=100&key={2}",
                                        user.BaseAddress,
                                        updatedOn,
                                        user.ApiKey);

            var resultModel = new ResultModel();

            resultModel = Http.Get(url);

            if (resultModel.IsSuccess)
            {
                try
                {
                    user.Issues = XML.Deserialize<Issues>(resultModel.Results);
                }
                catch (Exception ex)
                {
                }
            }
            else
            {

            }
        }
    }
}
