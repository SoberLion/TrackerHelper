using System;
using System.Collections.Generic;



namespace TrackerHelper
{
    public class Filter
    {
        public List<int> _StatusId { get; set; } = new List<int>();
        public List<int> _AssignedToId { get; set; } = new List<int>();
        public List<int> _TrackerId { get; set; } = new List<int>();
        public List<int> _AuthorId { get; set; } = new List<int>();
        public List<int> _ProjectId { get; set; } = new List<int>();
    }
    public class Redmines
    {   


        public static void GetUserIssueList(User user)
        {
            /* string url = string.Format("{0}issues.xml?assigned_to_id=2232&limit=100&key={1}",
                                         user.BaseAddress,
                                         user.ApiKey);*/
            
            //string url = @"http://test-tracker.ucs.ru/issues.xml?utf8=%E2%9C%93&set_filter=1&f[]=&c[]=project&c[]=tracker&c[]=status&c[]=priority&c[]=author&c[]=subject&c[]=assigned_to&c[]=updated_on&c[]=category&group_by=&t[]=&key=1287ca3310be20d6992a764b57f9c8bcfbb05664";
            string url = @"http://test-tracker.ucs.ru/issues.xml?utf8=%E2%9C%93&set_filter=1&f[]=project_id&op[project_id]==&v[project_id][]=26&f[]=&c[]=tracker&c[]=status&c[]=priority&c[]=author&c[]=subject&c[]=assigned_to&c[]=updated_on&c[]=category&group_by=&t[]=&key=1287ca3310be20d6992a764b57f9c8bcfbb05664";

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
            // счётчик - redmine возвращает максимум 100 элементов, если кол-во total_count больше, необходимо сделать повторные запросы со смещением
            int cnt = int.Parse(user.Issues.total_count) / 100;
            if (cnt > 0)
            {
                for (int i = 1; i <= cnt; i++)
                {
                    resultModel = Http.Get(url + "&offset=" + (i * 100).ToString());
                    if (resultModel.IsSuccess)
                    {
                        try
                        {
                            // Десериализуем следующие записи и добавим их к существующим.
                            XML.Deserialize<Issues>(resultModel.Results).issue.ForEach(p => user.Issues.issue.Add(p));
                        }
                        catch (Exception ex)
                        {
                        }
                    }
                }
            }
        }
    }
}
