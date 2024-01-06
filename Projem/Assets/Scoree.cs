using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Scoree : MonoBehaviour
{
    public Text sc;
    public WalkAndRun walk;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        sc.text = walk.puan.ToString();
    }
}
