using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    // Start is called before the first frame update
    public int P1score, P2score;
    public static GameManager instance;

    public void Awake()
    {
        if (instance == null)
        {
            instance = this;
        }else
        {
            Destroy(gameObject);
        }
    }
    void Start()
    {
        P1score = 0;
        P2score = 0;
    }

    public void Score(string lineName)
    {
        if(lineName == "line1")
        {
            P2score += 1;
        }
        else
        {
            P1score += 1;
        }
        Debug.Log("Player 1: " + P1score + "Player 2: " + P2score);
    }

    // Update is called once per frame
    //void Update()
    //{
        
    //}
}
