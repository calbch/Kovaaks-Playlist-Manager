using System;

namespace KovaaksPlaylistManager
{
    public class UserSettings
    {
        public string PlaylistPath { get; set; }
        
        
        public override bool Equals(Object obj)
        {
            //Check for null and compare run-time types.
            if ((obj == null) || ! this.GetType().Equals(obj.GetType()))
            {
                return false;
            }
            else
            {
                return this.PlaylistPath.Equals(((UserSettings) obj).PlaylistPath);
            }
        }
    }
}