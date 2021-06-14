using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Dropper : MonoBehaviour
{
    MeshRenderer renderMe;
    Rigidbody Gravitee;
    [SerializeField]float TimeToWait = 5f;


    // Start is called before the first frame update
    void Start()
    {
        renderMe = GetComponent<MeshRenderer>();
        renderMe.enabled = false;

        Gravitee = GetComponent<Rigidbody>();
        Gravitee.useGravity = false;
    }

    // Update is called once per frame
    void Update()
    {
        if (Time.time > TimeToWait)
        {
            renderMe.enabled = true;
            Gravitee.useGravity = true;
        }
    }
}
