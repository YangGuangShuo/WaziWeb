using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Launch : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        StartCoroutine(WaitChangeScene());
    }

    IEnumerator WaitChangeScene()
    {
        yield return new WaitForSeconds(2);

        SceneManager.LoadScene("Station");
    }

}
