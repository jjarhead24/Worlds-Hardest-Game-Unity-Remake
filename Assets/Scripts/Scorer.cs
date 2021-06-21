using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Scorer : MonoBehaviour
{
    int Deaths = 0; //the amount of times the player has died
    int NumOfYellow =10000 -1 ; //amount of yellow in the level, -1 due to having to keep 1 in the game that is under the map
    int savedYellow; //the amount of yellows that have been saved
    int NumOfCollected; //amount the playere has collected
    bool AllCollected; //are they all collected
    List<Vector3> YellowPosList; //list of all the poistions of yellows collected since last checkpoint
    public GameObject YellowSpheres;

    void Start() 
    {
        AllCollected = false;
        YellowPosList = new List<Vector3>();
        
        //TODO set the num in level based on the level
    }
    private void OnCollisionEnter(Collision collision)
    {
        switch (collision.gameObject.tag)
        {
            case "Death":
                {
                    Deaths++;
                    Debug.Log("You have died this many times: " + Deaths);

                    //TODO set the player back to start or checkpoint
                    NumOfCollected = savedYellow;
                    for(int x = 0; x<=YellowPosList.Count -1; x++) //go thtough list and recreate non saved spheres
                    {
                        Instantiate(YellowSpheres, YellowPosList[x], Quaternion.identity);
                    } 
                    break;
                }

            case "Yellow":
                {
                    //TODO: make sure all yellow spheres have been collected, maybe int for how many in each stage
                    Vector3 collidedObject = collision.transform.position;
                    YellowPosList.Add(collidedObject);
                    NumOfCollected ++;
                    if (NumOfCollected == NumOfYellow)
                    {
                        AllCollected = true;
                    }
                    Destroy(collision.collider.gameObject);
                    break;
                }

            case "Green":
                {
                    //TODO: check if all yellow collected, if all collected next level, else checkpoint
                    Debug.Log("green collision"); //TODO fix collision with trigger
                    if (AllCollected == true)
                    {
                        //TODO go to next level
                    }
                    else
                    {
                        savedYellow = NumOfCollected;
                        YellowPosList = new List<Vector3>(); //save all spheres by not letting them have locations to be remade
                        //TODO set a checkpoint here, save the possion and number of yellows
                    }
                    break;
                }

            case "":
                {
                    break;
                }
        }
        
    }
}
