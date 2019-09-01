using System;

using R5T.NetStandard.IO.Paths;
using R5T.NetStandard.IO.Paths.Extensions;

using BasePathUtilities = R5T.NetStandard.IO.Paths.Base.Utilities;
using PathUtilities = R5T.NetStandard.IO.Paths.Utilities;


namespace R5T.Dropbox.Base
{
    public static class Utilities
    {
        public static string DropboxDirectoryPathValue
        {
            get
            {
                var output = PathUtilities.Combine(BasePathUtilities.UserProfileDirectoryPathValue, Constants.DropboxDirectoryNameValue);
                return output;
            }
        }

        public static DirectoryPath DropboxDirectoryPath
        {
            get
            {
                var output = Utilities.DropboxDirectoryPathValue.AsDirectoryPath();
                return output;
            }
        }
    }
}
