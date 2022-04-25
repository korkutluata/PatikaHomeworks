using System;
using System.Collections.Generic;

namespace ToDo_App_Console
{
    public class Member
    {
        public int MemberID { get; set; }
        public string FullName { get; set; }
        public Nullable<int> CardID{get; set;}
        public Card Card{get;set;}

        static int memberid;
        public Member()
        {
            memberid++;
            MemberID=memberid;
        }
    }
}