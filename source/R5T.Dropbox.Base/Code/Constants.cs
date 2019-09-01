using System;

using R5T.NetStandard.IO.Paths;
using R5T.NetStandard.IO.Paths.Extensions;


namespace R5T.Dropbox.Base
{
    public static class Constants
    {
        public const string DropboxDirectoryNameValue = @"Dropbox";
        public static DirectoryName DropboxDirectoryName = Constants.DropboxDirectoryNameValue.AsDirectoryName();
    }
}
