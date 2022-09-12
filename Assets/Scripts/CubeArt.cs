using System.Collections;
using UnityEngine;


public class CubeArt : MonoBehaviour
{
    Renderer m_Renderer;

    public Material[] materials;
    [SerializeField] int matAmount = 4;
    
    // Start is called before the first frame update
    void Start()
    {
        m_Renderer = GetComponent<Renderer>();
        MaterialSwitcher();
        InvokeRepeating("MaterialSwitcher",1f,1f);
    }

    void MaterialSwitcher()
    {
        m_Renderer.sharedMaterial = materials[Random.Range(0, matAmount)];
     }
}
