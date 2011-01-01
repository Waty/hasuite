//uncomment the line below to create a new settings file
//#define CREATENEW

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using MapleLib;
using MapleLib.WzLib;
using MapleLib.WzLib.Util;
using MapleLib.WzLib.WzProperties;
using System.IO;
using System.Reflection;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using HaCreator.MapEditor;
using MapleLib.WzLib.WzStructure.Data;
using MapleLib.WzLib.WzStructure;

namespace HaCreator
{
    public static class UserSettings
    {
        public static bool ShowMousePos = true;
        public static DevComponents.DotNetBar.eStyle applicationStyle = DevComponents.DotNetBar.eStyle.Office2007Blue;
        public static System.Drawing.Color TabColor = System.Drawing.Color.LightSteelBlue;
        public static int LineWidth = 1;
        public static int DotWidth = 3;
        public static Color SelectSquare = new Color(0, 0, 255, 255);
        public static Color SelectSquareFill = new Color(0, 0, 200, 200);
        public static Color SelectedColor = new Color(0, 0, 255, 250);
        public static Color VRColor = new Color(0, 0, 255, 255);
        public static Color FootholdColor = Color.Red;
        public static Color RopeColor = Color.Green;
        public static Color ChairColor = Color.Orange;
        public static Color ToolTipColor = Color.SkyBlue;
        public static Color ToolTipFill = new Color(0, 0, 255, 100);
        public static Color ToolTipSelectedFill = new Color(0, 0, 255, 150);
        public static Color ToolTipCharFill = new Color(0, 255, 0, 100);
        public static Color ToolTipCharSelectedFill = new Color(0, 255, 0, 150);
        public static Color ToolTipBindingLine = Color.Magenta;
        public static Color MiscColor = Color.Brown;
        public static Color MiscFill = new Color(150, 75, 0, 100);
        public static Color MiscSelectedFill = new Color(150, 75, 0, 150);
        public static int NonActiveAlpha = 63;
        public static int Mobrx0Offset = 200;
        public static int Mobrx1Offset = 200;
        public static int Npcrx0Offset = 20;
        public static int Npcrx1Offset = 20;
        public static int defaultMobTime = 7;
        public static int defaultReactorTime = 7;
        public static float SnapDistance = 10;
        public static int ScrollDistance = 70;
        public static double ScrollFactor = 1;
        public static double ScrollBase = 1.05;
        public static double ScrollExponentFactor = 1;
        public static int zShift = 1;
        public static int HiddenLifeR = 127;
        public static string FontName = "Arial";
        public static int FontSize = 15;
        public static bool AntiAliasing = true;
        public static System.Drawing.FontStyle FontStyle = System.Drawing.FontStyle.Regular;
        public static int dotDescriptionBoxSize = 100;


        public static bool useMiniMap = true;
        public static bool showVR = true;
        public static bool useSnapping = true;
        public static bool useThreeState = true;
        public static bool emulateParallax = true;
        public static bool suppressWarnings = false;
    }

    public static class ApplicationSettings
    {
        public static ItemTypes visibleTypes = ItemTypes.All;
        public static ItemTypes editedTypes = ItemTypes.All ^ ItemTypes.Backgrounds;
        public static int MapleVersionIndex = 3;
        public static string MapleFolder = "";
        public static int MapleFolderIndex = 0;
        public static System.Drawing.Size LastMapSize = new System.Drawing.Size(800, 800);
        public static int lastRadioIndex = 3;
        public static bool newTab = true;
        public static bool randomTiles = true;
        public static int lastDefaultLayer = 0;
    }

    /*public class WzSettingsManager
    {
        string wzPath;

        public WzSettingsManager(string wzPath)
        {
            this.wzPath = wzPath;
        }

        public void ExtractSettingsImage(WzImage settingsImage, Type settingsHolderType)
        {
            if (!settingsImage.Parsed) settingsImage.ParseImage();
            foreach (FieldInfo fieldInfo in settingsHolderType.GetFields(BindingFlags.Public | BindingFlags.Static))
            {
                string settingName = fieldInfo.Name;
                IWzImageProperty settingProp = settingsImage[settingName];
                byte[] argb;
                if (settingProp == null)
                    SaveField(settingsImage, fieldInfo);
                else if (fieldInfo.FieldType.BaseType != null && fieldInfo.FieldType.BaseType.FullName == "System.Enum")
                    fieldInfo.SetValue(null, InfoTool.GetInt(settingProp));
                else switch (fieldInfo.FieldType.FullName)
                    {
                        case "Microsoft.Xna.Framework.Graphics.Color":
                            argb = BitConverter.GetBytes((uint)((WzDoubleProperty)settingProp).Value);
                            fieldInfo.SetValue(null, new Color(argb[2], argb[1], argb[0], argb[3]));
                            break;
                        case "System.Drawing.Color":
                            argb = BitConverter.GetBytes((uint)((WzDoubleProperty)settingProp).Value);
                            fieldInfo.SetValue(null, System.Drawing.Color.FromArgb(argb[3], argb[2], argb[1], argb[0]));
                            break;
                        case "System.Int32":
                            fieldInfo.SetValue(null, InfoTool.GetInt(settingProp));
                            break;
                        case "System.Double":
                            fieldInfo.SetValue(null, ((WzDoubleProperty)settingProp).Value);
                            break;
                        case "System.Boolean":
                            fieldInfo.SetValue(null, InfoTool.GetBool(settingProp));
                            break;
                        case "System.Single":
                            fieldInfo.SetValue(null, ((WzByteFloatProperty)settingProp).Value);
                            break;
                        /*case "WzMapleVersion":
                            fieldInfo.SetValue(null, (WzMapleVersion)InfoTool.GetInt(settingProp));
                            break;
                        case "ItemTypes":
                            fieldInfo.SetValue(null, (ItemTypes)InfoTool.GetInt(settingProp));
                            break;*/
                        /*case "System.Drawing.Size":
                            fieldInfo.SetValue(null, new System.Drawing.Size(((WzVectorProperty)settingProp).X.Value, ((WzVectorProperty)settingProp).Y.Value));
                            break;
                        case "System.String":
                            fieldInfo.SetValue(null, InfoTool.GetString(settingProp));
                            break;
                        case "System.Drawing.Bitmap":
                            fieldInfo.SetValue(null, ((WzCanvasProperty)settingProp).PngProperty.GetPNG(false));
                            break;
                        default:
                            throw new Exception("unrecognized setting type");
                    }
            }
        }

        public void CreateWzProp(IPropertyContainer parent, WzPropertyType propType, string propName, object value)
        {
            IWzImageProperty addedProp;
            switch (propType)
            {
                case WzPropertyType.ByteFloat:
                    addedProp = new WzByteFloatProperty(propName);
                    break;
                case WzPropertyType.Canvas:
                    addedProp = new WzCanvasProperty(propName);
                    ((WzCanvasProperty)addedProp).PngProperty = new WzPngProperty();
                    break;
                case WzPropertyType.CompressedInt:
                    addedProp = new WzCompressedIntProperty(propName);
                    break;
                case WzPropertyType.Double:
                    addedProp = new WzDoubleProperty(propName);
                    break;
                case WzPropertyType.Sound:
                    addedProp = new WzSoundProperty(propName);
                    break;
                case WzPropertyType.String:
                    addedProp = new WzStringProperty(propName);
                    break;
                case WzPropertyType.UnsignedShort:
                    addedProp = new WzUnsignedShortProperty(propName);
                    break;
                case WzPropertyType.Vector:
                    addedProp = new WzVectorProperty(propName);
                    ((WzVectorProperty)addedProp).X = new WzCompressedIntProperty("X");
                    ((WzVectorProperty)addedProp).Y = new WzCompressedIntProperty("Y");
                    break;
                default:
                    throw new NotSupportedException("not supported type");
            }
            addedProp.SetValue(value);
            parent.AddProperty(addedProp);
        }

        public void SetWzProperty(WzImage parentImage, string propName, WzPropertyType propType, object value)
        {
            IWzImageProperty property = parentImage[propName];
            if (property != null)
            {
                if (property.PropertyType == propType)
                    property.SetValue(value);
                else
                {
                    property.Remove();
                    CreateWzProp(parentImage, propType, propName, value);
                }
            }
            else
                CreateWzProp(parentImage, propType, propName, value);
        }

        public void SaveSettingsImage(WzImage settingsImage, Type settingsHolderType)
        {
            if (!settingsImage.Parsed) settingsImage.ParseImage();
            foreach (FieldInfo fieldInfo in settingsHolderType.GetFields(BindingFlags.Public | BindingFlags.Static))
            {
                SaveField(settingsImage, fieldInfo);
            }
            settingsImage.Changed = true;
        }

        private void SaveField(WzImage settingsImage, FieldInfo fieldInfo)
        {
            string settingName = fieldInfo.Name;
            if (fieldInfo.FieldType.BaseType != null && fieldInfo.FieldType.BaseType.FullName == "System.Enum")
                SetWzProperty(settingsImage, settingName, WzPropertyType.CompressedInt, fieldInfo.GetValue(null));
            else switch (fieldInfo.FieldType.FullName)
                {
                    case "Microsoft.Xna.Framework.Graphics.Color":
                        SetWzProperty(settingsImage, settingName, WzPropertyType.Double, (double)((Color)fieldInfo.GetValue(null)).PackedValue);
                        break;
                    case "System.Drawing.Color":
                        SetWzProperty(settingsImage, settingName, WzPropertyType.Double, (double)((System.Drawing.Color)fieldInfo.GetValue(null)).ToArgb());
                        break;
                    case "System.Int32":
                        SetWzProperty(settingsImage, settingName, WzPropertyType.CompressedInt, fieldInfo.GetValue(null));
                        break;
                    case "System.Double":
                        SetWzProperty(settingsImage, settingName, WzPropertyType.Double, fieldInfo.GetValue(null));
                        break;
                    case "Single":
                        SetWzProperty(settingsImage, settingName, WzPropertyType.ByteFloat, fieldInfo.GetValue(null));
                        break;
                    case "System.Drawing.Size":
                        SetWzProperty(settingsImage, settingName, WzPropertyType.Vector, fieldInfo.GetValue(null));
                        break;
                    case "System.String":
                        SetWzProperty(settingsImage, settingName, WzPropertyType.String, fieldInfo.GetValue(null));
                        break;
                    case "System.Drawing.Bitmap":
                        SetWzProperty(settingsImage, settingName, WzPropertyType.Canvas, fieldInfo.GetValue(null));
                        break;
                    case "System.Boolean":
                        SetWzProperty(settingsImage, settingName, WzPropertyType.CompressedInt, (bool)fieldInfo.GetValue(null) ? 1 : 0);
                        break;
                }
        }

        public void Load()
        {
            if (File.Exists(wzPath))
            {
                WzFile wzFile = new WzFile(wzPath, 1337, WzMapleVersion.CLASSIC);
                wzFile.ParseWzFile();
                ExtractSettingsImage((WzImage)wzFile["UserSettings.img"], typeof(UserSettings));
                ExtractSettingsImage((WzImage)wzFile["ApplicationSettings.img"], typeof(ApplicationSettings));
                wzFile.Dispose();
            }
            MultiBoard.RecalculateSettings();
        }

        public void Save()
        {
            bool settingsExist = File.Exists(wzPath);
            WzFile wzFile;
            if (settingsExist)
            {
                wzFile = new WzFile(wzPath, 1337, WzMapleVersion.CLASSIC);
                wzFile.ParseWzFile();
            }
            else
            {
                wzFile = new WzFile(1337, WzMapleVersion.CLASSIC);
                wzFile.Header.Copyright = "Wz settings file, made by haha01haha01";
                wzFile.Header.RecalculateFileStart();
                WzImage US = new WzImage("UserSettings.img") { Changed = true, Parsed = true };
                WzImage AS = new WzImage("ApplicationSettings.img") { Changed = true, Parsed = true };
                wzFile.WzDirectory.WzImages.Add(US);
                wzFile.WzDirectory.WzImages.Add(AS);
            }
            SaveSettingsImage((WzImage)wzFile["UserSettings.img"], typeof(UserSettings));
            SaveSettingsImage((WzImage)wzFile["ApplicationSettings.img"], typeof(ApplicationSettings));
            if (settingsExist)
            {
                string tempFile = Path.GetTempFileName();
                string settingsPath = wzFile.FilePath;
                wzFile.SaveToDisk(tempFile);
                wzFile.Dispose();
                File.Delete(settingsPath);
                File.Move(tempFile, settingsPath);
            }
            else
                wzFile.SaveToDisk(wzPath);
        }
    }*/
}
