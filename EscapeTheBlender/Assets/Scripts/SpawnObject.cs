using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SpawnObject : MonoBehaviour {

    //These variables deal with the process of spawning shape at a certain time
    float startTime;
    bool spawnObject;
    private int waitTime;
    private float xspawnPoint;

    //This variable references an Object that chooses the spawn point of each obstacle
    public Transform spawnPoint;

    public GameObject obstacle;

    // Use this for initialization
    void Start()
    {
        startTime = Time.time;
        spawnObject = false;

        if (SceneManager.GetActiveScene().name == "Level1")
        {
            waitTime = 4;
        }
        else if (SceneManager.GetActiveScene().name == "Level2")
        {
            waitTime = 4;
        }
        else if (SceneManager.GetActiveScene().name == "Level3")
        {
            waitTime = 2;
        }
        else if (SceneManager.GetActiveScene().name == "Level4")
        {
            waitTime = 2;
        }
        else if (SceneManager.GetActiveScene().name == "Level5")
        {
            waitTime = 4;
        }
        else if (SceneManager.GetActiveScene().name == "Level6")
        {
            waitTime = 5;
        }
        else if (SceneManager.GetActiveScene().name == "Level7")
        {
            waitTime = 3;
        }
        else if (SceneManager.GetActiveScene().name == "Level8")
        {
            waitTime = 4;
        }
        else if (SceneManager.GetActiveScene().name == "Level9")
        {
            waitTime = 5;
        }
        else
        {
            waitTime = 1000;
        }
    }

    // Update is called once per frame
    void Update()
    {
       
        //Enacts if two seconds has passed
        if (Time.time - startTime > waitTime)
        {
            if (SceneManager.GetActiveScene().name == "Level1")
            {
                xspawnPoint = Random.Range(-12, 12);
            }
            else if (SceneManager.GetActiveScene().name == "Level2")
            {
                xspawnPoint = 0.67f;
            }
            else if (SceneManager.GetActiveScene().name == "Level3")
            {
                xspawnPoint = xspawnPoint = Random.Range(-12, 12);
            }
            else if (SceneManager.GetActiveScene().name == "Level4")
            {
                xspawnPoint = xspawnPoint = 0.67f;
            }
            else if (SceneManager.GetActiveScene().name == "Level5")
            {
                xspawnPoint = xspawnPoint = Random.Range(-12, 12);
            }
            else if (SceneManager.GetActiveScene().name == "Level6")
            {
                xspawnPoint = xspawnPoint = 0.67f;
            }
            else if (SceneManager.GetActiveScene().name == "Level7")
            {
                xspawnPoint = xspawnPoint = Random.Range(-12, 12);
            }
            else if (SceneManager.GetActiveScene().name == "Level8")
            {
                xspawnPoint = xspawnPoint = Random.Range(-12, 12);
            }
            else if (SceneManager.GetActiveScene().name == "Level9")
            {
                xspawnPoint = xspawnPoint = 0.67f;
            }
            else
            {
                xspawnPoint = xspawnPoint = 0.0f;
            }


            spawnPoint.position = new Vector3(xspawnPoint, 23, 0);
            spawnObject = true;
        }

        if (spawnObject) {
            GameObject fallingObject =
                Instantiate(obstacle, spawnPoint.position, spawnPoint.rotation) as GameObject;
            fallingObject.SetActive(true);
            spawnObject = false;
            startTime = Time.time;
        }
    }
}
