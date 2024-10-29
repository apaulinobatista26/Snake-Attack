using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{ 
    private float horizontolInput;
    private float verticalInput; 
    private float speed =6; 
    private float score =0;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        horizontolInput = Input.GetAxis("Horizontal");
        verticalInput = Input.GetAxis("Vertical");
        
        transform.Translate(Vector3.right * horizontolInput * Time.deltaTime * speed);
        transform.Translate(Vector3. forward * vertical * Time.deltaTime * speed);
         
    }

    void OnCollisionEnter(Collision collision)
    {    
        if(collision.gameObject.tag == "BadTag")
        {
            score = score +1;
            Debug.Log(score);
        }
        else if (collision.gameObject.tag == "BadTag")
        {
         score = 0; 
         Debug.Log("you lost all of your points!");
         Debug.Log(score);
        }
    }   

}

