using System;

using R5T.NetStandard.IO.Paths;
using R5T.NetStandard.IO.Paths.Extensions;

using BasePathUtilities = R5T.NetStandard.IO.Paths.Base.Utilities;
using OrganizationUtilities = R5T.NetStandard.Organizational.Utilities;
using PathUtilities = R5T.NetStandard.IO.Paths.Utilities;


namespace R5T.Dropbox.Base
{
    public static class Utilities
    {
        public static string DropboxDirectoryPathValue
        {
            get
            {
                var output = Utilities.AppendDropboxDirectory(BasePathUtilities.UserProfileDirectoryPathValue);
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

        public static string OrganizationsDirectoryPathValue
        {
            get
            {
                var output = OrganizationUtilities.AppendOrganizationsDirectory(Utilities.DropboxDirectoryPathValue);
                return output;
            }
        }

        public static DirectoryPath OrganizationsDirectoryPath
        {
            get
            {
                var output = Utilities.OrganizationsDirectoryPathValue.AsDirectoryPath();
                return output;
            }
        }


        public static string AppendDropboxDirectory(string directoryPath)
        {
            var output = PathUtilities.Combine(directoryPath, Constants.DropboxDirectoryNameValue);
            return output;
        }

        public static DirectoryPath AppendDropboxDirectory(DirectoryPath directoryPath)
        {
            var output = Utilities.AppendDropboxDirectory(directoryPath.Value).AsDirectoryPath();
            return output;
        }
    }
}
