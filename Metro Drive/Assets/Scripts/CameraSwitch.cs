using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraSwitch : MonoBehaviour
{
    public Camera MainCamera;
    public Camera SideCamera;
    public GameObject Player;

    private Rigidbody rb;

    void Start()
    {
        rb = Player.GetComponent<Rigidbody>();
        MainCamera.gameObject.SetActive(true);
        SideCamera.gameObject.SetActive(false);
    }

    void Update()
    {
        if (Player.transform.position.z > 300f & rb.velocity.z <= 0.2f)
        {
            SideCamera.gameObject.SetActive(true);
            MainCamera.gameObject.SetActive(false);
        }
    }
}
