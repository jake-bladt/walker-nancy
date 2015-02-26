using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Walker.Nancy.Entities
{
    public class User
    {
        public virtual int Id { get; protected set; }
        public virtual string Nickname { get; set; }
        public virtual string Password { get; set; } // Obviously horrible to keep in plaintext. Fix before letting anyone else use this system.
    }
}