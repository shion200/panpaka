using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Titlemanager : MonoBehaviour
{
    public void OnClick()
    {
        SceneManager.LoadScene("Brock");
    }
}
