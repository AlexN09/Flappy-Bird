using System.Collections;
using System.Collections.Generic;
using System.Runtime.ConstrainedExecution;
using UnityEngine;

public class Pipe : MonoBehaviour
{
    public GameObject PipePrefabScore;
    public GameObject PipePrefab;
    private GameObject BottomPipe, TopPipe;
    public List<GameObject> Pipes = new List<GameObject>();
    public static bool CanDel = false;
    private float timer = 0.0f;
    private float lastExecutionTime;
    private float interval = 1.8f;
    float LastRandom = 0;
    private void Start()
    {

      


    }
   
    void Update()
    {
        timer += Time.deltaTime;
       
       
        if (BirdMovement.restart) 
        {
            foreach (var pipe in Pipes)
            {
                Destroy(pipe);
            }
            Pipes.Clear();
            BirdMovement.restart = false;
            Counter.currentScore = 0;
               
        }
        if (CanDel)
        {
            Destroy(Pipes[0]);
            Destroy(Pipes[1]);
            Pipes.RemoveAt(0);
            Pipes.RemoveAt(0);
            CanDel = false;
         
        }
        if (Time.time - lastExecutionTime >= interval && !BirdMovement.defeat)
        {
            
            lastExecutionTime = Time.time;
            if (BirdMovement.firstTap)
                SpawnPipe();
        }

    }

    
    private void SpawnPipe()
    {
        
        float RandomScale = 0;
        if (Pipes.Count == 0)
        {
            RandomScale = Random.Range(1, 7);
            LastRandom = RandomScale;
        }
        if (LastRandom > 2 && LastRandom < 5)
        {
            int randomNumber = Random.Range(0, 2) * 2 - 1;
            float newRandom = LastRandom + randomNumber;

            if (newRandom > 1 && newRandom < 7)
            {
                LastRandom = newRandom;
                RandomScale = LastRandom;
               
            }
        }
        else
        {
            RandomScale = Random.Range(1, 7);
            LastRandom = RandomScale;
          
        }
        float ScaleTop = 8 - RandomScale - 1f;
        BottomPipe = Instantiate(PipePrefab, new Vector3(10, -2 + RandomScale, 1), Quaternion.identity);
        BottomPipe.name = "PipePrefab(Clone)";
        TopPipe = Instantiate(PipePrefabScore, new Vector3(19.2f, 11 - ScaleTop, 1), Quaternion.Euler(0, 0, 180));
        TopPipe.name = "PipePrefab(Clone)";
        Pipes.Add(BottomPipe);
       Pipes.Add(TopPipe);
     
    }
 
}