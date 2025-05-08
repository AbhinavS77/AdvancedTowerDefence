using UnityEngine;

public class BaseTower : MonoBehaviour
{
	/// <summary>
	/// The part of the tower that rotates to aim.
	/// </summary>
	[SerializeField] private Transform RotatingGun;

	/// <summary>
	/// The bullet prefab that the tower will instantiate when firing.
	/// </summary>
	[SerializeField] private GameObject BulletPrefab;

    private GameObject TowerPrefab;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        if (RotatingGun == null)
        {
            RotatingGun = this.transform.GetChild(0);
        }
    }

    // Update is called once per frame
    void Update()
    {
        if(RotatingGun != null)
        {
            Debug.Log("Done");
        }
    }
    public BaseTower()
    {
        RotatingGun = null;
    }
}
