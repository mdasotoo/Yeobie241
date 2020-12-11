using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class Timer : MonoBehaviour
{
    public float t_current;
    public float t_initial;

    [SerializeField] Text countdownText;
    // Start is called before the first frame update
    void Start()
    {
        t_current = t_initial;
    }

    // Update is called once per frame
    void Update()
    {
        t_current -= 1 * Time.deltaTime;
        //print (t_current);
        countdownText.text = t_current.ToString("0");
        if (t_current <= 0)
        {
          t_current = 0;  //End of Game condition
          Time.timeScale=0f;
          SceneManager.LoadScene("WonScene");

        }
    }
}
