using System;
using System.Collections.Generic;
using System.IO;
using System.Windows.Forms;
using static KovaaksPlaylistManager.UserSettingManager;

namespace KovaaksPlaylistManager
{
    public partial class PlaylistManager : Form
    {
        
        private readonly FileManager _fileManager = new FileManager();

        private readonly List<Playlist> _currentPlaylists = new List<Playlist>();

        //  TODO: save that to a config file

        private UserSettings _userSettings;


        public PlaylistManager()
        {
            if (!UserSettingsExist())
            {
                CreateUserSettings();
            }
            InitializeComponent();
            _userSettings = LoadUserSettings();
            UpdatePlaylists();
        }

        private void setBtn_Click(object sender, EventArgs e)
        {
            var result = FolderBrowserDialog.ShowDialog();
            if (result != DialogResult.OK) return;
            _userSettings.PlaylistPath = _fileManager.FindPlaylistFoLder(FolderBrowserDialog.SelectedPath);
            SaveUserSettings(_userSettings);
            UpdatePlaylists();
        }
        
        private void UpdatePlaylists()
        {
            if (_userSettings.PlaylistPath.Equals("")) return;
            foreach (var playlist in Directory.GetFiles(_userSettings.PlaylistPath))
            {
                var playlistStrings = playlist.Split('\\');
                var playlistName = playlistStrings[^1].Split('.')[0];
                _currentPlaylists.Add(new Playlist(playlist, playlistName));
                if (!playlistListBox.Items.Contains(playlistName))
                {
                    playlistListBox.Items.Add(playlistName);
                }
            }
        }

        private void playlistListBox_DragEnter(object sender, DragEventArgs e)
        {
            e.Effect = e.Data.GetDataPresent(DataFormats.FileDrop) ? DragDropEffects.All : DragDropEffects.None;
        }

        private void playlistListBox_DragDrop(object sender, DragEventArgs e)
        {
            var droppedFilePath = ((string[]) e.Data.GetData(DataFormats.FileDrop, false))[0];
            var fileString = droppedFilePath.Split('\\');
            var splitFileString = fileString[^1];
            if (splitFileString.Split('.')[1].Equals("plo"))
            {
                _fileManager.CopyFile(splitFileString, droppedFilePath, _userSettings.PlaylistPath);
                UpdatePlaylists();
                MessageBox.Show(@"You added a playlist");
            }
            else
            {
                MessageBox.Show(@"the added file is not a kovaaks playlist");
            }
        }

        private void deleteBtn_Click(object sender, EventArgs e)
        {
            var selectedPlaylist = playlistListBox.SelectedItem;
            var file = _currentPlaylists.Find(playlist => playlist.Name.Equals(selectedPlaylist));
            if (file != null && _fileManager.DeleteFile(file.FileName))
            {
                playlistListBox.Items.Remove(file.Name);
            }
        }
    }
}