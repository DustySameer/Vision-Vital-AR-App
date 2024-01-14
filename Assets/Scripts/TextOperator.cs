using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TextOperator : MonoBehaviour
{
    public GameObject Text;

    public void Display()
    {
        if(Text != null)
        {
            bool isActive = Text.activeSelf;
            Text.SetActive(!isActive);
        }
    }
}
