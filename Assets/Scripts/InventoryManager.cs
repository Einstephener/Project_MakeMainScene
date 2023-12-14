using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

//public enum Items
//{
//    woodenSword,
//    woodenShield,
//    bicycleHelmet
//}
public class InventoryManager : MonoBehaviour
{
    public static InventoryManager instance;
    [SerializeField] private GameObject IsEquip;

    public GameObject ShopItemUIPrefabs;
    public GameObject ShopScreen;


    [Header("ItemSprite")]
    [SerializeField] private Sprite woodenSwordImage;
    [SerializeField] private Sprite woodenShieldImage;
    [SerializeField] public Sprite[] ItemImages;
    [SerializeField] public Sprite[] InventoryImages;

    public GameData gameData;

    List<GameObject> HideBtnList = new List<GameObject>();

    public static List<Weapon> weapons = new List<Weapon>
    {
        new Weapon("목검", 100, "초보자의 검. 나무로 만들었다.", 10, 0,  5),
        new Weapon("나무 방패", 100, "초보자의 방패. 나무로 만들었다.", 0, 10, 5),
        new Weapon("상점템 1", 100, "111111111111111111.", 0, 10, 5),
      new Weapon("상점템 8", 100, "111111111111111111111111111111", 0, 10, 5)
    };
    private void Awake()
    {
        instance = this;
    }

    private void Start()
    {
        for (int i = 0; i < weapons.Count; i++)
        {
            var weapon = weapons[i];
            
            ShopItemSetting(ShopItemUIPrefabs, ShopScreen, i);  
        }

    }

    private void ShopItemSetting(GameObject gameObject, GameObject Parent, int index)
    {
        GameObject temp = Instantiate(gameObject, Parent.transform.position, Quaternion.identity);
        temp.transform.SetParent(Parent.transform);

        //Transform descriptionTransform = temp.transform.Find("BackGround/ExplanationTxtBack/Description");
        //Text itemDescriptionText = descriptionTransform.GetComponent<Text>();
        //itemDescriptionText.text = weapons[index].ItemDescription.ToString();

        //Transform statsTransform = temp.transform.Find("BackGround/ItemStat/PlusStat");
        //Text itemstatsText = statsTransform.GetComponent<Text>();
        //itemstatsText.text = "+" + weapons[index].ItemStr.ToString();

        //Transform costTransform = temp.transform.Find("BackGround/Price/ItemPrice");
        //Text itemcostText = costTransform.GetComponent<Text>();
        //itemcostText.text = weapons[index].ItemGold.ToString();
        // 상점 창의 text값을 바꾸려다 실패...


        temp.SetActive(true);
        
    }

}
