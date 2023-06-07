using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;
using AxWMPLib;

namespace LearningLanguagePlayer
{
    public class MediaPlayerHandler
    {
        private readonly AxWindowsMediaPlayer mediaPlayer;

        public MediaPlayerHandler(AxWindowsMediaPlayer mediaPlayer)
        {
            this.mediaPlayer = mediaPlayer;
        }

        public void LoadMedia(List<string> mediaFiles)
        {
            mediaPlayer.currentPlaylist = mediaPlayer.newPlaylist("", "");

            foreach (string media in mediaFiles)
            {
                mediaPlayer.currentPlaylist.appendItem(mediaPlayer.newMedia(media));
            }
        }

        public void PlayMedia(string url)
        {
            mediaPlayer.URL = url;
        }

        public void HandleMediaStateChange(_WMPOCXEvents_PlayStateChangeEvent e, Action onMediaPlaying, Action onMediaStopped, Action onMediaReady)
        {
            if (e.newState == 0)
            {
                onMediaReady?.Invoke();
            }
            else if (e.newState == 1)
            {
                onMediaStopped?.Invoke();
            }
            else if (e.newState == 3)
            {
                onMediaPlaying?.Invoke();
            }
        }

        public void HandlePlayListChange(ListBox playList, Action<string> onPlayListChange)
        {
            playList.SelectedIndexChanged += (sender, e) =>
            {
                string selectedItem = playList.SelectedItem.ToString();
                PlayMedia(selectedItem);
                onPlayListChange?.Invoke(selectedItem);
            };
        }
    }
}
