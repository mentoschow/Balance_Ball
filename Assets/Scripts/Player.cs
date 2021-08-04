using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class Player : MonoBehaviour
{
    public TextMeshProUGUI countText;
    private Rigidbody rb;
    private int count = 0;

    private int minute, second, millisecond;
    private float timeSpend;
    public TextMeshProUGUI time;

    public GameObject GameEnd;

    void Start()
    {
        rb = GetComponent<Rigidbody>();
        SetCountText();
        SetTime();
        GameEnd.SetActive(false);
    }

    void SetCountText()
    {
        countText.text = "Point: " + "<color=green>" + count.ToString() + "</color>" + "/10";
        if(count == 10)
        {
            GameEnd.SetActive(true);
        }
    }

    void SetTime()
    {
        timeSpend += Time.deltaTime;
        minute = (int)timeSpend / 60;
        second = (int)timeSpend - minute * 60;
        millisecond = (int)((timeSpend - (int)timeSpend) * 1000);

        time.text = "Time: " + minute.ToString() + ":" + second.ToString() + "." + millisecond.ToString();
    }
    
    void FixedUpdate()
    {
        rb.AddForce(Physics.gravity);
    }

    void Update()
    {
        SetTime();
    }

    private void OnTriggerEnter(Collider other)  //金币碰撞触发器
    {
        if (other.gameObject.CompareTag("Coin"))
        {
            other.gameObject.SetActive(false);  //禁用金币物件
            count++;
            SetCountText();
        }       
    }
}
