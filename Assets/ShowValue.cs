using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ShowValue : MonoBehaviour
{
    Text PercentText;
    public Animator anim;
    // Start is called before the first frame update
    void Start()
    {
        PercentText = GetComponent<Text>();
    }

    // Update is called once per frame
    public void textUpdate (float value)
    {
        PercentText.text = Mathf.RoundToInt(value * 100) + "%";
    }
}
