﻿// ------------------------------------------------------------------------------
//  <auto-generated>
//    Generated by NCop Copyright ©
//    Changes to this file may cause incorrect behavior and will be lost if
//    the code is regenerated.
// </auto-generated
// ------------------------------------------------------------------------------

namespace NCop.Aspects.Exceptions
{
    using NCop.Core.Extensions;
    using System;
    using System.Runtime.Serialization;
	
	[Serializable]
	public class AspectBuilderNotFoundException : SystemException, ISerializable
	{
        private readonly string message = string.Empty;
		private readonly bool messageInitialized = false;
		
        public AspectBuilderNotFoundException(string message) 
		    : base(message) {
            messageInitialized = true;
        }

        public AspectBuilderNotFoundException(string message, Exception innerException) 
		    : base(message, innerException) {
            messageInitialized = true;
        }
		
		public AspectBuilderNotFoundException(Type aspectType)
			: base(null) {
			AspectType = aspectType;
			message = "Could not found matching IAspectBuilder for type {0}".Fmt(aspectType.FullName);
		}
	
		public Type AspectType { get; protected set; }

		public override string Message {
            get {
                if (messageInitialized) {
                    return base.Message;
                }

                return message;
            }
        }
		
		protected AspectBuilderNotFoundException(SerializationInfo info, StreamingContext context)
            : base(info, context) {
			object value = null;

            if (info == null) {
                throw new ArgumentNullException("info");
            }

            message = info.GetString("AspectMessage");
			value = info.GetValue("AspectType", typeof(Type));

			if (value != null) {
				AspectType = (Type)value;
			}
        }

        public override void GetObjectData(SerializationInfo info, StreamingContext context) {
            if (info == null) {
                throw new ArgumentNullException("info");
            }

            base.GetObjectData(info, context);
            info.AddValue("AspectMessage", Message);
			info.AddValue("AspectAspectType", AspectType, typeof(Type));
        }
	}	
}