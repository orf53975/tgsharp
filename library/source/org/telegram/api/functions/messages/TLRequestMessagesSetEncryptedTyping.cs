﻿namespace org.telegram.api.functions.messages
{
    using IKVM.Attributes;
    using java.io;
    using java.lang;
    using org.telegram.api.input.encrypted;
    using org.telegram.tl;
    using System;
    using System.ComponentModel;
    using System.Runtime.CompilerServices;
    using System.Runtime.Serialization;
    using System.Security.Permissions;

    [Serializable, Signature("Lorg/telegram/tl/TLMethod<Lorg/telegram/tl/TLBool;>;")]
    public class TLRequestMessagesSetEncryptedTyping : TLMethod
    {
        public const int CLASS_ID = 0x791451ed;
        private TLInputEncryptedChat peer;
        private bool typing;

        [MethodImpl(MethodImplOptions.NoInlining), LineNumberTable(new byte[] { 0x9f, 0xac, 0x68 })]
        public TLRequestMessagesSetEncryptedTyping()
        {
        }

        [HideFromJava, SecurityPermission(SecurityAction.Demand, SerializationFormatter=true)]
        protected TLRequestMessagesSetEncryptedTyping(SerializationInfo info1, StreamingContext context1) : base(info1, context1)
        {
        }

        [MethodImpl(MethodImplOptions.NoInlining), Throws(new string[] { "java.io.IOException" }), Modifiers(0x1041), EditorBrowsable(EditorBrowsableState.Never), LineNumberTable(0x11)]
        public virtual TLObject <bridge>deserializeResponse(InputStream @is, TLContext tlc) => 
            this.deserializeResponse(@is, tlc);

        [MethodImpl(MethodImplOptions.NoInlining), Throws(new string[] { "java.io.IOException" }), LineNumberTable(new byte[] { 0x29, 0x72, 0x6c })]
        public override void deserializeBody(InputStream stream, TLContext context)
        {
            this.peer = StreamingUtils.readTLObject(stream, context);
            this.typing = StreamingUtils.readTLBool(stream);
        }

        [MethodImpl(MethodImplOptions.NoInlining), Throws(new string[] { "java.io.IOException" }), LineNumberTable(new byte[] { 0x9f, 0xb5, 0x68, 0x63, 0x70, 0x68, 0x67 })]
        public virtual TLBool deserializeResponse(InputStream stream, TLContext context)
        {
            TLObject obj2 = StreamingUtils.readTLObject(stream, context);
            if (obj2 == null)
            {
                Throwable.__<suppressFillInStackTrace>();
                throw new IOException("Unable to parse response");
            }
            if (obj2 is TLBool)
            {
                return (TLBool) obj2;
            }
            Throwable.__<suppressFillInStackTrace>();
            throw new IOException(new StringBuilder().append("Incorrect response type. Expected org.telegram.tl.TLBool, got: ").append(Object.instancehelper_getClass(obj2).getCanonicalName()).toString());
        }

        public override int getClassId() => 
            0x791451ed;

        public virtual TLInputEncryptedChat getPeer() => 
            this.peer;

        public virtual bool getTyping() => 
            this.typing;

        [MethodImpl(MethodImplOptions.NoInlining), Throws(new string[] { "java.io.IOException" }), LineNumberTable(new byte[] { 0x23, 0x6c, 110 })]
        public override void serializeBody(OutputStream stream)
        {
            StreamingUtils.writeTLObject(this.peer, stream);
            StreamingUtils.writeTLBool(this.typing, stream);
        }

        public virtual void setPeer(TLInputEncryptedChat value)
        {
            this.peer = value;
        }

        public virtual void setTyping(bool value)
        {
            int num = (int) value;
            this.typing = (bool) num;
        }

        public override string toString() => 
            "messages.setEncryptedTyping#791451ed";
    }
}

