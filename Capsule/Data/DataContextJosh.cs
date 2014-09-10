using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Capsule.Data.Tables;
using SkyGroundLabs.Data.Entity;
using SkyGroundLabs.Data.Entity.Mapping;

namespace Capsule.Data
{
	public class DbContextJosh : DataContext
	{
		#region Constructor
		public DbContextJosh(string server, string database, string userID, string password)
			: base(server, database, userID, password)
		{
			_initialize();
		}

		public DbContextJosh(string connectionString)
			: base(connectionString)
		{
			_initialize();
		}

		private void _initialize()
		{
			
		}
		#endregion

		#region Properties
		public IDbSet<Contact> Contacts { get; set; }
		#endregion

		#region Methods
		public virtual void DeleteOnSave<TEntity>(TEntity entity)
			where TEntity : DbTableEquatable<IDbTableEquatable<long>>
		{
			base.DeleteOnSave<TEntity, long>(entity);
		}

        public virtual void SaveChanges<TEntity>(TEntity entity)
            where TEntity : DbTableEquatable<IDbTableEquatable<long>>
        {
            base.SaveChanges<TEntity, long>(entity);
        }

		protected override void _preprocessSave<TEntity, TPKType>(TEntity entity)
		{

		}
		#endregion
    }

    public class AuthenticateFunctions
    {
        public void Validate(string s, string t, string p)
        {

        }
    }
}
