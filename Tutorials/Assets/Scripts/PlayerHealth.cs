using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class PlayerHealth : MonoBehaviour
{
    [SerializeField] private TMP_Text damageTextPrefab = null;
    [SerializeField] private DamageTypeScriptableObject[] damageTypes = new DamageTypeScriptableObject[0];

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (!Input.GetKeyDown(KeyCode.Space)) { return; }
        DealDamage();
    }

    private void DealDamage()
    {
        int damageToDeal = Random.Range(1, 11);
        DamageTypeScriptableObject damageType = damageTypes[Random.Range(0, damageTypes.Length)];

        SpawnDamageText(damageToDeal, damageType);
    }
    private void SpawnDamageText(int damageToDeal, DamageTypeScriptableObject damageType)
    {
        TMP_Text damageTextInstance = Instantiate(damageTextPrefab, transform.position, Quaternion.identity);

        damageTextInstance.text = damageToDeal.ToString();
        damageTextInstance.color = damageType.colour;

        Destroy(damageTextInstance.gameObject, 1f);
    }
}
