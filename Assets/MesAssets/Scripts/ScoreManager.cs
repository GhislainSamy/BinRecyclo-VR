using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ScoreManager : MonoBehaviour
{
	public static ScoreManager instance;
	
	public Text scoreText;
    public Text scoreTextb;
	
    int score = 0;
    int scoreb = 0;
	
	private void Awake() {
		instance = this;
	}
	
    // Start is called before the first frame update
    void Start()
    {
        scoreText.text = score.ToString() + " POINTS";
    }

    // Update is called once per frame
    public void AddPoint()
    {
        score +=1;
		scoreText.text = score.ToString() + " POINTS";
    }
    public void AddBadPoint()
    {
        scoreb +=1;
		scoreTextb.text = scoreb.ToString() + " PERDU";
    }
}
