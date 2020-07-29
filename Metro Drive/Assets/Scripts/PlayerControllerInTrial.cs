using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class PlayerControllerInTrial : MonoBehaviour
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

    int stage;

    public GameObject Tutorial;

    void Start()
    {
        rb = GetComponent<Rigidbody>();
        i = 3;
        Score = -1;
        k = 0;
        MainCamera.gameObject.SetActive(true);
        SideCamera.gameObject.SetActive(false);

        Tutorial.SetActive(true);

        stage = 1;
    }

    public void adjustAcceleration(float newAcceleration)
    {
        Acceleration = newAcceleration;
        if (newAcceleration >= 4840f)
        {
            Tutorial.transform.GetChild(3).gameObject.SetActive(false);
            Tutorial.transform.GetChild(4).gameObject.SetActive(true);
        }
    }
    public void Move()
    {
        rb.AddForce(0, 0, Acceleration, ForceMode.Acceleration);
        Tutorial.transform.GetChild(4).gameObject.SetActive(false);
        Tutorial.SetActive(false);
    }

    private void Update()
    {
        if (Input.touchCount > 0 || Input.GetMouseButtonDown(0))
        {
            if (stage < 3)
            {
                Tutorial.transform.GetChild(stage).gameObject.SetActive(false);
                stage++;
                Tutorial.transform.GetChild(stage).gameObject.SetActive(true);
            }
        }
    }

    void FixedUpdate()
    {
        if (transform.position.z > 55.28f)
        {
            ControlPanel(false);
            if (rb.velocity.z <= 0.2f)
            {
                SideCamera.gameObject.SetActive(true);
                MainCamera.gameObject.SetActive(false);
                float distance = Math.Abs(transform.position.z - 79.884f);
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
    
    void ControlPanel(Boolean action)
    {
        but.interactable = action;
        slid.interactable = action;
    }
}
