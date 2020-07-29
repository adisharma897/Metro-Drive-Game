using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class PlayerController : MonoBehaviour
{
    [SerializeField] private Camera MainCamera;
    [SerializeField] private Camera SideCamera;
    private float Acceleration;
    public TextMeshProUGUI T;
    public Button but;
    public Slider slid;
    public GameObject Finish;

    private TextMeshPro ScoreText;
    private int i;
    private int k;
    private Rigidbody rb;
    private GameObject Sec;
    int Score;

    void Start()
    {
        rb = GetComponent<Rigidbody>();
        i = 3;
        Score = -1;
        k = 0;
        MainCamera.gameObject.SetActive(true);
        SideCamera.gameObject.SetActive(false);
    }

    public void adjustAcceleration(float newAcceleration)
    {
        Acceleration = newAcceleration;
    }
    public void Move()
    {
        rb.AddForce(0, 0, Acceleration, ForceMode.Acceleration);
    }
    
    void FixedUpdate()
    {
        if (transform.position.z > 300f)
        {
            ControlPanel(false);
            if (rb.velocity.z <= 0.2f)
            {
                SideCamera.gameObject.SetActive(true);
                MainCamera.gameObject.SetActive(false);
                float distance = Math.Abs(transform.position.z - 324.604f);
                if (distance > 0.746f)
                {
                    Score = 0;
                }
                else
                    if (distance > 0.598f)
                {
                    Score = 200;
                }
                else
                    if (distance > 0.456f)
                {
                    Score = 400;
                }
                else
                    if (distance > 0.301f)
                {
                    Score = 600;
                }
                else
                    if (distance > 0.149f)
                {
                    Score = 700;
                }
                else
                    if (distance > 0.058f)
                {
                    Score = 900;
                }
                else
                {
                    Score = 1000;
                }

                if (Score != -1 && rb.velocity.z <= 0.05f)
                {
                    Finish.SetActive(true);
                    if (k <= Score)
                    {
                        T.text = "SCORE: " + k.ToString();
                        k = k + 10;
                    }
                }
            }
        }
    }

    void OnTriggerEnter(Collider Other)
    {
        if (Other.gameObject.name == ("Section (" + (i % 13) + ")"))
        {
            switch(i%13)
            {
                case 3: Sec = GameObject.Find("Section (0)"); break;
                case 4: Sec = GameObject.Find("Section (1)"); break;
                case 5: Sec = GameObject.Find("Section (2)"); break;
                case 6: Sec = GameObject.Find("Section (3)"); break;
                case 7: Sec = GameObject.Find("Section (4)"); break;
                case 8: Sec = GameObject.Find("Section (5)"); break;
                case 9: Sec = GameObject.Find("Section (6)"); break;
                case 10: Sec = GameObject.Find("Section (7)"); break;
                case 11: Sec = GameObject.Find("Section (8)"); break;
                case 12: Sec = GameObject.Find("Section (9)"); break;
                case 0: Sec = GameObject.Find("Section (10)"); break;
                case 1: Sec = GameObject.Find("Section (11)"); break;
                case 2: Sec = GameObject.Find("Section (12)"); break;
            }
            Sec.transform.Translate(0, 0, 138.32f);
            i = i + 1;
        }
    }
    void ControlPanel(Boolean action)
    {
        but.interactable = action;
        slid.interactable = action;
    }
}