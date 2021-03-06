﻿namespace org.telegram.api.input.sticker.media
{
    using IKVM.Attributes;
    using org.telegram.tl;
    using System;
    using System.Runtime.CompilerServices;
    using System.Runtime.Serialization;
    using System.Security.Permissions;

    [Serializable]
    public abstract class TLAbsInputStickeredMedia : TLObject
    {
        [MethodImpl(MethodImplOptions.NoInlining), LineNumberTable(11)]
        public TLAbsInputStickeredMedia()
        {
        }

        [HideFromJava, SecurityPermission(SecurityAction.Demand, SerializationFormatter=true)]
        protected TLAbsInputStickeredMedia(SerializationInfo info1, StreamingContext context1) : base(info1, context1)
        {
        }
    }
}

