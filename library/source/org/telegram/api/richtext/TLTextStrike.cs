﻿namespace org.telegram.api.richtext
{
    using IKVM.Attributes;
    using ikvm.internal;
    using java.io;
    using org.telegram.tl;
    using System;
    using System.Runtime.CompilerServices;
    using System.Runtime.Serialization;
    using System.Security.Permissions;

    [Serializable]
    public class TLTextStrike : TLAbsRichText
    {
        public const int CLASS_ID = -1678197867;
        private TLAbsRichText text;

        [MethodImpl(MethodImplOptions.NoInlining), LineNumberTable(new byte[] { 0x9f, 0xa3, 0x68 })]
        public TLTextStrike()
        {
        }

        [HideFromJava, SecurityPermission(SecurityAction.Demand, SerializationFormatter=true)]
        protected TLTextStrike(SerializationInfo info1, StreamingContext context1) : base(info1, context1)
        {
        }

        [MethodImpl(MethodImplOptions.NoInlining), Throws(new string[] { "java.io.IOException" }), LineNumberTable(new byte[] { 0x9f, 0xb6, 0x77 })]
        public override void deserializeBody(InputStream stream, TLContext context)
        {
            this.text = StreamingUtils.readTLObject(stream, context, ClassLiteral<TLAbsRichText>.Value);
        }

        public override int getClassId() => 
            -1678197867;

        public virtual TLAbsRichText getText() => 
            this.text;

        [MethodImpl(MethodImplOptions.NoInlining), Throws(new string[] { "java.io.IOException" }), LineNumberTable(new byte[] { 0x9f, 0xb1, 110 })]
        public override void serializeBody(OutputStream stream)
        {
            StreamingUtils.writeTLObject(this.text, stream);
        }

        public override string toString() => 
            "textStrike#9bf8bb95";
    }
}

