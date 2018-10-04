﻿namespace org.telegram.api.input.geopoint
{
    using IKVM.Attributes;
    using java.io;
    using org.telegram.tl;
    using System;
    using System.Runtime.CompilerServices;
    using System.Runtime.Serialization;
    using System.Security.Permissions;

    [Serializable]
    public class TLInputGeoPoint : TLAbsInputGeoPoint
    {
        public const int CLASS_ID = -206066487;
        private double lat;
        private double lon;

        [MethodImpl(MethodImplOptions.NoInlining), LineNumberTable(new byte[] { 0x9f, 0xa8, 0x68 })]
        public TLInputGeoPoint()
        {
        }

        [HideFromJava, SecurityPermission(SecurityAction.Demand, SerializationFormatter=true)]
        protected TLInputGeoPoint(SerializationInfo info1, StreamingContext context1) : base(info1, context1)
        {
        }

        [MethodImpl(MethodImplOptions.NoInlining), Throws(new string[] { "java.io.IOException" }), LineNumberTable(new byte[] { 0x9f, 0xba, 0x6d, 0x6d })]
        public override void deserializeBody(InputStream stream, TLContext context)
        {
            this.lat = StreamingUtils.readDouble(stream);
            this.lon = StreamingUtils.readDouble(stream);
        }

        public override int getClassId() => 
            -206066487;

        [MethodImpl(MethodImplOptions.NoInlining), Throws(new string[] { "java.io.IOException" }), LineNumberTable(new byte[] { 0x9f, 0xb3, 0x6c, 110 })]
        public override void serializeBody(OutputStream stream)
        {
            StreamingUtils.writeDouble(this.lat, stream);
            StreamingUtils.writeDouble(this.lon, stream);
        }

        public override string toString() => 
            "inputGeoPoint#f3b7acc9";
    }
}

