using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class TitleScreenStart : MonoBehaviour
{

    public string newGameScene;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per fram
    // e
    void Update()
    {
        
    }
    public void NewGame()
    {
        SceneManager.LoadScene(newGameScene);
    }
}
