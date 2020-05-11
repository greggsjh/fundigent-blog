using System;

namespace Fundigent.Blog.Enums
{
    [Flags]
    public enum PermissionType
    {
        Unknown = 0,
        Admin = 1,
        Anonymous = 2
    }
}
