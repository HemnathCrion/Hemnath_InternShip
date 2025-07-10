using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ColorChange : MonoBehaviour
{
    private Renderer cubeRenderer;
    private Color[] colors = new Color[5];
    private int currentColorIndex = 0;
    // Start is called before the first frame update
    void Start()
    {
        cubeRenderer = GetComponent<Renderer>();

        colors[0] = Color.white;
        colors[1] = Color.red;
        colors[2] = Color.yellow;
        colors[3] = Color.black;
        colors[4] = Color.blue;

        cubeRenderer.material.color = colors[currentColorIndex];
        
    }

    private void OnMouseDown()
    {
        currentColorIndex = (currentColorIndex + 1) % colors.Length;

        cubeRenderer.material.color = colors[currentColorIndex];
    }
    public void LoadNextScene()
    {
        SceneManager.LoadScene("Basic UI Elements");
    }
}
