using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SphereManager : MonoBehaviour
{
    public GameObject SpherePreFab;
    public List<GameObject> SphereList;
    // Start is called before the first frame update
    void Start()
    {
        SphereList = new List<GameObject>();
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.A))
        {
            AddSphere();
        }
        if (Input.GetKeyDown(KeyCode.D))
        {
            RemoveSphere();
        }
    }

    void AddSphere()
    {
        GameObject newSphere = Instantiate(SpherePreFab);
        newSphere.transform.position = new Vector3(Random.Range(-5f,5f), Random.Range(-5f,5f), 0);
        SphereList.Add(newSphere);
        Debug.Log("Spheres has been added" + SphereList.Count);
    }

    void RemoveSphere()
    {
        if (SphereList.Count > 0)
        {
            GameObject LastSphere = SphereList[SphereList.Count - 1];
            Destroy(LastSphere);
            SphereList.RemoveAt(SphereList.Count - 1);
            Debug.Log("Sphere has benn determined " + SphereList.Count);            
        }
        else
        {
            Debug.Log("List is Empty");
        }

    }
}
