using System;
using System.Collections.Generic;
using UnityEngine.SceneManagement;

namespace CustomAvatar
{
    public class Plugin
    {
        public string Name
        {
            get { return "Custom Avatar Plugin"; }
        }

        public string Version
        {
            get { return "2.0"; }
        }

        public static string _currentAvatarPath;

        public void OnApplicationStart()
        {

        }

        public void OnApplicationQuit()
        {

        }

        private void SceneManagerOnActiveSceneChanged(Scene arg0, Scene scene)
        {

        }

        public static List<string> RetrieveCustomAvatars()
        {
            return new List<string>();
        }

        public void OnUpdate()
        {

        }

        public void LoadNewAvatar(string path)
        {

        }

        private void AvatarLoaded()
        {

        }

        public void OnFixedUpdate()
        {

        }

        public void OnLevelWasInitialized(int level)
        {


        }

        public void OnLevelWasLoaded(int level)
        {

        }
    }
}