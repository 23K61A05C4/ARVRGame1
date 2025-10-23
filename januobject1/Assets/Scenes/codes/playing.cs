using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class playing : MonoBehaviour
{
    // Start is called before the first frame update
    public void play()
    {
        SceneManager.LoadScene("game");
    }

    // Update is called once per frame
    public void Quit()
    {
        Debug.LogWarning("Application closed");
        Application.Quit(); 
    }
}
