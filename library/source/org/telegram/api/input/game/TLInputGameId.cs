﻿namespace org.telegram.api.input.game
{
    using IKVM.Attributes;
    using java.io;
    using org.telegram.tl;
    using System;
    using System.Runtime.CompilerServices;
    using System.Runtime.Serialization;
    using System.Security.Permissions;

    [Serializable]
    public class TLInputGameId : TLAbsInputGame
    {
        private long accessHash;
        public const int CLASS_ID = 0x32c3e77;
        private long id;

        [MethodImpl(MethodImplOptions.NoInlining), LineNumberTable(0x10)]
        public TLInputGameId()
        {
        }

        [HideFromJava, SecurityPermission(SecurityAction.Demand, SerializationFormatter=true)]
        protected TLInputGameId(SerializationInfo info1, StreamingContext context1) : base(info1, context1)
        {
        }

        [MethodImpl(MethodImplOptions.NoInlining), Throws(new string[] { "java.io.IOException" }), LineNumberTable(new byte[] { 1, 0x6c, 0x6c })]
        public override void deserializeBody(InputStream stream, TLContext context)
        {
            this.id = StreamingUtils.readLong(stream);
            this.accessHash = StreamingUtils.readLong(stream);
        }

        public virtual long getAccessHash() => 
            this.accessHash;

        public override int getClassId() => 
            0x32c3e77;

        public virtual long getId() => 
            this.id;

        [MethodImpl(MethodImplOptions.NoInlining), Throws(new string[] { "java.io.IOException" }), LineNumberTable(new byte[] { 0x9f, 0xbb, 0x6c, 110 })]
        public override void serializeBody(OutputStream stream)
        {
            StreamingUtils.writeLong(this.id, stream);
            StreamingUtils.writeLong(this.accessHash, stream);
        }

        public virtual void setAccessHash(long accessHash)
        {
            this.accessHash = accessHash;
        }

        public virtual void setId(long id)
        {
            this.id = id;
        }

        public override string toString() => 
            "inputGameID#32c3e77";
    }
}

