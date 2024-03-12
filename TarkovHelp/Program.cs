using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;

namespace TarkovHelp
{
    internal static class Program
    {
        /// <summary>
        /// Главная точка входа для приложения.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new MainForm());
        }
    }
    public static class UserConfig
    {
        public static bool AllQuest { get; set; } = false; //Отвечает за то, чтобы не показывать выполненые квесты
    }
    public static class Database
    {
        public static string connectionDB = @"Data Source = DateBase.db; Integrated Security = False; MultipleActiveResultSets=True";
    }
    public static class Quests
    {
        public static string main = "Quest";
        public static string id = "ID";
        public static string Quester = "Quester";
        public static string QuestName = "QuestName";
        public static string QuestGoal = "QuestGoal";
        public static string DialogBefore = "DialogBefore";
        public static string DialogAfter = "DialogAfter";
        public static string Reward = "Reward";
        public static string Picture = "Picture";
        public static string Format = "Format";
        public static string NameImg = "NameImg";
        public static string Done = "Done";
        public static string Pin = "Pin";
        public static string HowDone = "HowDone";
    }
    public class DataQuests
    {
        public static string Id { get; set; }
        public static string Quester { get; set; }
        public static string QuestName { get; set; }
        public static string QuestGoal { get; set; }
        public static string DialogBefore { get; set; }
        public static string DialogAfter { get; set; }
        public static string Reward { get; set; }
        public static Image PictureQuest { get; internal set; }
        public static string Done { get; set; }
        public static string HowDone { get; set; }
        public static bool isOpen { get; set; } = false;
    }
    public class DataGuns
    {
        public static string Name { get; set; }
    }

    public static class Items
    {
        public static string main = "Items";
        public static string id = "ID";
        public static string TypeItems = "TypeItems";
        public static string Name = "Name";
        public static string ForWhat = "ForWhat";
        public static string Count = "Count";
        public static string Picture = "Picture";
        public static string Format = "Format";
        public static string NameImg = "NameImg";
    }
    public static class Assemblys
    {
        public static string main = "Assemblys";
        public static string id = "ID";
        public static string TypeGun = "TypeGun";
        public static string NameGun = "NameGun";
        public static string PictureLogo = "PictureLogo";
        public static string FormatLogo = "FormatLogo";
        public static string NameImgLogo = "NameImgLogo";
        public static string Picture = "Picture";
        public static string Format = "Format";
        public static string NameImg = "NameImg";
    }

    #region Система кветов
    public class Quest
    {
        public static int MaxItem { get; set; } = 0;
        public List<Item_Quest> items = new List<Item_Quest>();
        public List<Slot_Quest> InventoryArray = new List<Slot_Quest>();
        public void CreateItem(string who, string title, string questGoal, string dialogBefore, string dialogAfter, string reward, Image pictureQuest, string done, string pin, string howDone)
        {
            if (title != "")
            {
                Item_Quest.Accessories item = new Item_Quest.Accessories { Id = items.Count, Who = who, Title = title, QuestGoal = questGoal, DialogBefore = dialogBefore, DialogAfter = dialogAfter, Reward = reward, PictureQuest = pictureQuest, Done = done, Pin = pin, HowDone = howDone};
                items.Add(item);
            }
        }
        public Quest(int capacity)
        {
            if (capacity > 0)
            {
                InventoryArray = new List<Slot_Quest>();
                for (int i = 0; i < capacity; i++)
                {
                    InventoryArray.Add(new Slot_Quest());
                }
            }
        }
    }
    public class Item_Quest
    {
        public int Id { get; set; }
        public string Who { get; set; }
        public string Title { get; set; }
        public string QuestGoal { get; set; }
        public string DialogBefore { get; set; }
        public string DialogAfter { get; set; }
        public string Reward { get; set; }
        public Image PictureQuest { get; internal set; }

        public string Done { get; set; }
        public string Pin { get; set; }
        public string HowDone { get; set; }

        public class Accessories : Item_Quest
        {

        }
    }
    public class Slot_Quest
    {
        public Item_Quest item { get; set; }
        public int count { get; set; }
    }
    #endregion

    #region Система предметов
    public class SystemItems
    {
        public static int MaxItem { get; set; } = 0;
        public List<Item> items = new List<Item>();
        public List<Slot> InventoryArray = new List<Slot>();
        public void CreateItem(string title, string forWhat, string count, Image pictureQuest)
        {
            if (title != "")
            {
                Item.Accessories item = new Item.Accessories { Id = items.Count, Title = title, ForWhat = forWhat, Count = count, PictureQuest = pictureQuest};
                items.Add(item);
            }
        }
        public SystemItems(int capacity)
        {
            if (capacity > 0)
            {
                InventoryArray = new List<Slot>();
                for (int i = 0; i < capacity; i++)
                {
                    InventoryArray.Add(new Slot());
                }
            }
        }
    }
    public class Item
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public string ForWhat { get; set; }
        public string Count { get; set; }
        public Image PictureQuest { get; internal set; }

        public class Accessories : Item
        {

        }
    }
    public class Slot
    {
        public Item item { get; set; }
        public int count { get; set; }
    }
    #endregion

    #region Система сборок
    public class SystemAssemblys
    {
        public static int MaxItem { get; set; } = 0;
        public List<Item_Assembly> items = new List<Item_Assembly>();
        public List<Slot_Assembly> InventoryArray = new List<Slot_Assembly>();
        public void CreateItem(string title, Image pictureLogo, Image picture)
        {
            if (title != "")
            {
                Item_Assembly.Accessories item = new Item_Assembly.Accessories { Id = items.Count, Title = title, PictureLogo = pictureLogo, Picture = picture };
                items.Add(item);
            }
        }
        public SystemAssemblys(int capacity)
        {
            if (capacity > 0)
            {
                InventoryArray = new List<Slot_Assembly>();
                for (int i = 0; i < capacity; i++)
                {
                    InventoryArray.Add(new Slot_Assembly());
                }
            }
        }
    }
    public class Item_Assembly
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public Image PictureLogo { get; internal set; }
        public Image Picture { get; internal set; }

        public class Accessories : Item_Assembly
        {

        }
    }
    public class Slot_Assembly
    {
        public Item_Assembly item { get; set; }
        public int count { get; set; }
    }
    #endregion
}