using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class PrefabSpawner : MonoBehaviour
{
    public TMP_Dropdown prefabDropdown;
    public GameObject[] prefabs;
    public Transform spawnArea;

    public void SpawnSelectedPrefab()
    {
        int index = prefabDropdown.value;
        if (index < 0 || index >= prefabs.Length) return;

        Vector3 randomPos = new Vector3(Random.Range(-5,5),1,Random.Range(-5,5));

        Instantiate(prefabs[index],randomPos,Quaternion.identity);
    }
}
