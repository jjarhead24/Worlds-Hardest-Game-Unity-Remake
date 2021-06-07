using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Scorer : MonoBehaviour
{
    //TODO make it so there can be yellow spheres too by looking at tags
    int Deaths = 0;

    private void OnCollisionEnter(Collision collision)
    {
        switch (collision.gameObject.tag)
        {
            case "Death":
                {
                    Deaths++;
                    Debug.Log("You have died this many times: " + Deaths);
                    break;
                }

            case "Yellow":
                {
                    //TODO make sure all yellow spheres have been collected, maybe int for how many in each stage
                    break;
                }

            case "":
                break;
        }
        
    }
}
