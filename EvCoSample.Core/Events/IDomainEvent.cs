﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EvCoSample.Core.Events
{
	public interface IDomainEvent
	{
		DateTime OcurrendOn { get; set; }
	}
}
