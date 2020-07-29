using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PointerControllerInTrial : MonoBehaviour
{
    public GameObject player;
    private float Pos;
    

    void Start()
    {
        Pos = player.transform.position.z;
    }

    void LateUpdate()
    {
        if (Pos < 79.136)
        {
            transform.position = new Vector3(-0.636f, 4.564f, 85.542f);
        }

        if (Pos > 80.632)
        {
            transform.position = new Vector3(-0.636f, 4.564f, 87.034f);
        }

        if (Pos > 79.136 && Pos < 80.632)
        {
            transform.position = new Vector3(-0.636f, 4.564f, Pos + 6.404f);
        }

        Pos = player.transform.position.z;
    }
}
