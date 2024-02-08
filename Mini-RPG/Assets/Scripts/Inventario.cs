using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Inventario : MonoBehaviour
{

    public Button[] buttonsHints;
    // Start is called before the first frame update
    void OnEnable()
    {
        for (int i = 0; i < buttonsHints.Length; i++) {
            if (GameplayManager.instance.hints[i])
            {
                buttonsHints[i].interactable = true;
            }
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
