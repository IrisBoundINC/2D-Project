 using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RubyController : MonoBehaviour
{
    public int = maxHealth = 5;
    private int = currentHealth;
       
        
    private void Start()
    {
        currentHealth = maxHealth;
    }




    void Start()
    {
        QualitySettings.vSyncCount = 0;
        Application.targetFrameRate = 10;
    }

    // Update is called once per frame
    void Update()
    {
        float horizontal = Input.GetAxis("Horizontal");
        Debug.Log(horizontal);
        float vertical = Input.GetAxis("Vertical");
        Debug.Log(vertical);

        Vector2 position = transform.position;
        position.x = position.x + 0.3f * horizontal * Time.deltaTime;
        position.y = position.y + 0.3f * vertical * Time.deltaTime;
        transform.position = position;
    }

    void ChangeHealth(int amount)
    {
        currentHealth = Mathf.Clamp(currentHealth + amount, 0, maxHealth);
        Debug.Log("Current Health: " + currentHealth + "/" maxHealth);
    }
}
