using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class LoadScreen : MonoBehaviour
{
    // Start is called before the first frame update


    public void StartLoadScene()
    {
        SceneManager.LoadScene("Color_Change");
    }
    public void ExitLoadScene()
    {
        Application.Quit();
    }
}
