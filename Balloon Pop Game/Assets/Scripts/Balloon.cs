using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Balloon : MonoBehaviour
{
    public int scoreToGive = 100; //Score give for pop balloon

    public int clicksToPop = 3; //How many clicks before balloon pops

    public float scaleToIncrease = 0.10f; //Scale increase each time the balloon is clicked

    public ScoreManager scoreManger; //A Variable to reference

    // Start is called before the first frame update
    void Start()
    {
        //refrence scoremanager compent
        ScoreManager = GameObject.Find("ScoreManager").GetComponent<ScoreManager>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void OnMouseDown()
    {
        //Reduce clicks by one
        clicksToPop -= 1;
        //Increase 
        transform.localScale += Vector3.one * scaleToIncrease;

        if(clicksToPop == 0)
        {
            scoreManger.IncreaseScoreText(scoreToGive);
            Destroy(gameObject);
        }
    }
}
