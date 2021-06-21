using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Mover : MonoBehaviour
{
    [SerializeField] float speed = 10f;
    // Start is called before the first frame update
    void Start()
    {
        PrintInstructions();
    }

    // Update is called once per frame
    void Update()
    {
        MovePlayer();
    }

    void PrintInstructions()
    {
        //TODO remove this
        Debug.Log("Welcome to the game");
        Debug.Log("Avoid all the blue shapes and make it to the other green section");
        Debug.Log("Make sure to grab all yellow circles on the way");
    }

    void MovePlayer()
    {
        float XValue = Input.GetAxis("Horizontal") * Time.deltaTime * speed;
        float ZValue = Input.GetAxis("Vertical") * Time.deltaTime * speed;
        transform.Translate(XValue, 0f, ZValue);
    }
}
