using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;
using TMPro;

public class Ball : MonoBehaviour
{
    public TMP_Text enemyscore;
    public TMP_Text playerscore;
    int enemy = 0;
    int player = 0;

    private void OnCollisionEnter2D(Collision2D collision)
    {
        
        if (collision.gameObject.name.Contains("Gates"))
        {
            transform.position = Vector3.zero;
            GetComponent<Rigidbody2D>().velocity = Vector2.zero;
        };
        
        if (collision.gameObject.name.Contains("PlayerGates"))
        {
            enemy += 1;
            enemyscore.SetText(enemy.ToString());
        };

        if (collision.gameObject.name.Contains("EnemyGates"))
        {
            player += 1;
            playerscore.SetText(player.ToString());
        };

    }
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
