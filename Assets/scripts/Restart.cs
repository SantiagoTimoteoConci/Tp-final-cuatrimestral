using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class Restart : MonoBehaviour
{
    public Text txtTime;
    public float elapsedTime;
    void Update()
    {
        elapsedTime = Time.timeSinceLevelLoad;
        txtTime.text = Mathf.Floor(elapsedTime).ToString();
    }
 

    public void ResetScene()
    {
        SceneManager.LoadScene("Game");
        
    }

}
