using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ui3 : MonoBehaviour
{
    public Transform TextIndiactor;


    [SerializeField] private float currentAmount;

    [SerializeField] private float speed;

    private void Update()
    {
        if (currentAmount < 100)
        {
            currentAmount += speed * Time.deltaTime;
            TextIndiactor.GetComponent<Text>().text = ((int)currentAmount).ToString() + "%";

        }
        else
        {

            TextIndiactor.GetComponent<Text>().text = "LeaderBoard Updated!!";
        }

    }
}
