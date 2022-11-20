using UnityEngine;
using UnityEngine.SceneManagement;

public class Intro : MonoBehaviour
{
    private float timeintro = 2.5f;
    
    void Update()
    {
        timeintro -= Time.deltaTime;
        if (timeintro <= 0)
        {
            SceneManager.LoadScene("Menu", LoadSceneMode.Single);

        }
    }
}
