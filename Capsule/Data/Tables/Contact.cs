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

        public int Classification { get; set; }

        public string FirstName { get; set; }

        public string MiddleInitial { get; set; }

        public string LastName { get; set; }

        public string Nickname { get; set; }

        public string NameSuffix { get; set; }

        public string Email { get; set; }

        public string Username { get; set; }

        public string Password { get; set; }

        public int LoginAttempts { get; set; }

        public bool ForcePasswordChange { get; set; }

        public bool IsLocked { get; set; }

        public string DisplayName { get; set; }

        public string Address1 { get; set; }

        public string Address2 { get; set; }

        public string City { get; set; }

        public string State { get; set; }

        public string Zip { get; set; }

        public string Phone1 { get; set; }

        public string Phone1Type { get; set; }

        public string Phone2 { get; set; }

        public string Phone2Type { get; set; }

        public string Fax { get; set; }

        public int UserRoleTypeID { get; set; }

        public string SecurityQuestion { get; set; }

        public string SecurityAnswer { get; set; }

        public DateTime LastAuthenticationDate { get; set; }

        public string SeparateAddress1 { get; set; }

        public string SeparateAddress2 { get; set; }

        public string SeparateCity { get; set; }

        public string SeparateState{ get; set; }

        public string SeparateZip { get; set; }

        public string AltContactName { get; set; }

        public string AltContactRelationship { get; set; }

        public string AltContactPhone { get; set; }

        public string LinkedIn { get; set; }

        public string Facebook { get; set; }

        public string Youtube { get; set; }

        public string Twitter { get; set; }

        public string Pinterest { get; set; }

        public string AgentCompanyName { get; set; }

        public string AgentEIN { get; set; }

        public int ReferredByID { get; set; }

        public int AssignedToID { get; set; }

        public int ContactTypeID { get; set; }
    }
}
