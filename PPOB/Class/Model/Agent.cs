using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace PPOB.Class.Model
{
    public class Agent
    {
        public string Username { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public int Role { get; set; }
        public int Status { get; set; }
        public string Password { get; set; }
        public string AgentCode { get; set; }
        public string Pin { get; set; }
        public int TipeUsaha { get; set; }
        public string Email { get; set; }
        public int Commission { get; set; }
        public DateTime LastLogin { get; set; }
        public string Token { get; set; }
        public DateTime TokenExpired { get; set; }
        public int Upline { get; set; }
        public int Margin { get; set; }
        public int IdAgent { get; set; }
        public int Deposite { get; set; }
    }
}
