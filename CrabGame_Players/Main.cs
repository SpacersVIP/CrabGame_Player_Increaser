using MelonLoader;
using UnityEngine;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UnityEngine.UI;
using System.Collections;
using System.IO;

[assembly: MelonInfo(typeof(CrabGame_Players.Main), "Player Increaser", "1.0.0", "Spacers.VIP")]
[assembly: MelonGame("Dani", "Crab Game")]

namespace CrabGame_Players
{
    public class Main : MelonMod
    {
        public static bool IsInLobby = false;
        public override void OnApplicationStart()
        {
            IsInLobby = true;
        }

        public override void OnSceneWasLoaded(int buildIndex, string sceneName)
        {
            IsInLobby = true;
        }

        public override void OnGUI()
        {
            if (GameObject.Find("UI/CreateLobby/GameSettingsWindow") && IsInLobby)
            {
                GameObject.Find("UI/CreateLobby/GameSettingsWindow/Settings/Container/Content/SliderSetting/Interact/Slider").GetComponent<Slider>().m_MaxValue = 100;
                IsInLobby = false;
            }
        }

    }
}
