using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GroundMovement : MonoBehaviour
{
   public GameObject firstPart;
   public GameObject secondPart;

    // Update is called once per frame
    void Update()
    {  
        if (BirdMovement.defeat == false)
        {
            float firstPartPosX = firstPart.transform.position.x;
            float secondPartPosX = secondPart.transform.position.x;
            if (firstPartPosX < -6.85f)
            {
                firstPartPosX = 1.8f;
                secondPartPosX = 10.5f;

            }
            else
            {
                firstPartPosX += -3 * Time.deltaTime; secondPartPosX += -3 * Time.deltaTime;
            }
            firstPart.transform.position = new Vector3(firstPartPosX, -0.5654f, -1);
            secondPart.transform.position = new Vector3(secondPartPosX, -0.5654f, -1);
        }
     

        
    }
}
