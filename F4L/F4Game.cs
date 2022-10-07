using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OliverKarger.F4L
{
    public sealed class F4Game
    {
        private List<string> F4GamePaths;

        public F4Game()
        {
            // Initialize Path List
            this.F4GamePaths = new List<string>();
        }

        private void ScanDrivesForSteam()
        {
            // Enumerate Drives
            var drives = DriveInfo.GetDrives();

            var folderNames = new List<string>() {  "Program Files", "Program Files (x86)" };

            var paths = drives.Select(
                // for each drive
                d => folderNames.Select(
                    // for each folder in folderNames
                    f => $@"{d.Name}{f}"
                )
            );

            // Loop over paths and check if Folder "Steam Exists"
            paths.Select(
                // each drive
                p => p.Select(
                    // each path
                    sp => new DirectoryInfo($@"{sp}\steam").Exists
                )
            );
        }
    }
}
