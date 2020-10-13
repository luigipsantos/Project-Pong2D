using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GameController : MonoBehaviour {

    public Text Score_1;
    public Text Score_2;
    public GameObject bola;

    public float initialSpeed = 2f;

    private int StartScore1 = 0;
    private int StartScore2 = 0;

    void Start ()
    {
        bola = GameObject.Find("Bola");
    }
	
	void Update ()
    {
        if (bola.transform.position.x >= 8.35f)
        {
            StartScore1 ++;
            bola.transform.position = new Vector2(0f, 0f);
            bola.GetComponent<Rigidbody2D>().velocity = new Vector2(initialSpeed, initialSpeed);
        }

        else if (bola.transform.position.x <= -8.35f)
        {
            StartScore2 ++;
            bola.transform.position = new Vector2(0f, 0f);
            bola.GetComponent<Rigidbody2D>().velocity = new Vector2(initialSpeed, initialSpeed);
        }

        Score_1.text = StartScore1.ToString();
        Score_2.text = StartScore2.ToString();

        print(StartScore1 + " , " + StartScore2);

	}
}
