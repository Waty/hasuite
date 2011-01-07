using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using DevComponents.DotNetBar;

namespace HaCreator.GUI
{
    public partial class UserSettingsForm : Office2007Form
    {
        public UserSettingsForm()
        {
            InitializeComponent();
            styleManager.ManagerStyle = UserSettings.applicationStyle;
            string[] styleNames = Enum.GetNames(typeof(eStyle));
            for (int i = 0; i < styleNames.Length; i++) themeBox.Items.Add(styleNames[i]);
            themeBox.SelectedIndex = (int)UserSettings.applicationStyle;
            linewBox.Value = UserSettings.LineWidth;
            dotwBox.Value = UserSettings.DotWidth;
            inactiveaBox.Value = UserSettings.NonActiveAlpha;
            threeStateBox.Checked = UserSettings.useThreeState;
            showMousePosCheckbox.Checked = UserSettings.ShowMousePos;

            tabColorPicker.Color = UserSettings.TabColor;
            dragColorPicker.Color = XNAToSystemColor(UserSettings.SelectSquare);
            dragFillColorPicker.Color = XNAToSystemColor(UserSettings.SelectSquareFill);
            selectedColorPicker.Color = XNAToSystemColor(UserSettings.SelectedColor);
            vrColorPicker.Color = XNAToSystemColor(UserSettings.VRColor);
            fhColorPicker.Color = XNAToSystemColor(UserSettings.FootholdColor);
            rlColorPicker.Color = XNAToSystemColor(UserSettings.RopeColor);
            seatColorPicker.Color = XNAToSystemColor(UserSettings.ChairColor);
            ttColorPicker.Color = XNAToSystemColor(UserSettings.ToolTipColor);
            ttFillColorPicker.Color = XNAToSystemColor(UserSettings.ToolTipFill);
            ttSelectColorPicker.Color = XNAToSystemColor(UserSettings.ToolTipSelectedFill);
            ttcColorPicker.Color = XNAToSystemColor(UserSettings.ToolTipCharFill);
            ttcSelectColorPicker.Color = XNAToSystemColor(UserSettings.ToolTipCharSelectedFill);
            ttLineColorPicker.Color = XNAToSystemColor(UserSettings.ToolTipBindingLine);
            rInput.Value = UserSettings.HiddenLifeR;
            fontName.Text = UserSettings.FontName;
            fontSize.Value = UserSettings.FontSize;

            mobrx0Box.Value = UserSettings.Mobrx0Offset;
            mobrx1Box.Value = UserSettings.Mobrx1Offset;
            npcrx0Box.Value = UserSettings.Npcrx0Offset;
            npcrx1Box.Value = UserSettings.Npcrx1Offset;
            mobtimeBox.Value = UserSettings.defaultMobTime;
            reacttimeBox.Value = UserSettings.defaultReactorTime;
            zShiftBox.Value = UserSettings.zShift;
            snapdistBox.Value = UserSettings.SnapDistance;
            scrolldistBox.Value = UserSettings.ScrollDistance;
            scrollbaseBox.Value = UserSettings.ScrollBase;
            scrollexpBox.Value = UserSettings.ScrollExponentFactor;
            scrollfactBox.Value = UserSettings.ScrollFactor;
        }

        public static Color XNAToSystemColor(Microsoft.Xna.Framework.Color color)
        {
            return Color.FromArgb((int)color.PackedValue);
        }

        public static Microsoft.Xna.Framework.Color SystemToXNAColor(Color color)
        {
            return new Microsoft.Xna.Framework.Color(color.R, color.G, color.B, color.A);
        }

        private void cancelButton_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void okayButton_Click(object sender, EventArgs e)
        {

            if (themeBox.SelectedIndex != -1) UserSettings.applicationStyle = (eStyle)themeBox.SelectedIndex;
            UserSettings.LineWidth = linewBox.Value;
            UserSettings.DotWidth = dotwBox.Value;
            UserSettings.NonActiveAlpha = inactiveaBox.Value;
            UserSettings.useThreeState = threeStateBox.Checked;
            UserSettings.ShowMousePos = showMousePosCheckbox.Checked;

            UserSettings.TabColor = tabColorPicker.Color;
            UserSettings.SelectSquare = SystemToXNAColor(dragColorPicker.Color);
            UserSettings.SelectSquareFill = SystemToXNAColor(dragFillColorPicker.Color);
            UserSettings.SelectedColor = SystemToXNAColor(selectedColorPicker.Color);
            UserSettings.VRColor = SystemToXNAColor(vrColorPicker.Color);
            UserSettings.FootholdColor = SystemToXNAColor(fhColorPicker.Color);
            UserSettings.RopeColor = SystemToXNAColor(rlColorPicker.Color);
            UserSettings.ChairColor = SystemToXNAColor(seatColorPicker.Color);
            UserSettings.ToolTipColor = SystemToXNAColor(ttColorPicker.Color);
            UserSettings.ToolTipFill = SystemToXNAColor(ttFillColorPicker.Color);
            UserSettings.ToolTipSelectedFill = SystemToXNAColor(ttSelectColorPicker.Color);
            UserSettings.ToolTipCharFill = SystemToXNAColor(ttcColorPicker.Color);
            UserSettings.ToolTipCharSelectedFill = SystemToXNAColor(ttcSelectColorPicker.Color);
            UserSettings.ToolTipBindingLine = SystemToXNAColor(ttLineColorPicker.Color);
            UserSettings.HiddenLifeR = rInput.Value;

            UserSettings.Mobrx0Offset = mobrx0Box.Value;
            UserSettings.Mobrx1Offset = mobrx1Box.Value;
            UserSettings.Npcrx0Offset = npcrx0Box.Value;
            UserSettings.Npcrx1Offset = npcrx1Box.Value;
            UserSettings.defaultMobTime = mobtimeBox.Value;
            UserSettings.defaultReactorTime = reacttimeBox.Value;
            UserSettings.zShift = zShiftBox.Value;
            UserSettings.SnapDistance = (float)snapdistBox.Value;
            UserSettings.ScrollDistance = scrolldistBox.Value;
            UserSettings.ScrollBase = scrollbaseBox.Value;
            UserSettings.ScrollExponentFactor = scrollexpBox.Value;
            UserSettings.ScrollFactor = scrollfactBox.Value;

            Close();
        }
    }
}
