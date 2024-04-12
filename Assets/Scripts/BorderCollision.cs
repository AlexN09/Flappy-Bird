using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BorderCollision : MonoBehaviour
{
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.name == "LeftBorder")
        {
            Pipe.CanDel = true;
            
        }
        
    }
 
    private void Update()
    {
        if (BirdMovement.defeat == false) 
        {
            gameObject.transform.position = new Vector3(gameObject.transform.position.x - 3 * Time.deltaTime, gameObject.transform.position.y, -1);
        }
      
    }



}
