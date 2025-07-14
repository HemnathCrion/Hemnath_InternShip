using UnityEngine;
using TMPro;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour
{
    public TMP_Dropdown modeDropdown;

    public void Start()
    {
        modeDropdown.onValueChanged.AddListener(onModeChange);

    }
    public void onModeChange(int index)
    {
        switch (index)
        { 
            case 0:
                PlayerPrefs.SetFloat("PlayerSpeed", 4f);
                PlayerPrefs.SetFloat("SpawnInterval", 2.5f);
                break;
             case 1:
                PlayerPrefs.SetFloat("PlayerSpeed", 6f);
                PlayerPrefs.SetFloat("SpawnInterval", 1.5f);
                break;
             case 2:
                PlayerPrefs.SetFloat("PlayerSpeed", 9f);
                PlayerPrefs.SetFloat("SpawnInterval", 0.75f);
                break;
        }
        PlayerPrefs.Save();

    }
    public void StartGame()
    {
        SceneManager.LoadScene("Game_Scene");
    }
}
