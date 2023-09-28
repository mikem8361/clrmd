// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.

using System.Collections.Generic;
using Microsoft.Diagnostics.Runtime.Utilities;

namespace Microsoft.Diagnostics.Runtime.AbstractDac
{
    internal interface IClrTypeFactory
    {
        ClrType FreeType { get; }
        ClrType StringType { get; }
        ClrType ObjectType { get; }
        ClrType ExceptionType { get; }
        ClrType ErrorType { get; }

        string? GetTypeName(ulong mt);
        ClrType? TryGetType(ulong mt);
        ClrType? GetOrCreateType(ulong mt, ulong obj);
        ClrType GetOrCreateBasicType(ClrElementType basicType);
        ClrType? GetOrCreateArrayType(ClrType inner, int ranks);
        ClrType? GetOrCreateTypeFromToken(ClrModule module, int token);
        ClrType? GetOrCreateTypeFromSignature(ClrModule module, SigParser parser, IEnumerable<ClrGenericParameter> typeParameters, IEnumerable<ClrGenericParameter> methodParameters);
        ClrType? GetOrCreatePointerType(ClrType innerType, int depth);
    }
}