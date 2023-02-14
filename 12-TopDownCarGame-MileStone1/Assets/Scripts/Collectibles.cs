using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Collectibles : MonoBehaviour
{
    [SerializeField] private int _Value = 0;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnTriggerEnter2D(Collider2D other)
    {
        Debug.Log("I've was hit by the player");
        LevelManager.Instance.UpdateLevelCoinCount(_Value); 
        Destroy(this.gameObject);
        if(this.gameObject.CompareTag("Coin"))
        {
            LevelManager.Instance.UpdateLevelCoinCount(_Value);
        }

        if (this.gameObject.CompareTag("Gas Can"))
        {
            LevelManager.Instance.UpdateLevelCoinCount(_Value);
        }

        Destroy(this.gameObject);
    }
}
