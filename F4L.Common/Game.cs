using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OliverKarger.F4L
{

    public sealed class Game
    {
        private List<string> F4GamePaths;

        public Game()
        {
            // Initialize Path List
            this.F4GamePaths = new List<string>();
        }

        /// <summary>
        /// Scans Drives for Fallout4.exe
        /// </summary>
        /// <param name="filtered">only return paths where game exe has been found</param>
        /// <returns>List of Paths and found result (either filtered for true or not)</returns>
        public IEnumerable<KeyValuePair<string, bool>> ScanDrivesForGameExe(bool filtered = true)
        {
            // Enumerate Drives
            var drives = DriveInfo.GetDrives();
            var folderNames = new List<string>() { 
                @"Program Files\Steam\steamapps\common\Fallout 4",
                @"Program Files (x86)\Steam\steamapps\common\Fallout 4",
                @"SteamLibrary\steamapps\common\Fallout 4",
            };

            // Path Storage
            var paths = new List<string>();

            // Create all Paths
            foreach(var drive in drives)
            {
                paths.AddRange(folderNames.Select(e => $@"{drive.Name}{e}\Fallout4.exe"));
            }

            var output = paths.Select<string, KeyValuePair<string, bool>>((path, index) =>
            {
                return new KeyValuePair<string, bool>(path, new FileInfo(path).Exists);
            });

            if (filtered)
            {
                output = output.Where(e => e.Value == true);
            }

            return output;
        }
    }
}
