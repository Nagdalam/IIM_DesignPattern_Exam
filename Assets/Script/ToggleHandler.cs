using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ToggleHandler : MonoBehaviour
{
    int togglesActivated = 0;
    [SerializeField] GameObject door;

    public void OnToggleHit(bool isOn)
    {
        if (isOn)
            togglesActivated++;
        else
            togglesActivated--;
        if (togglesActivated >= 3)
            door.SetActive(false);
    }
}
