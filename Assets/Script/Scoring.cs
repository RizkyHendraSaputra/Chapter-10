using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Scoring : MonoBehaviour
{
    public static Scoring SCOR;
    public Text text;
    int scor;

    // Start is called before the first frame update
    void Start()
    {
        if (SCOR == null)
        {
            SCOR = this;
        }
    }

    public void ChangeScore(int boxValue)
    {
        scor += boxValue;
        text.text = "Obstacle Clear = " + scor.ToString();
    }
}
