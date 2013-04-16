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
	public class AspectBuilderNotFoundException : SystemException, ISerializable
	{
        private readonly string _message = string.Empty;
		private readonly bool _messageInitialized = false;

        public AspectBuilderNotFoundException(string message) 
		    : base(message) {
            _messageInitialized = true;
        }

        public AspectBuilderNotFoundException(string message, Exception innerException) 
		    : base(message, innerException) {
            _messageInitialized = true;
        }
		
		public AspectBuilderNotFoundException(Type type)
			: base(null) {
			Type = type;
			_message = string.Format("Could not found matching IAspectBuilder for type {0}", Type.FullName);
		}
	
		protected AspectBuilderNotFoundException(SerializationInfo info, StreamingContext context)
            : base(info, context) {
			object value = null;

            if (info == null) {
                throw new ArgumentNullException("info");
            }

            _message = info.GetString("AspectMessage");
			value = info.GetValue("AspectType", typeof(Type));

			if (value != null) {
				Type = (Type)value;
			}
        }
		
		public Type Type { get; protected set; }

		public override string Message {
            get {
                if (_messageInitialized) {
                    return base.Message;
                }

                return _message;
            }
        }

        public override void GetObjectData(SerializationInfo info, StreamingContext context) {
            if (info == null) {
                throw new ArgumentNullException("info");
            }

            base.GetObjectData(info, context);
            info.AddValue("AspectMessage", Message);
			info.AddValue("AspectType", Type, typeof(Type));
        }
	}	
}