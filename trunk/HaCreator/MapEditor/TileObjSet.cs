/*using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using MapleLib.WzLib;
using MapleLib.WzLib.WzProperties;

namespace HaCreator
{
    public class ObjectSet
    {
        private MapleTable<ObjectCategoryL0> catsByName = new MapleTable<ObjectCategoryL0>();
        private string name;
        private WzImage parentObject;
        private bool extr;

        public ObjectSet(string name)
        {
            this.name = name;
        }

        public void ParseImage()
        {
            if (Extracted) return;
            if (!parentObject.Parsed) parentObject.ParseImage();
            foreach (WzSubProperty objCat in parentObject.WzProperties)
                catsByName[objCat.Name] = ObjectCategoryL0.Load((WzSubProperty)objCat);
            extr = true;
        }

        public static ObjectSet Load(WzImage parentObject)
        {
            ObjectSet result = new ObjectSet(WzInfoTools.RemoveExtension(parentObject.Name));
            result.ParentObject = parentObject;
            return result;
        }

        public static void Reload(ObjectSet objToReload)
        {
            if (objToReload.Extracted)
            {
                objToReload = ObjectSet.Load(objToReload.ParentObject);
                objToReload.ParseImage();
            }
            else
                objToReload = ObjectSet.Load(objToReload.ParentObject);
        }

        public bool Extracted { get { return extr; } }
        public WzImage ParentObject { get { return parentObject; } set { parentObject = value; } }

        public string Name
        {
            get
            {
                return name;
            }
            set
            {
                name = value;
            }
        }

        public ObjectCategoryL0 this[string name]
        {
            get { if (catsByName.Count == 0) ParseImage();
                return catsByName[name]; }
            set { if (catsByName.Count == 0) ParseImage();
                catsByName[name] = value; }
        }

        public MapleTable<ObjectCategoryL0> ObjectCategories { get { return catsByName; } }
    }

    public class ObjectCategoryL0
    {
        private MapleTable<ObjectCategoryL1> catsByName = new MapleTable<ObjectCategoryL1>();
        private string name;
        private WzSubProperty parentObject;

        public ObjectCategoryL0(string name)
        {
            this.name = name;
        }

        public static ObjectCategoryL0 Load(WzSubProperty parentObject)
        {
            ObjectCategoryL0 result = new ObjectCategoryL0(parentObject.Name);
            result.ParentObject = parentObject;
            foreach (WzSubProperty objCatl1 in parentObject.WzProperties)
            {
                result.ObjectCategories[objCatl1.Name] = ObjectCategoryL1.Load(objCatl1);
            }
            return result;
        }

        public static void Reload(ObjectCategoryL0 objToReload)
        {
            objToReload = Load(objToReload.ParentObject);
        }

        public WzSubProperty ParentObject { get { return parentObject; } set { parentObject = value; } }

        public string Name
        {
            get
            {
                return name;
            }
            set
            {
                name = value;
            }
        }

        public ObjectCategoryL1 this[string name]
        {
            get { return catsByName[name]; }
            set { catsByName[name] = value; }
        }

        public MapleTable<ObjectCategoryL1> ObjectCategories { get { return catsByName; } }
    }

    public class ObjectCategoryL1
    {
        private MapleTable<ObjectInfo> objsByNo = new MapleTable<ObjectInfo>();
        private string name;
        private WzSubProperty parentObject;

        public ObjectCategoryL1(string name)
        {
            this.name = name;
        }

        public static ObjectCategoryL1 Load(WzSubProperty parentObject)
        {
            ObjectCategoryL1 result = new ObjectCategoryL1(parentObject.Name);
            result.ParentObject = parentObject;
            foreach (WzSubProperty objectProp in parentObject.WzProperties)
                result.ObjectCategories.Add(objectProp.Name, ObjectInfo.Load(objectProp));
            return result;
        }

        public static void Reload(ObjectCategoryL1 objToReload)
        {
            objToReload = Load(objToReload.ParentObject);
        }

        public WzSubProperty ParentObject { get { return parentObject; } set { parentObject = value; } }

        public string Name
        {
            get
            {
                return name;
            }
            set
            {
                name = value;
            }
        }

        public ObjectInfo this[string no]
        {
            get { return objsByNo[no]; }
            set { objsByNo[no] = value; }
        }

        public MapleTable<ObjectInfo> ObjectCategories { get { return objsByNo; } }
    }

    public class TileSet
    {
        private MapleTable<TileCategory> catsByName = new MapleTable<TileCategory>();
        private string name;
        private WzImage parentObject;
        private bool extr;

        public TileSet(string name)
        {
            this.name = name;
        }

        public void ParseImage()
        {
            if (Extracted) return;
            if (!parentObject.Parsed) parentObject.ParseImage();
            foreach (IWzImageProperty tileCat in parentObject.WzProperties)
                if (tileCat is WzSubProperty)
                    catsByName[tileCat.Name] = TileCategory.Load((WzSubProperty)tileCat);
            extr = true;
        }

        public static TileSet Load(WzImage parentObject)
        {
            TileSet result = new TileSet(WzInfoTools.RemoveExtension(parentObject.Name));
            result.ParentObject = parentObject;
            return result;
        }

        public static void Reload(TileSet objToReload)
        {
            if (objToReload.Extracted)
            {
                objToReload = TileSet.Load(objToReload.ParentObject);
                objToReload.ParseImage();
            }
            else
                objToReload = TileSet.Load(objToReload.ParentObject);
        }

        public bool Extracted { get { return extr; } }
        public WzImage ParentObject { get { return parentObject; } set { parentObject = value; } }

        public string Name
        {
            get
            {
                return name;
            }
            set
            {
                name = value;
            }
        }

        public TileCategory this[string name]
        {
            get { if (catsByName.Count == 0) ParseImage(); 
                return catsByName[name]; }
            set { if (catsByName.Count == 0) ParseImage(); 
                catsByName[name] = value; }
        }

        public MapleTable<TileCategory> TileCategories { get { return catsByName; } }
    }

    public class TileCategory
    {
        private List<TileInfo> tilesByNo = new List<TileInfo>();
        private string name;
        private WzSubProperty parentObject;
        
        public TileCategory(string name)
        {
            this.name = name;
        }

        public static TileCategory Load(WzSubProperty parentObject)
        {
            TileCategory result = new TileCategory(parentObject.Name);
            result.ParentObject = parentObject;
            for (int i = 0; i < parentObject.WzProperties.Count; i++)
            {
                result.Tiles.Add(TileInfo.Load((WzCanvasProperty)parentObject[i.ToString()]));
            }
            return result;
        }

        public static void Reload(TileCategory objToReload)
        {
            objToReload = Load(objToReload.ParentObject);
        }

        public WzSubProperty ParentObject { get { return parentObject; } set { parentObject = value; } }

        public string Name
        {
            get
            {
                return name;
            }
            set
            {
                name = value;
            }
        }

        public TileInfo this[int no]
        {
            get { return tilesByNo[no]; }
            set { tilesByNo[no] = value; }
        }

        public List<TileInfo> Tiles { get { return tilesByNo; } }
    }
}
*/