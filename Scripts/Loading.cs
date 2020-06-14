using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class Loading : MonoBehaviour
{
    public Text timertext;
    private float starttime;

        void start()
        {
        starttime = Time.time;
        }

    void Update()
    {
        float t = Time.time - starttime;
        string seconds = (t % 60).ToString("f2");
        timertext.text = seconds + " Sec";
    }
    // Start is called before the first frame update


    // Update is called once per frame

}
