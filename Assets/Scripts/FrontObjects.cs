using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class FrontObjects : MonoBehaviour
{
    [SerializeField] private GameObject m_BusObj;

    private static FrontObjects instance;
    public static FrontObjects Instance
    {
        get { return instance; }
    }
    private void Awake()
    {
        if (instance == null)
            instance = this;
    }
    // Start is called before the first frame update
    void Start()
    {
        DontDestroyOnLoad(gameObject);
    }

    public void PlayBusFront()
    {
        m_BusObj.SetActive(true);
        m_BusObj.GetComponent<Animator>().Play("BusAnim", -1, 0);
    }
}
