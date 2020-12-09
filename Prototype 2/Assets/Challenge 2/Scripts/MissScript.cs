using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class MissScript : MonoBehaviour
{
    public static int missValueX = 0;
    Text miss;
    // Start is called before the first frame update
    void Start()
    {
        miss = GetComponent<Text>();
    }

    // Update is called once per frame
    void Update()
    {
        miss.text = "Miss: " + missValueX;
    }
}
