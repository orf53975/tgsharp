﻿namespace org.telegram.api.functions.messages
{
    using IKVM.Attributes;
    using ikvm.internal;
    using java.io;
    using java.lang;
    using org.telegram.api.input.peer;
    using org.telegram.tl;
    using System;
    using System.ComponentModel;
    using System.Runtime.CompilerServices;
    using System.Runtime.Serialization;
    using System.Security.Permissions;

    [Serializable, Signature("Lorg/telegram/tl/TLMethod<Lorg/telegram/tl/TLBool;>;")]
    public class TLRequestMessagesReportSpam : TLMethod
    {
        public const int CLASS_ID = -820669733;
        private TLAbsInputPeer peer;

        [MethodImpl(MethodImplOptions.NoInlining), LineNumberTable(new byte[] { 0x9f, 0xab, 0x68 })]
        public TLRequestMessagesReportSpam()
        {
        }

        [HideFromJava, SecurityPermission(SecurityAction.Demand, SerializationFormatter=true)]
        protected TLRequestMessagesReportSpam(SerializationInfo info1, StreamingContext context1) : base(info1, context1)
        {
        }

        [MethodImpl(MethodImplOptions.NoInlining), Throws(new string[] { "java.io.IOException" }), Modifiers(0x1041), EditorBrowsable(EditorBrowsableState.Never), LineNumberTable(0x11)]
        public virtual TLObject <bridge>deserializeResponse(InputStream @is, TLContext tlc) => 
            this.deserializeResponse(@is, tlc);

        [MethodImpl(MethodImplOptions.NoInlining), Throws(new string[] { "java.io.IOException" }), LineNumberTable(new byte[] { 13, 0x72 })]
        public override void deserializeBody(InputStream stream, TLContext context)
        {
            this.peer = StreamingUtils.readTLObject(stream, context);
        }

        [MethodImpl(MethodImplOptions.NoInlining), Throws(new string[] { "java.io.IOException" }), LineNumberTable(new byte[] { 0x9f, 180, 0x68, 0x63, 0x90, 0x68, 0x87 })]
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
            throw new IOException(new StringBuilder().append("Incorrect response type. Expected ").append(ClassLiteral<TLBool>.Value.getName()).append(", got: ").append(Object.instancehelper_getClass(obj2).getCanonicalName()).toString());
        }

        public override int getClassId() => 
            -820669733;

        public virtual TLAbsInputPeer getPeer() => 
            this.peer;

        [MethodImpl(MethodImplOptions.NoInlining), Throws(new string[] { "java.io.IOException" }), LineNumberTable(new byte[] { 8, 110 })]
        public override void serializeBody(OutputStream stream)
        {
            StreamingUtils.writeTLObject(this.peer, stream);
        }

        public virtual void setPeer(TLAbsInputPeer peer)
        {
            this.peer = peer;
        }

        public override string toString() => 
            "messages.reportSpam#cf1592db";
    }
}

