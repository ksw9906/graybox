using UnityEngine;
using System.Collections;

public class Hover : MonoBehaviour {

    //Oscillation height
    public float amplitude = .1f;
    //Oscillations per second
    public float frequency = 1f;

    //Stores the original height
    private float initY;
    private float initTimeOffset;

	// Use this for initialization
	void Start () {
        initY = gameObject.transform.position.y;
        initTimeOffset = Random.Range(0.0f, 1f);
	}
	
	// Update is called once per frame
	void Update () {
        Vector3 newPos = new Vector3(gameObject.transform.position.x, initY + amplitude * Mathf.Sin(initTimeOffset + frequency * Time.unscaledTime), gameObject.transform.position.z);
        gameObject.transform.position = newPos;
	}

    void OnCollisionEnter(Collision c)
    {
        Debug.Log("collsion");
    }

    void OnTriggerEnter()
    {
        Debug.Log("trigger");
    }
}
