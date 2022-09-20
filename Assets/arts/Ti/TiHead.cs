using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class TiHead : MonoBehaviour
{
    [SerializeField] SpriteRenderer eyes;
    [SerializeField] SpriteRenderer mouth;


    public Sprite neutralMouth;
    public Sprite happyMouth;

    public Sprite happyEyes;

    void Update()
    {
        if(Input.GetButton("Fire1"))
        {
            eyes.sprite = happyEyes;
            mouth.sprite = neutralMouth; 
        }
        else
        {
            eyes.sprite = happyEyes;
            mouth.sprite = happyMouth;
        }
    }
}
