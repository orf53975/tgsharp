﻿namespace org.telegram.api.functions.photos
{
    using IKVM.Attributes;
    using java.io;
    using java.lang;
    using org.telegram.tl;
    using System;
    using System.ComponentModel;
    using System.Runtime.CompilerServices;
    using System.Runtime.Serialization;
    using System.Security.Permissions;

    [Serializable, Signature("Lorg/telegram/tl/TLMethod<Lorg/telegram/tl/TLLongVector;>;")]
    public class TLRequestPhotosDeletePhotos : TLMethod
    {
        public const int CLASS_ID = -2016444625;
        [Signature("Lorg/telegram/tl/TLVector<Lorg/telegram/api/input/photo/TLAbsInputPhoto;>;")]
        private TLVector id;

        [MethodImpl(MethodImplOptions.NoInlining), LineNumberTable(new byte[] { 0x9f, 0xac, 0x68 })]
        public TLRequestPhotosDeletePhotos()
        {
        }

        [HideFromJava, SecurityPermission(SecurityAction.Demand, SerializationFormatter=true)]
        protected TLRequestPhotosDeletePhotos(SerializationInfo info1, StreamingContext context1) : base(info1, context1)
        {
        }

        [MethodImpl(MethodImplOptions.NoInlining), Throws(new string[] { "java.io.IOException" }), Modifiers(0x1041), EditorBrowsable(EditorBrowsableState.Never), LineNumberTable(0x12)]
        public virtual TLObject <bridge>deserializeResponse(InputStream @is, TLContext tlc) => 
            this.deserializeResponse(@is, tlc);

        [MethodImpl(MethodImplOptions.NoInlining), Throws(new string[] { "java.io.IOException" }), LineNumberTable(new byte[] { 0x16, 0x6d })]
        public override void deserializeBody(InputStream stream, TLContext context)
        {
            this.id = StreamingUtils.readTLVector(stream, context);
        }

        [MethodImpl(MethodImplOptions.NoInlining), Throws(new string[] { "java.io.IOException" }), LineNumberTable(new byte[] { 0x9f, 0xb5, 0x68, 0x63, 0x70, 0x68, 0x67 })]
        public virtual TLLongVector deserializeResponse(InputStream stream, TLContext context)
        {
            TLObject obj2 = StreamingUtils.readTLObject(stream, context);
            if (obj2 == null)
            {
                Throwable.__<suppressFillInStackTrace>();
                throw new IOException("Unable to parse response");
            }
            if (obj2 is TLLongVector)
            {
                return (TLLongVector) obj2;
            }
            Throwable.__<suppressFillInStackTrace>();
            throw new IOException(new StringBuilder().append("Incorrect response type. Expected org.telegram.TLLongVector, got: ").append(Object.instancehelper_getClass(obj2).getCanonicalName()).toString());
        }

        public override int getClassId() => 
            -2016444625;

        [Signature("()Lorg/telegram/tl/TLVector<Lorg/telegram/api/input/photo/TLAbsInputPhoto;>;")]
        public virtual TLVector getId() => 
            this.id;

        [MethodImpl(MethodImplOptions.NoInlining), Throws(new string[] { "java.io.IOException" }), LineNumberTable(new byte[] { 0x11, 110 })]
        public override void serializeBody(OutputStream stream)
        {
            StreamingUtils.writeTLObject(this.id, stream);
        }

        [Signature("(Lorg/telegram/tl/TLVector<Lorg/telegram/api/input/photo/TLAbsInputPhoto;>;)V")]
        public virtual void setId(TLVector id)
        {
            this.id = id;
        }

        public override string toString() => 
            "photos.deletePhotos#87cf7f2f";
    }
}

