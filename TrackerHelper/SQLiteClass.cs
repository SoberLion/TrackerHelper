using System;
using System.Data;
using System.Data.SQLite;

namespace TrackerHelper
{
    public delegate void MessageDelegate(string message);
    public class SQLiteClass
    {
        private static string DbName = "TrackerHelper.db";

        public static void SetDbName(string dbName)
        {
            DbName = dbName;
        }

        static MessageDelegate MessageDel;

        public void RegisterDelegate(MessageDelegate del)
        {
            MessageDel += del;
        }
        public void UnregisterDelegate(MessageDelegate del)
        {
            MessageDel -= del;
        }

        // check if table exist
        public static bool Exist(string TableName)
        {
            SQLiteConnection conn = new SQLiteConnection($"Data Source={DbName}; Version=3;");
            Object obj = null;

            conn.Open();

            if (conn.State == ConnectionState.Open)
            {
                SQLiteCommand cmd = conn.CreateCommand();
                cmd.CommandText = "SELECT name FROM sqlite_master WHERE type = 'table' AND name = '" + TableName + "';";

                try
                {
                    obj = cmd.ExecuteScalar();
                }
                catch (SQLiteException sqlex)
                {
                    MessageDel?.Invoke($"Error: {sqlex.Message}");
                    return false;
                }
                cmd.Dispose();
                conn.Dispose();
            }
            return obj == null ? false : true;
        }

        #region ---------------------Create database/tables-------------------------
        public static bool CreateDatabase()
        {
            try
            {
                CreateIssuesTable();
                CreateTETable();
                CreateJournalsTable();
                CreateJournalDetailsTable();
                CreateUsersTable();
                return true;
            }
            catch (Exception sqlex)
            {
                MessageDel?.Invoke($"Error: {sqlex.Message}");
                return false;
            }
        }
        private static void CreateTETable()
        {
            SQLiteConnection conn = new SQLiteConnection($"Data Source={DbName}; Version=3;");

            conn.Open();

            if (conn.State == ConnectionState.Open)
            {
                SQLiteCommand cmd = conn.CreateCommand();
                cmd.CommandText = string.Format("CREATE TABLE IF NOT EXISTS TimeEntries({0},{1},{2},{3},{4},{5},{6},{7},{8},{9},{10});",
                                     "id INTEGER PRIMARY KEY",
                                     "ProjectId INTEGER",
                                     "ProjectName TEXT",
                                     "IssueId INTEGER",
                                     "UserId INTEGER",
                                     "UserName TEXT",
                                     "ActivityId INTEGER",
                                     "ActivityName TEXT",
                                     "Hours TEXT",
                                     "Comment TEXT",
                                     "SpentOn INTEGER");
                try
                {
                    cmd.ExecuteNonQuery();
                }
                catch (SQLiteException sqlex)
                {
                    MessageDel?.Invoke($"Error: {sqlex.Message}");
                }
                cmd.Dispose();
                conn.Dispose();
            }
        }
        private static void CreateIssuesTable()
        {
            SQLiteConnection conn = new SQLiteConnection($"Data Source={DbName}; Version=3;");

            conn.Open();

            if (conn.State == ConnectionState.Open)
            {
                SQLiteCommand cmd = conn.CreateCommand();
                cmd.CommandText = string.Format("CREATE TABLE IF NOT EXISTS Issues({0},{1},{2},{3},{4},{5},{6},{7},{8},{9},{10},{11},{12},{13},{14},{15},{16},{17},{18},{19},{20},{21},{22},{23},{24});",
                                     "IssueId INTEGER PRIMARY KEY",
                                     "ProjectId INTEGER",
                                     "ProjectName TEXT",
                                     "TrackerId INTEGER",
                                     "TrackerName TEXT",
                                     "StatusId INTEGER",
                                     "StatusName TEXT",
                                     "PriorityId INTEGER",
                                     "PriorityName TEXT",
                                     "AuthorId INTEGER",
                                     "AuthorName TEXT",
                                     "AssignedToId INTEGER",
                                     "AssignedToName TEXT",
                                     "CategoryId INTEGER",
                                     "CategoryName TEXT",
                                     "Subject TEXT",
                                     "Description TEXT",
                                     "StartDate TEXT",
                                     "DueDate TEXT",
                                     "DoneRatio INTEGER",
                                     "IsPrivate INTEGER",
                                     "EstimatedHours TEXT",
                                     "CreatedOn TEXT",
                                     "UpdatedOn TEXT",
                                     "ClosedOn TEXT");
                try
                {
                    cmd.ExecuteNonQuery();
                }
                catch (SQLiteException sqlex)
                {
                    MessageDel?.Invoke($"Error: {sqlex.Message}");
                }
                cmd.Dispose();
                conn.Dispose();
            }
        }
        private static void CreateJournalsTable()
        {
            SQLiteConnection conn = new SQLiteConnection($"Data Source={DbName}; Version=3;");

            conn.Open();

            if (conn.State == ConnectionState.Open)
            {
                SQLiteCommand cmd = conn.CreateCommand();
                cmd.CommandText = string.Format("CREATE TABLE IF NOT EXISTS Journals({0},{1},{2},{3},{4},{5});",
                                     "Id INTEGER PRIMARY KEY",
                                     "UserId INTEGER",
                                     "UserName TEXT",
                                     "IssueId INTEGER",
                                     "Notes TEXT",
                                     "CreatedOn TEXT");
                try
                {
                    cmd.ExecuteNonQuery();
                }
                catch (SQLiteException sqlex)
                {
                    MessageDel?.Invoke($"Error: {sqlex.Message}");
                }
                cmd.Dispose();
                conn.Dispose();
            }
        }
        private static void CreateJournalDetailsTable()
        {
            SQLiteConnection conn = new SQLiteConnection($"Data Source={DbName}; Version=3;");

            conn.Open();

            if (conn.State == ConnectionState.Open)
            {
                SQLiteCommand cmd = conn.CreateCommand();
                cmd.CommandText = string.Format("CREATE TABLE IF NOT EXISTS JournalDetails({0},{1},{2},{3},{4},{5});",
                                     "id INTEGER PRIMARY KEY AUTOINCREMENT",
                                     "Property TEXT",
                                     "Name TEXT",
                                     "OldValue TEXT",
                                     "NewValue TEXT",
                                     "JournalId INTEGER");
                try
                {
                    cmd.ExecuteNonQuery();
                }
                catch (SQLiteException sqlex)
                {
                    MessageDel?.Invoke($"Error: {sqlex.Message}");
                }
                cmd.Dispose();
                conn.Dispose();
            }
        }
        private static void CreateUsersTable()
        {
            SQLiteConnection conn = new SQLiteConnection($"Data Source={DbName}; Version=3;");

            conn.Open();

            if (conn.State == ConnectionState.Open)
            {
                SQLiteCommand cmd = conn.CreateCommand();
                cmd.CommandText = string.Format("CREATE TABLE IF NOT EXISTS Users({0},{1},{2},{3},{4},{5},{6},{7},{8});",
                                     "Id INTEGER PRIMARY KEY",
                                     "Name TEXT",
                                     "CompanyName TEXT",
                                     "Position TEXT",
                                     "Telephone TEXT",
                                     "InternalPhone INTEGER",
                                     "Language INTEGER",
                                     "BaseAddress TEXT",
                                     "ApiKey TEXT");
                try
                {
                    cmd.ExecuteNonQuery();
                }
                catch (SQLiteException sqlex)
                {
                    MessageDel?.Invoke($"Error: {sqlex.Message}");
                }
                cmd.Dispose();
                conn.Dispose();
            }
        }
        #endregion

        #region ------------------------- Insert methods ---------------------------
        // insert time entry to table
        public static void InsertUser(User user)
        {
            SQLiteConnection conn = new SQLiteConnection($"Data Source={DbName}; Version=3;");

            conn.Open();

            // if connection established create sqlite command and begin transaction
            if (conn.State == ConnectionState.Open)
            {
                SQLiteCommand cmd = conn.CreateCommand();
                SQLiteTransaction transaction = conn.BeginTransaction();

                cmd.CommandText = "INSERT OR IGNORE INTO Users(id, Name, CompanyName, Position, Telephone, InternalPhone, Language, BaseAddress, APiKey) "
                                   + "VALUES (@Id, @Name, @CompanyName, @Position, @Telephone, @InternalPhone, @Language, @BaseAddress, @ApiKey)";


                // create command parameters
                cmd.Parameters.AddWithValue("@Id", "");
                cmd.Parameters.AddWithValue("@Name", "");
                cmd.Parameters.AddWithValue("@CompanyName", "");
                cmd.Parameters.AddWithValue("@Position", "");
                cmd.Parameters.AddWithValue("@Telephone", "");
                cmd.Parameters.AddWithValue("@InternalPhone", "");
                cmd.Parameters.AddWithValue("@Language", "");
                cmd.Parameters.AddWithValue("@BaseAddress", "");
                cmd.Parameters.AddWithValue("@APiKey", "");

                try
                {   // cycle writing data in table
                        cmd.Parameters["@Id"].Value = user.Id;
                        cmd.Parameters["@Name"].Value = user.Name;
                        cmd.Parameters["@CompanyName"].Value = user.CompanyName;
                        cmd.Parameters["@Position"].Value = user.Position;
                        cmd.Parameters["@Telephone"].Value = user.Telephone;
                        cmd.Parameters["@InternalPhone"].Value = user.InternalPhone;
                        //cmd.Parameters["@Language"].Value = user.Language;
                        cmd.Parameters["@BaseAddress"].Value = user.BaseAddress;
                        cmd.Parameters["@APiKey"].Value = user.ApiKey;
                        cmd.ExecuteNonQuery();
                }
                catch (SQLiteException sqlex)
                {
                    MessageDel?.Invoke($"Error: {sqlex.Message}");
                }
                transaction.Commit();
                cmd.Dispose();
                conn.Dispose();
            }
        }
        public static void InsertTE(Time_entries TE)
        {
            SQLiteConnection conn = new SQLiteConnection($"Data Source={DbName}; Version=3;");

            conn.Open();

            // if connection established create sqlite command and begin transaction
            if (conn.State == ConnectionState.Open)
            {
                SQLiteCommand cmd = conn.CreateCommand();
                SQLiteTransaction transaction = conn.BeginTransaction();

                cmd.CommandText = "INSERT OR IGNORE INTO TimeEntries(id, ProjectId, ProjectName, IssueId, UserId, UserName, ActivityId, ActivityName, Hours, Comment, SpentOn) "
                                   + "VALUES (@id, @ProjectId, @ProjectName, @IssueId, @UserId, @UserName, @ActivityId, @ActivityName, @Hours, @Comment, @SpentOn)";
                // create command parameters
                cmd.Parameters.AddWithValue("@id", "");
                cmd.Parameters.AddWithValue("@ProjectId", "");
                cmd.Parameters.AddWithValue("@ProjectName", "");
                cmd.Parameters.AddWithValue("@IssueId", "");
                cmd.Parameters.AddWithValue("@UserId", "");
                cmd.Parameters.AddWithValue("@UserName", "");
                cmd.Parameters.AddWithValue("@ActivityId", "");
                cmd.Parameters.AddWithValue("@ActivityName", "");
                cmd.Parameters.AddWithValue("@Hours", "");
                cmd.Parameters.AddWithValue("@Comment", "");
                cmd.Parameters.AddWithValue("@SpentOn", "");

                try
                {   // cycle writing data in table
                    foreach (Time_entry teItem in TE.time_entry_list)
                    {
                        cmd.Parameters["@id"].Value = teItem.id;
                        cmd.Parameters["@ProjectId"].Value = teItem.project.id;
                        cmd.Parameters["@ProjectName"].Value = teItem.project.name;
                        cmd.Parameters["@IssueId"].Value = teItem.issue.id;
                        cmd.Parameters["@UserId"].Value = teItem.user.id;
                        cmd.Parameters["@UserName"].Value = teItem.user.name;
                        cmd.Parameters["@ActivityId"].Value = teItem.activity.id;
                        cmd.Parameters["@ActivityName"].Value = teItem.activity.name;
                        cmd.Parameters["@Hours"].Value = teItem.hours;
                        cmd.Parameters["@Comment"].Value = teItem.comments;
                        cmd.Parameters["@SpentOn"].Value = teItem.spent_on + " 00:00:00.000";
                        cmd.ExecuteNonQuery();
                    }
                }
                catch (SQLiteException sqlex)
                {
                    MessageDel?.Invoke($"Error: {sqlex.Message}");
                }                
                transaction.Commit();
                cmd.Dispose();
                conn.Dispose();
            }
        }
        public static void InsertIssues(Issues issues)
        {
            SQLiteConnection conn = new SQLiteConnection($"Data Source={DbName}; Version=3;");

            conn.Open();

            // if connection established create sqlite command and begin transaction
            if (conn.State == ConnectionState.Open)
            {
                SQLiteCommand cmd = conn.CreateCommand();
                SQLiteTransaction transaction = conn.BeginTransaction();

                cmd.CommandText = "INSERT OR REPLACE INTO Issues(IssueId,ProjectId,ProjectName,TrackerId,TrackerName,StatusId,StatusName,PriorityId,PriorityName,AuthorId,AuthorName,AssignedToId,AssignedToName,CategoryId,CategoryName,Subject,Description,StartDate,DueDate,DoneRatio,IsPrivate,EstimatedHours,CreatedOn,UpdatedOn,ClosedOn) "
                                   + "VALUES (@IssueId, @ProjectId, @ProjectName, @TrackerId, @TrackerName, @StatusId, @StatusName, @PriorityId, @PriorityName, @AuthorId, @AuthorName, @AssignedToId, @AssignedToName, @CategoryId, @CategoryName, @Subject, @Description, @StartDate, @DueDate, @DoneRatio, @IsPrivate, @EstimatedHours, @CreatedOn, @UpdatedOn, @ClosedOn)";
                // create command parameters
                cmd.Parameters.AddWithValue("@IssueId", "");
                cmd.Parameters.AddWithValue("@ProjectId", "");
                cmd.Parameters.AddWithValue("@ProjectName", "");
                cmd.Parameters.AddWithValue("@TrackerId", "");
                cmd.Parameters.AddWithValue("@TrackerName", "");
                cmd.Parameters.AddWithValue("@StatusId", "");
                cmd.Parameters.AddWithValue("@StatusName", "");
                cmd.Parameters.AddWithValue("@PriorityId", "");
                cmd.Parameters.AddWithValue("@PriorityName", "");
                cmd.Parameters.AddWithValue("@AuthorId", "");
                cmd.Parameters.AddWithValue("@AuthorName", "");
                cmd.Parameters.AddWithValue("@AssignedToId", "");
                cmd.Parameters.AddWithValue("@AssignedToName", "");
                cmd.Parameters.AddWithValue("@CategoryId", "");
                cmd.Parameters.AddWithValue("@CategoryName", "");
                cmd.Parameters.AddWithValue("@Subject", "");
                cmd.Parameters.AddWithValue("@Description", "");
                cmd.Parameters.AddWithValue("@StartDate", "");
                cmd.Parameters.AddWithValue("@DueDate", "");
                cmd.Parameters.AddWithValue("@DoneRatio", "");
                cmd.Parameters.AddWithValue("@IsPrivate", "");
                cmd.Parameters.AddWithValue("@EstimatedHours", "");
                cmd.Parameters.AddWithValue("@CreatedOn", "");
                cmd.Parameters.AddWithValue("@UpdatedOn", "");
                cmd.Parameters.AddWithValue("@ClosedOn", "");

                try
                {   // cycle writing data in table
                    foreach (Issue issue in issues.issue)
                    {
                        cmd.Parameters["@IssueId"].Value = issue.id;
                        cmd.Parameters["@ProjectId"].Value = issue.project.id;
                        cmd.Parameters["@ProjectName"].Value = issue.project.name;
                        cmd.Parameters["@TrackerId"].Value = issue.tracker.id;
                        cmd.Parameters["@TrackerName"].Value = issue.tracker.name;
                        cmd.Parameters["@StatusId"].Value = issue.status.id;
                        cmd.Parameters["@StatusName"].Value = issue.status.name;
                        cmd.Parameters["@PriorityId"].Value = issue.priority.id;
                        cmd.Parameters["@PriorityName"].Value = issue.priority.name;
                        cmd.Parameters["@AuthorId"].Value = issue.author.id;
                        cmd.Parameters["@AuthorName"].Value = issue.author.name;
                        cmd.Parameters["@AssignedToId"].Value = issue.assigned_to.id;
                        cmd.Parameters["@AssignedToName"].Value = issue.assigned_to.name;
                        cmd.Parameters["@CategoryId"].Value = issue.category.id;
                        cmd.Parameters["@CategoryName"].Value = issue.category.name;
                        cmd.Parameters["@Subject"].Value = issue.subject;
                        cmd.Parameters["@Description"].Value = issue.description;
                        cmd.Parameters["@StartDate"].Value = issue.startDate;
                        cmd.Parameters["@DueDate"].Value = issue.dueDate;
                        cmd.Parameters["@DoneRatio"].Value = issue.doneRatio;
                        cmd.Parameters["@IsPrivate"].Value = issue.IsPrivate == true ? 1 : 0;
                        cmd.Parameters["@EstimatedHours"].Value = issue.estimatedHours;
                        cmd.Parameters["@CreatedOn"].Value = issue.createdOn;
                        cmd.Parameters["@UpdatedOn"].Value = issue.updatedOn;
                        cmd.Parameters["@ClosedOn"].Value = issue.closedOn;
                        cmd.ExecuteNonQuery();
                    }
                }
                catch (SQLiteException sqlex)
                {
                    MessageDel?.Invoke($"Error: {sqlex.Message}");
                }
                transaction.Commit();
                cmd.Dispose();
                conn.Dispose();
            }
        }
        public static void InsertIssue(Issue issue)
        {
            SQLiteConnection conn = new SQLiteConnection($"Data Source={DbName}; Version=3;");

            if (issue.JournalList.Count > 0)
            {
                InsertJournals(issue);
            }

            conn.Open();

            // if connection established create sqlite command and begin transaction
            if (conn.State == ConnectionState.Open)
            {
                SQLiteCommand cmd = conn.CreateCommand();
                SQLiteTransaction transaction = conn.BeginTransaction();

                cmd.CommandText = "INSERT OR REPLACE INTO Issues(IssueId,ProjectId,ProjectName,TrackerId,TrackerName,StatusId,StatusName,PriorityId,PriorityName,AuthorId,AuthorName,AssignedToId,AssignedToName,CategoryId,CategoryName,Subject,Description,StartDate,DueDate,DoneRatio,IsPrivate,EstimatedHours,CreatedOn,UpdatedOn,ClosedOn) "
                                   + "VALUES (@IssueId, @ProjectId, @ProjectName, @TrackerId, @TrackerName, @StatusId, @StatusName, @PriorityId, @PriorityName, @AuthorId, @AuthorName, @AssignedToId, @AssignedToName, @CategoryId, @CategoryName, @Subject, @Description, @StartDate, @DueDate, @DoneRatio, @IsPrivate, @EstimatedHours, @CreatedOn, @UpdatedOn, @ClosedOn)";
                // create command parameters
                cmd.Parameters.AddWithValue("@IssueId", "");
                cmd.Parameters.AddWithValue("@ProjectId", "");
                cmd.Parameters.AddWithValue("@ProjectName", "");
                cmd.Parameters.AddWithValue("@TrackerId", "");
                cmd.Parameters.AddWithValue("@TrackerName", "");
                cmd.Parameters.AddWithValue("@StatusId", "");
                cmd.Parameters.AddWithValue("@StatusName", "");
                cmd.Parameters.AddWithValue("@PriorityId", "");
                cmd.Parameters.AddWithValue("@PriorityName", "");
                cmd.Parameters.AddWithValue("@AuthorId", "");
                cmd.Parameters.AddWithValue("@AuthorName", "");
                cmd.Parameters.AddWithValue("@AssignedToId", "");
                cmd.Parameters.AddWithValue("@AssignedToName", "");
                cmd.Parameters.AddWithValue("@CategoryId", "");
                cmd.Parameters.AddWithValue("@CategoryName", "");
                cmd.Parameters.AddWithValue("@Subject", "");
                cmd.Parameters.AddWithValue("@Description", "");
                cmd.Parameters.AddWithValue("@StartDate", "");
                cmd.Parameters.AddWithValue("@DueDate", "");
                cmd.Parameters.AddWithValue("@DoneRatio", "");
                cmd.Parameters.AddWithValue("@IsPrivate", "");
                cmd.Parameters.AddWithValue("@EstimatedHours", "");
                cmd.Parameters.AddWithValue("@CreatedOn", "");
                cmd.Parameters.AddWithValue("@UpdatedOn", "");
                cmd.Parameters.AddWithValue("@ClosedOn", "");

                try
                {   // cycle writing data in table
                    cmd.Parameters["@IssueId"].Value = issue.id;
                    cmd.Parameters["@ProjectId"].Value = issue.project.id;
                    cmd.Parameters["@ProjectName"].Value = issue.project.name;
                    cmd.Parameters["@TrackerId"].Value = issue.tracker.id;
                    cmd.Parameters["@TrackerName"].Value = issue.tracker.name;
                    cmd.Parameters["@StatusId"].Value = issue.status.id;
                    cmd.Parameters["@StatusName"].Value = issue.status.name;
                    cmd.Parameters["@PriorityId"].Value = issue.priority.id;
                    cmd.Parameters["@PriorityName"].Value = issue.priority.name;
                    cmd.Parameters["@AuthorId"].Value = issue.author.id;
                    cmd.Parameters["@AuthorName"].Value = issue.author.name;
                    cmd.Parameters["@AssignedToId"].Value = issue.assigned_to.id;
                    cmd.Parameters["@AssignedToName"].Value = issue.assigned_to.name;
                    cmd.Parameters["@CategoryId"].Value = issue.category.id;
                    cmd.Parameters["@CategoryName"].Value = issue.category.name;
                    cmd.Parameters["@Subject"].Value = issue.subject;
                    cmd.Parameters["@Description"].Value = issue.description;
                    cmd.Parameters["@StartDate"].Value = issue.startDate;
                    cmd.Parameters["@DueDate"].Value = issue.dueDate;
                    cmd.Parameters["@DoneRatio"].Value = issue.doneRatio;
                    cmd.Parameters["@IsPrivate"].Value = issue.IsPrivate == true ? 1 : 0;
                    cmd.Parameters["@EstimatedHours"].Value = issue.estimatedHours;
                    cmd.Parameters["@CreatedOn"].Value = issue.createdOn;
                    cmd.Parameters["@UpdatedOn"].Value = issue.updatedOn;
                    cmd.Parameters["@ClosedOn"].Value = issue.closedOn;
                    cmd.ExecuteNonQuery();
                }
                catch (SQLiteException sqlex)
                {
                    MessageDel?.Invoke($"Error: {sqlex.Message}");
                }
                transaction.Commit();
                cmd.Dispose();
                conn.Dispose();
            }
        }
        private static void InsertJournals(Issue issue)
        {
            SQLiteConnection conn = new SQLiteConnection($"Data Source={DbName}; Version=3;");

            if (issue.JournalList.Count > 0)
            {
                InsertDetails(issue);
            }

            conn.Open();

            // if connection established create sqlite command and begin transaction
            if (conn.State == ConnectionState.Open)
            {
                SQLiteCommand cmd = conn.CreateCommand();
                SQLiteTransaction transaction = conn.BeginTransaction();

                cmd.CommandText = "INSERT OR IGNORE INTO Journals(Id, IssueId, UserId, UserName, CreatedOn, Notes) "
                                   + "VALUES (@Id, @IssueId, @UserId, @UserName, @CreatedOn, @Notes)";
                // create command parameters
                cmd.Parameters.AddWithValue("@Id", "");
                cmd.Parameters.AddWithValue("@IssueId", "");
                cmd.Parameters.AddWithValue("@UserId", "");
                cmd.Parameters.AddWithValue("@UserName", "");
                cmd.Parameters.AddWithValue("@CreatedOn", "");
                cmd.Parameters.AddWithValue("@Notes", "");
                try
                {   // cycle writing data in table
                    foreach (Issue.IssueJournalItem Item in issue.JournalList)
                    {
                        cmd.Parameters["@id"].Value = Item.Id;
                        cmd.Parameters["@IssueId"].Value = issue.id;
                        cmd.Parameters["@UserId"].Value = Item.User.id;
                        cmd.Parameters["@UserName"].Value = Item.User.name;
                        cmd.Parameters["@Notes"].Value = Item.Notes;
                        cmd.Parameters["@CreatedOn"].Value = Item.CreatedOn;
                        cmd.ExecuteNonQuery();
                    }
                }
                catch (SQLiteException sqlex)
                {
                    MessageDel?.Invoke($"Error: {sqlex.Message}");
                }
                transaction.Commit();
                cmd.Dispose();
                conn.Dispose();
            }
        }
        private static void InsertDetails(Issue issue)
        {
            SQLiteConnection conn = new SQLiteConnection($"Data Source={DbName}; Version=3;");

            conn.Open();

            // if connection established create sqlite command and begin transaction
            if (conn.State == ConnectionState.Open)
            {
                SQLiteCommand cmd = conn.CreateCommand();
                SQLiteTransaction transaction = conn.BeginTransaction();

                cmd.CommandText = "INSERT OR IGNORE INTO JournalDetails(JournalId, Property, Name, OldValue, NewValue) "
                                   + "VALUES (@JournalId, @Property, @Name, @OldValue, @NewValue)";
                // create command parameters
                cmd.Parameters.AddWithValue("@JournalId", "");
                cmd.Parameters.AddWithValue("@Property", "");
                cmd.Parameters.AddWithValue("@Name", "");
                cmd.Parameters.AddWithValue("@OldValue", "");
                cmd.Parameters.AddWithValue("@NewValue", "");

                try
                {   // cycle writing data in table
                    foreach (Issue.IssueJournalItem JournalItem in issue.JournalList)
                    {
                        foreach (Issue.IssueJournalItem.Detail DetailItem in JournalItem.Details)
                        {
                            cmd.Parameters["@JournalId"].Value = JournalItem.Id;
                            cmd.Parameters["@Property"].Value = DetailItem.Property;
                            cmd.Parameters["@Name"].Value = DetailItem.Name;
                            cmd.Parameters["@OldValue"].Value = DetailItem.OldValue;
                            cmd.Parameters["@NewValue"].Value = DetailItem.NewValue;
                            cmd.ExecuteNonQuery();
                        }
                    }
                }
                catch (SQLiteException sqlex)
                {
                    MessageDel?.Invoke($"Error: {sqlex.Message}");
                }
                transaction.Commit();
                cmd.Dispose();
                conn.Dispose();
            }
        }
        #endregion

        #region ------------------------ get/calc methods---------------------------
        public static User GetUserById(string UserId)
        {
            User user = new User();
            SQLiteConnection conn = new SQLiteConnection($"Data Source={DbName}; Version=3;");

            conn.Open();

            if (conn.State == ConnectionState.Open)
            {
                SQLiteCommand cmd = conn.CreateCommand();
                cmd.CommandText = "SELECT * FROM Users WHERE Id = @UserId LIMIT 1";
                cmd.Parameters.AddWithValue("@UserId", UserId);

                try
                {
                    SQLiteDataReader r = cmd.ExecuteReader();
                    while (r.Read())
                    {
                        user.Id = r["Id"].ToString();
                        user.Name = r["Name"].ToString();
                        user.CompanyName = r["CompanyName"].ToString();
                        user.Position = r["Position"].ToString();
                        user.Telephone = r["Telephone"].ToString();
                        user.InternalPhone = r["InternalPhone"].ToString();
                    //    user.Language = (Language)r["Language"].ToString();
                        user.BaseAddress = r["BaseAddress"].ToString();
                        user.ApiKey = r["ApiKey"].ToString();
                    }
                    r.Close();
                }
                catch (SQLiteException sqlex)
                {
                    MessageDel?.Invoke($"Error: {sqlex.Message}");
                }
                cmd.Dispose();
                conn.Dispose();
            }
            return (user.Name != string.Empty) ? user : null;
        }
        public static void GetIssue(Issue issue)
        {
            SQLiteConnection conn = new SQLiteConnection($"Data Source={DbName}; Version=3;");

            conn.Open();

            if (conn.State == ConnectionState.Open)
            {
                SQLiteCommand cmd = conn.CreateCommand();
                cmd.CommandText = "select * from Issues where IssueId = @IssueId";
                cmd.Parameters.AddWithValue("@IssueId", issue.id);
                try
                {
                    SQLiteDataReader r = cmd.ExecuteReader();
                    while (r.Read())
                    {                                                 
                        issue.project.id = int.Parse(r["ProjectId"].ToString());
                        issue.project.name = r["ProjectName"].ToString();
                        issue.tracker.id = int.Parse(r["TrackerId"].ToString());
                        issue.tracker.name = r["TrackerName"].ToString();
                        issue.status.id = int.Parse(r["StatusId"].ToString());
                        issue.status.name = r["StatusName"].ToString();
                        issue.priority.id = int.Parse(r["PriorityId"].ToString());
                        issue.priority.name = r["PriorityName"].ToString();
                        issue.author.id = int.Parse(r["AuthorId"].ToString());
                        issue.author.name = r["AuthorName"].ToString();
                        issue.assigned_to.id = int.Parse(r["AssignedToId"].ToString());
                        issue.assigned_to.name = r["AssignedToName"].ToString();
                        issue.category.id = int.Parse(r["CategoryId"].ToString());
                        issue.category.name = r["CategoryName"].ToString();
                        issue.subject = r["Subject"].ToString();
                        issue.description = r["Description"].ToString();
                        issue.startDate = r["StartDate"].ToString();
                        issue.dueDate = r["DueDate"].ToString();
                        issue.doneRatio = r["DoneRatio"].ToString();
                        issue.IsPrivate = int.Parse(r["IsPrivate"].ToString()) == 0 ? false : true;
                        issue.estimatedHours = r["EstimatedHours"].ToString();
                        issue.createdOn = r["CreatedOn"].ToString();
                        issue.updatedOn = r["UpdatedOn"].ToString();
                        issue.closedOn = r["ClosedOn"].ToString();
                    }
                    r.Close();
                }
                catch (SQLiteException sqlex)
                {
                    MessageDel?.Invoke($"Error: {sqlex.Message}");
                }
                cmd.Dispose();
                conn.Dispose();
            }
        }

        /// Get min or max date for user existed in DB,
        /// <param name="UserId">string, UserID</param>
        /// <param name="isMIN">true if needed min, false if max</param>
        public static string GetDate(string UserId, bool isMIN)
        {

            SQLiteConnection conn = new SQLiteConnection($"Data Source={DbName}; Version=3;");
            Object obj = "";

            conn.Open();

            if (conn.State == ConnectionState.Open)
            {
                SQLiteCommand cmd = conn.CreateCommand();
                if (isMIN == true)
                    cmd.CommandText = "SELECT MIN(SpentOn) FROM TimeEntries where UserId = @UserId";
                else
                    cmd.CommandText = "SELECT MAX(SpentOn) FROM TimeEntries where UserId = @UserId";

                cmd.Parameters.AddWithValue("@UserId", UserId);
                try
                {
                    obj = cmd.ExecuteScalar();
                }
                catch (SQLiteException sqlex)
                {
                    MessageDel?.Invoke($"Error: {sqlex.Message}");
                    return null;
                }
                cmd.Dispose();
                conn.Dispose();
            }
            return (obj.ToString() != "") ? obj.ToString() : "1970-01-01";

        }

        // calc time for user
        public static string CalcTime(string UserId, string DateFrom, string DateTo)
        {
            SQLiteConnection conn = new SQLiteConnection($"Data Source={DbName}; Version=3;");
            Object obj = "";

            conn.Open();

            if (conn.State == ConnectionState.Open)
            {
                SQLiteCommand cmd = conn.CreateCommand();
                cmd.CommandText = "SELECT SUM(Hours) FROM (SELECT Hours FROM TimeEntries where UserId = @UserId and (SpentOn between @DateFrom and @DateTo));";
                cmd.Parameters.AddWithValue("@UserId", UserId);
                cmd.Parameters.AddWithValue("@DateFrom", (DateFrom + " 00:00:00.000"));
                cmd.Parameters.AddWithValue("@DateTo", (DateTo + " 23:59:59.999"));

                try
                {
                    obj = cmd.ExecuteScalar();
                }
                catch (SQLiteException sqlex)
                {
                    MessageDel?.Invoke($"Error: {sqlex.Message}");
                    return "0,00";
                }
                cmd.Dispose();
                conn.Dispose();
            }
            return (obj.ToString() == "") ? "0,00" : Math.Round(double.Parse(obj.ToString()),2).ToString();
        }

        // GetName
        public static string GetName(string UserId)
        {
            SQLiteConnection conn = new SQLiteConnection($"Data Source={DbName}; Version=3;");
            string str = "";

            conn.Open();

            if (conn.State == ConnectionState.Open)
            {
                SQLiteCommand cmd = conn.CreateCommand();
                cmd.CommandText = "SELECT UserName FROM TimeEntries WHERE UserId = @UserId LIMIT 1";
                cmd.Parameters.AddWithValue("@UserId", UserId);

                try
                {
                    SQLiteDataReader r = cmd.ExecuteReader();                   
                    while (r.Read())
                    {
                        str = r["UserName"].ToString();
                    }
                    r.Close();
                }
                catch (SQLiteException sqlex)
                {
                    MessageDel?.Invoke($"Error: {sqlex.Message}");
                    return "error";
                }
                cmd.Dispose();
                conn.Dispose();
            }
            return (str != "") ? str : "John Doe";
        }

        // count records for UserId for time period
        public static int CountRecs(string UserId, string DateFrom, string DateTo)
        {
            SQLiteConnection conn = new SQLiteConnection($"Data Source={DbName}; Version=3;");
            int obj = 0;

            conn.Open();

            if (conn.State == ConnectionState.Open)
            {
                SQLiteCommand cmd = conn.CreateCommand();
                cmd.CommandText = "SELECT COUNT(*) FROM (SELECT UserId FROM TimeEntries where UserId = @UserId and (SpentOn between @DateFrom and @DateTo));";
                cmd.Parameters.AddWithValue("@UserId", UserId);
                cmd.Parameters.AddWithValue("@DateFrom", (DateFrom + " 00:00:00.000"));
                cmd.Parameters.AddWithValue("@DateTo", (DateTo + " 23:59:59.999"));

                try
                {
                    obj = int.Parse(cmd.ExecuteScalar().ToString());
                }
                catch (SQLiteException sqlex)
                {
                    MessageDel?.Invoke($"Error: {sqlex.Message}");
                }
                cmd.Dispose();
                conn.Dispose();
            }
            return obj;
        }

        // get UserId with UserName
        public static string GetUserId(string UserName)
        {
            SQLiteConnection conn = new SQLiteConnection($"Data Source={DbName}; Version=3;");
            string str = "";

            conn.Open();

            if (conn.State == ConnectionState.Open)
            {
                SQLiteCommand cmd = conn.CreateCommand();
                cmd.CommandText = "SELECT UserId FROM TimeEntries WHERE UserName = @UserName LIMIT 1";
                cmd.Parameters.AddWithValue("@UserName", UserName);

                try
                {
                    SQLiteDataReader r = cmd.ExecuteReader();
                    while (r.Read())
                    {
                        str = r["UserId"].ToString();
                    }
                    r.Close();
                }
                catch (SQLiteException sqlex)
                {
                    MessageDel?.Invoke($"Error: {sqlex.Message}");
                }
                cmd.Dispose();
                conn.Dispose();
            }
            return (str != "") ? str : "0";
        }
        #endregion
    }
}
