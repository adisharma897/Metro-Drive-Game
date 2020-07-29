using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HandleControllerInTrial : MonoBehaviour
{

    public GameObject Player;

    private float pos;
    private RectTransform rt;

    void Start()
    {
        rt = GetComponent<RectTransform>();
        pos = Player.transform.position.z;
    }

    void Update()
    {
        if (pos < 0)
        {
            rt.anchoredPosition = new Vector3(-37, 339, 0);
        }
        else
            if (pos > 70.28)
        {
            rt.anchoredPosition = new Vector3(-37, 1003, 0);
        }
        else
        {
            rt.anchoredPosition = new Vector3(-37, 339f + (pos * 9.4479225f), 0);
        }

        pos = Player.transform.position.z;
    }
}
