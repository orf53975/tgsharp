﻿namespace org.telegram.api.input.peer.notify.events
{
    using IKVM.Attributes;
    using org.telegram.tl;
    using System;
    using System.Runtime.CompilerServices;
    using System.Runtime.Serialization;
    using System.Security.Permissions;

    [Serializable]
    public abstract class TLAbsInputPeerNotifyEvents : TLObject
    {
        [MethodImpl(MethodImplOptions.NoInlining), LineNumberTable(new byte[] { 0x9f, 0x9b, 0x68 })]
        protected internal TLAbsInputPeerNotifyEvents()
        {
        }

        [HideFromJava, SecurityPermission(SecurityAction.Demand, SerializationFormatter=true)]
        protected TLAbsInputPeerNotifyEvents(SerializationInfo info1, StreamingContext context1) : base(info1, context1)
        {
        }
    }
}

