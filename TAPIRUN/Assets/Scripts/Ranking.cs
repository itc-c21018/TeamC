using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Ranking : MonoBehaviour
{
    public Text scoreTextE1st;
    public Text scoreTextE2nd;
    public Text scoreTextE3rd;

    // Start is called before the first frame update
    void Start()
    {
        scoreTextE1st.text = "1��" + PlayerPrefs.GetInt("scoreE1st");
        scoreTextE2nd.text = "2��" + PlayerPrefs.GetInt("scoreE2nd");
        scoreTextE3rd.text = "3��" + PlayerPrefs.GetInt("scoreE3rd");
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
