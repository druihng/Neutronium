﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using Neutronium.Core.Binding.GlueBuilder;
using Neutronium.Core.Infra.Reflection;
using Neutronium.MVVMComponents;

namespace Neutronium.Core.Infra
{
    public static class Types
    {
        public static readonly Type Bool = typeof(bool);
        public static readonly Type String = typeof(string);
        public static readonly Type Int = typeof(int);
        public static readonly Type Double = typeof(double);
        public static readonly Type Uint = typeof(uint);
        public static readonly Type Decimal = typeof(decimal);
        public static readonly Type Long = typeof(long);
        public static readonly Type Short = typeof(short);
        public static readonly Type Float = typeof(float);
        public static readonly Type ULong = typeof(ulong);
        public static readonly Type UShort = typeof(ushort);
        public static readonly Type DateTime = typeof(DateTime);
        public static readonly Type Char = typeof(char);

        public static bool IsClr(this Type type) => _ClrTypes.Contains(type);

        private static readonly ISet<Type> _ClrTypes = new HashSet<Type>
        {
            Bool,
            String,
            Int,
            Double,
            Uint,
            Decimal,
            Long,
            Short,
            Float,
            ULong,
            UShort,
            Char,
            DateTime
        };

        public static readonly Type Object = typeof(object);
        public static readonly Type DescriptionAttribute = typeof(DescriptionAttribute);
        public static readonly Type Nullable = typeof(Nullable<>);
        public static readonly Type Enumerable = typeof(IEnumerable<>);
        public static readonly Type Dictionary = typeof(IDictionary<,>);
        public static readonly Type SimpleCommand = typeof(ISimpleCommand<>);
    }
}
