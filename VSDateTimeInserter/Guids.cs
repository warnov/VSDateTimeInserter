// Guids.cs
// MUST match guids.h
using System;

namespace WarNov.VSDateTimeInserter
{
    static class GuidList
    {
        public const string guidVSDateTimeInserterPkgString = "17729dc5-d246-410f-87eb-e285732f045b";
        public const string guidVSDateTimeInserterCmdSetString = "18e2f04b-d31e-4f4c-b117-d007ad6ff143";

        public static readonly Guid guidVSDateTimeInserterCmdSet = new Guid(guidVSDateTimeInserterCmdSetString);
    };
}