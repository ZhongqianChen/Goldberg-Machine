using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class RunGame : MonoBehaviour
{
    void Scene1()
    {
        SceneManager.LoadScene("JohnMachine");
    }

    void Update()
    {
        if (Input.GetKeyDown("space"))
        {
            Scene1();
        }
    }
}
