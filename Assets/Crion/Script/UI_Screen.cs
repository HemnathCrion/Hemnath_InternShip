using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class UI_Screen : MonoBehaviour
{
    public GameObject mainMenuPanel;
    public GameObject SettingPanal;
    public Button SettingButton;
    public Button exitButton;
    public Button QuiteButton;
    public AudioSource bjAudio;
    public Slider volumeSLider;
    // Start is called before the first frame update
    void Start()
    {
        ShowMainMenu();
        SettingButton.onClick.AddListener(ShowSettingPanel);
        exitButton.onClick.AddListener(ExitSettingPanel);
        QuiteButton.onClick.AddListener(ExitAplication);
        volumeSLider.value = bjAudio.volume;
        volumeSLider.onValueChanged.AddListener(SetVolume);
    }

    public void ShowMainMenu()
    {
        mainMenuPanel.SetActive(true);
        SettingPanal.SetActive(false);
    }    
    public void ShowSettingPanel()
    {
        mainMenuPanel.SetActive(false);
        SettingPanal.SetActive(true);
    }

    public void ExitSettingPanel()
    {
        ShowMainMenu();
    }
    public void ExitAplication()
    {
        Application.Quit();
    }
    public void SetVolume(float value)
    {
        bjAudio.volume = value;
    }
}
