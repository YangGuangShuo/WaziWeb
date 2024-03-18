using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using DG.Tweening;

public class BugScript : MonoBehaviour
{
    public float time;

    void Start()
    {
        
    }

    void Update()
    {
        gameObject.transform.DOMoveY(-12f, time, true);
    }
}
