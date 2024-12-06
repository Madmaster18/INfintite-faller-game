using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlatformMoveScript : MonoBehaviour
{   [SerializeField] float currentspeed;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        transform.Translate(Vector3.up*currentspeed*Time.deltaTime);

    }
    private void OnTriggerEnter2D(Collider2D collider)
    {
        if (collider.gameObject.CompareTag ("deathlineforplatforms"))
        {
            Debug.Log("Platform has been destroyed");
            Destroy (gameObject);
        }

    }
}