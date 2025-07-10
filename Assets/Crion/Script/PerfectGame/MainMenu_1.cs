using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class MainMenu_1 : MonoBehaviour
{
    public GameObject mainPanel;
    public GameObject settingPanel;
    public GameObject musicPanel;
    public Button exitButton;
    public Button confirmButton;
    public Button backButton;
    public Button settingButton;
    public Button musicButton;
    public Button exitSetting;
    public Slider music_Slider;
    public AudioSource bgAudio;
    // Start is called before the first frame update
    void Start()
    {
        ShowMainPanel();
        music_Slider.onValueChanged.AddListener(SetMusic);
        exitButton.onClick.AddListener(ExitApplication);
        confirmButton.onClick.AddListener(StartLoadScene);
        backButton.onClick.AddListener(BackToSetting);
        settingButton.onClick.AddListener(ShowSettingPanel);
        musicButton.onClick.AddListener(ShowMusicPanel);
        exitSetting.onClick.AddListener(ShowMainPanel);
        music_Slider.value = bgAudio.volume;

    }

   public void ShowMainPanel()
    {
        mainPanel.SetActive(true);
        settingPanel.SetActive(false);
        musicPanel.SetActive(false);
    }
    public void ShowSettingPanel()
    {
        mainPanel.SetActive(false);
        settingPanel.SetActive(true);
        musicPanel.SetActive(false);
    }
    public void ShowMusicPanel()
    {
        mainPanel.SetActive(false);
        settingPanel.SetActive(false);
        musicPanel.SetActive(true);
    }
    public void StartLoadScene()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
    }
    public void ExitApplication()
    {
        Application.Quit();
    }
    public void ExitMainPanel()
    {
        ShowMainPanel();
    }
    public void BackToSetting()
    {
        ShowSettingPanel();
    }
    public void SetMusic(float value)
    {
        bgAudio.volume = value;
    }
}
