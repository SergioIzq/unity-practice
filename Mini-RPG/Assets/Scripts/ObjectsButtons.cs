using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.UI;

public class ObjectButtons : MonoBehaviour
{
    // Start is called before the first frame update
    public string hint;
    public TMP_Text text;
    public Sprite image; // Aquí almacenamos la imagen que deseamos mostrar
    public Image imageDisplay; // Referencia al componente Image donde mostraremos la imagen

    public void setHintDesc()
    {
        text.text = hint;
        imageDisplay.sprite = image; // Asignamos la imagen al componente Image si ambos están disponibles

    }
}
