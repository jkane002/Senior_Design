using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ballMaterial : MonoBehaviour
{
    static public int material = 0;
    Material lightningMaterial;
    Material portalMaterial;
    Material waterMaterial;
    MeshRenderer meshRenderer;

    // Start is called before the first frame update
    void Start()
    {
        lightningMaterial = Resources.Load<Material>("lightning");
        portalMaterial = Resources.Load<Material>("portal");
        waterMaterial = Resources.Load<Material>("WaterMaterial");

        meshRenderer = GetComponent<MeshRenderer>();
        // Get the current material applied on the GameObject
    }

    // Update is called once per frame
    void Update()
    {
        if (material == 1)
        {
            Debug.Log("Here");
            // Set the new material on the GameObject
            meshRenderer.material = waterMaterial;
        }
        else if (material == 2)
        {
            Debug.Log("Here");
            // Set the new material on the GameObject
            meshRenderer.material = lightningMaterial;
        }
        else if (material == 3)
        {
            Debug.Log("Here");
            // Set the new material on the GameObject
            meshRenderer.material = portalMaterial;
        }
    }
}
