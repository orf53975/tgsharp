﻿namespace org.telegram.api.document.attribute
{
    using IKVM.Attributes;
    using org.telegram.tl;
    using System;
    using System.Runtime.CompilerServices;
    using System.Runtime.Serialization;
    using System.Security.Permissions;

    [Serializable]
    public abstract class TLAbsDocumentAttribute : TLObject
    {
        [MethodImpl(MethodImplOptions.NoInlining), LineNumberTable(new byte[] { 0x9f, 0xa5, 0x68 })]
        protected internal TLAbsDocumentAttribute()
        {
        }

        [HideFromJava, SecurityPermission(SecurityAction.Demand, SerializationFormatter=true)]
        protected TLAbsDocumentAttribute(SerializationInfo info1, StreamingContext context1) : base(info1, context1)
        {
        }
    }
}

