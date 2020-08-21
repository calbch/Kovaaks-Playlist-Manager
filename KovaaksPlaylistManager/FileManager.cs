﻿using System;

namespace KovaaksPlaylistManager
{
    public class FileManager
    {
        public void CopyFile(string fileName, string sourceFile, string targetPath)
        {
            var destFile = System.IO.Path.Combine(targetPath, fileName);
            
            System.IO.File.Copy(sourceFile,destFile,true);
        }

        public bool DeleteFile(string fileName)
        {
            if (!System.IO.File.Exists(fileName)) return true;
            try
            {
                System.IO.File.Delete(fileName);
            }
            catch (System.IO.IOException e)
            {
                Console.WriteLine(e);
                return false;
            }

            return true;
        }
        
        public string FindPlaylistFoLder(string steamFolder)
        {
            const string targetFolder = @"\steamapps\common\FPSAimTrainer\FPSAimTrainer\Saved\SaveGames\Playlists";
            return steamFolder + targetFolder;
        }
    }
}