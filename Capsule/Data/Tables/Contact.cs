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

    }
}
