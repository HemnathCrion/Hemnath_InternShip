using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class Input_Name : MonoBehaviour
{

    public GameObject cube;
    public InputField nameInput;
    public TMP_Text cubeName;
    public Slider slider;
    public Button button;
    // Start is called before the first frame update
    void Start()
    {
        slider.value = cube.transform.localScale.x;
        slider.onValueChanged.AddListener(SetSize);
        button.onClick.AddListener(InputName);
    }

    public void SetSize(float newSize)
    {
        cube.transform.localScale = new Vector3(newSize, newSize, newSize); 
    }
    public void InputName()
    {
        string newName = nameInput.text;
        if(!string.IsNullOrEmpty(newName) )
        {
            cube.name = newName;
            cubeName.text = " "+newName;
        }

    }
    
}
