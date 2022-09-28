using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HealthBarScript : MonoBehaviour
{
    public GameObject heart;
    // Start is called before the first frame update

    private void Awake() {
        float offset = 90;
        for (int i = 0; i < PlayerBehavior.maxPlayerHealth; i++) {
            var newHeart = Instantiate(heart, new Vector3(transform.position.x + (i * offset), transform.position.y, 0), Quaternion.identity);
            newHeart.transform.parent = gameObject.transform;
        }
    }
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
