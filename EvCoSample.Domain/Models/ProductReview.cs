﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using EvCoSample.Core;

namespace EvCoSample.Domain
{
	public class ProductReview: Entity
	{		
		public string Text { get; set; }
		public Guid ProductId { get; set; }

		protected ProductReview()
		{}

		public ProductReview(string text, Guid productId)
		{
			this.Text = text;
			this.ProductId = productId;
		}
	}
}