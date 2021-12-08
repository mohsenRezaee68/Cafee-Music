﻿namespace _0_Framework.Infrastructure
{
    public static class Roles
    {
        public const string Administrator = "1";
        public const string Operator = "2";
        public const string SystemUser = "3";
      
        public const string ColleagueUser = "10002";
        
        public static string GetRoleBy(long id)
        {
            switch (id)
            {
                case 1:
                    return "مدیرسیستم";
                case 2:
                    return "محتوا گذار";
                case 3:
                    return "کاربر";
                default:
                    return "";
            }
        }
    }
}
