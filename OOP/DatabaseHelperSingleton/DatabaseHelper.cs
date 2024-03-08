using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DatabaseHelperSingleton
{
    internal class DatabaseHelper
    {
        // Private static reference, will hold the only instance:
        private static DatabaseHelper instance;
        // The constructor should be private:
        private DatabaseHelper()
        {
            // Some real code, connection to the DB and so on
            // ...
        }
        // A single access point:
        public static DatabaseHelper GetInstance()
        {
            // Lazy instantiation:
            if (instance == null)
            {
                instance = new DatabaseHelper();
            }
            return instance;
        }

        public List<User> RetrieveAllUsers()
        {
            List<User> users = new List<User>();
            // Actually query the DB for users
            // Load the results into the list
            return users;
        }
    }
    }
