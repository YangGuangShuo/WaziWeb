using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UIElements;

public class BusIn : MonoBehaviour
{
    [SerializeField]
    private GameObject mViewGame;

    public void OnGameBtn()
    {
        mViewGame.GetComponent<Animator>().Play("BGanim_2");
        StartCoroutine(WaitTime(1, () =>
        {
            SceneManager.LoadScene("BusTop");
        }));
    }

    public void OnBusBtn()
    {
        SceneManager.LoadScene("Station");
    }

    IEnumerator WaitTime(float time, Action callBack)
    {
        yield return new WaitForSeconds(time);

        callBack();
    }


}
