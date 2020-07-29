using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class HandleController : MonoBehaviour
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
            if (pos > 315)
        {
            rt.anchoredPosition = new Vector3(-37, 1003, 0);
        }
        else
        {
            rt.anchoredPosition = new Vector3(-37, 339f + (pos * 2.107936f), 0);
        }

        pos = Player.transform.position.z;
    }
}
