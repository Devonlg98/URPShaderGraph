using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PlayerController : MonoBehaviour
{
    Animator anim;
    public float speed = 0.5f;
    public Slider textSlider;
    public float turnTime = 10f;
    // Start is called before the first frame update
    void Start()
    {
        
        //textSlider = GetComponent<ShowValue>();
        anim = GetComponent<Animator>();
    }

    void Update()
    {
        speed = textSlider.value * 2f;
        if (turnTime > Time.time)
        {
            transform.Translate(new Vector3(0, 0, Time.deltaTime * speed));
        }
        else
        {
            transform.rotation *= Quaternion.Euler(0, 180f, 0);
            turnTime += 10f;
        }
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        anim.SetFloat("speed", speed);
    }
}
