using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SkyGroundLabs.Data.Entity.Mapping;

namespace Capsule.Data.Tables
{
    [Table("Contacts")]
    public class Contact : DbTableEquatable<IDbTableEquatable<long>>
    {

        public Contact()
        {
            /*
            Zip = "";
            DateEdited = DateTime.Now;
            DateEntered = DateTime.Now;
            AppointmentCount = 0;
            IsLocked = false;
            LockedByUserID = 0;
            */
			LastAuthenticationDate = Convert.ToDateTime("1/1/1900");
            
        }

        public long ID { get; set; }

        public string FirstName { get; set; }

        public string LastName { get; set; }

        public int ContactTypeID { get; set; }

        public string Email { get; set; }

        public string Username { get; set; }

        public string Password { get; set; }

        public int LoginAttempts { get; set; }

        public bool ForcePasswordChange { get; set; }

        public bool IsLocked { get; set; }

        public string DisplayName { get; set; }

        public string Street { get; set; }

        public string City { get; set; }

        public string State { get; set; }

        public string Zip { get; set; }

        public string Phone1 { get; set; }

        public string Phone2 { get; set; }

        public int UserRoleTypeID { get; set; }

        public string SecurityQuestion { get; set; }

        public string SecurityAnswer { get; set; }

        public DateTime LastAuthenticationDate { get; set; }
    }
}
