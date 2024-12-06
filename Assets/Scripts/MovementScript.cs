using System.Collections;
using System.Collections.Generic;
using UnityEngine;



public class MovementScript : MonoBehaviour
{               //this will tell you if your grounded
    
    public float Jump;
    public GameOverScript gameOverScript;
    [SerializeField] int JumpForce = 1000;
    [SerializeField] bool isGrounded = false;    
    [SerializeField] float horizontalMove;
    [SerializeField] float walkForce;
    [SerializeField] float MathF;
 
    private Rigidbody2D rb;

    public Rigidbody2D Rb { get => rb; set => rb = value; }
    public Animator animator ; 
    // Start is called before the first frame update
        void Start()
        {
            Rb = GetComponent<Rigidbody2D>();
            Debug.Log("DING DONG HAS AWOKEN");

        }
        
    


      // Update is called once per frame
    void Update()
        {   

            if(Input.GetKey(KeyCode.R))
            {
                
                
            }

            if(Input.GetKey(KeyCode.A))
            {
            Rb.AddForce(Vector3.left * Jump);
            }
        
            if(Input.GetKey(KeyCode.Space))
            {
                if(isGrounded == true)
                {
                    rb.AddForce(Vector2.up * JumpForce);
                    isGrounded = false;
                }

            }
                
            {
                
                horizontalMove = Input.GetAxisRaw("Horizontal") * walkForce;
                animator.SetFloat("Speed", Mathf.Abs(horizontalMove));
                
            }
        

        
    
            if(Input.GetKey(KeyCode.D))
            { 
                Rb.AddForce(Vector3.right * Jump);
              
            }
        }
            
        private void OnCollisionEnter2D(Collision2D collider)            
        {

            if( isGrounded != true)
            {

                if (isGrounded == false)
                {
                 isGrounded = true; 
                 Debug.Log("Ground is Detected");
                }



            }
             if (collider.gameObject.CompareTag("FinishLine"))
            {
                 Destroy(gameObject);
                 Debug.Log ("YIPPEEEEE");
            }    
            if (collider.gameObject.CompareTag("DeathLine"))
            {
                gameOverScript.isAlive = false;
                Debug.Log ("you sold hahahahahahah!");
                Destroy(gameObject);
            }   
        }
}