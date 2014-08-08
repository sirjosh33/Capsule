using System;
using System.Collections.Generic;
using System.Data.Linq;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Capsule.Data.Tables;
using Ion.Data.Linq;
using Ion.Data.Linq.Mapping;

namespace Capsule.Data
{
	public class DataContext : DbContext
	{
		#region Constructor
		public DataContext(string server, string database, string userID, string password)
			: base(server, database, userID, password)
		{
			_initialize();
		}

		public DataContext(string connectionString)
			: base(connectionString)
		{
			_initialize();
		}

		private void _initialize()
		{
			Contacts = GetTable<Contact>();
		}
		#endregion

		#region Properties
		public Table<Contact> Contacts { get; set; }
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

		public Table<TEntity> GetTable<TEntity>()
			where TEntity : DbTableEquatable<IDbTableEquatable<long>>
		{
			return base.GetTable<TEntity, long>();
		}

		protected override void _preprocessSave<TEntity, TPKType>(TEntity entity)
		{

		}
		#endregion

		#region Disposable Methods
		public void Dispose()
		{
			Contacts = null;

			base.Dispose();
		}
		#endregion
    }
}
