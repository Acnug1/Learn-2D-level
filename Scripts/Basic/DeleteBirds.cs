using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DeleteBirds : MonoBehaviour
{
    private void Start()
    {
        var camera = GameObject.FindObjectOfType<Camera>();
        GameObject bird1 = GameObject.Find("Bird1");

        Destroy(bird1);

        GameObject[] birds = GameObject.FindGameObjectsWithTag("BirdToDelete");

        foreach (GameObject bird in birds)
        {
            bird.GetComponent<SpriteRenderer>().color = Color.red;
        }
    }
}
