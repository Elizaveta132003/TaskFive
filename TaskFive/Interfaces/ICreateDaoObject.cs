using System;
using System.Collections.Generic;
using System.Text;
using static TaskFive.Interfaces.IDao;

namespace TaskFive.Interfaces
{
	internal interface ICreateDaoObject
	{
		IDao<T> Create<T>(string stringConnection) where T : class;
	}
}
