﻿

// ------------------------------------------------------------------------------
//  <auto-generated>
//    Generated by NCop Copyright © 2013
//    Changes to this file may cause incorrect behavior and will be lost if
//    the code is regenerated.
// </auto-generated
// ------------------------------------------------------------------------------
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;

namespace NCop.Aspects.Exceptions
{
	[Serializable]
	public class DuplicateAspectException : ArgumentException
	{
		private static string message = "Duplicate type aspects has been found";
		
		public DuplicateAspectException(string message = null) : base(message ?? DuplicateAspectException.message) { }

		public DuplicateAspectException(Exception innerException) : this(message, innerException) { }

		public DuplicateAspectException(string parameterName, string message = null) : base(message ?? DuplicateAspectException.message, parameterName) { }

		public DuplicateAspectException(string message, Exception innerException) : base(message, innerException) { }

		protected DuplicateAspectException(SerializationInfo info, StreamingContext context) : base(info, context) { }
	}
}
	