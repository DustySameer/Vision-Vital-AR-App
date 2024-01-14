using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ShowHideUI : MonoBehaviour
{
    public GameObject worldCanvasUI;
    public GameObject showUIbutton;
    public GameObject hideUIbutton;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void showUIfunction()
    {
        worldCanvasUI.SetActive(true);
        hideUIbutton.SetActive(true);
        showUIbutton.SetActive(false);
    }

    public void hideUIfunction()
    {
        worldCanvasUI.SetActive(false);
        hideUIbutton.SetActive(false);
        showUIbutton.SetActive(true);
    }
}
