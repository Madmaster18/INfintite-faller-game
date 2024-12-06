using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NewBehaviourScript : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKey("down"))
        {
            Quit();
        }
    }
    public void Quit()
    {
        Application.Quit();
        UnityEditor.EditorApplication.isPlaying=false;
        Debug.Log("BRO RAGE QUIT HHAHHAHAHAHA");

    }
}
