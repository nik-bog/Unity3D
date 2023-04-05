using UnityEngine;

public class Scorer : MonoBehaviour
{
    int hits = 0;

    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.tag != "Hit")
        {
            Debug.Log("You've bumped into a thing this many times: " + ++hits);
        }
    }
}
