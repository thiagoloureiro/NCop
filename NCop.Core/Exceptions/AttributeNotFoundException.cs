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

namespace NCop.Core.Exceptions
{	
	[Serializable]
	public class AttributeNotFoundException : SystemException, ISerializable
	{
        private readonly string _message = string.Empty;
		private readonly bool _messageInitialized = false;

        public AttributeNotFoundException(string message) 
		    : base(message) {
            _messageInitialized = true;
        }

        public AttributeNotFoundException(string message, Exception innerException) 
		    : base(message, innerException) {
            _messageInitialized = true;
        }
		
		protected AttributeNotFoundException(SerializationInfo info, StreamingContext context)
            : base(info, context) {

            if (info == null) {
                throw new ArgumentNullException("info");
            }

            _message = info.GetString("AttributeMessage");
        }
		
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
            info.AddValue("AttributeMessage", Message);
        }
	}	
}