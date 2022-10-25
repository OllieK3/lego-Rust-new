using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Menumanager : MonoBehaviour
{
    public void loadgame(string Scene)
    {
        SceneManager.LoadScene(Scene);
    }
    
    void Start()
    {
        
    }

   
    void Update()
    {
        Cursor.lockState = CursorLockMode.None;
        Cursor.visible = true;
    }
}
