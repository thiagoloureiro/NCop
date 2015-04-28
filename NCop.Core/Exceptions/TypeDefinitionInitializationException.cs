﻿// ------------------------------------------------------------------------------
//  <auto-generated>
//    Generated by NCop Copyright © 2015
//    Changes to this file may cause incorrect behavior and will be lost if
//    the code is regenerated.
// </auto-generated
// ------------------------------------------------------------------------------

namespace NCop.Core.Exceptions
{
	using System;
    using System.Runtime.Serialization;
	
	[Serializable]
	public class TypeDefinitionInitializationException : SystemException, ISerializable
	{
        private readonly string message = string.Empty;
		private readonly bool messageInitialized = false;
		
        public TypeDefinitionInitializationException(string message) 
		    : base(message) {
            messageInitialized = true;
        }

        public TypeDefinitionInitializationException(string message, Exception innerException) 
		    : base(message, innerException) {
            messageInitialized = true;
        }
		
		
		public override string Message {
            get {
                if (messageInitialized) {
                    return base.Message;
                }

                return message;
            }
        }
		
		protected TypeDefinitionInitializationException(SerializationInfo info, StreamingContext context)
            : base(info, context) {

            if (info == null) {
                throw new ArgumentNullException("info");
            }

            message = info.GetString("TypeDefinitionMessage");
        }

        public override void GetObjectData(SerializationInfo info, StreamingContext context) {
            if (info == null) {
                throw new ArgumentNullException("info");
            }

            base.GetObjectData(info, context);
            info.AddValue("TypeDefinitionMessage", Message);
        }
	}	
}