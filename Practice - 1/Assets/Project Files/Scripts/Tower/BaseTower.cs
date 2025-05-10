using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.Animations;

public class BaseTower : MonoBehaviour
{
	#region Variables
	/// <summary>
	/// The part of the tower that rotates to aim.
	/// </summary>
	[SerializeField] private Transform rotatingGun;

	/// <summary>
	/// The bullet prefab that the tower will instantiate when firing.
	/// </summary>
	[SerializeField] private GameObject BulletPrefab;

	/// <summary>
	/// This is the enemy Transform.
	/// </summary>
	[SerializeField] private Transform target;

	[Header("Target facing speed")]
	[SerializeField] private float rotationSpeed = 10f;

	[Header("Clamp Angle")]
	[SerializeField] private float clampAngle = 120f;
	#endregion
	#region Start
	void Start()
	{
		if (rotatingGun == null)
		{
			rotatingGun = transform.GetChild(0);
		}
		if (target == null)
		{
			target = GameObject.FindWithTag("target").transform;
		}
	}
	#endregion
	void Update()
	{
		FaceTarget();
		Movement();
	}
	#region FaceTarget
	private void FaceTarget()
	{
		Quaternion targetRotation = Quaternion.LookRotation(target.position - rotatingGun.position);
		targetRotation *= Quaternion.Euler(0f, 90f, 0f);
		//Clamp
		Vector3 eulerAngle = targetRotation.eulerAngles;
		for (int i = 0; i < 3; i++)
		{
			if (eulerAngle[i] > 180f)
			{
				eulerAngle[i] -= 360f;
			}
			eulerAngle[i] = Mathf.Clamp(eulerAngle[i], -clampAngle, clampAngle);
		}

		targetRotation = Quaternion.Euler(eulerAngle);

		rotatingGun.rotation = Quaternion.Lerp(rotatingGun.rotation, targetRotation, Time.deltaTime * rotationSpeed);

		float angle = Quaternion.Angle(rotatingGun.rotation, targetRotation);

		if (angle < 0.3f)
		{
		}
		else
		{
		}
	}
	#endregion
	#region Movement
	private void Movement()
	{
		
	}
	#endregion
}
