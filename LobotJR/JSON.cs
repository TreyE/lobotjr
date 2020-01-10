﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


class Data
{
    public int chatter_count { get; set; }
    public Chatters chatters { get; set; }
    

    public class Chatters
    {
        public List<string> vips { get; set; }
        public List<string> moderators { get; set; }
        public List<string> staff { get; set; }
        public List<string> viewers { get; set; }
        public List<string> admins { get; set; }
    }

    
}

class SubscriberData
{
    public class RootObject
    {
        public List<Subscription> data { get; set; }
        public Pagination pagination { get; set; }
    }

    public class Subscription
    {
        public String broadcaster_id { get; set; }
        public String broadcaster_name { get; set; }
        public bool is_gift { get; set; }
        public String tier { get; set; }
        public String plan_name { get; set; }
        public String user_id { get; set; }
        public String user_name { get; set; }
    }

    public class Pagination
    {
        public String cursor { get; set; }
    }
}

//class SubscriberData
//{
//    public class Links
//    {
//        public string next { get; set; }
//        public string self { get; set; }
//    }

//    public class Links2
//    {
//        public string self { get; set; }
//    }

//    public class User
//    {
//        public int _id { get; set; }
//        public object logo { get; set; }
//        public bool staff { get; set; }
//        public string created_at { get; set; }
//        public string name { get; set; }
//        public string updated_at { get; set; }
//        public string display_name { get; set; }
//        public Links2 _links { get; set; }
//    }

//    public class Links3
//    {
//        public string self { get; set; }
//    }

//    public class Subscription
//    {
//        public string _id { get; set; }
//        public User user { get; set; }
//        public string created_at { get; set; }
//        public Links3 _links { get; set; }
//    }

//    public class RootObject
//    {
//        public int _total { get; set; }
//        public Links _links { get; set; }
//        public List<Subscription> subscriptions { get; set; }
//    }
//}
