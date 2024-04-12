using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BirdMovement : Sounds
{
    private Vector3 direction;
    public float gravity = -20f;
    public float streangth = -7f;
    public static bool defeat = false;
    public static bool firstTap = false;
    public static bool restart = false;
    public static bool canRes = false;
  
    void Update()
    {
        
        if (Input.GetKeyDown(KeyCode.E) || canRes)
        {
            restart = true;
            transform.position = new Vector2(0.7f, 3.8f);
            firstTap = false;
            defeat = false;
            canRes = false;
           
            
        }
        if (Input.GetKeyDown(KeyCode.Space) && transform.position.y < 11 && MenuManager.CanPlay)
        {
            direction = Vector3.up * streangth;
            firstTap = true;
        }
        if (firstTap && !defeat)
        {
            direction.y += gravity * Time.deltaTime;
            transform.position += direction * Time.deltaTime;
         
        }
      
        
       
    }
   
    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.name != "TopBorder" && other.name != "ScoreColl")
        {
            defeat = true;
            PlaySound(sounds[1]);
            Debug.Log(other.name);
        }
        if (other.name == "ScoreColl")
        {
            
            Counter.currentScore++;
            PlaySound(sounds[0]);
        }
        Debug.Log(other.name);
    }
 
}
