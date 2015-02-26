using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

using FluentNHibernate;
using FluentNHibernate.Mapping;
using NHibernate;

namespace Walker.Nancy.Entities
{
    public class User
    {
        public virtual int Id { get; protected set; }
        public virtual string Nickname { get; set; }
        public virtual string Password { get; set; } // Obviously horrible to keep in plaintext. Fix before golive.
    }

    public class UserMap: ClassMap<User>
    {
        public UserMap()
        {
            Id(x => x.Id);
            Map(x => x.Nickname);
            Map(x => x.Password);
        }
    }
    
}