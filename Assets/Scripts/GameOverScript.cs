using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameOverScript : MonoBehaviour
{   public bool isAlive;
    // Start is called before the first frame update
    void Start()
    {
        isAlive = true;
        Debug.Log(" ding dong has awoken");
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
