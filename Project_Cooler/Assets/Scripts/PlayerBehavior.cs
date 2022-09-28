using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerBehavior : MonoBehaviour
{
    public static float maxPlayerHealth = 5;
    public static float currentPlayerHealth;

    // Start is called before the first frame update
    void Start()
    {
        currentPlayerHealth = maxPlayerHealth;
    }

    private void OnCollisionEnter2D(Collision2D collision) {
        currentPlayerHealth--;
    }



        // Update is called once per frame
        void Update()
    {
        Debug.Log(currentPlayerHealth);
    }
}
