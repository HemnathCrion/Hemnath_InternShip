using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class LoadingScreen_1 : MonoBehaviour
{
    public Slider loadingSlider;
    public TMP_Text loadingText;
    float currentValue;

    // Update is called once per frame
    void Start()
    {
        StartCoroutine(LoadNextScene());
    }

    IEnumerator LoadNextScene()
    {
       // float progress = 0f;

        while (currentValue < 1f)
        {
            currentValue += Time.deltaTime / 5f;
            loadingSlider.value = currentValue;
            loadingText.text = "Loading..." + (int)(currentValue * 100f) + "%";
            yield return null;
        }

        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
    }

}
