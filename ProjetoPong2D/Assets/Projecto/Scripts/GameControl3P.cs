using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GameControl3P : MonoBehaviour
{

    public Text Score_1;
    public Text Score_2;
    public Text Score_3;
    public GameObject bola;

    private int StartScore1 = 0;
    private int StartScore2 = 0;
    private int StartScore3 = 0;

    void Start()
    {
        bola = GameObject.Find("Bola");
    }

    void Update()
    {

        if (bola.transform.position.x >= 17.5f)
        {
            StartScore1++;
            StartScore3++;

            bola.transform.position = new Vector2(0f, 0f);
        }

        else if (bola.transform.position.x <= -17.5f)
        {
            StartScore2++;
            StartScore3++;

            bola.transform.position = new Vector2(0f, 0f);
        }

        else if (bola.transform.position.y <= -9.6f)
        {
            StartScore1++;
            StartScore2++;

            bola.transform.position = new Vector2(0f, 0f);
        }

        Score_1.text = StartScore1.ToString();
        Score_2.text = StartScore2.ToString();
        Score_3.text = StartScore3.ToString();

        print(StartScore1 + " , " + StartScore2);

    }
}