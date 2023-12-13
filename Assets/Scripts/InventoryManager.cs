using System.Collections;
using System.Collections.Generic;
using UnityEngine;

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


    List<GameObject> HideBtnList = new List<GameObject>();

    public static List<Weapon> weapons = new List<Weapon>
    {
        new Weapon("목검", 100, "초보자의 검. 나무로 만들었다.", 10, 0,  5),
        new Weapon("나무 방패", 100, "초보자의 방패. 나무로 만들었다.", 0, 10, 5),
        new Weapon("나무 방패", 100, "초보자의 방패. 나무로 만들었다.", 0, 10, 5),
        new Weapon("나무 방패", 100, "초보자의 방패. 나무로 만들었다.", 0, 10, 5),
        new Weapon("나무 방패", 100, "초보자의 방패. 나무로 만들었다.", 0, 10, 5),
        new Weapon("나무 방패", 100, "초보자의 방패. 나무로 만들었다.", 0, 10, 5),
        new Weapon("나무 방패", 100, "초보자의 방패. 나무로 만들었다.", 0, 10, 5),
        new Weapon("나무 방패", 100, "초보자의 방패. 나무로 만들었다.", 0, 10, 5),
        new Weapon("나무 방패", 100, "초보자의 방패. 나무로 만들었다.", 0, 10, 5),
        new Weapon("나무 방패", 100, "초보자의 방패. 나무로 만들었다.", 0, 10, 5)
    };
    private void Awake()
    {
        instance = this;
    }

    private void Start()
    {
        for (int i = 0; i < weapons.Count; i++)
        {
            ShopItemSetting(ShopItemUIPrefabs, ShopScreen);
        }

    }

    private void ShopItemSetting(GameObject gameObject, GameObject Parent)
    {
        GameObject temp = Instantiate(gameObject, Parent.transform.position, Quaternion.identity);
        temp.transform.SetParent(Parent.transform);
        temp.SetActive(true);
    }

}
