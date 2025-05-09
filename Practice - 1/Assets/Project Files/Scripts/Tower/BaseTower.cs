using UnityEngine;

public class BaseTower : MonoBehaviour
{
	#region Variables
	/// <summary>
	/// The part of the tower that rotates to aim.
	/// </summary>
	[SerializeField] private Transform RotatingGun;

	/// <summary>
	/// The bullet prefab that the tower will instantiate when firing.
	/// </summary>
	[SerializeField] private GameObject BulletPrefab;
	#endregion
	#region Start
	void Start()
	{
		if (RotatingGun == null)
		{
			RotatingGun = transform.GetChild(0);
			MyLogger.Log("Gun Assigned!");
		}
	}
	#endregion
	#region Update
	void Update()
	{
		//float q = Quaternion.Angle(transform.rotation, RotatingGun.rotation);
		////Vector3 v = q.eulerAngles;
		//MyLogger.Log(q);
		//transform.eulerAngles = new Vector3(q, q, q);
		//transform.rotation = Quaternion.Euler(q, q, q);
		//Quaternion nq = new Quaternion(0,0, 0, 0);
		//transform.eulerAngles = new Quaternion(0,0,0,0).eulerAngles;

		RotatingGun.Rotate(Vector3.up * 90 * Time.deltaTime);
	}
	#endregion
}
