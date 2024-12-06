using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class PlatformGeneratorScript : MonoBehaviour
{      [SerializeField] GameOverScript gameOverScript;
        [SerializeField] GameObject platform;
        [SerializeField] List <GameObject> spawnPostitions = new List <GameObject> {};
     
    // Start is called before the first frame update
    void Start()
    {
        //GenerateNextPlatform
    }

    // Update is called once per frame
    void Update()
    {


    }
     private void GenerateNextPlatform()
     {
        float randomWait = Random.Range(3.0f,8.0f);
        // Creates next platform based on a random wait tiem with infinite loop
        Invoke ("GeneratePlatform",randomWait);
     }   
    private void GeneratePlatform()
    {   
        foreach (var spawnPoint in spawnPostitions)
        {
            Vector3 pos = new Vector3 (spawnPoint.transform.position.x, spawnPoint.transform.position.y, spawnPoint.transform.position.z);
            GameObject platformInstantiate = Instantiate(platform, pos, Quaternion.identity);
            UnityEngine.Debug.Log("Position: " + pos);
            
           
        }


    }
    
    
    private void OnTriggerEnter2D(Collider2D collider)
    {
        if(gameOverScript.isAlive!=false)
        {
            Debug.Log("game is alive cool beans");
            if(collider.gameObject.CompareTag("DeathLine"))   

            {   
                Debug.Log("platform is ready to be made");
                GenerateNextPlatform();
            }
        }   
    }
        
}
