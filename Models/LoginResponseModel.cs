﻿namespace YUJCSR.Web.Corporate.Models
{
    public class LoginResponseModel
    {
       public  LoginResponseReult result { get; set;}
    }

    public class LoginResponseReult
    {
        public string csoid { get; set; }
        public string csoName { get; set; }
    }
}
