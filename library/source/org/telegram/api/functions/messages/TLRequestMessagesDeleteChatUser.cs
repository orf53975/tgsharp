﻿namespace org.telegram.api.functions.messages
{
    using IKVM.Attributes;
    using ikvm.internal;
    using java.io;
    using java.lang;
    using org.telegram.api.input.user;
    using org.telegram.api.updates;
    using org.telegram.tl;
    using System;
    using System.ComponentModel;
    using System.Runtime.CompilerServices;
    using System.Runtime.Serialization;
    using System.Security.Permissions;

    [Serializable, Signature("Lorg/telegram/tl/TLMethod<Lorg/telegram/api/updates/TLAbsUpdates;>;")]
    public class TLRequestMessagesDeleteChatUser : TLMethod
    {
        private int chatId;
        public const int CLASS_ID = -530505962;
        private TLAbsInputUser userId;

        [MethodImpl(MethodImplOptions.NoInlining), LineNumberTable(new byte[] { 0x9f, 0xac, 0x68 })]
        public TLRequestMessagesDeleteChatUser()
        {
        }

        [HideFromJava, SecurityPermission(SecurityAction.Demand, SerializationFormatter=true)]
        protected TLRequestMessagesDeleteChatUser(SerializationInfo info1, StreamingContext context1) : base(info1, context1)
        {
        }

        [MethodImpl(MethodImplOptions.NoInlining), Throws(new string[] { "java.io.IOException" }), Modifiers(0x1041), EditorBrowsable(EditorBrowsableState.Never), LineNumberTable(0x11)]
        public virtual TLObject <bridge>deserializeResponse(InputStream @is, TLContext tlc) => 
            this.deserializeResponse(@is, tlc);

        [MethodImpl(MethodImplOptions.NoInlining), Throws(new string[] { "java.io.IOException" }), LineNumberTable(new byte[] { 0x21, 0x6c, 0x72 })]
        public override void deserializeBody(InputStream stream, TLContext context)
        {
            this.chatId = StreamingUtils.readInt(stream);
            this.userId = StreamingUtils.readTLObject(stream, context);
        }

        [MethodImpl(MethodImplOptions.NoInlining), Throws(new string[] { "java.io.IOException" }), LineNumberTable(new byte[] { 0x9f, 0xb5, 0x68, 0x63, 0x90, 0x68, 0x87 })]
        public virtual TLAbsUpdates deserializeResponse(InputStream stream, TLContext context)
        {
            TLObject obj2 = StreamingUtils.readTLObject(stream, context);
            if (obj2 == null)
            {
                Throwable.__<suppressFillInStackTrace>();
                throw new IOException("Unable to parse response");
            }
            if (obj2 is TLAbsUpdates)
            {
                return (TLAbsUpdates) obj2;
            }
            Throwable.__<suppressFillInStackTrace>();
            throw new IOException(new StringBuilder().append("Incorrect response type. Expected ").append(ClassLiteral<TLAbsUpdates>.Value.getName()).append(", got: ").append(Object.instancehelper_getClass(obj2).getCanonicalName()).toString());
        }

        public virtual int getChatId() => 
            this.chatId;

        public override int getClassId() => 
            -530505962;

        public virtual TLAbsInputUser getUserId() => 
            this.userId;

        [MethodImpl(MethodImplOptions.NoInlining), Throws(new string[] { "java.io.IOException" }), LineNumberTable(new byte[] { 0x1b, 0x6c, 110 })]
        public override void serializeBody(OutputStream stream)
        {
            StreamingUtils.writeInt(this.chatId, stream);
            StreamingUtils.writeTLObject(this.userId, stream);
        }

        public virtual void setChatId(int chatId)
        {
            this.chatId = chatId;
        }

        public virtual void setUserId(TLAbsInputUser value)
        {
            this.userId = value;
        }

        public override string toString() => 
            "messages.deleteChatUser#e0611f16";
    }
}

