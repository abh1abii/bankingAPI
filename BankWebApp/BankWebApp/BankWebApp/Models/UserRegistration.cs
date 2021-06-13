using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Dapper;
using System.Configuration;
using System.Data;
using System.Data.SQLite;
using System.Text;
using System.Threading.Tasks;


namespace BankWebApp.Models
{
    public class UserRegistration
    {
        List<User> userList;
        static UserRegistration usrRegd = null;
        
        private UserRegistration()
        {
            userList = new List<User>();
            String cs = "Data Source=/Users/abii/Projects/Bank/Bank/bankDatabase.db; Version=3;";

            SQLiteConnection con = new SQLiteConnection(cs);
            con.Open();
            string query = "SELECT * from BankAcc;";
            using (SQLiteCommand cmd = new SQLiteCommand(query, con))
            {
                using (SQLiteDataReader rdr = cmd.ExecuteReader())
                {




                    if (rdr.HasRows)
                    {
                        while (rdr.Read())
                        {
                            User currentUser = new User();
                            currentUser.Name = rdr.GetString(0);
                            currentUser.AccNo = (UInt64)rdr.GetInt64(1);
                            currentUser.Bal = rdr.GetFloat(2);
                            userList.Add(currentUser);


                        }
                    }

                    

                }
            }
            con.Close();
            
        }

        public static UserRegistration getInstance()
        {
            //if (usrRegd == null)
            //{
                usrRegd = new UserRegistration();
                return usrRegd;
            //}
            //else
            //{
            //    return usrRegd;
            //}
        }

        public void Add(User user)
        {
            userList.Add(user);
            String cs = "Data Source=/Users/abii/Projects/Bank/Bank/bankDatabase.db; Version=3;";

            SQLiteConnection con = new SQLiteConnection(cs);
            con.Open();
            string query = "Insert INTO BankAcc VALUES(\"" + user.Name + "\"," + user.AccNo + ", " + user.Bal + ");";
            SQLiteCommand command = new SQLiteCommand(con);

            command.CommandText = query;

            command.ExecuteNonQuery();
            con.Close();
        }
        public int Remove(UInt64 AccNo)
        {
            for(int i = 0; i<userList.Count;i++)
            {
                User userAtIndex = userList.ElementAt(i);
                if (userAtIndex.AccNo.Equals(AccNo))
                {
                    userList.RemoveAt(i);

                    
                    String cs = "Data Source=/Users/abii/Projects/Bank/Bank/bankDatabase.db; Version=3;";

                    SQLiteConnection con = new SQLiteConnection(cs);
                    con.Open();
                    string query = "DELETE FROM BankAcc WHERE AccNo="+userAtIndex.AccNo+";";
                    SQLiteCommand command = new SQLiteCommand(con);

                    command.CommandText = query;

                    command.ExecuteNonQuery();
                    con.Close();


                    return 1;
                }
                
            }
            return 0;
        }
        public List<User> getAllUsers()
        {
            
            return userList;
        }
        public User GetAccNo(UInt64 AccNo)
        {
            for (int i = 0; i < userList.Count; i++)
            {
                User userAtIndex = userList.ElementAt(i);
                if (userAtIndex.AccNo.Equals(AccNo))
                {
                    return userAtIndex;
                }
            }
            return null;
        }
        public int UpdateUser(User user)
        {
            for (int i = 0; i < userList.Count; i++)
            {
                User userAtIndex = userList.ElementAt(i);
                if (userAtIndex.AccNo.Equals(user.AccNo))
                {
                    userList[i] = user;

                    String cs = "Data Source=/Users/abii/Projects/Bank/Bank/bankDatabase.db; Version=3;";

                    SQLiteConnection con = new SQLiteConnection(cs);
                    con.Open();
                    string query = "UPDATE BankAcc SET Name=\""+user.Name+"\", AccNo="+user.AccNo+", Balance="+user.Bal+" WHERE AccNo="+user.AccNo+";";
                    SQLiteCommand command = new SQLiteCommand(con);

                    command.CommandText = query;

                    command.ExecuteNonQuery();
                    con.Close();

                    return 1;
                }

            }

            return 0;
        }
    }
}
