using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class BtnContol : MonoBehaviour
{
    public GameObject Sidnav;
    
    void Start()
    {
        /// Add Here for after remove script numitms
    }
    
    public void opnsidnav()
    {
        Sidnav.SetActive(true);
    }

    public void clssidnav()
    {
        Sidnav.SetActive(false);
    }

    public void clsapp()
    {
        Application.Quit();
    }

    public void cartbtn()
    {
        SceneManager.LoadScene(1);
    }
    public void cusbtn()
    {
        SceneManager.LoadScene(3);
    }

    public void setbtn()
    {
        SceneManager.LoadScene(2);
    }
    
    public void home()
    {
        SceneManager.LoadScene(0);
    }
}
