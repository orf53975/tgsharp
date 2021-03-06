﻿namespace org.telegram.api.document.attribute
{
    using IKVM.Attributes;
    using System;
    using System.Runtime.CompilerServices;
    using System.Runtime.Serialization;
    using System.Security.Permissions;

    [Serializable]
    public class TLDocumentAttributeHasStickers : TLAbsDocumentAttribute
    {
        public const int CLASS_ID = -1744710921;

        [MethodImpl(MethodImplOptions.NoInlining), LineNumberTable(new byte[] { 0x9f, 0xa7, 0x68 })]
        public TLDocumentAttributeHasStickers()
        {
        }

        [HideFromJava, SecurityPermission(SecurityAction.Demand, SerializationFormatter=true)]
        protected TLDocumentAttributeHasStickers(SerializationInfo info1, StreamingContext context1) : base(info1, context1)
        {
        }

        public override int getClassId() => 
            -1744710921;

        public override string toString() => 
            "documentAttributeHasStickers#9801d2f7";
    }
}

