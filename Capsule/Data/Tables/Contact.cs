using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Linq;
using System.Data.Linq.Mapping;
using Ion.Data.Linq.Mapping;

namespace Capsule.Data.Tables
{
    [Table(Name = "Contacts")]
    public class Contact : DbTableEquatable<IDbTableEquatable<long>>, IDbTableEquatable<long>
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

        [Column(IsPrimaryKey = true, DbType = "Bigint NOT NULL IDENTITY", AutoSync = AutoSync.OnInsert, IsDbGenerated = true)]
        public long ID { get; set; }
        [Column]
        public string FirstName { get; set; }
        [Column]
        public string LastName { get; set; }
        [Column]
        public int ContactTypeID { get; set; }
        [Column]
        public string Email { get; set; }
        [Column]
        public string Username { get; set; }
        [Column]
        public string Password { get; set; }
        [Column]
        public int LoginAttempts { get; set; }
        [Column]
        public bool ForcePasswordChange { get; set; }
        [Column]
        public bool IsLocked { get; set; }
        [Column]
        public string DisplayName { get; set; }
        [Column]
        public string Street { get; set; }
        [Column]
        public string City { get; set; }
		[MaxLength(Length = 2,ShouldTruncate=true)]
        [Column]
        public string State { get; set; }
        [Column]
        public string Zip { get; set; }
        [Column]
        public string Phone1 { get; set; }
        [Column]
        public string Phone2 { get; set; }
        [Column]
        public int UserRoleTypeID { get; set; }
        [Column]
        public string SecurityQuestion { get; set; }
        [Column]
        public string SecurityAnswer { get; set; }
        [Column]
        public DateTime LastAuthenticationDate { get; set; }
    }
}
