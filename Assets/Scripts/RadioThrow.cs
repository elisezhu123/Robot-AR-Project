using UnityEngine;

public class RadioThrow : MonoBehaviour
{
    public Transform PosInRadio;
    private GameObject[] RadioLocation;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        RadioLocation= Resources. LoadAll<GameObject>("Radio");
        LaunchRadio();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void LaunchRadio()
    {
         Instantiate(RadioLocation[0],PosInRadio.position,PosInRadio.rotation); 
    }
}
