using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PanelOpener : MonoBehaviour
{
    public GameObject Text;

    public void OpenPanel()
    {
        if(Text != null)
        {
            bool isActive = Text.activeSelf;
            Text.SetActive(true);
        }
    }
}
