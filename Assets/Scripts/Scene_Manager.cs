using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Scene_Manager : MonoBehaviour
{
    [SerializeField] GameObject exitPanel;

    void Update()
    {
        if (Input.GetKeyDown (KeyCode.Escape))
        {
            if (SceneManager.GetActiveScene().buildIndex != 0)
            {
                SceneManager.LoadScene(0);
            }
            else
            {
                if (exitPanel)
                {
                    exitPanel.SetActive(true);
                }
            }
        }
    }
    public void onUserClickYesNo(int choice)
    {
        if (choice==1)
        {
            Application.Quit();
        }
        exitPanel.SetActive (false);
    }
    public void LoadIndexScene()
    {
        SceneManager.LoadScene(0);
    }

    public void LoadLearningScene()
    {
        SceneManager.LoadScene(1);
    }

    public void LoadLearning_AnimationScene()
    {
        SceneManager.LoadScene(2);
    }

    public void LoadTest_IndexScene()
    {
        SceneManager.LoadScene(3);
    }


    public void LoadQuizScene()
    {
        SceneManager.LoadScene(4);
    }
}
