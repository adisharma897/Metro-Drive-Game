using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PointerController : MonoBehaviour
{
    public GameObject player;
    private float Pos;

    void Start()
    {
        Pos = player.transform.position.z;
    }

    void LateUpdate()
    {
        if (Pos < 323.856)
        {
            transform.position = new Vector3(-0.636f, 4.564f, 330.262f);
        }

        if (Pos > 325.352)
        {
            transform.position = new Vector3(-0.636f, 4.564f, 331.754f);
        }

        if (Pos > 323.856 && Pos < 325.352)
        {
            transform.position = new Vector3(-0.636f, 4.564f, Pos + 6.404f);
        }

        Pos = player.transform.position.z;
    }
}
