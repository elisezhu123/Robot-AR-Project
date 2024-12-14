using UnityEngine;

public class RadioProduce : MonoBehaviour
{
    public Transform PosInRadio;
    private GameObject[] Radio;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        Radio = Resources. LoadAll<GameObject>("Radio");
        LaunchRadio();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void LaunchRadio()
    {
         GameObject _Radio=Instantiate(Radio[0],PosInRadio.position,PosInRadio.rotation); 
         _Radio.transform.SetParent(PosInRadio);
         _Radio.gameObject.GetComponent<SphereCollider>();
    }
}
