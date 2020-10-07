using System.Collections;
using System.Collections.Generic;
using System.Collections.Specialized;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MainSystem : MonoBehaviour
{
    public float nextX = 0;
    public float intervalX = 1.0f;
    public GameObject target;
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        //スペースを押したら
        if (Input.GetKeyDown(KeyCode.Space))
        {
            //Instantiate( 生成するオブジェクト,  場所, 回転 );  回転はそのままなら↓
            Instantiate(target, new Vector3(nextX, 0, 0.0f), Quaternion.identity);
            nextX += intervalX;
        }
        if (Input.GetMouseButtonDown(0)) 
        {
            SceneManager.LoadScene("Title");
        
        }

    }
}
