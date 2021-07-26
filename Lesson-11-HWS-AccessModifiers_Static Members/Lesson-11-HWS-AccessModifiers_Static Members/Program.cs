using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson_11_HWS_AccessModifiers_Static_Members
{
    class Program
    {
        static void Main(string[] args)
        {
            User u1 = new User
            {
                userName = "1",
                password = "1",
                permission = Permission.Admin,
                isLogin = false
            };
            User u2 = new User
            {
                userName = "2",
                password = "2",
                permission = Permission.Admin,
                isLogin = false
            };
            User u3 = new User
            {
                userName = "3",
                password = "3",
                permission = Permission.User,
                isLogin = false
            };
            User.users[0] = u1;
            User.users[1] = u2;
            User.users[2] = u3;

            User.Login("1", "1");

            #region Enum

            DaysOfWeek someDay = DaysOfWeek.Sunday;
            
            // Get All Values As Strin Array
            string[] s = Enum.GetNames(typeof(DaysOfWeek));

            //Parse
            string dayFromUser = "Monday";
            DaysOfWeek afterParse = (DaysOfWeek)Enum.Parse(typeof(DaysOfWeek), dayFromUser);
            //DaysOfWeek dd = DaysOfWeek.Tuesday;


            int res;
            int.TryParse("3aa2", out res);

            //Get Number Value From Enum
            int xx = (int)DaysOfWeek.Saturday;// = 6

            string nameOfValue = DaysOfWeek.Sunday.ToString();// = "Sunday"

            //Multiple Values
            DaysOfWeek dow = DaysOfWeek.Friday | DaysOfWeek.Wednesday;

            #endregion

        }
    }

    public enum DaysOfWeek
    {
        Sunday,
        Monday,
        Tuesday,
        Wednesday,
        Thursday,
        Friday,
        Saturday
    }

    public enum PromoteTypes
    {
        BuyAndGet,
        LineDiscount
    }

}
