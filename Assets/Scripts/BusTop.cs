using Cinemachine;
using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UIElements;

public class BusTop : MonoBehaviour
{
    [SerializeField]
    private GameObject mViewGameOver;

    public VariableJoystick variableJoystick;
    public CinemachineFreeLook cinemachineFreeLook;

    private void Start()
    {
        StartCoroutine(WaitTime(10, () =>
        {
            mViewGameOver.SetActive(true);
        }));
    }

    private void Update()
    {
        cinemachineFreeLook.m_XAxis.m_InputAxisValue = variableJoystick.Horizontal;
        cinemachineFreeLook.m_YAxis.m_InputAxisValue = variableJoystick.Vertical;
    }

    public void OnBusBtn()
    {
        StartCoroutine(WaitTime(2, () =>
        {
            SceneManager.LoadScene("BusIn");
        }));
    }

    IEnumerator WaitTime(float time, Action callBack)
    {
        yield return new WaitForSeconds(time);

        callBack();
    }


}
