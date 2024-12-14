using UnityEngine;

public class RadioProduce : MonoBehaviour
{
    public static RadioProduce instance;
    public Transform PosInRadio;
    private GameObject[] Radio;
    // Start is called once before the first execution of Update after the MonoBehaviour is created

    void Awake()
    {
        instance = this;
    }
    void Start()
    {
        Radio = Resources. LoadAll<GameObject>("Radio");
    }

    public void LaunchRadio()
    {
         GameObject _Radio=Instantiate(Radio[0],PosInRadio.position,PosInRadio.rotation); 
         _Radio.transform.SetParent(PosInRadio);
         _Radio.gameObject.GetComponent<SphereCollider>();
    }

    public void TriggerLaunchRadio()
    {
        Debug.Log("Button clicked - Launch Radio triggered");
        LaunchRadio();
    }
}
