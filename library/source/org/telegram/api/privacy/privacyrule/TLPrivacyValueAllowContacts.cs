﻿namespace org.telegram.api.privacy.privacyrule
{
    using IKVM.Attributes;
    using System;
    using System.Runtime.CompilerServices;
    using System.Runtime.Serialization;
    using System.Security.Permissions;

    [Serializable]
    public class TLPrivacyValueAllowContacts : TLAbsPrivacyRule
    {
        public const int CLASS_ID = -123988;

        [MethodImpl(MethodImplOptions.NoInlining), LineNumberTable(new byte[] { 0x9f, 0xba, 0x68 })]
        public TLPrivacyValueAllowContacts()
        {
        }

        [HideFromJava, SecurityPermission(SecurityAction.Demand, SerializationFormatter=true)]
        protected TLPrivacyValueAllowContacts(SerializationInfo info1, StreamingContext context1) : base(info1, context1)
        {
        }

        public override int getClassId() => 
            -123988;

        public override string toString() => 
            "privacy.privacyValueAllowContacts#fffe1bac";
    }
}

