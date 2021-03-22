using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class menuScripts : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public string username;
    public GameObject usernameInput;
    public GameObject usernameOutput;

    public void StoreUsername()
    {
   	username = usernameInput.GetComponent<Text>().text;
    usernameOutput.GetComponent<Text>().text = "Username: " + username;

    }

    
    public void RulesClick (string LevelName) 
    {
        SceneManager.LoadScene("RulesScene", LoadSceneMode.Single);
    }


    public void PlayClick (string LevelName) 
    {
        SceneManager.LoadScene("LoginScene", LoadSceneMode.Single);
    }

    public void Exit() 
    {
    	Application.Quit();
    }

    public void BackClick (string LevelName)
    {
        SceneManager.LoadScene("HomeScene", LoadSceneMode.Single);
    }

    public void Gameplay (string LevelName)
    {
        SceneManager.LoadScene("SampleScene", LoadSceneMode.Single);
    }

}
