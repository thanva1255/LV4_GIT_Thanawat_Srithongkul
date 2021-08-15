using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Ballcontrol : MonoBehaviour
{
    private Rigidbody rb;
    private int Score;
    public int speed;
    public Text ScoreText;
    public Text finalText;
    
    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody>();
        Score = 0;
        SetScoreText();
        finalText.text = "";
    }

    // Update is called once per frame
    void Update()
    {
        float moveHorizontal = Input.GetAxis("Horizontal");
        float moveVertical = Input.GetAxis("Vertical");
        Vector3 movement = new Vector3(moveHorizontal, 0.0f, moveVertical);
        rb.AddForce(movement*speed);
    }

    void OnTriggerEnter(Collider other)
    {
        if(other.gameObject.CompareTag("item"))
        {
            other.gameObject.SetActive(false);
            Score = Score + 1;
            SetScoreText();
        }
    }

    void SetScoreText()
    {
        ScoreText.text = " Count:" + Score.ToString();
        if(Score == 11)
        {
            finalText.text = "You Win!";
        }
     }
}
