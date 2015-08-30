﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EvCoSample.Domain
{
	public interface IProductRepository
	{		
		Product GetById(Guid productId);
		void Update(Product product);
	}
}