using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PersonHealth : MonoBehaviour
{

    const float TIME_UNTIL_RECOVERY = 2;  // Time in seconds until recovering

    [SerializeField] private Sprite _healthySprite;
    [SerializeField] private Sprite _sickSprite;

    bool IsSick;  // Tracks whether person is sick or not
    float _timeLastInfected;  // Will store time since we were last infected
    SpriteRenderer _spriteRenderer;  // Stores sprite renderer of current object

    private void Start()
    {
        _spriteRenderer = GetComponent<SpriteRenderer>();

        GetSick();  // Everyone starts sick
    }

    void Update()
    {
        // Current time - time last infected = time since you were last infected
        float timeSinceLastInfected = Time.time - _timeLastInfected;

        // Check when we haven't been infected for more than `TIME_UNTIL_RECOVERY` secs
        if (timeSinceLastInfected > TIME_UNTIL_RECOVERY)
        {
            Recover();
        }
    }

    public void GetSick()
    {
        IsSick = true;
        _spriteRenderer.sprite = _sickSprite;
        _timeLastInfected = Time.time;
    }

    void Recover()
    {
        IsSick = false;
        _spriteRenderer.sprite = _healthySprite;
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        GameObject otherObject = collision.gameObject;
        if (otherObject.CompareTag("Person") && otherObject.GetComponent<PersonHealth>().IsSick)
        {
            GetSick();  // We are now sick :(
        }
    }


}
