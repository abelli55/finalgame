using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.XR.Interaction.Toolkit;

public class firebullet : MonoBehaviour
{
    public GameObject bullet;
    public Transform SpawnPoint;
    public float firespeed = 25;

    // Start is called before the first frame update
    void Start()
    {
        XRGrabInteractable grabbable = GetComponent<XRGrabInteractable>();
        grabbable.activated.AddListener(fireBullet);
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    public void fireBullet(ActivateEventArgs args) 
    {
        GameObject spawnBullet = Instantiate(bullet);
        spawnBullet.transform.position = SpawnPoint.position;
        spawnBullet.GetComponent<Rigidbody>().velocity = SpawnPoint.forward * firespeed;
        Destroy(spawnBullet, 5);
    }
}
