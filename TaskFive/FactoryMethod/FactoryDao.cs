using System;
using System.Collections.Generic;
using System.Text;
using TaskFive.Interfaces;
using static TaskFive.Interfaces.IDao;

namespace TaskFive.FactoryMethod
{
	internal class FactoryDao : ICreateDaoObject
	{
		public FactoryDao()
		{
		}

		public IDao<T> Create<T>(string stringConnection) where T : class
		{
			return GenericDao<T>.GetDao(stringConnection);
		}


	}
}
