using UnityEngine;

public class PingPong : MonoBehaviour
{
    Quaternion from, to;
    [SerializeField] float speed = 1f;
    [SerializeField] Vector3 toVector;
	// Start is called once before the first execution of Update after the MonoBehaviour is created
	void Start()
    {
        
	}

    // Update is called once per frame
    void Update()
    {
		from = Quaternion.Euler(0, 0, 0);
		to = Quaternion.Euler(toVector);

		float t = Mathf.PingPong(Time.time * speed, 1f);
        float smoothT = Mathf.SmoothStep(0, 1, t);
		transform.rotation = Quaternion.Slerp(from, to, smoothT);
	}
}
