using UnityEngine;
using UnityEngine.UI; // For Dropdown
using TMPro;          // If using TMP_Dropdown

public class GameManager : MonoBehaviour
{
    public PrefabSpawner prefabSpawner;
    public PlayerMovement player;
    public TMP_Dropdown modeDropdown; // or use Dropdown if not TMP

    void Start()
    {
        //modeDropdown.onValueChanged.AddListener(OnModeChanged);
        OnModeChanged(modeDropdown.value); // Set initial values
    }

    public void OnModeChanged(int index)
    {
        switch (index)
        {
            case 0: // Easy
                prefabSpawner.spawnInterval = 2.5f;
                player.moveSpeed = 4f;
                break;
            case 1: // Medium
                prefabSpawner.spawnInterval = 1.5f;
                player.moveSpeed = 6f;
                break;
            case 2: // Hard
                prefabSpawner.spawnInterval = 0.75f;        
                player.moveSpeed = 9f;
                break;
        }
    }
}
