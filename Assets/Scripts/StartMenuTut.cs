using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class StartMenuTut : MonoBehaviour
{
    // Start is called before the first frame update
    public void PlayButton(){
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
    }

    public void QuitGame(){
        Debug.Log("QUIT GAME");
        Application.Quit();
    }
    
    public void QuitButton(){
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex -1);
    }
}
