using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ReserScript : MonoBehaviour
{
    public int i;
    public void ResetLevel()
    {
          SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + i);
        
    } 
}