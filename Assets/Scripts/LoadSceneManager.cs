using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class LoadSceneManager : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    public void LoadMain()
    {
        //audioSource.PlayOneShot(onClick, 0.7F);
        SceneManager.LoadScene("PlayScene", LoadSceneMode.Single);
    }

    public void LoadCredits()
    {
        //audioSource.PlayOneShot(onClick, 0.7F);
        //SceneManager.LoadScene("CreditScreen", LoadSceneMode.Single);
    }

    public void Exit()
    {
        Debug.Log("EXIT");
        Application.Quit();
    }

    void Update() {

        if (Input.GetKeyDown(KeyCode.Escape)) {
            Exit();
        }

    }
}
