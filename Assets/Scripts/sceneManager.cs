using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class sceneManager : MonoBehaviour
{
    public void Home()
    {
        SceneManager.LoadScene(0);
    }

    public void loadAR()
    {
        SceneManager.LoadScene(2);
    }

    public void load3D()
    {
        SceneManager.LoadScene(1);
    }


}
