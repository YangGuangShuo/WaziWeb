using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UIElements;

public class Station : MonoBehaviour
{
    [SerializeField]
    private GameObject mViewPhone;
    [SerializeField]
    private GameObject mCameraRoot;


    private void Start()
    {
        
    }

    public void OnPhoneBtn()
    {
        mViewPhone.SetActive(true);
        mViewPhone.GetComponent<Animator>().Play("PhoneAppear");
        mCameraRoot.GetComponent<Animator>().Play("CameraPhone");
    }

    public void OnPhoneBackBtn()
    {
        mViewPhone.GetComponent<Animator>().Play("PhoneBack");
        mCameraRoot.GetComponent<Animator>().Play("CameraPhoneBack");
        StartCoroutine(WaitTime(1, () =>
        {
            mViewPhone.SetActive(false);
        }));
    }

    public void OnBusBtn()
    {
        FrontObjects.Instance.PlayBusFront();
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
