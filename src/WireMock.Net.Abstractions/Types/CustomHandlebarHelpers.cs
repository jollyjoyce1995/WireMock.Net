using System;

namespace WireMock.Types;

/// <summary>
/// A enum defining the supported Handlebar helpers.
/// </summary>
[Flags]
public enum CustomHandlebarHelpers
{
    None = 0,

    File = 1,

    All = File
}