﻿namespace org.telegram.mtproto.tl
{
    using IKVM.Attributes;
    using java.io;
    using java.lang;
    using java.util;
    using org.telegram.tl;
    using System;
    using System.Runtime.CompilerServices;
    using System.Runtime.Serialization;
    using System.Security.Permissions;

    [Serializable]
    public class MTMsgsStateReq : TLObject
    {
        public const int CLASS_ID = -630588590;
        private TLLongVector messages;

        [MethodImpl(MethodImplOptions.NoInlining), LineNumberTable(new byte[] { 0x9f, 0xac, 0x68, 0x6b })]
        public MTMsgsStateReq()
        {
            this.messages = new TLLongVector();
        }

        [MethodImpl(MethodImplOptions.NoInlining), LineNumberTable(new byte[] { 0x9f, 0xa8, 0x68, 0x67 })]
        public MTMsgsStateReq(TLLongVector messages)
        {
            this.messages = messages;
        }

        [MethodImpl(MethodImplOptions.NoInlining), LineNumberTable(new byte[] { 0x9f, 0xb7, 0x68, 0x6b, 0x6d })]
        public MTMsgsStateReq(Long[] msgIds)
        {
            this.messages = new TLLongVector();
            Collections.addAll(this.messages, msgIds);
        }

        [MethodImpl(MethodImplOptions.NoInlining), LineNumberTable(new byte[] { 0x9f, 0xb0, 0x68, 0x6b, 0x70, 0x33, 0xa6 })]
        public MTMsgsStateReq(long[] msgIds)
        {
            this.messages = new TLLongVector();
            long[] numArray = msgIds;
            int length = numArray.Length;
            int index = 0;
            while (true)
            {
                if (index >= length)
                {
                    break;
                }
                long num3 = numArray[index];
                this.messages.add(Long.valueOf(num3));
                index++;
            }
        }

        [HideFromJava, SecurityPermission(SecurityAction.Demand, SerializationFormatter=true)]
        protected MTMsgsStateReq(SerializationInfo info1, StreamingContext context1) : base(info1, context1)
        {
        }

        [MethodImpl(MethodImplOptions.NoInlining), Throws(new string[] { "java.io.IOException" }), LineNumberTable(new byte[] { 12, 0x6d })]
        public override void deserializeBody(InputStream stream, TLContext context)
        {
            this.messages = StreamingUtils.readTLLongVector(stream, context);
        }

        public override int getClassId() => 
            -630588590;

        public virtual TLLongVector getMessages() => 
            this.messages;

        [MethodImpl(MethodImplOptions.NoInlining), Throws(new string[] { "java.io.IOException" }), LineNumberTable(new byte[] { 7, 110 })]
        public override void serializeBody(OutputStream stream)
        {
            StreamingUtils.writeTLVector(this.messages, stream);
        }

        public override string toString() => 
            "msg_resend_req#da69fb52";
    }
}

