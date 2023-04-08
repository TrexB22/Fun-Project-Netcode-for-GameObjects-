using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Unity.Netcode;
using UnityEngine.UI;

public class MultiplayerManagerScript : MonoBehaviour
{

    private void Awake() {

        if (PlayerPrefs.GetString("multiplayerOptionSelected") == "HOST") {
            NetworkManager.Singleton.StartHost();
        } else {
            NetworkManager.Singleton.StartClient();
        }

        PlayerPrefs.DeleteKey("multiplayerOptionSelected");

    } // Awake

} // Class