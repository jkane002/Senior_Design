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
        lightningMaterial = Resources.Load<Material>("test");
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
            ballJump.jumpHeight = 80;
            moveBallScript.multiplier = 1.0f;
        }
        else if (material == 2)
        {
            Debug.Log("Here");
            // Set the new material on the GameObject
            meshRenderer.material = lightningMaterial;
            moveBallScript.multiplier = 1.1f;
            ballJump.jumpHeight = 65;
        }
        else if (material == 3)
        {
            Debug.Log("Here");
            // Set the new material on the GameObject
            meshRenderer.material = portalMaterial;
            ballJump.jumpHeight = 80;
            moveBallScript.multiplier = 1.0f;
        }
    }
}
