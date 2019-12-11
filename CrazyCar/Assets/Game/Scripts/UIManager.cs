using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class UIManager : MonoBehaviour
{
    public Text score;
    public Text time;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        time.text = "Time: " + System.Math.Round(GameManager.Get().time,2);
        score.text = "Score: " + GameManager.Get().score;
    }
}
