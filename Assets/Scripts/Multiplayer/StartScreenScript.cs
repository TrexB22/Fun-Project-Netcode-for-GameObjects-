using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class StartScreenScript : MonoBehaviour
{

    [SerializeField] Button hostBtn;
    [SerializeField] Button clientBtn;

    private void Awake() {
        hostBtn.onClick.AddListener(() => {
            PlayerPrefs.SetString("multiplayerOptionSelected", "HOST");
            LoadGameplayScene();
        });

        clientBtn.onClick.AddListener(() => {
            PlayerPrefs.SetString("multiplayerOptionSelected", "CLIENT");
            LoadGameplayScene();

        });
    } // Awake

    void LoadGameplayScene() {
        SceneManager.LoadScene("Gameplay");
    } // LoadGameplayScene

} // Class