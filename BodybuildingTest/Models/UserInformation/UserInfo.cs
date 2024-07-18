﻿using System;
namespace BodybuildingTest.Models.UserInformation
{
    public class UserInfo
    {
        public UserInfo()
        {
        }
        public string Username { get; set; }
        public string Email { get; set; }
        public string Password { get; set; }
        public DateTime CreateTime { get; set; }
        public int UserID { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public DateTime MostRecentWorkout { get; set; }
    }
}
